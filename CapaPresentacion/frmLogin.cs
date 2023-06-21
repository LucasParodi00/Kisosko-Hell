using CapaEntidad;
using CapaNegocio;
using System.Data;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar(); //Traemos toda la lista de usuarios y y buscamos uno en especifico

            Usuario ObjUsuario = new CN_Usuario().Listar().Where(u => u.Documento == TxtDocumento.Text && u.Clave == TxtPassword.Text).FirstOrDefault();


            if (ObjUsuario != null)
            {
                Inicio frmInicio = new Inicio(ObjUsuario);
                frmInicio.Show();
                this.Hide(); // Se oculta el menu de ingreso
                frmInicio.FormClosing += FrmInicio_Closing; // Concatenamos el evento para mostrar de nuevo
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FrmInicio_Closing(object sender, FormClosingEventArgs e)
        {
            TxtDocumento.Text = "";
            TxtPassword.Text = "";
            this.Show();
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
            {
                BtnIngresar_Click(sender, e);
            }
        }
    }
}
