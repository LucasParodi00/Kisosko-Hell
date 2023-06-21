using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario UsuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuario ObjUsuario = null)
        {
            if (ObjUsuario == null)
            {
                UsuarioActual = new Usuario() { NombreCompleto = "ADMIN PREF", IdUsuario = 1 };
            }
            else
            {
                UsuarioActual = ObjUsuario;
            }


            //UsuarioActual = ObjUsuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> listaPermisos = new CN_Permiso().Listar(UsuarioActual.IdUsuario);

            AD.Text = UsuarioActual.NombreCompleto;
            iduss.Text = UsuarioActual.IdUsuario.ToString();

            foreach (IconMenuItem iconMenu in Menu.Items)
            {
                bool encontrado = listaPermisos.Any(m => m.Acceso == iconMenu.Name);

                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }


        }

        private void abrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null) // Preguntamos si es el menu que seleccionamos, para que nos marque de color
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;

            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            //formulario.BackColor = Color.SteelBlue;
            Contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void MenuUsuario_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void subMenuCategorias_Click(object sender, EventArgs e)
        {
            abrirFormulario(MenuMantenedor, new frmCategorias());

        }

        private void subMenuProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(MenuMantenedor, new frmProductos());

        }

        private void subMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(MenuVentas, new frmVentas(UsuarioActual));

        }

        private void subMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(MenuVentas, new frmDetalleVenta());

        }

        private void subMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(MenuCompras, new frmCompras(UsuarioActual));

        }

        private void subMenuVerDetallesCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario(MenuCompras, new frmDetalleCompras());

        }

        private void MenuClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmClientes());

        }

        private void MenuProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmProveedores());

        }

        private void MenuAcercaDe_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmNegocio());
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void subMenuReportesCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario(MenuReportes, new frmReportesCompras());

        }

        private void subMenuReportesVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(MenuReportes, new frmReportesVentas());

        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}