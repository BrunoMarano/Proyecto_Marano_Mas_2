namespace ModificaciónProductos
{
    partial class ModificarCliente
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
            GBDatosPersModifCliente = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            TBDniModifCliente = new TextBox();
            TBApellidoModifCliente = new TextBox();
            TBNombreModifCliente = new TextBox();
            GBSexoModifCliente = new GroupBox();
            RBFemeninoModifCliente = new RadioButton();
            RBMasculinoModifCliente = new RadioButton();
            LFechaNacModifCliente = new Label();
            LDniModifCliente = new Label();
            LApellidoModifCliente = new Label();
            LNombreModifCliente = new Label();
            GBDatosContModifCliente = new GroupBox();
            CBCiudadModifCliente = new ComboBox();
            LCiudadModifCliente = new Label();
            CBProvinciaModifCliente = new ComboBox();
            TBDireccionModifCliente = new TextBox();
            TTelModifCliente = new TextBox();
            TBEmailModifCliente = new TextBox();
            LProvinciaModifCliente = new Label();
            LDireccionModifCliente = new Label();
            LTelModifCliente = new Label();
            LEmailModifCliente = new Label();
            BModificarCliente = new Button();
            BLimpiarModifCliente = new Button();
            GBDatosPersModifCliente.SuspendLayout();
            GBSexoModifCliente.SuspendLayout();
            GBDatosContModifCliente.SuspendLayout();
            SuspendLayout();
            // 
            // GBDatosPersModifCliente
            // 
            GBDatosPersModifCliente.Controls.Add(dateTimePicker1);
            GBDatosPersModifCliente.Controls.Add(TBDniModifCliente);
            GBDatosPersModifCliente.Controls.Add(TBApellidoModifCliente);
            GBDatosPersModifCliente.Controls.Add(TBNombreModifCliente);
            GBDatosPersModifCliente.Controls.Add(GBSexoModifCliente);
            GBDatosPersModifCliente.Controls.Add(LFechaNacModifCliente);
            GBDatosPersModifCliente.Controls.Add(LDniModifCliente);
            GBDatosPersModifCliente.Controls.Add(LApellidoModifCliente);
            GBDatosPersModifCliente.Controls.Add(LNombreModifCliente);
            GBDatosPersModifCliente.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            GBDatosPersModifCliente.Location = new Point(7, 105);
            GBDatosPersModifCliente.Name = "GBDatosPersModifCliente";
            GBDatosPersModifCliente.Size = new Size(338, 263);
            GBDatosPersModifCliente.TabIndex = 0;
            GBDatosPersModifCliente.TabStop = false;
            GBDatosPersModifCliente.Text = "Datos Personales";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(192, 145);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(115, 29);
            dateTimePicker1.TabIndex = 8;
            // 
            // TBDniModifCliente
            // 
            TBDniModifCliente.Font = new Font("Segoe UI", 12F);
            TBDniModifCliente.Location = new Point(105, 108);
            TBDniModifCliente.Name = "TBDniModifCliente";
            TBDniModifCliente.Size = new Size(201, 29);
            TBDniModifCliente.TabIndex = 7;
            TBDniModifCliente.KeyPress += TBDniModifCliente_KeyPress;
            // 
            // TBApellidoModifCliente
            // 
            TBApellidoModifCliente.Font = new Font("Segoe UI", 12F);
            TBApellidoModifCliente.Location = new Point(106, 73);
            TBApellidoModifCliente.Name = "TBApellidoModifCliente";
            TBApellidoModifCliente.Size = new Size(201, 29);
            TBApellidoModifCliente.TabIndex = 6;
            TBApellidoModifCliente.KeyPress += TBApellidoModifCliente_KeyPress;
            // 
            // TBNombreModifCliente
            // 
            TBNombreModifCliente.Font = new Font("Segoe UI", 12F);
            TBNombreModifCliente.Location = new Point(106, 38);
            TBNombreModifCliente.Name = "TBNombreModifCliente";
            TBNombreModifCliente.Size = new Size(201, 29);
            TBNombreModifCliente.TabIndex = 5;
            TBNombreModifCliente.TextChanged += TBNombreModifCliente_TextChanged;
            TBNombreModifCliente.KeyPress += TBNombreModifCliente_KeyPress;
            // 
            // GBSexoModifCliente
            // 
            GBSexoModifCliente.Controls.Add(RBFemeninoModifCliente);
            GBSexoModifCliente.Controls.Add(RBMasculinoModifCliente);
            GBSexoModifCliente.Font = new Font("Segoe UI", 12F);
            GBSexoModifCliente.Location = new Point(29, 180);
            GBSexoModifCliente.Name = "GBSexoModifCliente";
            GBSexoModifCliente.Size = new Size(277, 57);
            GBSexoModifCliente.TabIndex = 4;
            GBSexoModifCliente.TabStop = false;
            GBSexoModifCliente.Text = "Sexo";
            // 
            // RBFemeninoModifCliente
            // 
            RBFemeninoModifCliente.AutoSize = true;
            RBFemeninoModifCliente.Location = new Point(141, 26);
            RBFemeninoModifCliente.Name = "RBFemeninoModifCliente";
            RBFemeninoModifCliente.Size = new Size(97, 25);
            RBFemeninoModifCliente.TabIndex = 1;
            RBFemeninoModifCliente.TabStop = true;
            RBFemeninoModifCliente.Text = "Femenino";
            RBFemeninoModifCliente.UseVisualStyleBackColor = true;
            // 
            // RBMasculinoModifCliente
            // 
            RBMasculinoModifCliente.AutoSize = true;
            RBMasculinoModifCliente.Location = new Point(28, 26);
            RBMasculinoModifCliente.Name = "RBMasculinoModifCliente";
            RBMasculinoModifCliente.Size = new Size(99, 25);
            RBMasculinoModifCliente.TabIndex = 0;
            RBMasculinoModifCliente.TabStop = true;
            RBMasculinoModifCliente.Text = "Masculino";
            RBMasculinoModifCliente.UseVisualStyleBackColor = true;
            // 
            // LFechaNacModifCliente
            // 
            LFechaNacModifCliente.AutoSize = true;
            LFechaNacModifCliente.BackColor = Color.Transparent;
            LFechaNacModifCliente.Font = new Font("Segoe UI", 12F);
            LFechaNacModifCliente.Location = new Point(30, 147);
            LFechaNacModifCliente.Name = "LFechaNacModifCliente";
            LFechaNacModifCliente.Size = new Size(158, 21);
            LFechaNacModifCliente.TabIndex = 3;
            LFechaNacModifCliente.Text = "Fecha de Nacimiento:";
            // 
            // LDniModifCliente
            // 
            LDniModifCliente.AutoSize = true;
            LDniModifCliente.BackColor = Color.Transparent;
            LDniModifCliente.Font = new Font("Segoe UI", 12F);
            LDniModifCliente.Location = new Point(30, 113);
            LDniModifCliente.Name = "LDniModifCliente";
            LDniModifCliente.Size = new Size(40, 21);
            LDniModifCliente.TabIndex = 2;
            LDniModifCliente.Text = "DNI:";
            // 
            // LApellidoModifCliente
            // 
            LApellidoModifCliente.AutoSize = true;
            LApellidoModifCliente.BackColor = Color.Transparent;
            LApellidoModifCliente.Font = new Font("Segoe UI", 12F);
            LApellidoModifCliente.Location = new Point(29, 79);
            LApellidoModifCliente.Name = "LApellidoModifCliente";
            LApellidoModifCliente.Size = new Size(70, 21);
            LApellidoModifCliente.TabIndex = 1;
            LApellidoModifCliente.Text = "Apellido:";
            // 
            // LNombreModifCliente
            // 
            LNombreModifCliente.AutoSize = true;
            LNombreModifCliente.BackColor = Color.Transparent;
            LNombreModifCliente.Font = new Font("Segoe UI", 12F);
            LNombreModifCliente.Location = new Point(29, 43);
            LNombreModifCliente.Name = "LNombreModifCliente";
            LNombreModifCliente.Size = new Size(71, 21);
            LNombreModifCliente.TabIndex = 0;
            LNombreModifCliente.Text = "Nombre:";
            // 
            // GBDatosContModifCliente
            // 
            GBDatosContModifCliente.Controls.Add(CBCiudadModifCliente);
            GBDatosContModifCliente.Controls.Add(LCiudadModifCliente);
            GBDatosContModifCliente.Controls.Add(CBProvinciaModifCliente);
            GBDatosContModifCliente.Controls.Add(TBDireccionModifCliente);
            GBDatosContModifCliente.Controls.Add(TTelModifCliente);
            GBDatosContModifCliente.Controls.Add(TBEmailModifCliente);
            GBDatosContModifCliente.Controls.Add(LProvinciaModifCliente);
            GBDatosContModifCliente.Controls.Add(LDireccionModifCliente);
            GBDatosContModifCliente.Controls.Add(LTelModifCliente);
            GBDatosContModifCliente.Controls.Add(LEmailModifCliente);
            GBDatosContModifCliente.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            GBDatosContModifCliente.Location = new Point(354, 105);
            GBDatosContModifCliente.Name = "GBDatosContModifCliente";
            GBDatosContModifCliente.Size = new Size(338, 263);
            GBDatosContModifCliente.TabIndex = 9;
            GBDatosContModifCliente.TabStop = false;
            GBDatosContModifCliente.Text = "Datos de Contacto";
            GBDatosContModifCliente.Enter += groupBox1_Enter;
            // 
            // CBCiudadModifCliente
            // 
            CBCiudadModifCliente.Font = new Font("Segoe UI", 12F);
            CBCiudadModifCliente.FormattingEnabled = true;
            CBCiudadModifCliente.Location = new Point(112, 187);
            CBCiudadModifCliente.Name = "CBCiudadModifCliente";
            CBCiudadModifCliente.Size = new Size(201, 29);
            CBCiudadModifCliente.TabIndex = 10;
            // 
            // LCiudadModifCliente
            // 
            LCiudadModifCliente.AutoSize = true;
            LCiudadModifCliente.BackColor = Color.Transparent;
            LCiudadModifCliente.Font = new Font("Segoe UI", 12F);
            LCiudadModifCliente.Location = new Point(30, 193);
            LCiudadModifCliente.Name = "LCiudadModifCliente";
            LCiudadModifCliente.Size = new Size(62, 21);
            LCiudadModifCliente.TabIndex = 9;
            LCiudadModifCliente.Text = "Ciudad:";
            // 
            // CBProvinciaModifCliente
            // 
            CBProvinciaModifCliente.Font = new Font("Segoe UI", 12F);
            CBProvinciaModifCliente.FormattingEnabled = true;
            CBProvinciaModifCliente.Location = new Point(112, 148);
            CBProvinciaModifCliente.Name = "CBProvinciaModifCliente";
            CBProvinciaModifCliente.Size = new Size(201, 29);
            CBProvinciaModifCliente.TabIndex = 8;
            // 
            // TBDireccionModifCliente
            // 
            TBDireccionModifCliente.Font = new Font("Segoe UI", 12F);
            TBDireccionModifCliente.Location = new Point(112, 108);
            TBDireccionModifCliente.Name = "TBDireccionModifCliente";
            TBDireccionModifCliente.Size = new Size(201, 29);
            TBDireccionModifCliente.TabIndex = 7;
            TBDireccionModifCliente.TextChanged += TBDireccionModifCliente_TextChanged;
            TBDireccionModifCliente.KeyPress += TBDireccionModifCliente_KeyPress;
            // 
            // TTelModifCliente
            // 
            TTelModifCliente.Font = new Font("Segoe UI", 12F);
            TTelModifCliente.Location = new Point(112, 73);
            TTelModifCliente.Name = "TTelModifCliente";
            TTelModifCliente.Size = new Size(201, 29);
            TTelModifCliente.TabIndex = 6;
            TTelModifCliente.KeyPress += TTelModifCliente_KeyPress;
            // 
            // TBEmailModifCliente
            // 
            TBEmailModifCliente.Font = new Font("Segoe UI", 12F);
            TBEmailModifCliente.Location = new Point(112, 38);
            TBEmailModifCliente.Name = "TBEmailModifCliente";
            TBEmailModifCliente.Size = new Size(201, 29);
            TBEmailModifCliente.TabIndex = 5;
            TBEmailModifCliente.KeyPress += TBEmailModifCliente_KeyPress;
            // 
            // LProvinciaModifCliente
            // 
            LProvinciaModifCliente.AutoSize = true;
            LProvinciaModifCliente.BackColor = Color.Transparent;
            LProvinciaModifCliente.Font = new Font("Segoe UI", 12F);
            LProvinciaModifCliente.Location = new Point(28, 151);
            LProvinciaModifCliente.Name = "LProvinciaModifCliente";
            LProvinciaModifCliente.Size = new Size(81, 21);
            LProvinciaModifCliente.TabIndex = 3;
            LProvinciaModifCliente.Text = " Provincia:";
            LProvinciaModifCliente.Click += LProvinciaModifCliente_Click;
            // 
            // LDireccionModifCliente
            // 
            LDireccionModifCliente.AutoSize = true;
            LDireccionModifCliente.BackColor = Color.Transparent;
            LDireccionModifCliente.Font = new Font("Segoe UI", 12F);
            LDireccionModifCliente.Location = new Point(30, 113);
            LDireccionModifCliente.Name = "LDireccionModifCliente";
            LDireccionModifCliente.Size = new Size(78, 21);
            LDireccionModifCliente.TabIndex = 2;
            LDireccionModifCliente.Text = "Direccion:";
            // 
            // LTelModifCliente
            // 
            LTelModifCliente.AutoSize = true;
            LTelModifCliente.BackColor = Color.Transparent;
            LTelModifCliente.Font = new Font("Segoe UI", 12F);
            LTelModifCliente.Location = new Point(29, 79);
            LTelModifCliente.Name = "LTelModifCliente";
            LTelModifCliente.Size = new Size(71, 21);
            LTelModifCliente.TabIndex = 1;
            LTelModifCliente.Text = "Telefono:";
            // 
            // LEmailModifCliente
            // 
            LEmailModifCliente.AutoSize = true;
            LEmailModifCliente.BackColor = Color.Transparent;
            LEmailModifCliente.Font = new Font("Segoe UI", 12F);
            LEmailModifCliente.Location = new Point(29, 43);
            LEmailModifCliente.Name = "LEmailModifCliente";
            LEmailModifCliente.Size = new Size(51, 21);
            LEmailModifCliente.TabIndex = 0;
            LEmailModifCliente.Text = "Email:";
            // 
            // BModificarCliente
            // 
            BModificarCliente.BackColor = SystemColors.ControlDark;
            BModificarCliente.Font = new Font("Segoe UI", 12F);
            BModificarCliente.Location = new Point(383, 412);
            BModificarCliente.Name = "BModificarCliente";
            BModificarCliente.Size = new Size(130, 30);
            BModificarCliente.TabIndex = 10;
            BModificarCliente.Text = "Modificar";
            BModificarCliente.UseVisualStyleBackColor = false;
            // 
            // BLimpiarModifCliente
            // 
            BLimpiarModifCliente.BackColor = SystemColors.ControlDark;
            BLimpiarModifCliente.Font = new Font("Segoe UI", 12F);
            BLimpiarModifCliente.Location = new Point(534, 412);
            BLimpiarModifCliente.Name = "BLimpiarModifCliente";
            BLimpiarModifCliente.Size = new Size(130, 30);
            BLimpiarModifCliente.TabIndex = 11;
            BLimpiarModifCliente.Text = "Limpiar";
            BLimpiarModifCliente.UseVisualStyleBackColor = false;
            // 
            // ModificarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 522);
            Controls.Add(BLimpiarModifCliente);
            Controls.Add(BModificarCliente);
            Controls.Add(GBDatosContModifCliente);
            Controls.Add(GBDatosPersModifCliente);
            Name = "ModificarCliente";
            Text = "Form1";
            GBDatosPersModifCliente.ResumeLayout(false);
            GBDatosPersModifCliente.PerformLayout();
            GBSexoModifCliente.ResumeLayout(false);
            GBSexoModifCliente.PerformLayout();
            GBDatosContModifCliente.ResumeLayout(false);
            GBDatosContModifCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GBDatosPersModifCliente;
        private Label LApellidoModifCliente;
        private Label LNombreModifCliente;
        private Label LDniModifCliente;
        private TextBox TBNombreModifCliente;
        private GroupBox GBSexoModifCliente;
        private RadioButton RBFemeninoModifCliente;
        private RadioButton RBMasculinoModifCliente;
        private Label LFechaNacModifCliente;
        private DateTimePicker dateTimePicker1;
        private TextBox TBDniModifCliente;
        private TextBox TBApellidoModifCliente;
        private GroupBox GBDatosContModifCliente;
        private TextBox TBDireccionModifCliente;
        private TextBox TTelModifCliente;
        private TextBox TBEmailModifCliente;
        private Label LProvinciaModifCliente;
        private Label LDireccionModifCliente;
        private Label LTelModifCliente;
        private Label LEmailModifCliente;
        private ComboBox CBProvinciaModifCliente;
        private ComboBox CBCiudadModifCliente;
        private Label LCiudadModifCliente;
        private Button BModificarCliente;
        private Button BLimpiarModifCliente;
    }
}
