namespace AvicolaVentas
{
    partial class fGestionVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGestionVentas));
            dgListadoVentas = new DataGridView();
            LGestionVentas = new Label();
            LClienteDniVenta = new Label();
            LProductoVenta = new Label();
            LCantidadVenta = new Label();
            LPrecioUnitarioVenta = new Label();
            cProductoVenta = new ComboBox();
            tCantidadVenta = new TextBox();
            tPrecioVenta = new TextBox();
            LListadoVentas = new Label();
            bVolverMenu = new Button();
            PBLogo = new Button();
            lFechaVenta = new Label();
            textBox1 = new TextBox();
            LNombreClienteVenta = new Label();
            tNombreClienteVenta = new TextBox();
            BLimpiarCampos = new Guna.UI2.WinForms.Guna2Button();
            BEliminarVenta = new Guna.UI2.WinForms.Guna2Button();
            BModificarVenta = new Guna.UI2.WinForms.Guna2Button();
            BConfirmarVenta = new Guna.UI2.WinForms.Guna2Button();
            BBuscarCliente = new Guna.UI2.WinForms.Guna2Button();
            bCargarProdVenta = new Guna.UI2.WinForms.Guna2Button();
            dgvRegistroVenta = new DataGridView();
            bCancelarVenta = new Guna.UI2.WinForms.Guna2Button();
            dgvFacturaVenta = new DataGridView();
            dtpFechaNacCliente = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgListadoVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFacturaVenta).BeginInit();
            SuspendLayout();
            // 
            // dgListadoVentas
            // 
            dgListadoVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgListadoVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgListadoVentas.BackgroundColor = Color.Gold;
            dgListadoVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListadoVentas.GridColor = Color.FromArgb(255, 255, 192);
            dgListadoVentas.Location = new Point(30, 262);
            dgListadoVentas.Margin = new Padding(4, 3, 4, 3);
            dgListadoVentas.Name = "dgListadoVentas";
            dgListadoVentas.Size = new Size(805, 248);
            dgListadoVentas.TabIndex = 0;
            dgListadoVentas.CellContentClick += dgListadoVentas_CellContentClick;
            // 
            // LGestionVentas
            // 
            LGestionVentas.BackColor = Color.Gold;
            LGestionVentas.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LGestionVentas.Location = new Point(-11, -2);
            LGestionVentas.Margin = new Padding(4, 0, 4, 0);
            LGestionVentas.Name = "LGestionVentas";
            LGestionVentas.Size = new Size(910, 50);
            LGestionVentas.TabIndex = 3;
            LGestionVentas.Text = "Gestión de Ventas";
            LGestionVentas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LClienteDniVenta
            // 
            LClienteDniVenta.AutoSize = true;
            LClienteDniVenta.BackColor = Color.Transparent;
            LClienteDniVenta.Font = new Font("Sitka Banner", 12F);
            LClienteDniVenta.Location = new Point(41, 57);
            LClienteDniVenta.Margin = new Padding(4, 0, 4, 0);
            LClienteDniVenta.Name = "LClienteDniVenta";
            LClienteDniVenta.Size = new Size(84, 23);
            LClienteDniVenta.TabIndex = 6;
            LClienteDniVenta.Text = "Dni Cliente:";
            // 
            // LProductoVenta
            // 
            LProductoVenta.AutoSize = true;
            LProductoVenta.BackColor = Color.Transparent;
            LProductoVenta.Font = new Font("Sitka Banner", 12F);
            LProductoVenta.Location = new Point(41, 117);
            LProductoVenta.Margin = new Padding(4, 0, 4, 0);
            LProductoVenta.Name = "LProductoVenta";
            LProductoVenta.Size = new Size(69, 23);
            LProductoVenta.TabIndex = 7;
            LProductoVenta.Text = "Producto:";
            // 
            // LCantidadVenta
            // 
            LCantidadVenta.AutoSize = true;
            LCantidadVenta.BackColor = Color.Transparent;
            LCantidadVenta.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LCantidadVenta.Location = new Point(437, 59);
            LCantidadVenta.Margin = new Padding(4, 0, 4, 0);
            LCantidadVenta.Name = "LCantidadVenta";
            LCantidadVenta.Size = new Size(70, 23);
            LCantidadVenta.TabIndex = 8;
            LCantidadVenta.Text = "Cantidad:";
            // 
            // LPrecioUnitarioVenta
            // 
            LPrecioUnitarioVenta.AutoSize = true;
            LPrecioUnitarioVenta.BackColor = Color.Transparent;
            LPrecioUnitarioVenta.Font = new Font("Sitka Banner", 12F);
            LPrecioUnitarioVenta.Location = new Point(437, 86);
            LPrecioUnitarioVenta.Margin = new Padding(4, 0, 4, 0);
            LPrecioUnitarioVenta.Name = "LPrecioUnitarioVenta";
            LPrecioUnitarioVenta.Size = new Size(52, 23);
            LPrecioUnitarioVenta.TabIndex = 9;
            LPrecioUnitarioVenta.Text = "Precio:";
            // 
            // cProductoVenta
            // 
            cProductoVenta.BackColor = Color.White;
            cProductoVenta.FormattingEnabled = true;
            cProductoVenta.Location = new Point(135, 115);
            cProductoVenta.Margin = new Padding(4, 3, 4, 3);
            cProductoVenta.Name = "cProductoVenta";
            cProductoVenta.Size = new Size(208, 23);
            cProductoVenta.TabIndex = 14;
            cProductoVenta.SelectedIndexChanged += cProductoVenta_SelectedIndexChanged;
            // 
            // tCantidadVenta
            // 
            tCantidadVenta.BackColor = Color.White;
            tCantidadVenta.Location = new Point(512, 60);
            tCantidadVenta.Margin = new Padding(4, 3, 4, 3);
            tCantidadVenta.Name = "tCantidadVenta";
            tCantidadVenta.Size = new Size(208, 23);
            tCantidadVenta.TabIndex = 15;
            // 
            // tPrecioVenta
            // 
            tPrecioVenta.BackColor = Color.White;
            tPrecioVenta.Location = new Point(512, 86);
            tPrecioVenta.Margin = new Padding(4, 3, 4, 3);
            tPrecioVenta.Name = "tPrecioVenta";
            tPrecioVenta.Size = new Size(208, 23);
            tPrecioVenta.TabIndex = 17;
            // 
            // LListadoVentas
            // 
            LListadoVentas.BackColor = Color.Gold;
            LListadoVentas.Font = new Font("Sitka Banner", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LListadoVentas.Location = new Point(-11, 225);
            LListadoVentas.Margin = new Padding(4, 0, 4, 0);
            LListadoVentas.Name = "LListadoVentas";
            LListadoVentas.Size = new Size(910, 34);
            LListadoVentas.TabIndex = 5;
            LListadoVentas.Text = "Listado de ventas";
            LListadoVentas.TextAlign = ContentAlignment.TopCenter;
            // 
            // bVolverMenu
            // 
            bVolverMenu.BackColor = Color.Gold;
            bVolverMenu.BackgroundImage = Properties.Resources.icons8_volver_67;
            bVolverMenu.BackgroundImageLayout = ImageLayout.Stretch;
            bVolverMenu.FlatAppearance.BorderSize = 0;
            bVolverMenu.FlatStyle = FlatStyle.Flat;
            bVolverMenu.Location = new Point(844, 10);
            bVolverMenu.Name = "bVolverMenu";
            bVolverMenu.Size = new Size(35, 28);
            bVolverMenu.TabIndex = 23;
            bVolverMenu.UseVisualStyleBackColor = false;
            bVolverMenu.Click += bVolverMenu_Click;
            // 
            // PBLogo
            // 
            PBLogo.BackColor = Color.Gold;
            PBLogo.BackgroundImage = Properties.Resources.logoAvicola;
            PBLogo.BackgroundImageLayout = ImageLayout.Stretch;
            PBLogo.FlatAppearance.BorderSize = 0;
            PBLogo.FlatStyle = FlatStyle.Flat;
            PBLogo.Location = new Point(2, -2);
            PBLogo.Name = "PBLogo";
            PBLogo.Size = new Size(73, 50);
            PBLogo.TabIndex = 24;
            PBLogo.UseVisualStyleBackColor = false;
            // 
            // lFechaVenta
            // 
            lFechaVenta.AutoSize = true;
            lFechaVenta.BackColor = Color.Transparent;
            lFechaVenta.Font = new Font("Sitka Banner", 12F);
            lFechaVenta.Location = new Point(437, 113);
            lFechaVenta.Margin = new Padding(4, 0, 4, 0);
            lFechaVenta.Name = "lFechaVenta";
            lFechaVenta.Size = new Size(50, 23);
            lFechaVenta.TabIndex = 25;
            lFechaVenta.Text = "Fecha:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(135, 57);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 27;
            // 
            // LNombreClienteVenta
            // 
            LNombreClienteVenta.AutoSize = true;
            LNombreClienteVenta.BackColor = Color.Transparent;
            LNombreClienteVenta.Font = new Font("Sitka Banner", 12F);
            LNombreClienteVenta.Location = new Point(41, 83);
            LNombreClienteVenta.Margin = new Padding(4, 0, 4, 0);
            LNombreClienteVenta.Name = "LNombreClienteVenta";
            LNombreClienteVenta.Size = new Size(64, 23);
            LNombreClienteVenta.TabIndex = 28;
            LNombreClienteVenta.Text = "Nombre:";
            // 
            // tNombreClienteVenta
            // 
            tNombreClienteVenta.BackColor = Color.White;
            tNombreClienteVenta.Location = new Point(135, 86);
            tNombreClienteVenta.Margin = new Padding(4, 3, 4, 3);
            tNombreClienteVenta.Name = "tNombreClienteVenta";
            tNombreClienteVenta.Size = new Size(208, 23);
            tNombreClienteVenta.TabIndex = 29;
            // 
            // BLimpiarCampos
            // 
            BLimpiarCampos.BackColor = Color.Transparent;
            BLimpiarCampos.BorderColor = Color.WhiteSmoke;
            BLimpiarCampos.BorderRadius = 20;
            BLimpiarCampos.BorderThickness = 3;
            BLimpiarCampos.CustomizableEdges = customizableEdges1;
            BLimpiarCampos.DisabledState.BorderColor = Color.DarkGray;
            BLimpiarCampos.DisabledState.CustomBorderColor = Color.DarkGray;
            BLimpiarCampos.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BLimpiarCampos.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BLimpiarCampos.FillColor = SystemColors.ControlDark;
            BLimpiarCampos.Font = new Font("Segoe UI", 9F);
            BLimpiarCampos.ForeColor = Color.White;
            BLimpiarCampos.HoverState.FillColor = SystemColors.ControlDarkDark;
            BLimpiarCampos.Image = Properties.Resources.icons8_limpiar_30;
            BLimpiarCampos.Location = new Point(334, 177);
            BLimpiarCampos.Name = "BLimpiarCampos";
            BLimpiarCampos.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BLimpiarCampos.Size = new Size(78, 45);
            BLimpiarCampos.TabIndex = 40;
            // 
            // BEliminarVenta
            // 
            BEliminarVenta.BackColor = Color.Transparent;
            BEliminarVenta.BorderColor = Color.WhiteSmoke;
            BEliminarVenta.BorderRadius = 20;
            BEliminarVenta.BorderThickness = 3;
            BEliminarVenta.CustomizableEdges = customizableEdges3;
            BEliminarVenta.DisabledState.BorderColor = Color.DarkGray;
            BEliminarVenta.DisabledState.CustomBorderColor = Color.DarkGray;
            BEliminarVenta.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BEliminarVenta.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BEliminarVenta.FillColor = SystemColors.ControlDark;
            BEliminarVenta.Font = new Font("Segoe UI", 9F);
            BEliminarVenta.ForeColor = Color.White;
            BEliminarVenta.HoverState.FillColor = SystemColors.ControlDarkDark;
            BEliminarVenta.Image = Properties.Resources.icons8_eliminar_30;
            BEliminarVenta.Location = new Point(610, 177);
            BEliminarVenta.Name = "BEliminarVenta";
            BEliminarVenta.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BEliminarVenta.Size = new Size(78, 45);
            BEliminarVenta.TabIndex = 39;
            // 
            // BModificarVenta
            // 
            BModificarVenta.BackColor = Color.Transparent;
            BModificarVenta.BorderColor = Color.WhiteSmoke;
            BModificarVenta.BorderRadius = 20;
            BModificarVenta.BorderThickness = 3;
            BModificarVenta.CustomizableEdges = customizableEdges5;
            BModificarVenta.DisabledState.BorderColor = Color.DarkGray;
            BModificarVenta.DisabledState.CustomBorderColor = Color.DarkGray;
            BModificarVenta.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BModificarVenta.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BModificarVenta.FillColor = SystemColors.ControlDark;
            BModificarVenta.Font = new Font("Segoe UI", 9F);
            BModificarVenta.ForeColor = Color.White;
            BModificarVenta.HoverState.FillColor = SystemColors.ControlDarkDark;
            BModificarVenta.Image = Properties.Resources.edicion__1_;
            BModificarVenta.Location = new Point(476, 177);
            BModificarVenta.Name = "BModificarVenta";
            BModificarVenta.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BModificarVenta.Size = new Size(78, 45);
            BModificarVenta.TabIndex = 38;
            // 
            // BConfirmarVenta
            // 
            BConfirmarVenta.BackColor = Color.Gold;
            BConfirmarVenta.BorderColor = Color.SeaGreen;
            BConfirmarVenta.BorderRadius = 20;
            BConfirmarVenta.BorderThickness = 3;
            BConfirmarVenta.CustomizableEdges = customizableEdges7;
            BConfirmarVenta.DisabledState.BorderColor = Color.DarkGray;
            BConfirmarVenta.DisabledState.CustomBorderColor = Color.DarkGray;
            BConfirmarVenta.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BConfirmarVenta.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BConfirmarVenta.FillColor = Color.Green;
            BConfirmarVenta.Font = new Font("Sitka Banner", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BConfirmarVenta.ForeColor = SystemColors.ActiveCaptionText;
            BConfirmarVenta.HoverState.FillColor = SystemColors.ControlDarkDark;
            BConfirmarVenta.Location = new Point(574, 453);
            BConfirmarVenta.Name = "BConfirmarVenta";
            BConfirmarVenta.ShadowDecoration.CustomizableEdges = customizableEdges8;
            BConfirmarVenta.Size = new Size(98, 45);
            BConfirmarVenta.TabIndex = 37;
            BConfirmarVenta.Text = "Confirmar Venta";
            // 
            // BBuscarCliente
            // 
            BBuscarCliente.BackColor = Color.Transparent;
            BBuscarCliente.BorderColor = Color.WhiteSmoke;
            BBuscarCliente.BorderRadius = 5;
            BBuscarCliente.BorderThickness = 3;
            BBuscarCliente.CustomizableEdges = customizableEdges9;
            BBuscarCliente.DisabledState.BorderColor = Color.DarkGray;
            BBuscarCliente.DisabledState.CustomBorderColor = Color.DarkGray;
            BBuscarCliente.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BBuscarCliente.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BBuscarCliente.FillColor = SystemColors.ControlDark;
            BBuscarCliente.Font = new Font("Segoe UI", 9F);
            BBuscarCliente.ForeColor = Color.White;
            BBuscarCliente.HoverState.FillColor = SystemColors.ControlDarkDark;
            BBuscarCliente.Image = Properties.Resources.icons8_buscar_301;
            BBuscarCliente.Location = new Point(350, 51);
            BBuscarCliente.Name = "BBuscarCliente";
            BBuscarCliente.ShadowDecoration.CustomizableEdges = customizableEdges10;
            BBuscarCliente.Size = new Size(35, 35);
            BBuscarCliente.TabIndex = 41;
            // 
            // bCargarProdVenta
            // 
            bCargarProdVenta.BackColor = Color.Transparent;
            bCargarProdVenta.BorderColor = Color.WhiteSmoke;
            bCargarProdVenta.BorderRadius = 20;
            bCargarProdVenta.BorderThickness = 3;
            bCargarProdVenta.CustomizableEdges = customizableEdges11;
            bCargarProdVenta.DisabledState.BorderColor = Color.DarkGray;
            bCargarProdVenta.DisabledState.CustomBorderColor = Color.DarkGray;
            bCargarProdVenta.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bCargarProdVenta.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bCargarProdVenta.FillColor = Color.DarkGray;
            bCargarProdVenta.Font = new Font("Segoe UI", 9F);
            bCargarProdVenta.ForeColor = Color.White;
            bCargarProdVenta.HoverState.FillColor = SystemColors.ControlDarkDark;
            bCargarProdVenta.Image = Properties.Resources.icons8_carrito_de_compras_30;
            bCargarProdVenta.ImageSize = new Size(25, 25);
            bCargarProdVenta.Location = new Point(202, 177);
            bCargarProdVenta.Name = "bCargarProdVenta";
            bCargarProdVenta.ShadowDecoration.CustomizableEdges = customizableEdges12;
            bCargarProdVenta.Size = new Size(78, 45);
            bCargarProdVenta.TabIndex = 42;
            // 
            // dgvRegistroVenta
            // 
            dgvRegistroVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistroVenta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvRegistroVenta.BackgroundColor = Color.Gold;
            dgvRegistroVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistroVenta.GridColor = Color.FromArgb(255, 255, 192);
            dgvRegistroVenta.Location = new Point(13, 262);
            dgvRegistroVenta.Margin = new Padding(4, 3, 4, 3);
            dgvRegistroVenta.Name = "dgvRegistroVenta";
            dgvRegistroVenta.Size = new Size(805, 248);
            dgvRegistroVenta.TabIndex = 43;
            // 
            // bCancelarVenta
            // 
            bCancelarVenta.BackColor = Color.Gold;
            bCancelarVenta.BorderColor = Color.Firebrick;
            bCancelarVenta.BorderRadius = 20;
            bCancelarVenta.BorderThickness = 3;
            bCancelarVenta.CustomizableEdges = customizableEdges13;
            bCancelarVenta.DisabledState.BorderColor = Color.DarkGray;
            bCancelarVenta.DisabledState.CustomBorderColor = Color.DarkGray;
            bCancelarVenta.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bCancelarVenta.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bCancelarVenta.FillColor = Color.Red;
            bCancelarVenta.Font = new Font("Sitka Banner", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bCancelarVenta.ForeColor = SystemColors.ActiveCaptionText;
            bCancelarVenta.HoverState.FillColor = SystemColors.ControlDarkDark;
            bCancelarVenta.Location = new Point(694, 453);
            bCancelarVenta.Name = "bCancelarVenta";
            bCancelarVenta.ShadowDecoration.CustomizableEdges = customizableEdges14;
            bCancelarVenta.Size = new Size(98, 45);
            bCancelarVenta.TabIndex = 44;
            bCancelarVenta.Text = "Cancelar Venta";
            // 
            // dgvFacturaVenta
            // 
            dgvFacturaVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFacturaVenta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvFacturaVenta.BackgroundColor = Color.Gold;
            dgvFacturaVenta.BorderStyle = BorderStyle.None;
            dgvFacturaVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturaVenta.GridColor = Color.FromArgb(255, 255, 192);
            dgvFacturaVenta.Location = new Point(15, 265);
            dgvFacturaVenta.Margin = new Padding(4, 3, 4, 3);
            dgvFacturaVenta.Name = "dgvFacturaVenta";
            dgvFacturaVenta.Size = new Size(800, 180);
            dgvFacturaVenta.TabIndex = 45;
            // 
            // dtpFechaNacCliente
            // 
            dtpFechaNacCliente.CalendarFont = new Font("Segoe UI", 12F);
            dtpFechaNacCliente.Font = new Font("Segoe UI", 12F);
            dtpFechaNacCliente.Format = DateTimePickerFormat.Short;
            dtpFechaNacCliente.Location = new Point(512, 115);
            dtpFechaNacCliente.Name = "dtpFechaNacCliente";
            dtpFechaNacCliente.Size = new Size(208, 29);
            dtpFechaNacCliente.TabIndex = 46;
            dtpFechaNacCliente.Value = new DateTime(2025, 9, 18, 17, 32, 0, 0);
            // 
            // fGestionVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 255, 192);
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(890, 522);
            Controls.Add(dtpFechaNacCliente);
            Controls.Add(dgvFacturaVenta);
            Controls.Add(bCancelarVenta);
            Controls.Add(BConfirmarVenta);
            Controls.Add(dgvRegistroVenta);
            Controls.Add(bCargarProdVenta);
            Controls.Add(BBuscarCliente);
            Controls.Add(BLimpiarCampos);
            Controls.Add(BEliminarVenta);
            Controls.Add(BModificarVenta);
            Controls.Add(tNombreClienteVenta);
            Controls.Add(LNombreClienteVenta);
            Controls.Add(textBox1);
            Controls.Add(lFechaVenta);
            Controls.Add(PBLogo);
            Controls.Add(bVolverMenu);
            Controls.Add(LGestionVentas);
            Controls.Add(LListadoVentas);
            Controls.Add(tPrecioVenta);
            Controls.Add(tCantidadVenta);
            Controls.Add(cProductoVenta);
            Controls.Add(LPrecioUnitarioVenta);
            Controls.Add(LCantidadVenta);
            Controls.Add(LProductoVenta);
            Controls.Add(LClienteDniVenta);
            Controls.Add(dgListadoVentas);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "fGestionVentas";
            Text = "Gestión de ventas";
            TransparencyKey = Color.FromArgb(255, 255, 192);
            Load += FormNuevaVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgListadoVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFacturaVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgListadoVentas;
        private Label LGestionVentas;
        private Label LClienteDniVenta;
        private Label LProductoVenta;
        private Label LCantidadVenta;
        private Label LPrecioUnitarioVenta;
        private ComboBox cProductoVenta;
        private TextBox tCantidadVenta;
        private TextBox tPrecioVenta;
        private Label LListadoVentas;
        private Button bVolverMenu;
        private Button PBLogo;
        private Label lFechaVenta;
        private TextBox textBox1;
        private Label LNombreClienteVenta;
        private TextBox tNombreClienteVenta;
        private Guna.UI2.WinForms.Guna2Button BLimpiarCampos;
        private Guna.UI2.WinForms.Guna2Button BEliminarVenta;
        private Guna.UI2.WinForms.Guna2Button BModificarVenta;
        private Guna.UI2.WinForms.Guna2Button BConfirmarVenta;
        private Guna.UI2.WinForms.Guna2Button BBuscarCliente;
        private Guna.UI2.WinForms.Guna2Button bCargarProdVenta;
        private DataGridView dgvRegistroVenta;
        private Guna.UI2.WinForms.Guna2Button bCancelarVenta;
        private DataGridView dgvFacturaVenta;
        private DateTimePicker dtpFechaNacCliente;
    }
}