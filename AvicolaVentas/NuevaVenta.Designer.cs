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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGestionVentas));
            dgListadoVentas = new DataGridView();
            id_venta = new DataGridViewTextBoxColumn();
            id_cliente = new DataGridViewTextBoxColumn();
            id_producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            total_venta = new DataGridViewTextBoxColumn();
            id_usuario = new DataGridViewTextBoxColumn();
            LGestionVentas = new Label();
            LClienteVenta = new Label();
            LProductoVenta = new Label();
            LCantidadVenta = new Label();
            LPrecioUnitarioVenta = new Label();
            BCargarVenta = new Button();
            BLimpiarCampos = new Button();
            cProductoVenta = new ComboBox();
            tCantidadVenta = new TextBox();
            tPrecioVenta = new TextBox();
            bEditarVenta = new Button();
            bEliminarVenta = new Button();
            LListadoVentas = new Label();
            cClienteVenta = new ComboBox();
            bVolverMenu = new Button();
            PBLogo = new Button();
            lTotalVenta = new Label();
            tTotalVenta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgListadoVentas).BeginInit();
            SuspendLayout();
            // 
            // dgListadoVentas
            // 
            dgListadoVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgListadoVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgListadoVentas.BackgroundColor = Color.Gold;
            dgListadoVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListadoVentas.Columns.AddRange(new DataGridViewColumn[] { id_venta, id_cliente, id_producto, Cantidad, precio, total_venta, id_usuario });
            dgListadoVentas.GridColor = Color.FromArgb(255, 255, 192);
            dgListadoVentas.Location = new Point(30, 262);
            dgListadoVentas.Margin = new Padding(4, 3, 4, 3);
            dgListadoVentas.Name = "dgListadoVentas";
            dgListadoVentas.Size = new Size(805, 248);
            dgListadoVentas.TabIndex = 0;
            dgListadoVentas.CellContentClick += dgListadoVentas_CellContentClick;
            // 
            // id_venta
            // 
            id_venta.HeaderText = "Nro de Venta";
            id_venta.Name = "id_venta";
            // 
            // id_cliente
            // 
            id_cliente.HeaderText = "Cliente";
            id_cliente.Name = "id_cliente";
            id_cliente.ReadOnly = true;
            // 
            // id_producto
            // 
            id_producto.HeaderText = "Producto";
            id_producto.Name = "id_producto";
            id_producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // precio
            // 
            precio.HeaderText = "Precio Unitario";
            precio.Name = "precio";
            precio.ReadOnly = true;
            // 
            // total_venta
            // 
            total_venta.HeaderText = "Total";
            total_venta.Name = "total_venta";
            total_venta.ReadOnly = true;
            // 
            // id_usuario
            // 
            id_usuario.HeaderText = "Vendedor";
            id_usuario.Name = "id_usuario";
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
            // LClienteVenta
            // 
            LClienteVenta.AutoSize = true;
            LClienteVenta.BackColor = Color.Transparent;
            LClienteVenta.Font = new Font("Sitka Banner", 12F);
            LClienteVenta.Location = new Point(41, 84);
            LClienteVenta.Margin = new Padding(4, 0, 4, 0);
            LClienteVenta.Name = "LClienteVenta";
            LClienteVenta.Size = new Size(58, 23);
            LClienteVenta.TabIndex = 6;
            LClienteVenta.Text = "Cliente:";
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
            LCantidadVenta.Location = new Point(437, 80);
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
            LPrecioUnitarioVenta.Location = new Point(437, 115);
            LPrecioUnitarioVenta.Margin = new Padding(4, 0, 4, 0);
            LPrecioUnitarioVenta.Name = "LPrecioUnitarioVenta";
            LPrecioUnitarioVenta.Size = new Size(52, 23);
            LPrecioUnitarioVenta.TabIndex = 9;
            LPrecioUnitarioVenta.Text = "Precio:";
            // 
            // BCargarVenta
            // 
            BCargarVenta.BackColor = Color.Silver;
            BCargarVenta.BackgroundImageLayout = ImageLayout.None;
            BCargarVenta.ForeColor = Color.Black;
            BCargarVenta.Location = new Point(135, 182);
            BCargarVenta.Margin = new Padding(4, 3, 4, 3);
            BCargarVenta.Name = "BCargarVenta";
            BCargarVenta.Size = new Size(110, 34);
            BCargarVenta.TabIndex = 11;
            BCargarVenta.Text = "Cargar venta";
            BCargarVenta.UseVisualStyleBackColor = false;
            BCargarVenta.Click += BCargarVenta_Click;
            // 
            // BLimpiarCampos
            // 
            BLimpiarCampos.BackColor = Color.Silver;
            BLimpiarCampos.Location = new Point(285, 182);
            BLimpiarCampos.Margin = new Padding(4, 3, 4, 3);
            BLimpiarCampos.Name = "BLimpiarCampos";
            BLimpiarCampos.Size = new Size(111, 34);
            BLimpiarCampos.TabIndex = 12;
            BLimpiarCampos.Text = "Limpiar campos";
            BLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // cProductoVenta
            // 
            cProductoVenta.BackColor = Color.FromArgb(255, 255, 192);
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
            tCantidadVenta.BackColor = Color.FromArgb(255, 255, 192);
            tCantidadVenta.Location = new Point(512, 81);
            tCantidadVenta.Margin = new Padding(4, 3, 4, 3);
            tCantidadVenta.Name = "tCantidadVenta";
            tCantidadVenta.Size = new Size(208, 23);
            tCantidadVenta.TabIndex = 15;
            // 
            // tPrecioVenta
            // 
            tPrecioVenta.BackColor = Color.FromArgb(255, 255, 192);
            tPrecioVenta.Location = new Point(512, 115);
            tPrecioVenta.Margin = new Padding(4, 3, 4, 3);
            tPrecioVenta.Name = "tPrecioVenta";
            tPrecioVenta.Size = new Size(208, 23);
            tPrecioVenta.TabIndex = 17;
            // 
            // bEditarVenta
            // 
            bEditarVenta.BackColor = Color.Silver;
            bEditarVenta.Location = new Point(437, 179);
            bEditarVenta.Margin = new Padding(4, 3, 4, 3);
            bEditarVenta.Name = "bEditarVenta";
            bEditarVenta.Size = new Size(111, 37);
            bEditarVenta.TabIndex = 19;
            bEditarVenta.Text = "Editar";
            bEditarVenta.UseVisualStyleBackColor = false;
            // 
            // bEliminarVenta
            // 
            bEliminarVenta.BackColor = Color.Silver;
            bEliminarVenta.FlatAppearance.BorderColor = Color.Silver;
            bEliminarVenta.FlatAppearance.BorderSize = 0;
            bEliminarVenta.Location = new Point(578, 179);
            bEliminarVenta.Margin = new Padding(4, 3, 4, 3);
            bEliminarVenta.Name = "bEliminarVenta";
            bEliminarVenta.Size = new Size(114, 37);
            bEliminarVenta.TabIndex = 20;
            bEliminarVenta.Text = "Eliminar";
            bEliminarVenta.UseVisualStyleBackColor = false;
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
            // cClienteVenta
            // 
            cClienteVenta.BackColor = Color.Gold;
            cClienteVenta.FormattingEnabled = true;
            cClienteVenta.Location = new Point(135, 81);
            cClienteVenta.Margin = new Padding(4, 3, 4, 3);
            cClienteVenta.Name = "cClienteVenta";
            cClienteVenta.Size = new Size(208, 23);
            cClienteVenta.TabIndex = 21;
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
            // lTotalVenta
            // 
            lTotalVenta.AutoSize = true;
            lTotalVenta.BackColor = Color.Transparent;
            lTotalVenta.Font = new Font("Sitka Banner", 12F);
            lTotalVenta.Location = new Point(437, 144);
            lTotalVenta.Margin = new Padding(4, 0, 4, 0);
            lTotalVenta.Name = "lTotalVenta";
            lTotalVenta.Size = new Size(45, 23);
            lTotalVenta.TabIndex = 25;
            lTotalVenta.Text = "Total:";
            // 
            // tTotalVenta
            // 
            tTotalVenta.BackColor = Color.FromArgb(255, 255, 192);
            tTotalVenta.Location = new Point(512, 146);
            tTotalVenta.Margin = new Padding(4, 3, 4, 3);
            tTotalVenta.Name = "tTotalVenta";
            tTotalVenta.Size = new Size(208, 23);
            tTotalVenta.TabIndex = 26;
            tTotalVenta.TextChanged += tTotalVenta_TextChanged;
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
            Controls.Add(tTotalVenta);
            Controls.Add(lTotalVenta);
            Controls.Add(PBLogo);
            Controls.Add(bVolverMenu);
            Controls.Add(cClienteVenta);
            Controls.Add(LGestionVentas);
            Controls.Add(LListadoVentas);
            Controls.Add(bEliminarVenta);
            Controls.Add(bEditarVenta);
            Controls.Add(tPrecioVenta);
            Controls.Add(tCantidadVenta);
            Controls.Add(cProductoVenta);
            Controls.Add(BLimpiarCampos);
            Controls.Add(BCargarVenta);
            Controls.Add(LPrecioUnitarioVenta);
            Controls.Add(LCantidadVenta);
            Controls.Add(LProductoVenta);
            Controls.Add(LClienteVenta);
            Controls.Add(dgListadoVentas);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "fGestionVentas";
            Text = "Gestión de ventas";
            TransparencyKey = Color.FromArgb(255, 255, 192);
            Load += FormNuevaVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgListadoVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgListadoVentas;
        private Button buttonAgregarArticuloVenta;
        private Button buttonEliminarArticuloVenta;
        private Label LGestionVentas;
        private Label LClienteVenta;
        private Label LProductoVenta;
        private Label LCantidadVenta;
        private Label LPrecioUnitarioVenta;
        private Button BCargarVenta;
        private Button BLimpiarCampos;
        private ComboBox cProductoVenta;
        private TextBox tCantidadVenta;
        private TextBox tPrecioVenta;
        private Button bEditarVenta;
        private Button bEliminarVenta;
        private Label LListadoVentas;
        private ComboBox cClienteVenta;
        private Button bVolverMenu;
        private Button PBLogo;
        private DataGridViewTextBoxColumn id_venta;
        private DataGridViewTextBoxColumn id_cliente;
        private DataGridViewTextBoxColumn id_producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn total_venta;
        private DataGridViewTextBoxColumn id_usuario;
        private Label lTotalVenta;
        private TextBox tTotalVenta;
    }
}