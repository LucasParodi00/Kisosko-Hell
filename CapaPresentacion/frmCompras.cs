using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System.Data;

namespace CapaPresentacion
{
    public partial class frmCompras : Form
    {

        private Usuario _Usuario;
        public frmCompras(Usuario ObjUsuario = null)
        {
            _Usuario = ObjUsuario;
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            cboTipoDocumento.Items.Add(new Utilidades.opcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cboTipoDocumento.Items.Add(new Utilidades.opcionCombo() { Valor = "Factura", Texto = "Factura" });
            cboTipoDocumento.DisplayMember = "Texto";
            cboTipoDocumento.ValueMember = "Valor";

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtIdProducto.Text = "0";
            txtIdProveedor.Text = "0";



        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var resultado = modal.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    txtIdProveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    txtDocProveedor.Text = modal._Proveedor.Documento.ToString();
                    txtNombreProveedor.Text = modal._Proveedor.RazonSocial.ToString();
                }
                else
                {
                    txtDocProveedor.Select();
                }

            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var resultado = modal.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    txtIdProducto.Text = modal._Producto.IdProducto.ToString();
                    txtNombreProducto.Text = modal._Producto.Nombre.ToString();
                    txtCodProducto.Text = modal._Producto.Codigo.ToString();
                    txtPrecioCompra.Select();
                }
                else
                {
                    txtPrecioCompra.Select();
                }

            }
        }

        private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto ObjProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtCodProducto.Text && p.Estado == true).FirstOrDefault();
                if (ObjProducto != null)
                {
                    txtCodProducto.BackColor = Color.Green;
                    txtIdProducto.Text = ObjProducto.IdProducto.ToString();
                    txtNombreProducto.Text = ObjProducto.Nombre;
                    txtPrecioCompra.Select();
                }
                else
                {
                    txtCodProducto.BackColor = Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtIdProducto.Text = "";
                }
            }
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {


            decimal precioCompra = 0;
            decimal precioVenta = 0;
            bool producto_existe = false;

            if (int.Parse(txtIdProducto.Text) == 0)
            {

                MessageBox.Show("Debe agregar un producto primero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrecioCompra.Text, out precioCompra))
            {
                MessageBox.Show("Precio Compra - Formato de moneda incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioCompra.Select();
                return;
            }

            if (!decimal.TryParse(txtPrecioVenta.Text, out precioVenta))
            {
                MessageBox.Show("Precio Venta - Formato de moneda incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioVenta.Select();
                return;
            }

            foreach (DataGridViewRow fila in dgvData.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtIdProducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                dgvData.Rows.Add(new object[]
                {
                    txtIdProducto.Text,
                    txtNombreProducto.Text,
                    precioCompra.ToString("0.00"),
                    precioVenta.ToString("0.00"),
                    txtCantidad.Value.ToString(),
                    (txtCantidad.Value * precioCompra).ToString("0.00")
                });

                calcularTotal();
                limpiarProducto();
                txtCodProducto.Select();
            }
        }

        private void limpiarProducto()
        {
            txtIdProducto.Text = "0";
            txtCodProducto.Text = "";
            txtCodProducto.BackColor = Color.White;
            txtNombreProducto.Text = "";
            txtCantidad.Value = 1;
            txtPrecioVenta.Text = "";
            txtPrecioCompra.Text = "";

        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["subTotal"].Value.ToString());
                }

                txtTotalAPagar.Text = total.ToString("0.00");
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgvData.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }

        private void frmCompras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPrecioCompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }

                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPrecioVenta.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }

                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (Convert.ToUInt32(txtIdProveedor.Text) == 0) //CAMBIIOS GIT
            {
                MessageBox.Show("Debe seleccionar un proveedor", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("Debe elegir algun producto ", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoFinal", typeof(decimal));

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                detalle_compra.Rows.Add(
                    new Object[]
                    {
                        Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                        row.Cells["PrecioCompra"].Value.ToString(),
                        row.Cells["PrecioVenta"].Value.ToString(),
                        row.Cells["Cantidad"].Value.ToString(),
                        row.Cells["subTotal"].Value.ToString()
                    });
            }

            int idcorrelativo = new CN_Compra().obtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);

            Compra ObjCompra = new Compra()
            {
                ObjUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                ObjProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtIdProveedor.Text), RazonSocial = txtNombreProveedor.Text },
                TipoDocumento = ((opcionCombo)cboTipoDocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                MontoTotal = Convert.ToDecimal(txtTotalAPagar.Text)
            };

            string Mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(ObjCompra, detalle_compra, out Mensaje);

            if (respuesta)
            {
                var resultado = MessageBox.Show("Numero de compra: \n" + numeroDocumento + "\n\nCopiar?", "MENSJAE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    Clipboard.SetText(numeroDocumento);
                }

                txtIdProveedor.Text = "0";
                txtDocProveedor.Text = "0";
                txtNombreProveedor.Text = "0";
                dgvData.Rows.Clear();
                calcularTotal();
            }
            else
            {
                MessageBox.Show(Mensaje, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
