using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

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
            txtDocumentoBuscar.Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDocumentoBuscar.Text != "")
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
            else
            {
                using( var modal = new Utilidades.mdCompras() ) 
                {
                    var resultado = modal.ShowDialog();

                    if ( resultado == DialogResult.OK )
                    {
                        txtDocumentoBuscar.Text = modal._Compra.NumeroDocumento;
                        btnBuscar_Click(sender, new EventArgs());
                    }
                }
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
            txtDocumentoBuscar.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
