using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using System.Data;

namespace CapaPresentacion
{
    public partial class frmReportesVentas : Form
    {
        public frmReportesVentas()
        {
            InitializeComponent();
        }

        private void frmReportesVentas_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                cbobusqueda.Items.Add(new opcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }

            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;
        }

        private void btnbuscarresultado_Click(object sender, EventArgs e)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            lista = new CN_Reporte().Venta(txtfechainicio.Value.ToString(), txtfechafin.Value.ToString());

            dgvdata.Rows.Clear();

            foreach (ReporteVenta row in lista)
            {
                dgvdata.Rows.Add(new object[]
                {
                    row.FechaRegistro,
                    row.TipoDocumento,
                    row.NumeroDocumento,
                    row.MontoTotal,
                    row.UsuarioRegistro,
                    row.DocumentoCliente,
                    row.NombreCliente,
                    row.CodigoProducto,
                    row.NombreProducto,
                    row.Categoria,
                    row.PrecioVenta,
                    row.Cantidad,
                    row.SubTotal
                });
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((opcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay registro para exportar", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dgvdata.Columns)
                {
                    if (columna.HeaderText != "")
                    {
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                    }
                }

                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Visible) dt.Rows.Add(new object[]
                    {
                        row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                        row.Cells[3].Value.ToString(),
                        row.Cells[4].Value.ToString(),
                        row.Cells[5].Value.ToString(),
                        row.Cells[6].Value.ToString(),
                        row.Cells[7].Value.ToString(),
                        row.Cells[8].Value.ToString(),
                        row.Cells[9].Value.ToString(),
                        row.Cells[10].Value.ToString(),
                        row.Cells[11].Value.ToString(),
                        row.Cells[12].Value.ToString()
                    }); ;
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyy"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Reporte");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
        }
    }
}
