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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new Utilidades.opcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new Utilidades.opcionCombo() { Valor = 0, Texto = "Inactivo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";


            // Listar los usuarios
            List<Categoria> lista = new CN_Categoria().Listar();

            foreach (Categoria item in lista)
            {
                dgvData.Rows.Add(new object[] { "", item.IdCategoria, item.Descripcion,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "Inactivo"
                });

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;


            Categoria Obj = new Categoria()
            {
                IdCategoria = Convert.ToInt32(txttId.Text),
                Descripcion = txtDescripcionCategoria.Text,
                Estado = Convert.ToInt32(((opcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false
            };


            if (Obj.IdCategoria == 0)
            {

                int idGenerado = new CN_Categoria().Registrar(Obj, out Mensaje);


                if (idGenerado != 0)
                {
                    dgvData.Rows.Add(new object[] { "", idGenerado, txtDescripcionCategoria.Text,
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
                bool editar = new CN_Categoria().Editar(Obj, out Mensaje);

                if (editar == true)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["id"].Value = txttId.Text;
                    row.Cells["Descripcion"].Value = txtDescripcionCategoria.Text;

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
            txttId.Text = "0";
            txtDescripcionCategoria.Text = "";
            cboEstado.SelectedIndex = 1;
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
                    txtDescripcionCategoria.Text = dgvData.Rows[indice].Cells["Descripcion"].Value.ToString();

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
                if (MessageBox.Show("Seguro que va a eliminar esta categoria?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Mensaje = string.Empty;
                    Categoria Obj = new Categoria()
                    {
                        IdCategoria = Convert.ToInt32(txttId.Text)
                    };

                    bool eliminar = new CN_Categoria().Eliminar(Obj, out Mensaje);

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
