using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void limpiarCampos()
        {
            txtIndice.Text = "-1";
            txttId.Text = "0";
            txtCodigoProducto.Text = "";
            txtNombreProducto.Text = "";
            txtDescripcion.Text = "";
            cboCategoria.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new Utilidades.opcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new Utilidades.opcionCombo() { Valor = 0, Texto = "Inactivo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";

            List<Categoria> listaCategoria = new CN_Categoria().Listar();
            foreach (Categoria item in listaCategoria)
            {
                cboCategoria.Items.Add(new Utilidades.opcionCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }

            cboCategoria.DisplayMember = "Texto";
            cboCategoria.ValueMember = "Valor";


            // Listar los Productos
            List<Producto> lista = new CN_Producto().Listar();
            foreach (Producto item in lista)
            {
                dgvData.Rows.Add(new object[] { "",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.ObjCategoria.IdCategoria,
                    item.ObjCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "Inactivo"
                });

            }

            cboCategoria.DisplayMember = "Texto";
            cboCategoria.ValueMember = "Valor";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;


            Producto ObjProducto = new Producto()
            {
                IdProducto = Convert.ToInt32(txttId.Text),
                Codigo = txtCodigoProducto.Text,
                Nombre = txtNombreProducto.Text,
                Descripcion = txtDescripcion.Text,
                ObjCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((opcionCombo)cboCategoria.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((opcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false
            };


            if (ObjProducto.IdProducto == 0)
            {

                int idProductoGenerado = new CN_Producto().Registrar(ObjProducto, out Mensaje);


                if (idProductoGenerado != 0)
                {
                    dgvData.Rows.Add(new object[] {
                    "",
                    idProductoGenerado,
                    txtCodigoProducto.Text,
                    txtNombreProducto.Text,
                    txtDescripcion.Text,
                    ((opcionCombo)cboCategoria.SelectedItem).Valor.ToString(),
                    ((opcionCombo)cboCategoria.SelectedItem).Texto.ToString(),
                    "0",
                    "0.00",
                    "0.00",
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
                bool editar = new CN_Producto().Editar(ObjProducto, out Mensaje);

                if (editar == true)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["id"].Value = txttId.Text;
                    row.Cells["Codigo"].Value = txtCodigoProducto.Text;
                    row.Cells["Nombre"].Value = txtNombreProducto.Text;
                    row.Cells["Descripcion"].Value = txtDescripcion.Text;
                    row.Cells["idCategoria"].Value = ((opcionCombo)cboCategoria.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((opcionCombo)cboCategoria.SelectedItem).Texto.ToString();
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
                    txtCodigoProducto.Text = dgvData.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtNombreProducto.Text = dgvData.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtDescripcion.Text = dgvData.Rows[indice].Cells["Descripcion"].Value.ToString();

                    foreach (opcionCombo oc in cboCategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["idCategoria"].Value))
                        {
                            int indiceCombo = cboCategoria.Items.IndexOf(oc);
                            cboCategoria.SelectedIndex = indiceCombo;
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
                    Producto ObjProducto = new Producto ()
                    {
                        IdProducto = Convert.ToInt32(txttId.Text)
                    };

                    bool eliminar = new CN_Producto().Eliminar(ObjProducto, out Mensaje);

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
