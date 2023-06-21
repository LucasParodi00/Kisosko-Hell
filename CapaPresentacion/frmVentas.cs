using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System.Data;

namespace CapaPresentacion
{
    public partial class frmVentas : Form
    {
        private Usuario _Usuario;
        public frmVentas(Usuario ObjUsuario = null)
        {
            _Usuario = ObjUsuario;
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cboTipoDocumento.Items.Add(new Utilidades.opcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cboTipoDocumento.Items.Add(new Utilidades.opcionCombo() { Valor = "Factura", Texto = "Factura" });
            cboTipoDocumento.DisplayMember = "Texto";
            cboTipoDocumento.ValueMember = "Valor";

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtIdProducto.Text = "0";
            txtIdCliente.Text = "0";

            cboTipoDocumento.SelectedIndex = 0;

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {

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
                    txtPrecio.Text = ObjProducto.PrecioVenta.ToString();
                    txtStock.Text = ObjProducto.Stock.ToString();
                    txtCantidad.Select();
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



        }

        private void limpiarProducto()
        {
            txtIdProducto.Text = "0";
            txtCodProducto.Text = "";
            txtCodProducto.BackColor = Color.White;
            txtNombreProducto.Text = "";
            txtCantidad.Value = 1;
            txtPrecio.Text = "";
            txtStock.Text = "";

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
                    bool respuesta = new CN_Venta().sumarStock(
                        Convert.ToInt32(dgvData.Rows[indice].Cells["idProducto"].Value.ToString()),
                        Convert.ToInt32(dgvData.Rows[indice].Cells["cantidad"].Value.ToString())
                        );

                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(indice);
                        calcularTotal();
                    }
                }
            }
        }



        private void txtPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPagaCon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void calcularVueltp()
        {
            if (txtTotalAPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la lista", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagaCon = Convert.ToDecimal(txtPagaCon.Text);
            decimal total = Convert.ToDecimal(txtTotalAPagar.Text);

            if (txtPagaCon.Text.Trim() == "")
            {
                txtPagaCon.Text = "0";
            }

            if (decimal.TryParse(txtPagaCon.Text.Trim(), out pagaCon))
            {
                if (pagaCon < total)
                {
                    txtVuelto.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagaCon - total;
                    txtVuelto.Text = cambio.ToString("0.00");
                }
            }


        }

        private void txtPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularVueltp();
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (txtDocCliente.Text == "")
            {
                MessageBox.Show("Debe seleccionar un cliente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNombreCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del cliente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar los productos para la venta", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));

            foreach (DataGridViewRow item in dgvData.Rows)
            {
                detalle_venta.Rows.Add(new object[]
                {
                    item.Cells["IdProducto"].Value.ToString(),
                    item.Cells["Precio"].Value.ToString(),
                    item.Cells["Cantidad"].Value.ToString(),
                    item.Cells["SubTotal"].Value.ToString(),
                });
            }

            int idCorrelativo = new CN_Venta().obtenerCorrelativo();

            string numeroFactura = string.Format("{0:00000}", idCorrelativo);

            calcularVueltp();

            Venta venta = new Venta()
            {
                ObjUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                TipoDocumento = ((opcionCombo)cboTipoDocumento.SelectedItem).Texto,
                NumeroDocumento = numeroFactura,
                DocumentoCliente = txtDocCliente.Text,
                NombreCliente = txtNombreCliente.Text,
                MontoPago = Convert.ToDecimal(txtPagaCon.Text),
                MontoCambio = Convert.ToDecimal(txtVuelto.Text),
                MontoTotal = Convert.ToDecimal(txtTotalAPagar.Text)
            };



            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(venta, detalle_venta, out mensaje);

            if (respuesta)
            {
                var resultado = MessageBox.Show("Numero de Venta: \n" + numeroFactura + "\n\nCopiar?", "MENSJAE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    Clipboard.SetText(numeroFactura);
                }

                txtDocCliente.Text = "";
                txtNombreCliente.Text = "";
                txtPagaCon.Text = "";
                txtVuelto.Text = "";
                dgvData.Rows.Clear();
                calcularTotal();
            }
            else
            {
                var resultado = MessageBox.Show(mensaje, "MENSJAE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BTT2_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var resultado = modal.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    txtIdProducto.Text = modal._Producto.IdProducto.ToString();
                    txtNombreProducto.Text = modal._Producto.Nombre.ToString();
                    txtCodProducto.Text = modal._Producto.Codigo.ToString();
                    txtPrecio.Text = modal._Producto.PrecioVenta.ToString();
                    txtStock.Text = modal._Producto.Stock.ToString();
                    txtCantidad.Select();
                }
                else
                {
                    txtCodProducto.Select();
                }

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (var modal = new mdClientes())
            {
                var resultado = modal.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    txtDocCliente.Text = modal._Cliente.Documento.ToString();
                    txtNombreCliente.Text = modal._Cliente.NombreCompleto.ToString();
                    txtCodProducto.Select();
                }
                else
                {
                    txtDocCliente.Select();
                }

            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(txtIdProducto.Text) == 0)
            {

                MessageBox.Show("Debe agregar un producto primero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio Compra - Formato de moneda incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Select();
                return;
            }

            if (Convert.ToInt32(txtStock.Text) < Convert.ToInt32(txtCantidad.Value.ToString()))
            {
                MessageBox.Show("No tiene suficiente Stock", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Select();
                return;
            }

            foreach (DataGridViewRow fila in dgvData.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtIdProducto.Text)
                {
                    MessageBox.Show("El producto ya se encuentra en el carrito", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                string mensaje = string.Empty;
                bool respuesta = new CN_Venta().restarStock(Convert.ToInt32(txtIdProducto.Text), Convert.ToInt32(txtCantidad.Value.ToString()));

                if (respuesta)
                {
                    dgvData.Rows.Add(new object[]
                    {
                        txtIdProducto.Text,
                        txtNombreProducto.Text,
                        precio.ToString("0.00"),
                        txtCantidad.Value.ToString(),
                        (txtCantidad.Value * precio).ToString("0.00")
                    });

                    calcularTotal();
                    limpiarProducto();
                    txtCodProducto.Select();
                }

            }
        }
    }
}
