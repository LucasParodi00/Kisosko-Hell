using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Utilidades
{
    public partial class mdCompras : Form
    {
        public Compra _Compra { get; set; }


        public mdCompras()
        {
            InitializeComponent();
        }

        private void mdCompras_Load(object sender, EventArgs e)
        {

            List<Compra> lista = new CN_Compra().listarCompras();

            foreach (Compra compra in lista)
            {
                dgvData.Rows.Add(new object[]
                {
                    compra.FechaRegistro,
                    compra.NumeroDocumento,
                    compra.NombreCompleto,
                    compra.MontoTotal
                });
            }


        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum >= 0)
            {

                _Compra = new Compra()
                {
                    NumeroDocumento = dgvData.Rows[iRow].Cells["CodCompra"].Value.ToString()
                };
                //string CodVenta = dgvData.Rows[iRow].Cells["CodVenta"].Value.ToString();

                //using frmDetalleVenta frmDetalleVenta = new frmDetalleVenta(CodVenta);

                this.Close();
                this.DialogResult = DialogResult.OK;

            }
        }
    }
}
