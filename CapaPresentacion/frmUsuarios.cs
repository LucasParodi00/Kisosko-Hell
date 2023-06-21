using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new Utilidades.opcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new Utilidades.opcionCombo() { Valor = 0, Texto = "Inactivo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";

            List<Rol> listaRol = new CN_Rol().Listar();
            foreach (Rol item in listaRol)
            {
                cboRol.Items.Add(new Utilidades.opcionCombo() { Valor = item.IdRol, Texto = item.descripcion });
            }

            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";


            // Listar los usuarios
            List<Usuario> listaUsuario = new CN_Usuario().Listar();
            foreach (Usuario item in listaUsuario)
            {
                dgvData.Rows.Add(new object[] { "", item.IdUsuario, item.Documento, item.NombreCompleto, item.Correo, item.Clave,
                    item.ObjRol.IdRol,
                    item.ObjRol.descripcion,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "Inactivo"
                });

            }

            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;


            Usuario ObjUsuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txttId.Text),
                Documento = txtDni.Text,
                NombreCompleto = txtNombreYApellido.Text,
                Correo = txtCorreo.Text,
                Clave = txtContraseña.Text,
                ObjRol = new Rol() { IdRol = Convert.ToInt32(((opcionCombo)cboRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((opcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false
            };


            if (ObjUsuario.IdUsuario == 0)
            {

                int idUsuarioGenerado = new CN_Usuario().Registrar(ObjUsuario, out Mensaje);


                if (idUsuarioGenerado != 0)
                {
                    dgvData.Rows.Add(new object[] { "", idUsuarioGenerado, txtDni.Text, txtNombreYApellido.Text, txtCorreo.Text, txtContraseña.Text,
                    ((opcionCombo)cboRol.SelectedItem).Valor.ToString(),
                    ((opcionCombo)cboRol.SelectedItem).Texto.ToString(),
                    ((opcionCombo)cboEstado.SelectedItem).Valor.ToString(),
                    ((opcionCombo)cboEstado.SelectedItem).Texto.ToString(),
                    });

                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }

            }
            else
            {
                bool editar = new CN_Usuario().Editar(ObjUsuario, out Mensaje);

                if (editar == true)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["id"].Value = txttId.Text;
                    row.Cells["Documento"].Value = txtDni.Text;
                    row.Cells["NombreCompleto"].Value = txtNombreYApellido.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Clave"].Value = txtContraseña.Text;
                    row.Cells["IdRol"].Value = ((opcionCombo)cboRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((opcionCombo)cboRol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((opcionCombo)cboEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((opcionCombo)cboEstado.SelectedItem).Texto.ToString();

                    limpiarCampos();

                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            }


        }


        private void limpiarCampos()
        {
            txtIndice.Text = "-1";
            txttId.Text = "";
            txtDni.Text = "";
            txtNombreYApellido.Text = "";
            txtCorreo.Text = "";
            txtRepetirContraseña.Text = "";
            txtContraseña.Text = "";
            cboEstado.SelectedIndex = 0;
            cboRol.SelectedIndex = 0;
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;


                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txttId.Text = dgvData.Rows[indice].Cells["id"].Value.ToString();
                    txtDni.Text = dgvData.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombreYApellido.Text = dgvData.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvData.Rows[indice].Cells["correo"].Value.ToString();
                    txtContraseña.Text = dgvData.Rows[indice].Cells["clave"].Value.ToString();
                    txtRepetirContraseña.Text = dgvData.Rows[indice].Cells["clave"].Value.ToString();
                    int a = Convert.ToInt32(dgvData.Rows[indice].Cells["idRol"].Value);
                    foreach (opcionCombo oc in cboRol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["idRol"].Value))
                        {
                            int indiceCombo = cboRol.Items.IndexOf(oc);
                            cboRol.SelectedIndex = indiceCombo;
                            break;
                        }
                    }

                    foreach (opcionCombo oc in cboEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indiceCombo = cboEstado.Items.IndexOf(oc);
                            cboEstado.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txttId.Text) != 0)
            {
                if (MessageBox.Show("Seguro que va a eliminar este cliente?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Mensaje = string.Empty;
                    Usuario ObjUsuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txttId.Text)
                    };

                    bool eliminar = new CN_Usuario().Eliminar(ObjUsuario, out Mensaje);

                    if (eliminar)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(Mensaje, " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
