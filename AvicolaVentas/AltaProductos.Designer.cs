namespace AvicolaVentas
{
    partial class AltaProductos
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
            lDescripciónProd = new Label();
            lPrecioProd = new Label();
            lStockProd = new Label();
            lCategoriaProd = new Label();
            lFechaAltaProd = new Label();
            lEstadoProd = new Label();
            label1 = new Label();
            cbProducto = new ComboBox();
            lDescripcionProd = new Label();
            cbCategoriaProd = new ComboBox();
            tDescripcionProd = new TextBox();
            tPrecioProd = new TextBox();
            tStockProd = new TextBox();
            dtpFechaAltaProd = new DateTimePicker();
            cActivoProd = new CheckBox();
            pImagenProd = new PictureBox();
            bGuardarProd = new Button();
            bLimpiarProd = new Button();
            ((System.ComponentModel.ISupportInitialize)pImagenProd).BeginInit();
            SuspendLayout();

            // Labels
            lDescripciónProd.AutoSize = true;
            lDescripciónProd.BackColor = System.Drawing.Color.Transparent;
            lDescripciónProd.Font = new System.Drawing.Font("Segoe UI", 12F);
            lDescripciónProd.Location = new System.Drawing.Point(74, 54);
            lDescripciónProd.Name = "lDescripciónProd";
            lDescripciónProd.Size = new System.Drawing.Size(76, 21);
            lDescripciónProd.Text = "Producto:";

            lPrecioProd.AutoSize = true;
            lPrecioProd.BackColor = System.Drawing.Color.Transparent;
            lPrecioProd.Font = new System.Drawing.Font("Segoe UI", 12F);
            lPrecioProd.Location = new System.Drawing.Point(74, 148);
            lPrecioProd.Name = "lPrecioProd";
            lPrecioProd.Size = new System.Drawing.Size(56, 21);
            lPrecioProd.Text = "Precio:";

            lStockProd.AutoSize = true;
            lStockProd.BackColor = System.Drawing.Color.Transparent;
            lStockProd.Font = new System.Drawing.Font("Segoe UI", 12F);
            lStockProd.Location = new System.Drawing.Point(74, 178);
            lStockProd.Name = "lStockProd";
            lStockProd.Size = new System.Drawing.Size(50, 21);
            lStockProd.Text = "Stock:";

            lCategoriaProd.AutoSize = true;
            lCategoriaProd.BackColor = System.Drawing.Color.Transparent;
            lCategoriaProd.Font = new System.Drawing.Font("Segoe UI", 12F);
            lCategoriaProd.Location = new System.Drawing.Point(74, 117);
            lCategoriaProd.Name = "lCategoriaProd";
            lCategoriaProd.Size = new System.Drawing.Size(80, 21);
            lCategoriaProd.Text = "Categoria:";

            lFechaAltaProd.AutoSize = true;
            lFechaAltaProd.BackColor = System.Drawing.Color.Transparent;
            lFechaAltaProd.Font = new System.Drawing.Font("Segoe UI", 12F);
            lFechaAltaProd.Location = new System.Drawing.Point(74, 212);
            lFechaAltaProd.Name = "lFechaAltaProd";
            lFechaAltaProd.Size = new System.Drawing.Size(103, 21);
            lFechaAltaProd.Text = "Fecha de alta:";

            lEstadoProd.AutoSize = true;
            lEstadoProd.BackColor = System.Drawing.Color.Transparent;
            lEstadoProd.Font = new System.Drawing.Font("Segoe UI", 12F);
            lEstadoProd.Location = new System.Drawing.Point(74, 247);
            lEstadoProd.Name = "lEstadoProd";
            lEstadoProd.Size = new System.Drawing.Size(59, 21);
            lEstadoProd.Text = "Estado:";

            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            label1.Location = new System.Drawing.Point(26, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(181, 28);
            label1.Text = "Alta de Productos";

            // ComboBox Producto
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new System.Drawing.Point(174, 52);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new System.Drawing.Size(195, 23);
            cbProducto.TabIndex = 7;

            // Label Descripción
            lDescripcionProd.AutoSize = true;
            lDescripcionProd.BackColor = System.Drawing.Color.Transparent;
            lDescripcionProd.Font = new System.Drawing.Font("Segoe UI", 12F);
            lDescripcionProd.Location = new System.Drawing.Point(74, 85);
            lDescripcionProd.Name = "lDescripcionProd";
            lDescripcionProd.Size = new System.Drawing.Size(94, 21);
            lDescripcionProd.Text = "Descripción:";

            // ComboBox Categoría
            cbCategoriaProd.FormattingEnabled = true;
            cbCategoriaProd.Location = new System.Drawing.Point(174, 115);
            cbCategoriaProd.Name = "cbCategoriaProd";
            cbCategoriaProd.Size = new System.Drawing.Size(195, 23);
            cbCategoriaProd.TabIndex = 9;

            // TextBox Descripción
            tDescripcionProd.Location = new System.Drawing.Point(174, 84);
            tDescripcionProd.Name = "tDescripcionProd";
            tDescripcionProd.Size = new System.Drawing.Size(195, 23);
            tDescripcionProd.TabIndex = 10;
            tDescripcionProd.TextChanged += tDescripcionProd_TextChanged;

            // TextBoxes Precio y Stock
            tPrecioProd.Location = new System.Drawing.Point(174, 146);
            tPrecioProd.Name = "tPrecioProd";
            tPrecioProd.Size = new System.Drawing.Size(195, 23);

            tStockProd.Location = new System.Drawing.Point(174, 177);
            tStockProd.Name = "tStockProd";
            tStockProd.Size = new System.Drawing.Size(195, 23);

            // DateTimePicker
            dtpFechaAltaProd.Format = DateTimePickerFormat.Short;
            dtpFechaAltaProd.Location = new System.Drawing.Point(183, 210);
            dtpFechaAltaProd.Size = new System.Drawing.Size(186, 23);
            dtpFechaAltaProd.Visible = false;

            // CheckBox Estado
            cActivoProd.AutoSize = true;
            cActivoProd.BackColor = System.Drawing.Color.Transparent;
            cActivoProd.Location = new System.Drawing.Point(174, 249);
            cActivoProd.Size = new System.Drawing.Size(124, 19);
            cActivoProd.Text = "Activo/ Disponible";
            cActivoProd.UseVisualStyleBackColor = false;

            // PictureBox Imagen
            pImagenProd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pImagenProd.BackgroundImage = Properties.Resources.logoAvicola;
            pImagenProd.BorderStyle = BorderStyle.FixedSingle;
            pImagenProd.Location = new System.Drawing.Point(469, 52);
            pImagenProd.Name = "pImagenProd";
            pImagenProd.Size = new System.Drawing.Size(140, 148);
            pImagenProd.SizeMode = PictureBoxSizeMode.Zoom; // Centrado y escalado
            pImagenProd.TabStop = false;

            // Botones
            bGuardarProd.BackColor = SystemColors.ControlDark;
            bGuardarProd.Font = new System.Drawing.Font("Segoe UI", 12F);
            bGuardarProd.Location = new System.Drawing.Point(166, 313);
            bGuardarProd.Size = new System.Drawing.Size(130, 30);
            bGuardarProd.Text = "Guardar";

            bLimpiarProd.BackColor = SystemColors.ControlDark;
            bLimpiarProd.Font = new System.Drawing.Font("Segoe UI", 12F);
            bLimpiarProd.Location = new System.Drawing.Point(322, 313);
            bLimpiarProd.Size = new System.Drawing.Size(130, 30);
            bLimpiarProd.Text = "Limpiar";

            // Formulario
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new System.Drawing.Size(704, 522);
            Controls.Add(bLimpiarProd);
            Controls.Add(bGuardarProd);
            Controls.Add(pImagenProd);
            Controls.Add(cActivoProd);
            Controls.Add(dtpFechaAltaProd);
            Controls.Add(tStockProd);
            Controls.Add(tPrecioProd);
            Controls.Add(tDescripcionProd);
            Controls.Add(cbCategoriaProd);
            Controls.Add(lDescripcionProd);
            Controls.Add(cbProducto);
            Controls.Add(label1);
            Controls.Add(lEstadoProd);
            Controls.Add(lFechaAltaProd);
            Controls.Add(lCategoriaProd);
            Controls.Add(lStockProd);
            Controls.Add(lPrecioProd);
            Controls.Add(lDescripciónProd);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AltaProductos";
            Text = "Alta de Producto";
            Load += AltaProductos_Load;

            ((System.ComponentModel.ISupportInitialize)pImagenProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private void AltaProductos_Load(object sender, EventArgs e)
        {
            // Inicializaciones al cargar el formulario
        }

        
        #endregion

        private Label lDescripciónProd;
        private Label lPrecioProd;
        private Label lStockProd;
        private Label lCategoriaProd;
        private Label lFechaAltaProd;
        private Label lEstadoProd;
        private Label label1;
        private ComboBox cbProducto;
        private Label lDescripcionProd;
        private ComboBox cbCategoriaProd;
        private TextBox tDescripcionProd;
        private TextBox tPrecioProd;
        private TextBox tStockProd;
        private DateTimePicker dtpFechaAltaProd;
        private CheckBox cActivoProd;
        private PictureBox pImagenProd;
        private Button bGuardarProd;
        private Button bLimpiarProd;
    }
}
