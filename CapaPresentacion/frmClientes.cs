using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new Utilidades.opcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new Utilidades.opcionCombo() { Valor = 0, Texto = "Inactivo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";

            // Listar los Clientes
            List<Cliente> listaCliente = new CN_Cliente().Listar();
            foreach (Cliente item in listaCliente)
            {
                dgvData.Rows.Add(new object[] { "",
                    item.IdCliente,
                    item.Documento,
                    item.NombreCompleto,
                    item.Correo,
                    item.Telefono,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "Inactivo",
                });

            }
        }
        private void limpiarCampos()
        {
            txtIndice.Text = "-1";
            txttId.Text = "0";
            txtDni.Text = "";
            txtNombreYApellido.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            cboEstado.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;


            Cliente ObjCliente = new Cliente()
            {
                IdCliente = Convert.ToInt32(txttId.Text),
                Documento = txtDni.Text,
                NombreCompleto = txtNombreYApellido.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Estado = Convert.ToInt32(((opcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false
            };


            if (ObjCliente.IdCliente == 0)
            {

                int idClienteGenerado = new CN_Cliente().Registrar(ObjCliente, out Mensaje);


                if (idClienteGenerado != 0)
                {
                    dgvData.Rows.Add(new object[] { "",
                        idClienteGenerado,
                        txtDni.Text,
                        txtNombreYApellido.Text,
                        txtCorreo.Text,
                        txtTelefono.Text,
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
                bool editar = new CN_Cliente().Editar(ObjCliente, out Mensaje);

                if (editar == true)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["id"].Value = txttId.Text;
                    row.Cells["Documento"].Value = txtDni.Text;
                    row.Cells["NombreCompleto"].Value = txtNombreYApellido.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Telefono"].Value = txtTelefono.Text;
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
                    txtTelefono.Text = dgvData.Rows[indice].Cells["Telefono"].Value.ToString();
                 
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
    }
}
