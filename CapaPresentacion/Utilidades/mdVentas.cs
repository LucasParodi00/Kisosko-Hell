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
    public partial class mdVentas : Form
    {
        public Venta _Venta { get; set; }
        public mdVentas()
        {
            InitializeComponent();
        }

        private void mdVentas_Load(object sender, EventArgs e)
        {
            List<Venta> lista = new CN_Venta().listaVentas();

            foreach (Venta v in lista)
            {
                dgvData.Rows.Add(new object[]
                {
                    v.FechaRegistro,
                    v.NumeroDocumento,
                    v.MontoTotal
                });
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum >= 0)
            {

                _Venta = new Venta()
                {
                    NumeroDocumento = dgvData.Rows[iRow].Cells["CodVenta"].Value.ToString()
                };
                //string CodVenta = dgvData.Rows[iRow].Cells["CodVenta"].Value.ToString();

                //using frmDetalleVenta frmDetalleVenta = new frmDetalleVenta(CodVenta);

                this.Close();
                this.DialogResult = DialogResult.OK;

            }
        }
    }
}
