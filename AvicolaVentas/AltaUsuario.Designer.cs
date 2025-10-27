namespace AvicolaVentas
{
    partial class fGestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGestionUsuarios));
            LNombreUsuario = new Label();
            TBNombreUsuario = new TextBox();
            TBApellidoUsuario = new TextBox();
            LApellidoUsuarioo = new Label();
            TBDniUsuario = new TextBox();
            LDniUsuario = new Label();
            TBCorreoUsuario = new TextBox();
            LCorreoUsuario = new Label();
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
            buttonSalir = new Button();
            labelContraseña = new Label();
            textBoxContraseñaUsuario = new TextBox();
            comboBoxRolUsuario = new ComboBox();
            labelRolUsuario = new Label();
            PImaagenUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBImagenUsuario).BeginInit();
            SuspendLayout();
            // 
            // LNombreUsuario
            // 
            LNombreUsuario.AutoSize = true;
            LNombreUsuario.BackColor = Color.Transparent;
            LNombreUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNombreUsuario.Location = new Point(54, 69);
            LNombreUsuario.Name = "LNombreUsuario";
            LNombreUsuario.Size = new Size(89, 30);
            LNombreUsuario.TabIndex = 4;
            LNombreUsuario.Text = "Nombre";
            LNombreUsuario.Click += label1_Click;
            // 
            // TBNombreUsuario
            // 
            TBNombreUsuario.Location = new Point(149, 78);
            TBNombreUsuario.Name = "TBNombreUsuario";
            TBNombreUsuario.Size = new Size(203, 23);
            TBNombreUsuario.TabIndex = 5;
            TBNombreUsuario.KeyPress += TBNombreUsuario_KeyPress;
            // 
            // TBApellidoUsuario
            // 
            TBApellidoUsuario.Location = new Point(149, 138);
            TBApellidoUsuario.Name = "TBApellidoUsuario";
            TBApellidoUsuario.Size = new Size(203, 23);
            TBApellidoUsuario.TabIndex = 7;
            TBApellidoUsuario.KeyPress += TBApellidoUsuario_KeyPress;
            // 
            // LApellidoUsuarioo
            // 
            LApellidoUsuarioo.AutoSize = true;
            LApellidoUsuarioo.BackColor = Color.Transparent;
            LApellidoUsuarioo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LApellidoUsuarioo.Location = new Point(54, 131);
            LApellidoUsuarioo.Name = "LApellidoUsuarioo";
            LApellidoUsuarioo.Size = new Size(89, 30);
            LApellidoUsuarioo.TabIndex = 6;
            LApellidoUsuarioo.Text = "Apellido";
            // 
            // TBDniUsuario
            // 
            TBDniUsuario.Location = new Point(149, 198);
            TBDniUsuario.Name = "TBDniUsuario";
            TBDniUsuario.Size = new Size(203, 23);
            TBDniUsuario.TabIndex = 9;
            TBDniUsuario.Text = "(Sin puntos ni comas)";
            TBDniUsuario.TextChanged += TBDniUsuario_TextChanged;
            TBDniUsuario.KeyPress += TBDniUsuario_KeyPress;
            // 
            // LDniUsuario
            // 
            LDniUsuario.AutoSize = true;
            LDniUsuario.BackColor = Color.Transparent;
            LDniUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LDniUsuario.Location = new Point(54, 196);
            LDniUsuario.Name = "LDniUsuario";
            LDniUsuario.Size = new Size(50, 30);
            LDniUsuario.TabIndex = 8;
            LDniUsuario.Text = "DNI";
            // 
            // TBCorreoUsuario
            // 
            TBCorreoUsuario.Location = new Point(149, 263);
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
            LCorreoUsuario.Location = new Point(54, 256);
            LCorreoUsuario.Name = "LCorreoUsuario";
            LCorreoUsuario.Size = new Size(63, 30);
            LCorreoUsuario.TabIndex = 10;
            LCorreoUsuario.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(376, 213);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 14;
            // 
            // TBTelefonoUsuario
            // 
            TBTelefonoUsuario.Location = new Point(149, 386);
            TBTelefonoUsuario.Name = "TBTelefonoUsuario";
            TBTelefonoUsuario.Size = new Size(203, 23);
            TBTelefonoUsuario.TabIndex = 16;
            TBTelefonoUsuario.KeyPress += TBTelefonoUsuario_KeyPress;
            // 
            // LTelefonoUsuario
            // 
            LTelefonoUsuario.AutoSize = true;
            LTelefonoUsuario.BackColor = Color.Transparent;
            LTelefonoUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LTelefonoUsuario.Location = new Point(36, 379);
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
            RBHombreUsuario.Location = new Point(418, 209);
            RBHombreUsuario.Name = "RBHombreUsuario";
            RBHombreUsuario.Size = new Size(85, 25);
            RBHombreUsuario.TabIndex = 17;
            RBHombreUsuario.TabStop = true;
            RBHombreUsuario.Text = "Hombre";
            RBHombreUsuario.UseVisualStyleBackColor = false;
            RBHombreUsuario.CheckedChanged += RBHombreUsuario_CheckedChanged;
            // 
            // RBMujerUsuario
            // 
            RBMujerUsuario.AutoSize = true;
            RBMujerUsuario.BackColor = Color.Transparent;
            RBMujerUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBMujerUsuario.Location = new Point(565, 209);
            RBMujerUsuario.Name = "RBMujerUsuario";
            RBMujerUsuario.Size = new Size(69, 25);
            RBMujerUsuario.TabIndex = 18;
            RBMujerUsuario.TabStop = true;
            RBMujerUsuario.Text = "Mujer";
            RBMujerUsuario.UseVisualStyleBackColor = false;
            RBMujerUsuario.CheckedChanged += RBMujerUsuario_CheckedChanged;
            // 
            // LFechaNacimientoUusario
            // 
            LFechaNacimientoUusario.AutoSize = true;
            LFechaNacimientoUusario.BackColor = Color.Transparent;
            LFechaNacimientoUusario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LFechaNacimientoUusario.Location = new Point(425, 243);
            LFechaNacimientoUusario.Name = "LFechaNacimientoUusario";
            LFechaNacimientoUusario.Size = new Size(209, 30);
            LFechaNacimientoUusario.TabIndex = 19;
            LFechaNacimientoUusario.Text = "Fecha de Nacimiento";
            // 
            // DTPFechaNacimientoUsuario
            // 
            DTPFechaNacimientoUsuario.CalendarFont = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTPFechaNacimientoUsuario.Location = new Point(418, 286);
            DTPFechaNacimientoUsuario.Name = "DTPFechaNacimientoUsuario";
            DTPFechaNacimientoUsuario.Size = new Size(234, 23);
            DTPFechaNacimientoUsuario.TabIndex = 20;
            DTPFechaNacimientoUsuario.ValueChanged += DTPFechaNacimientoUsuario_ValueChanged;
            // 
            // PImaagenUsuario
            // 
            PImaagenUsuario.Controls.Add(PBImagenUsuario);
            PImaagenUsuario.Location = new Point(455, 49);
            PImaagenUsuario.Name = "PImaagenUsuario";
            PImaagenUsuario.Size = new Size(150, 133);
            PImaagenUsuario.TabIndex = 21;
            // 
            // PBImagenUsuario
            // 
            PBImagenUsuario.Image = (Image)resources.GetObject("PBImagenUsuario.Image");
            PBImagenUsuario.Location = new Point(12, 6);
            PBImagenUsuario.Name = "PBImagenUsuario";
            PBImagenUsuario.Size = new Size(125, 120);
            PBImagenUsuario.TabIndex = 0;
            PBImagenUsuario.TabStop = false;
            PBImagenUsuario.Click += PBImagenUsuario_Click;
            // 
            // BAltaUsuario
            // 
            BAltaUsuario.BackColor = Color.Silver;
            BAltaUsuario.Location = new Point(396, 420);
            BAltaUsuario.Name = "BAltaUsuario";
            BAltaUsuario.Size = new Size(107, 38);
            BAltaUsuario.TabIndex = 22;
            BAltaUsuario.Text = "Crear";
            BAltaUsuario.UseVisualStyleBackColor = false;
            BAltaUsuario.Click += BAltaUsuario_Click;
            // 
            // BLimpiarAltaUsuario
            // 
            BLimpiarAltaUsuario.BackColor = Color.Silver;
            BLimpiarAltaUsuario.Location = new Point(565, 421);
            BLimpiarAltaUsuario.Name = "BLimpiarAltaUsuario";
            BLimpiarAltaUsuario.Size = new Size(107, 38);
            BLimpiarAltaUsuario.TabIndex = 23;
            BLimpiarAltaUsuario.Text = "Limpiar";
            BLimpiarAltaUsuario.UseVisualStyleBackColor = false;
            BLimpiarAltaUsuario.Click += BLimpiarAltaUsuario_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(34, 12);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(43, 23);
            buttonSalir.TabIndex = 24;
            buttonSalir.Text = "X";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.BackColor = Color.Transparent;
            labelContraseña.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelContraseña.Location = new Point(25, 321);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(118, 30);
            labelContraseña.TabIndex = 25;
            labelContraseña.Text = "Contraseña";
            // 
            // textBoxContraseñaUsuario
            // 
            textBoxContraseñaUsuario.Location = new Point(149, 330);
            textBoxContraseñaUsuario.Name = "textBoxContraseñaUsuario";
            textBoxContraseñaUsuario.Size = new Size(203, 23);
            textBoxContraseñaUsuario.TabIndex = 26;
            textBoxContraseñaUsuario.UseSystemPasswordChar = true;
            // 
            // comboBoxRolUsuario
            // 
            comboBoxRolUsuario.FormattingEnabled = true;
            comboBoxRolUsuario.Location = new Point(425, 359);
            comboBoxRolUsuario.Name = "comboBoxRolUsuario";
            comboBoxRolUsuario.Size = new Size(227, 23);
            comboBoxRolUsuario.TabIndex = 27;
            comboBoxRolUsuario.SelectedIndexChanged += comboBoxRolUsuario_SelectedIndexChanged;
            comboBoxRolUsuario.SelectedValueChanged += comboBoxRolUsuario_Load;
            // 
            // labelRolUsuario
            // 
            labelRolUsuario.AutoSize = true;
            labelRolUsuario.BackColor = Color.Transparent;
            labelRolUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRolUsuario.Location = new Point(452, 320);
            labelRolUsuario.Name = "labelRolUsuario";
            labelRolUsuario.Size = new Size(168, 30);
            labelRolUsuario.TabIndex = 28;
            labelRolUsuario.Text = "Seleccione el Rol";
            // 
            // fGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(704, 522);
            Controls.Add(labelRolUsuario);
            Controls.Add(comboBoxRolUsuario);
            Controls.Add(textBoxContraseñaUsuario);
            Controls.Add(labelContraseña);
            Controls.Add(buttonSalir);
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
            Controls.Add(TBCorreoUsuario);
            Controls.Add(LCorreoUsuario);
            Controls.Add(TBDniUsuario);
            Controls.Add(LDniUsuario);
            Controls.Add(TBApellidoUsuario);
            Controls.Add(LApellidoUsuarioo);
            Controls.Add(TBNombreUsuario);
            Controls.Add(LNombreUsuario);
            MinimumSize = new Size(720, 561);
            Name = "fGestionUsuarios";
            Text = "Alta Usuario";
            Load += FAltaUsuario_Load;
            PImaagenUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBImagenUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LNombreUsuario;
        private TextBox TBNombreUsuario;
        private TextBox TBApellidoUsuario;
        private Label LApellidoUsuarioo;
        private TextBox TBDniUsuario;
        private Label LDniUsuario;
        private TextBox TBCorreoUsuario;
        private Label LCorreoUsuario;
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
        private Button buttonSalir;
        private Label labelContraseña;
        private TextBox textBoxContraseñaUsuario;
        private ComboBox comboBoxRolUsuario;
        private Label labelRolUsuario;
    }
}