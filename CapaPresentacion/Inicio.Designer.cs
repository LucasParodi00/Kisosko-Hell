namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Menu = new MenuStrip();
            MenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            MenuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            subMenuCategorias = new FontAwesome.Sharp.IconMenuItem();
            subMenuProductos = new FontAwesome.Sharp.IconMenuItem();
            MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            subMenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            subMenuVerDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            MenuCompras = new FontAwesome.Sharp.IconMenuItem();
            subMenuRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            subMenuVerDetallesCompras = new FontAwesome.Sharp.IconMenuItem();
            MenuClientes = new FontAwesome.Sharp.IconMenuItem();
            MenuProveedores = new FontAwesome.Sharp.IconMenuItem();
            MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            MenuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            MenuTitulo = new MenuStrip();
            Contenedor = new Panel();
            AD = new Label();
            iduss = new Label();
            Menu.SuspendLayout();
            Contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Items.AddRange(new ToolStripItem[] { MenuUsuarios, MenuMantenedor, MenuVentas, MenuCompras, MenuClientes, MenuProveedores, MenuReportes, MenuAcercaDe });
            Menu.Location = new Point(0, 73);
            Menu.Name = "Menu";
            Menu.Size = new Size(1294, 74);
            Menu.TabIndex = 0;
            Menu.Text = "menuStrip1";
            Menu.ItemClicked += Menu_ItemClicked;
            // 
            // MenuUsuarios
            // 
            MenuUsuarios.AutoSize = false;
            MenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            MenuUsuarios.IconColor = Color.Black;
            MenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuUsuarios.IconSize = 60;
            MenuUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            MenuUsuarios.Name = "MenuUsuarios";
            MenuUsuarios.Size = new Size(122, 70);
            MenuUsuarios.Text = "USUARIOS";
            MenuUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuUsuarios.Click += MenuUsuario_Click;
            // 
            // MenuMantenedor
            // 
            MenuMantenedor.AutoSize = false;
            MenuMantenedor.DropDownItems.AddRange(new ToolStripItem[] { subMenuCategorias, subMenuProductos });
            MenuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            MenuMantenedor.IconColor = Color.Black;
            MenuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuMantenedor.IconSize = 60;
            MenuMantenedor.ImageScaling = ToolStripItemImageScaling.None;
            MenuMantenedor.Name = "MenuMantenedor";
            MenuMantenedor.Size = new Size(122, 70);
            MenuMantenedor.Text = "EDITOR";
            MenuMantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // subMenuCategorias
            // 
            subMenuCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuCategorias.IconColor = Color.Black;
            subMenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuCategorias.Name = "subMenuCategorias";
            subMenuCategorias.Size = new Size(130, 22);
            subMenuCategorias.Text = "Categorias";
            subMenuCategorias.Click += subMenuCategorias_Click;
            // 
            // subMenuProductos
            // 
            subMenuProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuProductos.IconColor = Color.Black;
            subMenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuProductos.Name = "subMenuProductos";
            subMenuProductos.Size = new Size(130, 22);
            subMenuProductos.Text = "Productos";
            subMenuProductos.Click += subMenuProductos_Click;
            // 
            // MenuVentas
            // 
            MenuVentas.AutoSize = false;
            MenuVentas.DropDownItems.AddRange(new ToolStripItem[] { subMenuRegistrarVenta, subMenuVerDetalleVenta });
            MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            MenuVentas.IconColor = Color.Black;
            MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuVentas.IconSize = 60;
            MenuVentas.ImageScaling = ToolStripItemImageScaling.None;
            MenuVentas.Name = "MenuVentas";
            MenuVentas.Size = new Size(122, 70);
            MenuVentas.Text = "VENTAS";
            MenuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarVenta
            // 
            subMenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuRegistrarVenta.IconColor = Color.Black;
            subMenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuRegistrarVenta.Name = "subMenuRegistrarVenta";
            subMenuRegistrarVenta.Size = new Size(120, 22);
            subMenuRegistrarVenta.Text = "Registrar";
            subMenuRegistrarVenta.Click += subMenuRegistrarVenta_Click;
            // 
            // subMenuVerDetalleVenta
            // 
            subMenuVerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuVerDetalleVenta.IconColor = Color.Black;
            subMenuVerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuVerDetalleVenta.Name = "subMenuVerDetalleVenta";
            subMenuVerDetalleVenta.Size = new Size(120, 22);
            subMenuVerDetalleVenta.Text = "Detalle";
            subMenuVerDetalleVenta.Click += subMenuVerDetalleVenta_Click;
            // 
            // MenuCompras
            // 
            MenuCompras.AutoSize = false;
            MenuCompras.DropDownItems.AddRange(new ToolStripItem[] { subMenuRegistrarCompra, subMenuVerDetallesCompras });
            MenuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            MenuCompras.IconColor = Color.Black;
            MenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuCompras.IconSize = 60;
            MenuCompras.ImageScaling = ToolStripItemImageScaling.None;
            MenuCompras.Name = "MenuCompras";
            MenuCompras.Size = new Size(122, 70);
            MenuCompras.Text = "COMPRAS";
            MenuCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarCompra
            // 
            subMenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuRegistrarCompra.IconColor = Color.Black;
            subMenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuRegistrarCompra.Name = "subMenuRegistrarCompra";
            subMenuRegistrarCompra.Size = new Size(134, 22);
            subMenuRegistrarCompra.Text = "Registrar";
            subMenuRegistrarCompra.Click += subMenuRegistrarCompra_Click;
            // 
            // subMenuVerDetallesCompras
            // 
            subMenuVerDetallesCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuVerDetallesCompras.IconColor = Color.Black;
            subMenuVerDetallesCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuVerDetallesCompras.Name = "subMenuVerDetallesCompras";
            subMenuVerDetallesCompras.Size = new Size(134, 22);
            subMenuVerDetallesCompras.Text = "Ver Detalles";
            subMenuVerDetallesCompras.Click += subMenuVerDetallesCompras_Click;
            // 
            // MenuClientes
            // 
            MenuClientes.AutoSize = false;
            MenuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            MenuClientes.IconColor = Color.Black;
            MenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuClientes.IconSize = 60;
            MenuClientes.ImageScaling = ToolStripItemImageScaling.None;
            MenuClientes.Name = "MenuClientes";
            MenuClientes.Size = new Size(122, 70);
            MenuClientes.Text = "CLIENTES";
            MenuClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuClientes.Click += MenuClientes_Click;
            // 
            // MenuProveedores
            // 
            MenuProveedores.AutoSize = false;
            MenuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            MenuProveedores.IconColor = Color.Black;
            MenuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuProveedores.IconSize = 60;
            MenuProveedores.ImageScaling = ToolStripItemImageScaling.None;
            MenuProveedores.Name = "MenuProveedores";
            MenuProveedores.Size = new Size(122, 70);
            MenuProveedores.Text = "PROVEEDORES";
            MenuProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuProveedores.Click += MenuProveedores_Click;
            // 
            // MenuReportes
            // 
            MenuReportes.AutoSize = false;
            MenuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            MenuReportes.IconColor = Color.Black;
            MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuReportes.IconSize = 60;
            MenuReportes.ImageScaling = ToolStripItemImageScaling.None;
            MenuReportes.Name = "MenuReportes";
            MenuReportes.Size = new Size(122, 70);
            MenuReportes.Text = "REPORTES";
            MenuReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuReportes.Click += MenuReportes_Click;
            // 
            // MenuAcercaDe
            // 
            MenuAcercaDe.AutoSize = false;
            MenuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            MenuAcercaDe.IconColor = Color.Black;
            MenuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuAcercaDe.IconSize = 60;
            MenuAcercaDe.ImageScaling = ToolStripItemImageScaling.None;
            MenuAcercaDe.Name = "MenuAcercaDe";
            MenuAcercaDe.Size = new Size(122, 70);
            MenuAcercaDe.Text = "ACERCA DE";
            MenuAcercaDe.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuAcercaDe.Click += MenuAcercaDe_Click;
            // 
            // MenuTitulo
            // 
            MenuTitulo.AutoSize = false;
            MenuTitulo.BackColor = Color.Ivory;
            MenuTitulo.Location = new Point(0, 0);
            MenuTitulo.Name = "MenuTitulo";
            MenuTitulo.RightToLeft = RightToLeft.Yes;
            MenuTitulo.Size = new Size(1294, 73);
            MenuTitulo.TabIndex = 1;
            MenuTitulo.Text = "menuStrip2";
            // 
            // Contenedor
            // 
            Contenedor.Controls.Add(iduss);
            Contenedor.Controls.Add(AD);
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.Location = new Point(0, 147);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(1294, 639);
            Contenedor.TabIndex = 2;
            // 
            // AD
            // 
            AD.AutoSize = true;
            AD.Location = new Point(1196, 569);
            AD.Name = "AD";
            AD.Size = new Size(13, 15);
            AD.TabIndex = 0;
            AD.Text = "a";
            // 
            // iduss
            // 
            iduss.AutoSize = true;
            iduss.Location = new Point(1196, 598);
            iduss.Name = "iduss";
            iduss.Size = new Size(13, 15);
            iduss.TabIndex = 1;
            iduss.Text = "a";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 786);
            Controls.Add(Contenedor);
            Controls.Add(Menu);
            Controls.Add(MenuTitulo);
            MainMenuStrip = Menu;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO";
            Load += Inicio_Load;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            Contenedor.ResumeLayout(false);
            Contenedor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private MenuStrip MenuTitulo;
        private FontAwesome.Sharp.IconMenuItem MenuUsuarios;
        private FontAwesome.Sharp.IconMenuItem MenuMantenedor;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuCompras;
        private FontAwesome.Sharp.IconMenuItem MenuClientes;
        private FontAwesome.Sharp.IconMenuItem MenuProveedores;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private FontAwesome.Sharp.IconMenuItem MenuAcercaDe;
        private Panel Contenedor;
        private FontAwesome.Sharp.IconMenuItem subMenuCategorias;
        private FontAwesome.Sharp.IconMenuItem subMenuProductos;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem subMenuVerDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem subMenuVerDetallesCompras;
        private Label AD;
        private Label iduss;
    }
}