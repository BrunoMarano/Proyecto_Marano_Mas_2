﻿namespace AvicolaVentas
{
    partial class fGestionProductos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGestionProductos));
            lPrecioProd = new Label();
            lStockProd = new Label();
            lCategoriaProd = new Label();
            lFechaAltaProd = new Label();
            lDescripcionProd = new Label();
            cbCategoriaProd = new ComboBox();
            tDescripcionProd = new TextBox();
            tPrecioProd = new TextBox();
            tStockProd = new TextBox();
            dtpFechaAltaProd = new DateTimePicker();
            LGestionClientes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PBLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            bVolverMenu = new Button();
            label1 = new Label();
            tStockMinimo = new TextBox();
            BLimpiarCampos = new Guna.UI2.WinForms.Guna2Button();
            BEliminarProducto = new Guna.UI2.WinForms.Guna2Button();
            BModificarProducto = new Guna.UI2.WinForms.Guna2Button();
            BGrabarProducto = new Guna.UI2.WinForms.Guna2Button();
            LListadoClientes = new Label();
            dgvListadoProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PBLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoProductos).BeginInit();
            SuspendLayout();
            // 
            // lPrecioProd
            // 
            lPrecioProd.AutoSize = true;
            lPrecioProd.BackColor = Color.Transparent;
            lPrecioProd.Font = new Font("Sitka Banner", 12F);
            lPrecioProd.Location = new Point(72, 147);
            lPrecioProd.Name = "lPrecioProd";
            lPrecioProd.Size = new Size(52, 23);
            lPrecioProd.TabIndex = 17;
            lPrecioProd.Text = "Precio:";
            // 
            // lStockProd
            // 
            lStockProd.AutoSize = true;
            lStockProd.BackColor = Color.Transparent;
            lStockProd.Font = new Font("Sitka Banner", 12F);
            lStockProd.Location = new Point(412, 107);
            lStockProd.Name = "lStockProd";
            lStockProd.Size = new Size(47, 23);
            lStockProd.TabIndex = 16;
            lStockProd.Text = "Stock:";
            // 
            // lCategoriaProd
            // 
            lCategoriaProd.AutoSize = true;
            lCategoriaProd.BackColor = Color.Transparent;
            lCategoriaProd.Font = new Font("Sitka Banner", 12F);
            lCategoriaProd.Location = new Point(72, 111);
            lCategoriaProd.Name = "lCategoriaProd";
            lCategoriaProd.Size = new Size(73, 23);
            lCategoriaProd.TabIndex = 15;
            lCategoriaProd.Text = "Categoria:";
            // 
            // lFechaAltaProd
            // 
            lFechaAltaProd.AutoSize = true;
            lFechaAltaProd.BackColor = Color.Transparent;
            lFechaAltaProd.Font = new Font("Sitka Banner", 12F);
            lFechaAltaProd.Location = new Point(412, 70);
            lFechaAltaProd.Name = "lFechaAltaProd";
            lFechaAltaProd.Size = new Size(96, 23);
            lFechaAltaProd.TabIndex = 14;
            lFechaAltaProd.Text = "Fecha de alta:";
            // 
            // lDescripcionProd
            // 
            lDescripcionProd.AutoSize = true;
            lDescripcionProd.BackColor = Color.Transparent;
            lDescripcionProd.Font = new Font("Sitka Banner", 12F);
            lDescripcionProd.Location = new Point(72, 70);
            lDescripcionProd.Name = "lDescripcionProd";
            lDescripcionProd.Size = new Size(86, 23);
            lDescripcionProd.TabIndex = 11;
            lDescripcionProd.Text = "Descripción:";
            // 
            // cbCategoriaProd
            // 
            cbCategoriaProd.Font = new Font("Sitka Banner", 12F);
            cbCategoriaProd.FormattingEnabled = true;
            cbCategoriaProd.Location = new Point(172, 101);
            cbCategoriaProd.Name = "cbCategoriaProd";
            cbCategoriaProd.Size = new Size(195, 31);
            cbCategoriaProd.TabIndex = 9;
            // 
            // tDescripcionProd
            // 
            tDescripcionProd.Font = new Font("Sitka Banner", 12F);
            tDescripcionProd.Location = new Point(172, 67);
            tDescripcionProd.Name = "tDescripcionProd";
            tDescripcionProd.Size = new Size(195, 28);
            tDescripcionProd.TabIndex = 10;
            tDescripcionProd.TextChanged += tDescripcionProd_TextChanged;
            // 
            // tPrecioProd
            // 
            tPrecioProd.Font = new Font("Sitka Banner", 12F);
            tPrecioProd.Location = new Point(172, 142);
            tPrecioProd.Name = "tPrecioProd";
            tPrecioProd.Size = new Size(195, 28);
            tPrecioProd.TabIndex = 6;
            // 
            // tStockProd
            // 
            tStockProd.Font = new Font("Sitka Banner", 12F);
            tStockProd.Location = new Point(521, 104);
            tStockProd.Name = "tStockProd";
            tStockProd.Size = new Size(195, 28);
            tStockProd.TabIndex = 5;
            // 
            // dtpFechaAltaProd
            // 
            dtpFechaAltaProd.CalendarFont = new Font("Segoe UI", 12F);
            dtpFechaAltaProd.DropDownAlign = LeftRightAlignment.Right;
            dtpFechaAltaProd.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaAltaProd.Format = DateTimePickerFormat.Short;
            dtpFechaAltaProd.Location = new Point(521, 64);
            dtpFechaAltaProd.Name = "dtpFechaAltaProd";
            dtpFechaAltaProd.Size = new Size(195, 28);
            dtpFechaAltaProd.TabIndex = 4;
            dtpFechaAltaProd.ValueChanged += dtpFechaAltaProd_ValueChanged;
            // 
            // LGestionClientes
            // 
            LGestionClientes.AutoSize = false;
            LGestionClientes.BackColor = Color.Gold;
            LGestionClientes.BackgroundImageLayout = ImageLayout.Center;
            LGestionClientes.Dock = DockStyle.Top;
            LGestionClientes.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold);
            LGestionClientes.Location = new Point(0, 0);
            LGestionClientes.Name = "LGestionClientes";
            LGestionClientes.Size = new Size(894, 50);
            LGestionClientes.TabIndex = 29;
            LGestionClientes.Text = "Gestión de Productos";
            LGestionClientes.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // PBLogo
            // 
            PBLogo.BackColor = Color.Gold;
            PBLogo.BackgroundImageLayout = ImageLayout.Stretch;
            PBLogo.CustomizableEdges = customizableEdges1;
            PBLogo.Image = Properties.Resources.logoAvicola;
            PBLogo.ImageRotate = 0F;
            PBLogo.Location = new Point(0, 0);
            PBLogo.Name = "PBLogo";
            PBLogo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PBLogo.Size = new Size(73, 50);
            PBLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            PBLogo.TabIndex = 30;
            PBLogo.TabStop = false;
            // 
            // bVolverMenu
            // 
            bVolverMenu.BackColor = Color.Gold;
            bVolverMenu.BackgroundImage = Properties.Resources.icons8_volver_67;
            bVolverMenu.BackgroundImageLayout = ImageLayout.Stretch;
            bVolverMenu.FlatAppearance.BorderColor = Color.Gold;
            bVolverMenu.FlatStyle = FlatStyle.Flat;
            bVolverMenu.Location = new Point(847, 12);
            bVolverMenu.Name = "bVolverMenu";
            bVolverMenu.Size = new Size(35, 28);
            bVolverMenu.TabIndex = 31;
            bVolverMenu.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Banner", 12F);
            label1.Location = new Point(412, 147);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 32;
            label1.Text = "Stock minimo:";
            // 
            // tStockMinimo
            // 
            tStockMinimo.Font = new Font("Sitka Banner", 12F);
            tStockMinimo.Location = new Point(521, 142);
            tStockMinimo.Name = "tStockMinimo";
            tStockMinimo.Size = new Size(195, 28);
            tStockMinimo.TabIndex = 33;
            // 
            // BLimpiarCampos
            // 
            BLimpiarCampos.BackColor = Color.Transparent;
            BLimpiarCampos.BorderColor = Color.WhiteSmoke;
            BLimpiarCampos.BorderRadius = 20;
            BLimpiarCampos.BorderThickness = 3;
            BLimpiarCampos.CustomizableEdges = customizableEdges3;
            BLimpiarCampos.DisabledState.BorderColor = Color.DarkGray;
            BLimpiarCampos.DisabledState.CustomBorderColor = Color.DarkGray;
            BLimpiarCampos.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BLimpiarCampos.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BLimpiarCampos.FillColor = SystemColors.ControlDark;
            BLimpiarCampos.Font = new Font("Segoe UI", 9F);
            BLimpiarCampos.ForeColor = Color.White;
            BLimpiarCampos.HoverState.FillColor = SystemColors.ControlDarkDark;
            BLimpiarCampos.Image = Properties.Resources.icons8_limpiar_30;
            BLimpiarCampos.Location = new Point(328, 194);
            BLimpiarCampos.Name = "BLimpiarCampos";
            BLimpiarCampos.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BLimpiarCampos.Size = new Size(78, 45);
            BLimpiarCampos.TabIndex = 40;
            // 
            // BEliminarProducto
            // 
            BEliminarProducto.BackColor = Color.Transparent;
            BEliminarProducto.BorderColor = Color.WhiteSmoke;
            BEliminarProducto.BorderRadius = 20;
            BEliminarProducto.BorderThickness = 3;
            BEliminarProducto.CustomizableEdges = customizableEdges5;
            BEliminarProducto.DisabledState.BorderColor = Color.DarkGray;
            BEliminarProducto.DisabledState.CustomBorderColor = Color.DarkGray;
            BEliminarProducto.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BEliminarProducto.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BEliminarProducto.FillColor = SystemColors.ControlDark;
            BEliminarProducto.Font = new Font("Segoe UI", 9F);
            BEliminarProducto.ForeColor = Color.White;
            BEliminarProducto.HoverState.FillColor = SystemColors.ControlDarkDark;
            BEliminarProducto.Image = Properties.Resources.icons8_eliminar_30;
            BEliminarProducto.Location = new Point(604, 194);
            BEliminarProducto.Name = "BEliminarProducto";
            BEliminarProducto.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BEliminarProducto.Size = new Size(78, 45);
            BEliminarProducto.TabIndex = 39;
            // 
            // BModificarProducto
            // 
            BModificarProducto.BackColor = Color.Transparent;
            BModificarProducto.BorderColor = Color.WhiteSmoke;
            BModificarProducto.BorderRadius = 20;
            BModificarProducto.BorderThickness = 3;
            BModificarProducto.CustomizableEdges = customizableEdges7;
            BModificarProducto.DisabledState.BorderColor = Color.DarkGray;
            BModificarProducto.DisabledState.CustomBorderColor = Color.DarkGray;
            BModificarProducto.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BModificarProducto.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BModificarProducto.FillColor = SystemColors.ControlDark;
            BModificarProducto.Font = new Font("Segoe UI", 9F);
            BModificarProducto.ForeColor = Color.White;
            BModificarProducto.HoverState.FillColor = SystemColors.ControlDarkDark;
            BModificarProducto.Image = Properties.Resources.edicion__1_;
            BModificarProducto.Location = new Point(470, 194);
            BModificarProducto.Name = "BModificarProducto";
            BModificarProducto.ShadowDecoration.CustomizableEdges = customizableEdges8;
            BModificarProducto.Size = new Size(78, 45);
            BModificarProducto.TabIndex = 38;
            // 
            // BGrabarProducto
            // 
            BGrabarProducto.BackColor = Color.Transparent;
            BGrabarProducto.BorderColor = Color.WhiteSmoke;
            BGrabarProducto.BorderRadius = 20;
            BGrabarProducto.BorderThickness = 3;
            BGrabarProducto.CustomizableEdges = customizableEdges9;
            BGrabarProducto.DisabledState.BorderColor = Color.DarkGray;
            BGrabarProducto.DisabledState.CustomBorderColor = Color.DarkGray;
            BGrabarProducto.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BGrabarProducto.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BGrabarProducto.FillColor = SystemColors.ControlDark;
            BGrabarProducto.Font = new Font("Segoe UI", 9F);
            BGrabarProducto.ForeColor = Color.White;
            BGrabarProducto.HoverState.FillColor = SystemColors.ControlDarkDark;
            BGrabarProducto.Image = Properties.Resources.guardar_el_archivo;
            BGrabarProducto.Location = new Point(195, 194);
            BGrabarProducto.Name = "BGrabarProducto";
            BGrabarProducto.ShadowDecoration.CustomizableEdges = customizableEdges10;
            BGrabarProducto.Size = new Size(78, 45);
            BGrabarProducto.TabIndex = 37;
            // 
            // LListadoClientes
            // 
            LListadoClientes.BackColor = Color.Gold;
            LListadoClientes.FlatStyle = FlatStyle.Flat;
            LListadoClientes.Font = new Font("Sitka Banner", 15F, FontStyle.Bold);
            LListadoClientes.Location = new Point(0, 246);
            LListadoClientes.Name = "LListadoClientes";
            LListadoClientes.Size = new Size(894, 34);
            LListadoClientes.TabIndex = 41;
            LListadoClientes.Text = "Listado de Productos";
            LListadoClientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvListadoProductos
            // 
            dgvListadoProductos.AllowUserToAddRows = false;
            dgvListadoProductos.BackgroundColor = Color.Gold;
            dgvListadoProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoProductos.GridColor = Color.DimGray;
            dgvListadoProductos.Location = new Point(33, 283);
            dgvListadoProductos.Name = "dgvListadoProductos";
            dgvListadoProductos.Size = new Size(818, 243);
            dgvListadoProductos.TabIndex = 42;
            // 
            // fGestionProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(894, 526);
            Controls.Add(dgvListadoProductos);
            Controls.Add(LListadoClientes);
            Controls.Add(BLimpiarCampos);
            Controls.Add(BEliminarProducto);
            Controls.Add(BModificarProducto);
            Controls.Add(BGrabarProducto);
            Controls.Add(tStockMinimo);
            Controls.Add(label1);
            Controls.Add(bVolverMenu);
            Controls.Add(PBLogo);
            Controls.Add(LGestionClientes);
            Controls.Add(dtpFechaAltaProd);
            Controls.Add(tStockProd);
            Controls.Add(tPrecioProd);
            Controls.Add(tDescripcionProd);
            Controls.Add(cbCategoriaProd);
            Controls.Add(lDescripcionProd);
            Controls.Add(lFechaAltaProd);
            Controls.Add(lCategoriaProd);
            Controls.Add(lStockProd);
            Controls.Add(lPrecioProd);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fGestionProductos";
            Text = "Alta de Producto";
            Load += AltaProductos_Load;
            ((System.ComponentModel.ISupportInitialize)PBLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private void AltaProductos_Load(object sender, EventArgs e)
        {
            // Inicializaciones al cargar el formulario
        }

        #endregion
        private Label lPrecioProd;
        private Label lStockProd;
        private Label lCategoriaProd;
        private Label lFechaAltaProd;
        private Label lDescripcionProd;
        private ComboBox cbCategoriaProd;
        private TextBox tDescripcionProd;
        private TextBox tPrecioProd;
        private TextBox tStockProd;
        private DateTimePicker dtpFechaAltaProd;
        private Guna.UI2.WinForms.Guna2HtmlLabel LGestionClientes;
        private Guna.UI2.WinForms.Guna2PictureBox PBLogo;
        private Button bVolverMenu;
        private Label label1;
        private TextBox tStockMinimo;
        private Guna.UI2.WinForms.Guna2Button BLimpiarCampos;
        private Guna.UI2.WinForms.Guna2Button BEliminarProducto;
        private Guna.UI2.WinForms.Guna2Button BModificarProducto;
        private Guna.UI2.WinForms.Guna2Button BGrabarProducto;
        private Label LListadoClientes;
        private DataGridView dgvListadoProductos;
    }
}
