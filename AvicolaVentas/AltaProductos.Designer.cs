namespace AvicolaVentas
{
    partial class FAltaProductos
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
            // 
            // lDescripciónProd
            // 
            lDescripciónProd.AutoSize = true;
            lDescripciónProd.BackColor = Color.Transparent;
            lDescripciónProd.Font = new Font("Segoe UI", 12F);
            lDescripciónProd.Location = new Point(80, 122);
            lDescripciónProd.Name = "lDescripciónProd";
            lDescripciónProd.Size = new Size(76, 21);
            lDescripciónProd.TabIndex = 18;
            lDescripciónProd.Text = "Producto:";
            // 
            // lPrecioProd
            // 
            lPrecioProd.AutoSize = true;
            lPrecioProd.BackColor = Color.Transparent;
            lPrecioProd.Font = new Font("Segoe UI", 12F);
            lPrecioProd.Location = new Point(80, 216);
            lPrecioProd.Name = "lPrecioProd";
            lPrecioProd.Size = new Size(56, 21);
            lPrecioProd.TabIndex = 17;
            lPrecioProd.Text = "Precio:";
            // 
            // lStockProd
            // 
            lStockProd.AutoSize = true;
            lStockProd.BackColor = Color.Transparent;
            lStockProd.Font = new Font("Segoe UI", 12F);
            lStockProd.Location = new Point(80, 246);
            lStockProd.Name = "lStockProd";
            lStockProd.Size = new Size(50, 21);
            lStockProd.TabIndex = 16;
            lStockProd.Text = "Stock:";
            // 
            // lCategoriaProd
            // 
            lCategoriaProd.AutoSize = true;
            lCategoriaProd.BackColor = Color.Transparent;
            lCategoriaProd.Font = new Font("Segoe UI", 12F);
            lCategoriaProd.Location = new Point(80, 185);
            lCategoriaProd.Name = "lCategoriaProd";
            lCategoriaProd.Size = new Size(80, 21);
            lCategoriaProd.TabIndex = 15;
            lCategoriaProd.Text = "Categoria:";
            // 
            // lFechaAltaProd
            // 
            lFechaAltaProd.AutoSize = true;
            lFechaAltaProd.BackColor = Color.Transparent;
            lFechaAltaProd.Font = new Font("Segoe UI", 12F);
            lFechaAltaProd.Location = new Point(80, 280);
            lFechaAltaProd.Name = "lFechaAltaProd";
            lFechaAltaProd.Size = new Size(103, 21);
            lFechaAltaProd.TabIndex = 14;
            lFechaAltaProd.Text = "Fecha de alta:";
            // 
            // lEstadoProd
            // 
            lEstadoProd.AutoSize = true;
            lEstadoProd.BackColor = Color.Transparent;
            lEstadoProd.Font = new Font("Segoe UI", 12F);
            lEstadoProd.Location = new Point(80, 315);
            lEstadoProd.Name = "lEstadoProd";
            lEstadoProd.Size = new Size(59, 21);
            lEstadoProd.TabIndex = 13;
            lEstadoProd.Text = "Estado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(32, 77);
            label1.Name = "label1";
            label1.Size = new Size(181, 28);
            label1.TabIndex = 12;
            label1.Text = "Alta de Productos";
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(180, 120);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(195, 23);
            cbProducto.TabIndex = 7;
            // 
            // lDescripcionProd
            // 
            lDescripcionProd.AutoSize = true;
            lDescripcionProd.BackColor = Color.Transparent;
            lDescripcionProd.Font = new Font("Segoe UI", 12F);
            lDescripcionProd.Location = new Point(80, 153);
            lDescripcionProd.Name = "lDescripcionProd";
            lDescripcionProd.Size = new Size(94, 21);
            lDescripcionProd.TabIndex = 11;
            lDescripcionProd.Text = "Descripción:";
            // 
            // cbCategoriaProd
            // 
            cbCategoriaProd.FormattingEnabled = true;
            cbCategoriaProd.Location = new Point(180, 183);
            cbCategoriaProd.Name = "cbCategoriaProd";
            cbCategoriaProd.Size = new Size(195, 23);
            cbCategoriaProd.TabIndex = 9;
            // 
            // tDescripcionProd
            // 
            tDescripcionProd.Location = new Point(180, 152);
            tDescripcionProd.Name = "tDescripcionProd";
            tDescripcionProd.Size = new Size(195, 23);
            tDescripcionProd.TabIndex = 10;
            tDescripcionProd.TextChanged += tDescripcionProd_TextChanged;
            // 
            // tPrecioProd
            // 
            tPrecioProd.Location = new Point(180, 214);
            tPrecioProd.Name = "tPrecioProd";
            tPrecioProd.Size = new Size(195, 23);
            tPrecioProd.TabIndex = 6;
            // 
            // tStockProd
            // 
            tStockProd.Location = new Point(180, 245);
            tStockProd.Name = "tStockProd";
            tStockProd.Size = new Size(195, 23);
            tStockProd.TabIndex = 5;
            // 
            // dtpFechaAltaProd
            // 
            dtpFechaAltaProd.Format = DateTimePickerFormat.Short;
            dtpFechaAltaProd.Location = new Point(189, 278);
            dtpFechaAltaProd.Name = "dtpFechaAltaProd";
            dtpFechaAltaProd.Size = new Size(186, 23);
            dtpFechaAltaProd.TabIndex = 4;
            dtpFechaAltaProd.Visible = false;
            // 
            // cActivoProd
            // 
            cActivoProd.AutoSize = true;
            cActivoProd.BackColor = Color.Transparent;
            cActivoProd.Location = new Point(180, 317);
            cActivoProd.Name = "cActivoProd";
            cActivoProd.Size = new Size(124, 19);
            cActivoProd.TabIndex = 3;
            cActivoProd.Text = "Activo/ Disponible";
            cActivoProd.UseVisualStyleBackColor = false;
            // 
            // pImagenProd
            // 
            pImagenProd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pImagenProd.BackColor = Color.Transparent;
            pImagenProd.BackgroundImage = Properties.Resources.logoAvicola;
            pImagenProd.BorderStyle = BorderStyle.FixedSingle;
            pImagenProd.Location = new Point(466, 105);
            pImagenProd.Name = "pImagenProd";
            pImagenProd.Size = new Size(212, 209);
            pImagenProd.SizeMode = PictureBoxSizeMode.Zoom;
            pImagenProd.TabIndex = 2;
            pImagenProd.TabStop = false;
            // 
            // bGuardarProd
            // 
            bGuardarProd.BackColor = SystemColors.ControlDark;
            bGuardarProd.Font = new Font("Segoe UI", 12F);
            bGuardarProd.Location = new Point(172, 381);
            bGuardarProd.Name = "bGuardarProd";
            bGuardarProd.Size = new Size(130, 30);
            bGuardarProd.TabIndex = 1;
            bGuardarProd.Text = "Guardar";
            bGuardarProd.UseVisualStyleBackColor = false;
            // 
            // bLimpiarProd
            // 
            bLimpiarProd.BackColor = SystemColors.ControlDark;
            bLimpiarProd.Font = new Font("Segoe UI", 12F);
            bLimpiarProd.Location = new Point(328, 381);
            bLimpiarProd.Name = "bLimpiarProd";
            bLimpiarProd.Size = new Size(130, 30);
            bLimpiarProd.TabIndex = 0;
            bLimpiarProd.Text = "Limpiar";
            bLimpiarProd.UseVisualStyleBackColor = false;
            // 
            // FAltaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(704, 522);
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
            Name = "FAltaProductos";
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
