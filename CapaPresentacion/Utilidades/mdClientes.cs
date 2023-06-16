using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Utilidades
{
    public partial class mdClientes : Form
    {
        public Cliente _Cliente { get; set; }
        public mdClientes()
        {
            InitializeComponent();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mdClientes_Load(object sender, EventArgs e)
        {
            List<Cliente> lista = new CN_Cliente().Listar();

            foreach (Cliente item in lista)
            {
                if (item.Estado)
                {
                    dgvData.Rows.Add(new object[]
                    {
                        item.Documento,
                        item.NombreCompleto
                    });
                }
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {
                _Cliente = new Cliente()
                {
                    Documento = dgvData.Rows[iRow].Cells["Documento"].Value.ToString(),
                    NombreCompleto = dgvData.Rows[iRow].Cells["NombreCompleto"].Value.ToString(),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }



    }
}
