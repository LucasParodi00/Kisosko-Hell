using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmReportesCompras : Form
    {
        public frmReportesCompras()
        {
            InitializeComponent();
        }

        private void frmReportesCompras_Load(object sender, EventArgs e)
        {
            List<Proveedor> lista = new CN_Proveedor().Listar();


            cboproveedor.Items.Add(new opcionCombo() { Valor = 0, Texto = "TODOS" });

            foreach (Proveedor pro in lista)
            {
                cboproveedor.Items.Add(new opcionCombo() { Valor = pro.IdProveedor, Texto = pro.RazonSocial });
            }
            cboproveedor.DisplayMember = "Texto";
            cboproveedor.ValueMember = "Valor";
            cboproveedor.SelectedIndex = 0;


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
            int idProveedor = Convert.ToInt32(((opcionCombo)cboproveedor.SelectedItem).Valor.ToString());

            List<ReporteCompra> lista = new List<ReporteCompra>();

            lista = new CN_Reporte().Compra(txtfechainicio.Value.ToString(), txtfechafin.Value.ToString(), idProveedor);

            dgvdata.Rows.Clear();

            foreach (ReporteCompra item in lista)
            {
                dgvdata.Rows.Add(new object[]
                {
                    item.FechaRegistro,
                    item.TipoDocumento,
                    item.NumeroDocumento,
                    item.MontoTotal,
                    item.UsuarioRegistro,
                    item.DocumentoProveedor,
                    item.RazonSocial,
                    item.CodigoProducto,
                    item.NombreProducto,
                    item.Categoria,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.Cantidad,
                    item.SubTotal
                });
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((opcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if(dgvdata.Rows.Count > 0 )
            {
                foreach(DataGridViewRow row in dgvdata.Rows)
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

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if(dgvdata.Rows.Count < 1)
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
                        row.Cells[12].Value.ToString(),
                        row.Cells[13].Value.ToString(),

                    }); ;
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteCompras_{0}.xlsx", DateTime.Now.ToString("ddMMyyyy"));
                savefile.Filter = "Excel Files | *.xlsx";

                if(savefile.ShowDialog() == DialogResult.OK)
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
