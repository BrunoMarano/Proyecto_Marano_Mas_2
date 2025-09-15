namespace AvicolaVentas
{
    partial class FormAltaProveedores
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
            textBoxNombreProveedor = new TextBox();
            labelNombreProveedor = new Label();
            textBoxTelefonoProveedor = new TextBox();
            labelTelefonoProveedor = new Label();
            textBoxCuitProveedor = new TextBox();
            labelCuitPorveedor = new Label();
            textBoxDireccionProveedor = new TextBox();
            labelDireccionPorveedor = new Label();
            labelCiudad = new Label();
            labelProvincia = new Label();
            buttonLimpiarProveedores = new Button();
            buttonCrearProveedor = new Button();
            buttonSalirAltaProveedor = new Button();
            comboBoxProvinciaProveedor = new ComboBox();
            comboBoxCiudadProveedor = new ComboBox();
            SuspendLayout();
            // 
            // textBoxNombreProveedor
            // 
            textBoxNombreProveedor.Location = new Point(286, 61);
            textBoxNombreProveedor.Name = "textBoxNombreProveedor";
            textBoxNombreProveedor.Size = new Size(203, 23);
            textBoxNombreProveedor.TabIndex = 7;
            textBoxNombreProveedor.TextChanged += textBoxNombreProveedor_TextChanged;
            // 
            // labelNombreProveedor
            // 
            labelNombreProveedor.AutoSize = true;
            labelNombreProveedor.BackColor = Color.Transparent;
            labelNombreProveedor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombreProveedor.Location = new Point(65, 54);
            labelNombreProveedor.Name = "labelNombreProveedor";
            labelNombreProveedor.Size = new Size(215, 30);
            labelNombreProveedor.TabIndex = 6;
            labelNombreProveedor.Text = "Nombre/Razon Social";
            // 
            // textBoxTelefonoProveedor
            // 
            textBoxTelefonoProveedor.Location = new Point(286, 141);
            textBoxTelefonoProveedor.Name = "textBoxTelefonoProveedor";
            textBoxTelefonoProveedor.Size = new Size(203, 23);
            textBoxTelefonoProveedor.TabIndex = 9;
            textBoxTelefonoProveedor.KeyPress += textBoxTelefonoProveedor_KeyPress;
            // 
            // labelTelefonoProveedor
            // 
            labelTelefonoProveedor.AutoSize = true;
            labelTelefonoProveedor.BackColor = Color.Transparent;
            labelTelefonoProveedor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTelefonoProveedor.Location = new Point(122, 134);
            labelTelefonoProveedor.Name = "labelTelefonoProveedor";
            labelTelefonoProveedor.Size = new Size(92, 30);
            labelTelefonoProveedor.TabIndex = 8;
            labelTelefonoProveedor.Text = "Telefono";
            // 
            // textBoxCuitProveedor
            // 
            textBoxCuitProveedor.Location = new Point(286, 225);
            textBoxCuitProveedor.Name = "textBoxCuitProveedor";
            textBoxCuitProveedor.Size = new Size(203, 23);
            textBoxCuitProveedor.TabIndex = 11;
            textBoxCuitProveedor.TextChanged += textBoxCuitProveedor_TextChanged;
            textBoxCuitProveedor.KeyPress += textBoxCuitProveedor_KeyPress;
            // 
            // labelCuitPorveedor
            // 
            labelCuitPorveedor.AutoSize = true;
            labelCuitPorveedor.BackColor = Color.Transparent;
            labelCuitPorveedor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCuitPorveedor.Location = new Point(139, 218);
            labelCuitPorveedor.Name = "labelCuitPorveedor";
            labelCuitPorveedor.Size = new Size(50, 30);
            labelCuitPorveedor.TabIndex = 10;
            labelCuitPorveedor.Text = "Cuit";
            // 
            // textBoxDireccionProveedor
            // 
            textBoxDireccionProveedor.Location = new Point(286, 301);
            textBoxDireccionProveedor.Name = "textBoxDireccionProveedor";
            textBoxDireccionProveedor.Size = new Size(203, 23);
            textBoxDireccionProveedor.TabIndex = 13;
            textBoxDireccionProveedor.TextChanged += textBoxDireccionProveedor_TextChanged;
            // 
            // labelDireccionPorveedor
            // 
            labelDireccionPorveedor.AutoSize = true;
            labelDireccionPorveedor.BackColor = Color.Transparent;
            labelDireccionPorveedor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDireccionPorveedor.Location = new Point(114, 292);
            labelDireccionPorveedor.Name = "labelDireccionPorveedor";
            labelDireccionPorveedor.Size = new Size(100, 30);
            labelDireccionPorveedor.TabIndex = 12;
            labelDireccionPorveedor.Text = "Direccion";
            // 
            // labelCiudad
            // 
            labelCiudad.AutoSize = true;
            labelCiudad.BackColor = Color.Transparent;
            labelCiudad.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCiudad.Location = new Point(122, 430);
            labelCiudad.Name = "labelCiudad";
            labelCiudad.Size = new Size(78, 30);
            labelCiudad.TabIndex = 14;
            labelCiudad.Text = "Ciudad";
            // 
            // labelProvincia
            // 
            labelProvincia.AutoSize = true;
            labelProvincia.BackColor = Color.Transparent;
            labelProvincia.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelProvincia.Location = new Point(114, 369);
            labelProvincia.Name = "labelProvincia";
            labelProvincia.Size = new Size(97, 30);
            labelProvincia.TabIndex = 16;
            labelProvincia.Text = "Provincia";
            // 
            // buttonLimpiarProveedores
            // 
            buttonLimpiarProveedores.BackColor = Color.Silver;
            buttonLimpiarProveedores.Location = new Point(556, 61);
            buttonLimpiarProveedores.Name = "buttonLimpiarProveedores";
            buttonLimpiarProveedores.Size = new Size(107, 38);
            buttonLimpiarProveedores.TabIndex = 18;
            buttonLimpiarProveedores.Text = "Limpiar";
            buttonLimpiarProveedores.UseVisualStyleBackColor = false;
            buttonLimpiarProveedores.Click += buttonLimpiarProveedores_Click_1;
            // 
            // buttonCrearProveedor
            // 
            buttonCrearProveedor.BackColor = Color.Silver;
            buttonCrearProveedor.Location = new Point(556, 141);
            buttonCrearProveedor.Name = "buttonCrearProveedor";
            buttonCrearProveedor.Size = new Size(107, 38);
            buttonCrearProveedor.TabIndex = 19;
            buttonCrearProveedor.Text = "Crear";
            buttonCrearProveedor.UseVisualStyleBackColor = false;
            // 
            // buttonSalirAltaProveedor
            // 
            buttonSalirAltaProveedor.Location = new Point(34, 12);
            buttonSalirAltaProveedor.Name = "buttonSalirAltaProveedor";
            buttonSalirAltaProveedor.Size = new Size(43, 23);
            buttonSalirAltaProveedor.TabIndex = 20;
            buttonSalirAltaProveedor.Text = "X";
            buttonSalirAltaProveedor.UseVisualStyleBackColor = true;
            buttonSalirAltaProveedor.Click += buttonSalirAltaProveedor_Click;
            // 
            // comboBoxProvinciaProveedor
            // 
            comboBoxProvinciaProveedor.FormattingEnabled = true;
            comboBoxProvinciaProveedor.Location = new Point(286, 378);
            comboBoxProvinciaProveedor.Name = "comboBoxProvinciaProveedor";
            comboBoxProvinciaProveedor.Size = new Size(203, 23);
            comboBoxProvinciaProveedor.TabIndex = 21;
            // 
            // comboBoxCiudadProveedor
            // 
            comboBoxCiudadProveedor.FormattingEnabled = true;
            comboBoxCiudadProveedor.Location = new Point(286, 437);
            comboBoxCiudadProveedor.Name = "comboBoxCiudadProveedor";
            comboBoxCiudadProveedor.Size = new Size(203, 23);
            comboBoxCiudadProveedor.TabIndex = 22;
            // 
            // FormAltaProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(704, 522);
            Controls.Add(comboBoxCiudadProveedor);
            Controls.Add(comboBoxProvinciaProveedor);
            Controls.Add(buttonSalirAltaProveedor);
            Controls.Add(buttonCrearProveedor);
            Controls.Add(buttonLimpiarProveedores);
            Controls.Add(labelProvincia);
            Controls.Add(labelCiudad);
            Controls.Add(textBoxDireccionProveedor);
            Controls.Add(labelDireccionPorveedor);
            Controls.Add(textBoxCuitProveedor);
            Controls.Add(labelCuitPorveedor);
            Controls.Add(textBoxTelefonoProveedor);
            Controls.Add(labelTelefonoProveedor);
            Controls.Add(textBoxNombreProveedor);
            Controls.Add(labelNombreProveedor);
            Name = "FormAltaProveedores";
            Text = "AltaProveedor";
            Load += AltaProveedores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombreProveedor;
        private Label labelNombreProveedor;
        private TextBox textBoxTelefonoProveedor;
        private Label labelTelefonoProveedor;
        private TextBox textBoxCuitProveedor;
        private Label labelCuitPorveedor;
        private TextBox textBoxDireccionProveedor;
        private Label labelDireccionPorveedor;
        private Label labelCiudad;
        private Label labelProvincia;
        private Button buttonLimpiarProveedores;
        private Button buttonCrearProveedor;
        private Button buttonSalirAltaProveedor;
        private ComboBox comboBoxProvinciaProveedor;
        private ComboBox comboBoxCiudadProveedor;
    }
}