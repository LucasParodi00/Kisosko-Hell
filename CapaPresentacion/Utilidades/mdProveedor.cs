using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Utilidades
{
    public partial class mdProveedor : Form
    {
        public Proveedor _Proveedor { get; set; }

        public mdProveedor()
        {
            InitializeComponent();
        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {
            List<Proveedor> listaProveedor = new CN_Proveedor().Listar();
            foreach (Proveedor item in listaProveedor)
            {
                dgvData.Rows.Add(new object[] {
                    item.IdProveedor,
                    item.Documento,
                    item.RazonSocial
                });

            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {
                _Proveedor = new Proveedor()
                {
                    IdProveedor = Convert.ToInt32(dgvData.Rows[iRow].Cells["id"].Value.ToString()),
                    Documento = dgvData.Rows[iRow].Cells["Documento"].Value.ToString(),
                    RazonSocial = dgvData.Rows[iRow].Cells["RazonSocial"].Value.ToString(),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }

}
