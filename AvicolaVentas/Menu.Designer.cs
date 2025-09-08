namespace AvicolaVentas
{
    partial class FMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            bindingSource1 = new BindingSource(components);
            PMenu = new TableLayoutPanel();
            BVentas = new Button();
            BProductos = new Button();
            BProveedores = new Button();
            BClientes = new Button();
            BUsuario = new Button();
            LMBienvenido = new Label();
            PLogoAvicola = new Panel();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            PMenu.SuspendLayout();
            SuspendLayout();
            // 
            // PMenu
            // 
            PMenu.BackColor = Color.Beige;
            PMenu.ColumnCount = 1;
            PMenu.ColumnStyles.Add(new ColumnStyle());
            PMenu.Controls.Add(BVentas, 0, 3);
            PMenu.Controls.Add(BProductos, 0, 2);
            PMenu.Controls.Add(BProveedores, 0, 1);
            PMenu.Controls.Add(BClientes, 0, 0);
            PMenu.Controls.Add(BUsuario, 0, 4);
            PMenu.Dock = DockStyle.Left;
            PMenu.Location = new Point(0, 0);
            PMenu.Name = "PMenu";
            PMenu.RowCount = 5;
            PMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            PMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            PMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            PMenu.Size = new Size(124, 450);
            PMenu.TabIndex = 0;
            // 
            // BVentas
            // 
            BVentas.BackColor = Color.Gold;
            BVentas.Dock = DockStyle.Fill;
            BVentas.Location = new Point(3, 273);
            BVentas.Name = "BVentas";
            BVentas.Size = new Size(118, 78);
            BVentas.TabIndex = 4;
            BVentas.Text = "Venta";
            BVentas.UseVisualStyleBackColor = false;
            // 
            // BProductos
            // 
            BProductos.BackColor = Color.Gold;
            BProductos.Dock = DockStyle.Fill;
            BProductos.Location = new Point(3, 189);
            BProductos.Name = "BProductos";
            BProductos.Size = new Size(118, 78);
            BProductos.TabIndex = 3;
            BProductos.Text = "Productos";
            BProductos.UseVisualStyleBackColor = false;
            // 
            // BProveedores
            // 
            BProveedores.BackColor = Color.Gold;
            BProveedores.Dock = DockStyle.Fill;
            BProveedores.Location = new Point(3, 96);
            BProveedores.Name = "BProveedores";
            BProveedores.Size = new Size(118, 87);
            BProveedores.TabIndex = 2;
            BProveedores.Text = "Proveedores";
            BProveedores.UseVisualStyleBackColor = false;
            BProveedores.Click += BProveedores_Click;
            // 
            // BClientes
            // 
            BClientes.BackColor = Color.Gold;
            BClientes.Dock = DockStyle.Fill;
            BClientes.Location = new Point(3, 3);
            BClientes.Name = "BClientes";
            BClientes.Size = new Size(118, 87);
            BClientes.TabIndex = 1;
            BClientes.Text = "Clientes";
            BClientes.UseVisualStyleBackColor = false;
            BClientes.Click += BClientes_Click;
            // 
            // BUsuario
            // 
            BUsuario.BackColor = Color.Gold;
            BUsuario.Dock = DockStyle.Fill;
            BUsuario.Location = new Point(3, 357);
            BUsuario.Name = "BUsuario";
            BUsuario.Size = new Size(118, 90);
            BUsuario.TabIndex = 5;
            BUsuario.Text = "Usuario";
            BUsuario.UseVisualStyleBackColor = false;
            BUsuario.Click += BUsuario_Click;
            // 
            // LMBienvenido
            // 
            LMBienvenido.AutoSize = true;
            LMBienvenido.BackColor = Color.Transparent;
            LMBienvenido.Font = new Font("Constantia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LMBienvenido.ForeColor = SystemColors.ControlText;
            LMBienvenido.Location = new Point(278, 57);
            LMBienvenido.Name = "LMBienvenido";
            LMBienvenido.Size = new Size(335, 59);
            LMBienvenido.TabIndex = 1;
            LMBienvenido.Text = "BIENVENIDO";
            LMBienvenido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PLogoAvicola
            // 
            PLogoAvicola.AutoSize = true;
            PLogoAvicola.BackColor = Color.Transparent;
            PLogoAvicola.BackgroundImage = (Image)resources.GetObject("PLogoAvicola.BackgroundImage");
            PLogoAvicola.BorderStyle = BorderStyle.FixedSingle;
            PLogoAvicola.Location = new Point(334, 119);
            PLogoAvicola.Name = "PLogoAvicola";
            PLogoAvicola.Size = new Size(202, 205);
            PLogoAvicola.TabIndex = 2;
            // 
            // FMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(PLogoAvicola);
            Controls.Add(LMBienvenido);
            Controls.Add(PMenu);
            Name = "FMenu";
            Text = "Avicola Santa Ana S.A";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            PMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private TableLayoutPanel PMenu;
        private Button BUsuario;
        private Button BVentas;
        private Button BProductos;
        private Button BProveedores;
        private Button BClientes;
        private Label LMBienvenido;
        private Panel PLogoAvicola;
    }
}