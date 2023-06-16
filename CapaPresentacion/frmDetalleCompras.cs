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

namespace CapaPresentacion
{
    public partial class frmDetalleCompras : Form
    {
        public frmDetalleCompras()
        {
            InitializeComponent();
        }



        private void frmDetalleCompras_Load(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Compra ObjCompra = new CN_Compra().ObtenerCompra(txtDocumentoBuscar.Text);

            if (ObjCompra.IdCompra != 0)
            {
                txtNroDocumentoCompra.Text = ObjCompra.NumeroDocumento;
                txtFechaCompra.Text = ObjCompra.FechaRegistro;
                txtTipoDocumento.Text = ObjCompra.TipoDocumento;
                txtUsuario.Text = ObjCompra.ObjUsuario.NombreCompleto;
                txtDocumentoProveedor.Text = ObjCompra.ObjProveedor.Documento;
                txtRazonSocial.Text = ObjCompra.ObjProveedor.RazonSocial;

                dgvData.Rows.Clear();

                foreach (DetalleCompra dc in ObjCompra.ObjDetalleCompra)
                {
                    dgvData.Rows.Add(new object[] {

                        dc.ObjProducto.Nombre,
                        dc.PrecioCompra,
                        dc.Cantidad,
                        dc.MontoTotal
                    });
                }

                txtMontoTotal.Text = ObjCompra.MontoTotal.ToString("0.00");

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFechaCompra.Text = "";
            txtTipoDocumento.Text = "";
            txtUsuario.Text = "";
            txtDocumentoProveedor.Text = "";
            txtRazonSocial.Text = "";
            dgvData.Rows.Clear();
            txtMontoTotal.Text = "";
            txtUsuario.Text = "";
            txtNroDocumentoCompra.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
