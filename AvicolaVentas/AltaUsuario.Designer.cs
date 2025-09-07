namespace AvicolaVentas
{
    partial class FAltaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAltaUsuario));
            PMenu = new TableLayoutPanel();
            BVentas = new Button();
            BProductos = new Button();
            BProveedores = new Button();
            BClientes = new Button();
            BUsuario = new Button();
            LNombreUsuario = new Label();
            TBNombreUsuario = new TextBox();
            TBApellidoUsuario = new TextBox();
            LApellidoUsuarioo = new Label();
            TBDniUsuario = new TextBox();
            LDniUsuario = new Label();
            TBCorreoUsuario = new TextBox();
            LCorreoUsuario = new Label();
            TBDirrecionUsuariuo = new TextBox();
            LDirrecionUsuario = new Label();
            label1 = new Label();
            TBTelefonoUsuario = new TextBox();
            LTelefonoUsuario = new Label();
            RBHombreUsuario = new RadioButton();
            RBMujerUsuario = new RadioButton();
            LFechaNacimientoUusario = new Label();
            DTPFechaNacimientoUsuario = new DateTimePicker();
            PImaagenUsuario = new Panel();
            PBImagenUsuario = new PictureBox();
            BAltaUsuario = new Button();
            BLimpiarAltaUsuario = new Button();
            PMenu.SuspendLayout();
            PImaagenUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBImagenUsuario).BeginInit();
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
            PMenu.TabIndex = 3;
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
            // 
            // LNombreUsuario
            // 
            LNombreUsuario.AutoSize = true;
            LNombreUsuario.BackColor = Color.Transparent;
            LNombreUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNombreUsuario.Location = new Point(147, 60);
            LNombreUsuario.Name = "LNombreUsuario";
            LNombreUsuario.Size = new Size(89, 30);
            LNombreUsuario.TabIndex = 4;
            LNombreUsuario.Text = "Nombre";
            LNombreUsuario.Click += label1_Click;
            // 
            // TBNombreUsuario
            // 
            TBNombreUsuario.Location = new Point(242, 69);
            TBNombreUsuario.Name = "TBNombreUsuario";
            TBNombreUsuario.Size = new Size(203, 23);
            TBNombreUsuario.TabIndex = 5;
            // 
            // TBApellidoUsuario
            // 
            TBApellidoUsuario.Location = new Point(242, 129);
            TBApellidoUsuario.Name = "TBApellidoUsuario";
            TBApellidoUsuario.Size = new Size(203, 23);
            TBApellidoUsuario.TabIndex = 7;
            // 
            // LApellidoUsuarioo
            // 
            LApellidoUsuarioo.AutoSize = true;
            LApellidoUsuarioo.BackColor = Color.Transparent;
            LApellidoUsuarioo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LApellidoUsuarioo.Location = new Point(147, 122);
            LApellidoUsuarioo.Name = "LApellidoUsuarioo";
            LApellidoUsuarioo.Size = new Size(89, 30);
            LApellidoUsuarioo.TabIndex = 6;
            LApellidoUsuarioo.Text = "Apellido";
            // 
            // TBDniUsuario
            // 
            TBDniUsuario.Location = new Point(242, 189);
            TBDniUsuario.Name = "TBDniUsuario";
            TBDniUsuario.Size = new Size(203, 23);
            TBDniUsuario.TabIndex = 9;
            TBDniUsuario.Text = "(Opcional)";
            // 
            // LDniUsuario
            // 
            LDniUsuario.AutoSize = true;
            LDniUsuario.BackColor = Color.Transparent;
            LDniUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LDniUsuario.Location = new Point(147, 187);
            LDniUsuario.Name = "LDniUsuario";
            LDniUsuario.Size = new Size(50, 30);
            LDniUsuario.TabIndex = 8;
            LDniUsuario.Text = "DNI";
            // 
            // TBCorreoUsuario
            // 
            TBCorreoUsuario.Location = new Point(242, 254);
            TBCorreoUsuario.Name = "TBCorreoUsuario";
            TBCorreoUsuario.Size = new Size(203, 23);
            TBCorreoUsuario.TabIndex = 11;
            TBCorreoUsuario.TextChanged += textBox2_TextChanged;
            // 
            // LCorreoUsuario
            // 
            LCorreoUsuario.AutoSize = true;
            LCorreoUsuario.BackColor = Color.Transparent;
            LCorreoUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LCorreoUsuario.Location = new Point(147, 247);
            LCorreoUsuario.Name = "LCorreoUsuario";
            LCorreoUsuario.Size = new Size(63, 30);
            LCorreoUsuario.TabIndex = 10;
            LCorreoUsuario.Text = "Email";
            // 
            // TBDirrecionUsuariuo
            // 
            TBDirrecionUsuariuo.Location = new Point(242, 321);
            TBDirrecionUsuariuo.Name = "TBDirrecionUsuariuo";
            TBDirrecionUsuariuo.Size = new Size(203, 23);
            TBDirrecionUsuariuo.TabIndex = 13;
            // 
            // LDirrecionUsuario
            // 
            LDirrecionUsuario.AutoSize = true;
            LDirrecionUsuario.BackColor = Color.Transparent;
            LDirrecionUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LDirrecionUsuario.Location = new Point(147, 314);
            LDirrecionUsuario.Name = "LDirrecionUsuario";
            LDirrecionUsuario.Size = new Size(100, 30);
            LDirrecionUsuario.TabIndex = 12;
            LDirrecionUsuario.Text = "Dirección";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(477, 196);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 14;
            // 
            // TBTelefonoUsuario
            // 
            TBTelefonoUsuario.Location = new Point(242, 388);
            TBTelefonoUsuario.Name = "TBTelefonoUsuario";
            TBTelefonoUsuario.Size = new Size(203, 23);
            TBTelefonoUsuario.TabIndex = 16;
            // 
            // LTelefonoUsuario
            // 
            LTelefonoUsuario.AutoSize = true;
            LTelefonoUsuario.BackColor = Color.Transparent;
            LTelefonoUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LTelefonoUsuario.Location = new Point(147, 381);
            LTelefonoUsuario.Name = "LTelefonoUsuario";
            LTelefonoUsuario.Size = new Size(92, 30);
            LTelefonoUsuario.TabIndex = 15;
            LTelefonoUsuario.Text = "Telefono";
            // 
            // RBHombreUsuario
            // 
            RBHombreUsuario.AutoSize = true;
            RBHombreUsuario.BackColor = Color.Transparent;
            RBHombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBHombreUsuario.Location = new Point(523, 214);
            RBHombreUsuario.Name = "RBHombreUsuario";
            RBHombreUsuario.Size = new Size(85, 25);
            RBHombreUsuario.TabIndex = 17;
            RBHombreUsuario.TabStop = true;
            RBHombreUsuario.Text = "Hombre";
            RBHombreUsuario.UseVisualStyleBackColor = false;
            // 
            // RBMujerUsuario
            // 
            RBMujerUsuario.AutoSize = true;
            RBMujerUsuario.BackColor = Color.Transparent;
            RBMujerUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBMujerUsuario.Location = new Point(670, 214);
            RBMujerUsuario.Name = "RBMujerUsuario";
            RBMujerUsuario.Size = new Size(69, 25);
            RBMujerUsuario.TabIndex = 18;
            RBMujerUsuario.TabStop = true;
            RBMujerUsuario.Text = "Mujer";
            RBMujerUsuario.UseVisualStyleBackColor = false;
            // 
            // LFechaNacimientoUusario
            // 
            LFechaNacimientoUusario.AutoSize = true;
            LFechaNacimientoUusario.BackColor = Color.Transparent;
            LFechaNacimientoUusario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LFechaNacimientoUusario.Location = new Point(523, 263);
            LFechaNacimientoUusario.Name = "LFechaNacimientoUusario";
            LFechaNacimientoUusario.Size = new Size(209, 30);
            LFechaNacimientoUusario.TabIndex = 19;
            LFechaNacimientoUusario.Text = "Fecha de Nacimiento";
            // 
            // DTPFechaNacimientoUsuario
            // 
            DTPFechaNacimientoUsuario.CalendarFont = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTPFechaNacimientoUsuario.Location = new Point(529, 325);
            DTPFechaNacimientoUsuario.Name = "DTPFechaNacimientoUsuario";
            DTPFechaNacimientoUsuario.Size = new Size(200, 23);
            DTPFechaNacimientoUsuario.TabIndex = 20;
            // 
            // PImaagenUsuario
            // 
            PImaagenUsuario.Controls.Add(PBImagenUsuario);
            PImaagenUsuario.Location = new Point(523, 54);
            PImaagenUsuario.Name = "PImaagenUsuario";
            PImaagenUsuario.Size = new Size(216, 129);
            PImaagenUsuario.TabIndex = 21;
            // 
            // PBImagenUsuario
            // 
            PBImagenUsuario.Location = new Point(9, 6);
            PBImagenUsuario.Name = "PBImagenUsuario";
            PBImagenUsuario.Size = new Size(200, 120);
            PBImagenUsuario.TabIndex = 0;
            PBImagenUsuario.TabStop = false;
            // 
            // BAltaUsuario
            // 
            BAltaUsuario.BackColor = Color.Silver;
            BAltaUsuario.Location = new Point(501, 381);
            BAltaUsuario.Name = "BAltaUsuario";
            BAltaUsuario.Size = new Size(107, 38);
            BAltaUsuario.TabIndex = 22;
            BAltaUsuario.Text = "Crear";
            BAltaUsuario.UseVisualStyleBackColor = false;
            // 
            // BLimpiarAltaUsuario
            // 
            BLimpiarAltaUsuario.BackColor = Color.Silver;
            BLimpiarAltaUsuario.Location = new Point(670, 381);
            BLimpiarAltaUsuario.Name = "BLimpiarAltaUsuario";
            BLimpiarAltaUsuario.Size = new Size(107, 38);
            BLimpiarAltaUsuario.TabIndex = 23;
            BLimpiarAltaUsuario.Text = "Limpiar";
            BLimpiarAltaUsuario.UseVisualStyleBackColor = false;
            // 
            // FAltaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(BLimpiarAltaUsuario);
            Controls.Add(BAltaUsuario);
            Controls.Add(PImaagenUsuario);
            Controls.Add(DTPFechaNacimientoUsuario);
            Controls.Add(LFechaNacimientoUusario);
            Controls.Add(RBMujerUsuario);
            Controls.Add(RBHombreUsuario);
            Controls.Add(TBTelefonoUsuario);
            Controls.Add(LTelefonoUsuario);
            Controls.Add(label1);
            Controls.Add(TBDirrecionUsuariuo);
            Controls.Add(LDirrecionUsuario);
            Controls.Add(TBCorreoUsuario);
            Controls.Add(LCorreoUsuario);
            Controls.Add(TBDniUsuario);
            Controls.Add(LDniUsuario);
            Controls.Add(TBApellidoUsuario);
            Controls.Add(LApellidoUsuarioo);
            Controls.Add(TBNombreUsuario);
            Controls.Add(LNombreUsuario);
            Controls.Add(PMenu);
            Name = "FAltaUsuario";
            Text = "Alta Usuario";
            Load += FAltaUsuario_Load;
            PMenu.ResumeLayout(false);
            PImaagenUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBImagenUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel PMenu;
        private Button BVentas;
        private Button BProductos;
        private Button BProveedores;
        private Button BClientes;
        private Button BUsuario;
        private Label LNombreUsuario;
        private TextBox TBNombreUsuario;
        private TextBox TBApellidoUsuario;
        private Label LApellidoUsuarioo;
        private TextBox TBDniUsuario;
        private Label LDniUsuario;
        private TextBox TBCorreoUsuario;
        private Label LCorreoUsuario;
        private TextBox TBDirrecionUsuariuo;
        private Label LDirrecionUsuario;
        private Label label1;
        private TextBox TBTelefonoUsuario;
        private Label LTelefonoUsuario;
        private RadioButton RBHombreUsuario;
        private RadioButton RBMujerUsuario;
        private Label LFechaNacimientoUusario;
        private DateTimePicker DTPFechaNacimientoUsuario;
        private Panel PImaagenUsuario;
        private PictureBox PBImagenUsuario;
        private Button BAltaUsuario;
        private Button BLimpiarAltaUsuario;
    }
}