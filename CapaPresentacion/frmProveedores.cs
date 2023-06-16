using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new Utilidades.opcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new Utilidades.opcionCombo() { Valor = 0, Texto = "Inactivo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";

            // Listar los Proveedors
            List<Proveedor> listaProveedor = new CN_Proveedor().Listar();
            foreach (Proveedor item in listaProveedor)
            {
                dgvData.Rows.Add(new object[] { "",
                    item.IdProveedor,
                    item.Documento,
                    item.RazonSocial,
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
            txtRazonSocial.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            cboEstado.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;


            Proveedor ObjProveedor = new Proveedor()
            {
                IdProveedor = Convert.ToInt32(txttId.Text),
                Documento = txtDni.Text,
                RazonSocial = txtRazonSocial.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Estado = Convert.ToInt32(((opcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false
            };


            if (ObjProveedor.IdProveedor == 0)
            {

                int idProveedorGenerado = new CN_Proveedor().Registrar(ObjProveedor, out Mensaje);


                if (idProveedorGenerado != 0)
                {
                    dgvData.Rows.Add(new object[] { "",
                        idProveedorGenerado,
                        txtDni.Text,
                        txtRazonSocial.Text,
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
                bool editar = new CN_Proveedor().Editar(ObjProveedor, out Mensaje);

                if (editar == true)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["id"].Value = txttId.Text;
                    row.Cells["Documento"].Value = txtDni.Text;
                    row.Cells["RazonSocial"].Value = txtRazonSocial.Text;
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
                    txtRazonSocial.Text = dgvData.Rows[indice].Cells["RazonSocial"].Value.ToString();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txttId.Text) != 0)
            {
                if (MessageBox.Show("Seguro que va a eliminar este usuario?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Mensaje = string.Empty;
                    Proveedor ObjProveedor = new Proveedor()
                    {
                        IdProveedor = Convert.ToInt32(txttId.Text)
                    };

                    bool eliminar = new CN_Proveedor().Eliminar(ObjProveedor, out Mensaje);

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
