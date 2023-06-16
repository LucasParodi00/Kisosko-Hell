using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Utilidades
{
    public partial class mdProducto : Form
    {
        public Producto _Producto { get; set; }

        public mdProducto()
        {
            InitializeComponent();
        }

        private void mdProducto_Load(object sender, EventArgs e)
        {

            // Listar los Productos
            List<Producto> lista = new CN_Producto().Listar();
            foreach (Producto item in lista)
            {
                dgvData.Rows.Add(new object[] {
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.ObjCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                });

            }


        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {
                _Producto = new Producto()
                {
                    IdProducto = Convert.ToInt32(dgvData.Rows[iRow].Cells["id"].Value.ToString()),
                    Codigo = dgvData.Rows[iRow].Cells["codigo"].Value.ToString(),
                    Nombre = dgvData.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Stock = Convert.ToInt32(dgvData.Rows[iRow].Cells["stock"].Value.ToString()),
                    PrecioCompra = Convert.ToDecimal(dgvData.Rows[iRow].Cells["PrecioCompra"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(dgvData.Rows[iRow].Cells["PrecioVenta"].Value.ToString())
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


    }
}
