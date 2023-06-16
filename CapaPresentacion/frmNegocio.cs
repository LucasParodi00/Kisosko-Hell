using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }


        public Image byteAImagen(byte[] imagenByte)
        {
            MemoryStream ms = new MemoryStream(); // nos permite guardar imagene en memoria
            ms.Write(imagenByte, 0, imagenByte.Length); // el nombre, desde donde empieza, y el temaño
            Image image = new Bitmap(ms);

            return image;
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteImagen = new CN_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)
            {
                pickLogo.Image = byteAImagen(byteImagen);
            }

            Negocio datos = new CN_Negocio().ObtenerDatos();

            txtNombreNegocio.Text = datos.Nombre;
            txtRUC.Text = datos.RUC;
            txtDireccion.Text = datos.Direccion;
        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.FileName = "Files|*.jpg; *.jpeg; *.png;";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                byte[] byteImagen = File.ReadAllBytes(openFile.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(byteImagen, out mensaje);

                if (respuesta)
                {
                    pickLogo.Image = byteAImagen(byteImagen);
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Negocio ObjNegocio = new Negocio()
            {
                Nombre = txtNombreNegocio.Text,
                Direccion = txtDireccion.Text,
                RUC = txtRUC.Text,
            };

            bool respuesta = new CN_Negocio().GuardarDatos(ObjNegocio, out mensaje);

            if (respuesta)
            {
                MessageBox.Show("Se guardo correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
