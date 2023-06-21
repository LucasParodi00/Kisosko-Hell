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

namespace CapaPresentacion
{
    public partial class frmDetalleVenta : Form
    {

        public frmDetalleVenta()
        {


            InitializeComponent();

        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtDocumentoBuscar.Text != "")
            {
                Venta ObjVenta = new CN_Venta().ObtenerVenta(txtDocumentoBuscar.Text);

                if (ObjVenta.IdVenta != 0)
                {

                    txtNroDocumentoCompra.Text = ObjVenta.NumeroDocumento;

                    txtFechaCompra.Text = ObjVenta.FechaRegistro;
                    txtTipoDocumento.Text = ObjVenta.TipoDocumento;
                    txtUsuario.Text = ObjVenta.ObjUsuario.NombreCompleto;


                    txtDocumento.Text = ObjVenta.DocumentoCliente;
                    txtNombreCliente.Text = ObjVenta.NombreCliente;

                    dgvData.Rows.Clear();

                    foreach (DetalleVenta dv in ObjVenta.ObjDetalleVenta)
                    {
                        dgvData.Rows.Add(new object[] { dv.ObjProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal });
                    }

                    txtMontoTotal.Text = ObjVenta.MontoTotal.ToString("0.00");
                    txtPago.Text = ObjVenta.MontoPago.ToString("0.00");
                    txtVuelto.Text = ObjVenta.MontoCambio.ToString("0.00");
                }
            }
            else
            {
                using (var modal = new Utilidades.mdVentas())
                {
                    var resultado = modal.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        txtDocumentoBuscar.Text = modal._Venta.NumeroDocumento.ToString();
                        btnBuscar_Click(sender, new EventArgs());

                    }
                    else
                    {
                        txtDocumentoBuscar.Select();
                    }
                }
            }



        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            txtDocumentoBuscar.Select();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDocumentoBuscar.Text = "";
            txtFechaCompra.Text = "";
            txtUsuario.Text = "";
            txtNroDocumentoCompra.Text = "";
            txtNombreCliente.Text = "";
            txtVuelto.Text = "";
            txtMontoTotal.Text = "";
            txtPago.Text = "";
            dgvData.Rows.Clear();
        }
    }
}
