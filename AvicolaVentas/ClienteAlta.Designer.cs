namespace AvicolaVentas
{
    partial class fGestionClientes
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
            tNombreCliente = new TextBox();
            lNombreCliente = new Label();
            lApellidoCliente = new Label();
            tApellidoCliente = new TextBox();
            lFechaNacCliente = new Label();
            dtpFechaNacCliente = new DateTimePicker();
            lDniCliente = new Label();
            tDni = new TextBox();
            rbMasculinoCliente = new RadioButton();
            rbFemeninoCliente = new RadioButton();
            gbSexoCliente = new GroupBox();
            lTelefonoCliente = new Label();
            textBox2 = new TextBox();
            lDirecciónCliente = new Label();
            tDirecciónCliente = new TextBox();
            lCiudadCliente = new Label();
            tCiudadCliente = new TextBox();
            lProvinciaCliente = new Label();
            tProvinciaCliente = new TextBox();
            lEmailCliente = new Label();
            tEmailCliente = new TextBox();
            gbDatosContCliente = new GroupBox();
            gbDatosPersCliente = new GroupBox();
            bGuardarCliente = new Button();
            bLimpiarCliente = new Button();
            gbSexoCliente.SuspendLayout();
            gbDatosContCliente.SuspendLayout();
            gbDatosPersCliente.SuspendLayout();
            SuspendLayout();
            // 
            // tNombreCliente
            // 
            tNombreCliente.Location = new Point(115, 33);
            tNombreCliente.Multiline = true;
            tNombreCliente.Name = "tNombreCliente";
            tNombreCliente.Size = new Size(201, 25);
            tNombreCliente.TabIndex = 0;
            tNombreCliente.KeyPress += tNombreCliente_KeyPress;
            // 
            // lNombreCliente
            // 
            lNombreCliente.AutoSize = true;
            lNombreCliente.BackColor = Color.Transparent;
            lNombreCliente.Font = new Font("Segoe UI", 12F);
            lNombreCliente.Location = new Point(35, 38);
            lNombreCliente.Name = "lNombreCliente";
            lNombreCliente.Size = new Size(71, 21);
            lNombreCliente.TabIndex = 1;
            lNombreCliente.Text = "Nombre:";
            lNombreCliente.Click += label1_Click;
            // 
            // lApellidoCliente
            // 
            lApellidoCliente.AutoSize = true;
            lApellidoCliente.BackColor = Color.Transparent;
            lApellidoCliente.Font = new Font("Segoe UI", 12F);
            lApellidoCliente.Location = new Point(35, 78);
            lApellidoCliente.Name = "lApellidoCliente";
            lApellidoCliente.Size = new Size(70, 21);
            lApellidoCliente.TabIndex = 3;
            lApellidoCliente.Text = "Apellido:";
            // 
            // tApellidoCliente
            // 
            tApellidoCliente.Location = new Point(115, 73);
            tApellidoCliente.Multiline = true;
            tApellidoCliente.Name = "tApellidoCliente";
            tApellidoCliente.Size = new Size(201, 25);
            tApellidoCliente.TabIndex = 4;
            tApellidoCliente.KeyPress += tApellidoCliente_KeyPress;
            // 
            // lFechaNacCliente
            // 
            lFechaNacCliente.AutoSize = true;
            lFechaNacCliente.BackColor = Color.Transparent;
            lFechaNacCliente.Font = new Font("Segoe UI", 12F);
            lFechaNacCliente.Location = new Point(35, 153);
            lFechaNacCliente.Name = "lFechaNacCliente";
            lFechaNacCliente.Size = new Size(158, 21);
            lFechaNacCliente.TabIndex = 5;
            lFechaNacCliente.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacCliente
            // 
            dtpFechaNacCliente.CalendarFont = new Font("Segoe UI", 12F);
            dtpFechaNacCliente.Font = new Font("Segoe UI", 12F);
            dtpFechaNacCliente.Format = DateTimePickerFormat.Short;
            dtpFechaNacCliente.Location = new Point(199, 148);
            dtpFechaNacCliente.Name = "dtpFechaNacCliente";
            dtpFechaNacCliente.Size = new Size(115, 29);
            dtpFechaNacCliente.TabIndex = 6;
            dtpFechaNacCliente.Value = new DateTime(2025, 9, 18, 17, 32, 0, 0);
            // 
            // lDniCliente
            // 
            lDniCliente.AutoSize = true;
            lDniCliente.BackColor = Color.Transparent;
            lDniCliente.Font = new Font("Segoe UI", 12F);
            lDniCliente.Location = new Point(35, 118);
            lDniCliente.Name = "lDniCliente";
            lDniCliente.Size = new Size(40, 21);
            lDniCliente.TabIndex = 7;
            lDniCliente.Text = "DNI:";
            // 
            // tDni
            // 
            tDni.BackColor = SystemColors.Window;
            tDni.Location = new Point(115, 113);
            tDni.Multiline = true;
            tDni.Name = "tDni";
            tDni.Size = new Size(201, 25);
            tDni.TabIndex = 8;
            tDni.KeyPress += tDni_KeyPress;
            // 
            // rbMasculinoCliente
            // 
            rbMasculinoCliente.AutoSize = true;
            rbMasculinoCliente.BackColor = Color.Transparent;
            rbMasculinoCliente.Location = new Point(29, 22);
            rbMasculinoCliente.Name = "rbMasculinoCliente";
            rbMasculinoCliente.Size = new Size(99, 25);
            rbMasculinoCliente.TabIndex = 10;
            rbMasculinoCliente.TabStop = true;
            rbMasculinoCliente.Text = "Masculino";
            rbMasculinoCliente.UseVisualStyleBackColor = false;
            // 
            // rbFemeninoCliente
            // 
            rbFemeninoCliente.AutoSize = true;
            rbFemeninoCliente.BackColor = Color.Transparent;
            rbFemeninoCliente.Location = new Point(141, 22);
            rbFemeninoCliente.Name = "rbFemeninoCliente";
            rbFemeninoCliente.Size = new Size(97, 25);
            rbFemeninoCliente.TabIndex = 11;
            rbFemeninoCliente.TabStop = true;
            rbFemeninoCliente.Text = "Femenino";
            rbFemeninoCliente.UseVisualStyleBackColor = false;
            // 
            // gbSexoCliente
            // 
            gbSexoCliente.BackColor = Color.Transparent;
            gbSexoCliente.Controls.Add(rbMasculinoCliente);
            gbSexoCliente.Controls.Add(rbFemeninoCliente);
            gbSexoCliente.Font = new Font("Segoe UI", 12F);
            gbSexoCliente.Location = new Point(39, 189);
            gbSexoCliente.Name = "gbSexoCliente";
            gbSexoCliente.Size = new Size(277, 57);
            gbSexoCliente.TabIndex = 12;
            gbSexoCliente.TabStop = false;
            gbSexoCliente.Text = "Sexo";
            // 
            // lTelefonoCliente
            // 
            lTelefonoCliente.AutoSize = true;
            lTelefonoCliente.BackColor = Color.Transparent;
            lTelefonoCliente.Font = new Font("Segoe UI", 12F);
            lTelefonoCliente.Location = new Point(29, 80);
            lTelefonoCliente.Name = "lTelefonoCliente";
            lTelefonoCliente.Size = new Size(71, 21);
            lTelefonoCliente.TabIndex = 14;
            lTelefonoCliente.Text = "Telefono:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 75);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 25);
            textBox2.TabIndex = 15;
            // 
            // lDirecciónCliente
            // 
            lDirecciónCliente.AutoSize = true;
            lDirecciónCliente.BackColor = Color.Transparent;
            lDirecciónCliente.Font = new Font("Segoe UI", 12F);
            lDirecciónCliente.Location = new Point(29, 120);
            lDirecciónCliente.Name = "lDirecciónCliente";
            lDirecciónCliente.Size = new Size(78, 21);
            lDirecciónCliente.TabIndex = 16;
            lDirecciónCliente.Text = "Dirección:";
            // 
            // tDirecciónCliente
            // 
            tDirecciónCliente.Location = new Point(109, 115);
            tDirecciónCliente.Multiline = true;
            tDirecciónCliente.Name = "tDirecciónCliente";
            tDirecciónCliente.Size = new Size(201, 25);
            tDirecciónCliente.TabIndex = 17;
            // 
            // lCiudadCliente
            // 
            lCiudadCliente.AutoSize = true;
            lCiudadCliente.BackColor = Color.Transparent;
            lCiudadCliente.Font = new Font("Segoe UI", 12F);
            lCiudadCliente.Location = new Point(29, 155);
            lCiudadCliente.Name = "lCiudadCliente";
            lCiudadCliente.Size = new Size(62, 21);
            lCiudadCliente.TabIndex = 18;
            lCiudadCliente.Text = "Ciudad:";
            // 
            // tCiudadCliente
            // 
            tCiudadCliente.Location = new Point(106, 150);
            tCiudadCliente.Multiline = true;
            tCiudadCliente.Name = "tCiudadCliente";
            tCiudadCliente.Size = new Size(201, 25);
            tCiudadCliente.TabIndex = 19;
            // 
            // lProvinciaCliente
            // 
            lProvinciaCliente.AutoSize = true;
            lProvinciaCliente.BackColor = Color.Transparent;
            lProvinciaCliente.Font = new Font("Segoe UI", 12F);
            lProvinciaCliente.Location = new Point(29, 195);
            lProvinciaCliente.Name = "lProvinciaCliente";
            lProvinciaCliente.Size = new Size(77, 21);
            lProvinciaCliente.TabIndex = 20;
            lProvinciaCliente.Text = "Provincia:";
            // 
            // tProvinciaCliente
            // 
            tProvinciaCliente.Location = new Point(106, 190);
            tProvinciaCliente.Multiline = true;
            tProvinciaCliente.Name = "tProvinciaCliente";
            tProvinciaCliente.Size = new Size(201, 25);
            tProvinciaCliente.TabIndex = 21;
            // 
            // lEmailCliente
            // 
            lEmailCliente.AutoSize = true;
            lEmailCliente.BackColor = Color.Transparent;
            lEmailCliente.Font = new Font("Segoe UI", 12F);
            lEmailCliente.Location = new Point(29, 40);
            lEmailCliente.Name = "lEmailCliente";
            lEmailCliente.Size = new Size(51, 21);
            lEmailCliente.TabIndex = 22;
            lEmailCliente.Text = "Email:";
            // 
            // tEmailCliente
            // 
            tEmailCliente.Location = new Point(109, 35);
            tEmailCliente.Multiline = true;
            tEmailCliente.Name = "tEmailCliente";
            tEmailCliente.Size = new Size(201, 25);
            tEmailCliente.TabIndex = 23;
            // 
            // gbDatosContCliente
            // 
            gbDatosContCliente.BackColor = Color.Transparent;
            gbDatosContCliente.Controls.Add(tProvinciaCliente);
            gbDatosContCliente.Controls.Add(tEmailCliente);
            gbDatosContCliente.Controls.Add(lTelefonoCliente);
            gbDatosContCliente.Controls.Add(lEmailCliente);
            gbDatosContCliente.Controls.Add(textBox2);
            gbDatosContCliente.Controls.Add(lDirecciónCliente);
            gbDatosContCliente.Controls.Add(lProvinciaCliente);
            gbDatosContCliente.Controls.Add(tDirecciónCliente);
            gbDatosContCliente.Controls.Add(tCiudadCliente);
            gbDatosContCliente.Controls.Add(lCiudadCliente);
            gbDatosContCliente.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            gbDatosContCliente.Location = new Point(380, 20);
            gbDatosContCliente.Name = "gbDatosContCliente";
            gbDatosContCliente.Size = new Size(350, 263);
            gbDatosContCliente.TabIndex = 24;
            gbDatosContCliente.TabStop = false;
            gbDatosContCliente.Text = "Datos de Contacto";
            // 
            // gbDatosPersCliente
            // 
            gbDatosPersCliente.BackColor = Color.Transparent;
            gbDatosPersCliente.Controls.Add(tNombreCliente);
            gbDatosPersCliente.Controls.Add(lNombreCliente);
            gbDatosPersCliente.Controls.Add(gbSexoCliente);
            gbDatosPersCliente.Controls.Add(lApellidoCliente);
            gbDatosPersCliente.Controls.Add(tDni);
            gbDatosPersCliente.Controls.Add(tApellidoCliente);
            gbDatosPersCliente.Controls.Add(lDniCliente);
            gbDatosPersCliente.Controls.Add(lFechaNacCliente);
            gbDatosPersCliente.Controls.Add(dtpFechaNacCliente);
            gbDatosPersCliente.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            gbDatosPersCliente.Location = new Point(12, 20);
            gbDatosPersCliente.Name = "gbDatosPersCliente";
            gbDatosPersCliente.Size = new Size(350, 263);
            gbDatosPersCliente.TabIndex = 25;
            gbDatosPersCliente.TabStop = false;
            gbDatosPersCliente.Text = "Datos Personales";
            // 
            // bGuardarCliente
            // 
            bGuardarCliente.Font = new Font("Segoe UI", 12F);
            bGuardarCliente.Location = new Point(424, 310);
            bGuardarCliente.Name = "bGuardarCliente";
            bGuardarCliente.Size = new Size(130, 30);
            bGuardarCliente.TabIndex = 26;
            bGuardarCliente.Text = "Guardar";
            bGuardarCliente.UseVisualStyleBackColor = true;
            // 
            // bLimpiarCliente
            // 
            bLimpiarCliente.Font = new Font("Segoe UI", 12F);
            bLimpiarCliente.Location = new Point(577, 310);
            bLimpiarCliente.Name = "bLimpiarCliente";
            bLimpiarCliente.Size = new Size(130, 30);
            bLimpiarCliente.TabIndex = 27;
            bLimpiarCliente.Text = "Limpiar";
            bLimpiarCliente.UseVisualStyleBackColor = true;
            // 
            // fGestionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(789, 378);
            Controls.Add(bLimpiarCliente);
            Controls.Add(bGuardarCliente);
            Controls.Add(gbDatosPersCliente);
            Controls.Add(gbDatosContCliente);
            Name = "fGestionClientes";
            Text = "Gestión de Clientes";
            Load += fGestionClientes_Load;
            gbSexoCliente.ResumeLayout(false);
            gbSexoCliente.PerformLayout();
            gbDatosContCliente.ResumeLayout(false);
            gbDatosContCliente.PerformLayout();
            gbDatosPersCliente.ResumeLayout(false);
            gbDatosPersCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tNombreCliente;
        private Label lNombreCliente;
        private Label lApellidoCliente;
        private TextBox tApellidoCliente;
        private Label lFechaNacCliente;
        private DateTimePicker dtpFechaNacCliente;
        private Label lDniCliente;
        private TextBox tDni;
        private RadioButton rbMasculinoCliente;
        private RadioButton rbFemeninoCliente;
        private GroupBox gbSexoCliente;
        private Label lTelefonoCliente;
        private TextBox textBox2;
        private Label lDirecciónCliente;
        private TextBox tDirecciónCliente;
        private Label lCiudadCliente;
        private TextBox tCiudadCliente;
        private Label lProvinciaCliente;
        private TextBox tProvinciaCliente;
        private Label lEmailCliente;
        private TextBox tEmailCliente;
        private GroupBox gbDatosContCliente;
        private GroupBox gbDatosPersCliente;
        private Button bGuardarCliente;
        private Button bLimpiarCliente;
    }
}