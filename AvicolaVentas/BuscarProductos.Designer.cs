namespace AvicolaVentas
{
    partial class fBuscarProductos
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
            LGestionClientes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PBLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            bVolverMenu = new Button();
            dgvListadoProductos = new DataGridView();
            lDescripcionProd = new Label();
            cbDescripcionProd = new ComboBox();
            cbCategoriaProd = new ComboBox();
            lCategoriaProd = new Label();
            BGrabarProducto = new Guna.UI2.WinForms.Guna2Button();
            lGrillaProductos = new Label();
            ((System.ComponentModel.ISupportInitialize)PBLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoProductos).BeginInit();
            SuspendLayout();
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
            LGestionClientes.Size = new Size(878, 50);
            LGestionClientes.TabIndex = 36;
            LGestionClientes.Text = "Listado de Productos";
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
            PBLogo.TabIndex = 37;
            PBLogo.TabStop = false;
            // 
            // bVolverMenu
            // 
            bVolverMenu.BackColor = Color.Gold;
            bVolverMenu.BackgroundImage = Properties.Resources.icons8_volver_67;
            bVolverMenu.BackgroundImageLayout = ImageLayout.Stretch;
            bVolverMenu.FlatAppearance.BorderColor = Color.Gold;
            bVolverMenu.FlatStyle = FlatStyle.Flat;
            bVolverMenu.Location = new Point(831, 12);
            bVolverMenu.Name = "bVolverMenu";
            bVolverMenu.Size = new Size(35, 28);
            bVolverMenu.TabIndex = 38;
            bVolverMenu.UseVisualStyleBackColor = false;
            // 
            // dgvListadoProductos
            // 
            dgvListadoProductos.AllowUserToAddRows = false;
            dgvListadoProductos.BackgroundColor = Color.Gold;
            dgvListadoProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoProductos.GridColor = Color.DimGray;
            dgvListadoProductos.Location = new Point(27, 253);
            dgvListadoProductos.Name = "dgvListadoProductos";
            dgvListadoProductos.Size = new Size(818, 236);
            dgvListadoProductos.TabIndex = 43;
            // 
            // lDescripcionProd
            // 
            lDescripcionProd.AutoSize = true;
            lDescripcionProd.BackColor = Color.Transparent;
            lDescripcionProd.Font = new Font("Sitka Banner", 12F);
            lDescripcionProd.Location = new Point(42, 76);
            lDescripcionProd.Name = "lDescripcionProd";
            lDescripcionProd.Size = new Size(86, 23);
            lDescripcionProd.TabIndex = 44;
            lDescripcionProd.Text = "Descripcion:";
            // 
            // cbDescripcionProd
            // 
            cbDescripcionProd.Font = new Font("Sitka Banner", 12F);
            cbDescripcionProd.FormattingEnabled = true;
            cbDescripcionProd.Location = new Point(134, 70);
            cbDescripcionProd.Name = "cbDescripcionProd";
            cbDescripcionProd.Size = new Size(195, 31);
            cbDescripcionProd.TabIndex = 45;
            // 
            // cbCategoriaProd
            // 
            cbCategoriaProd.Font = new Font("Sitka Banner", 12F);
            cbCategoriaProd.FormattingEnabled = true;
            cbCategoriaProd.Location = new Point(134, 111);
            cbCategoriaProd.Name = "cbCategoriaProd";
            cbCategoriaProd.Size = new Size(195, 31);
            cbCategoriaProd.TabIndex = 46;
            // 
            // lCategoriaProd
            // 
            lCategoriaProd.AutoSize = true;
            lCategoriaProd.BackColor = Color.Transparent;
            lCategoriaProd.Font = new Font("Sitka Banner", 12F);
            lCategoriaProd.Location = new Point(42, 115);
            lCategoriaProd.Name = "lCategoriaProd";
            lCategoriaProd.Size = new Size(73, 23);
            lCategoriaProd.TabIndex = 47;
            lCategoriaProd.Text = "Categoria:";
            // 
            // BGrabarProducto
            // 
            BGrabarProducto.BackColor = Color.Transparent;
            BGrabarProducto.BorderColor = Color.WhiteSmoke;
            BGrabarProducto.BorderRadius = 20;
            BGrabarProducto.BorderThickness = 3;
            BGrabarProducto.CustomizableEdges = customizableEdges3;
            BGrabarProducto.DisabledState.BorderColor = Color.DarkGray;
            BGrabarProducto.DisabledState.CustomBorderColor = Color.DarkGray;
            BGrabarProducto.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BGrabarProducto.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BGrabarProducto.FillColor = SystemColors.ControlDark;
            BGrabarProducto.Font = new Font("Segoe UI", 9F);
            BGrabarProducto.ForeColor = Color.White;
            BGrabarProducto.HoverState.FillColor = SystemColors.ControlDarkDark;
            BGrabarProducto.Image = Properties.Resources.icons8_buscar_301;
            BGrabarProducto.ImageSize = new Size(30, 30);
            BGrabarProducto.Location = new Point(251, 158);
            BGrabarProducto.Name = "BGrabarProducto";
            BGrabarProducto.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BGrabarProducto.Size = new Size(78, 45);
            BGrabarProducto.TabIndex = 50;
            // 
            // lGrillaProductos
            // 
            lGrillaProductos.BackColor = Color.Gold;
            lGrillaProductos.FlatStyle = FlatStyle.Flat;
            lGrillaProductos.Font = new Font("Sitka Banner", 15F, FontStyle.Bold);
            lGrillaProductos.Location = new Point(-8, 216);
            lGrillaProductos.Name = "lGrillaProductos";
            lGrillaProductos.Size = new Size(894, 34);
            lGrillaProductos.TabIndex = 51;
            lGrillaProductos.Text = "Grilla de productos";
            lGrillaProductos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fBuscarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(878, 487);
            Controls.Add(lGrillaProductos);
            Controls.Add(BGrabarProducto);
            Controls.Add(cbCategoriaProd);
            Controls.Add(lCategoriaProd);
            Controls.Add(cbDescripcionProd);
            Controls.Add(lDescripcionProd);
            Controls.Add(bVolverMenu);
            Controls.Add(PBLogo);
            Controls.Add(LGestionClientes);
            Controls.Add(dgvListadoProductos);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "fBuscarProductos";
            Text = "Buscar productos";
            ((System.ComponentModel.ISupportInitialize)PBLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel LGestionClientes;
        private Guna.UI2.WinForms.Guna2PictureBox PBLogo;
        private Button bVolverMenu;
        private DataGridView dgvListadoProductos;
        private Label lDescripcionProd;
        private ComboBox cbDescripcionProd;
        private ComboBox cbCategoriaProd;
        private Label lCategoriaProd;
        private Guna.UI2.WinForms.Guna2Button BGrabarProducto;
        private Label lGrillaProductos;
    }
}