using CapaDatos;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombreCopia.Text != "")
            {
                CN_BDD ObjBDD = new CN_BDD();

                string nombre = txtNombreCopia.Text;

                bool resultado = ObjBDD.copiaSeguridad(nombre);

                if (resultado)
                {
                    MessageBox.Show("Se realizo correctamente la copia de seguridad", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreCopia.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la copia ", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Debe completar el campo ", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCargarCopia_Click(object sender, EventArgs e)
        {

            try
            {
                CN_BDD ObjBDD = new CN_BDD();

                bool resultado = ObjBDD.restaurarBdd(txtRuta.Text);

                if (resultado)
                {
                    MessageBox.Show("BASE DE DATOS RESTAURADA EXITOSAMENTE ", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRuta.Text = "";
                }
                else
                {
                    MessageBox.Show("Ocurrio un error, no se pudo restaurar la BDD", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error en el proceso de carga", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnBuscarCopia_Click(object sender, EventArgs e)
        {
            string ruta = "";

            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "Respaldos SQL (*.bak)|";
            archivo.Title = "Seleccionar Respaldo";
            archivo.InitialDirectory = "D:\\LucasParodi\\UNNE\\Taller de Programacion II\\Proyecto\\TallerII\\ProyectoTallerII\\ProyectoTallerII\\BDD\\Respaldos";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                ruta = archivo.FileName;
                txtRuta.Text = ruta;
            }

        }
    }
}
