namespace AvicolaVentas
{
    partial class FormNuevaVenta
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
            dataGridViewArticulosAgregados = new DataGridView();
            buttonAgregarArticuloVenta = new Button();
            buttonEliminarArticuloVenta = new Button();
            labelAgregarArticulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArticulosAgregados).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewArticulosAgregados
            // 
            dataGridViewArticulosAgregados.BackgroundColor = Color.Silver;
            dataGridViewArticulosAgregados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArticulosAgregados.Location = new Point(39, 179);
            dataGridViewArticulosAgregados.Name = "dataGridViewArticulosAgregados";
            dataGridViewArticulosAgregados.Size = new Size(614, 315);
            dataGridViewArticulosAgregados.TabIndex = 0;
            // 
            // buttonAgregarArticuloVenta
            // 
            buttonAgregarArticuloVenta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAgregarArticuloVenta.Location = new Point(58, 137);
            buttonAgregarArticuloVenta.Name = "buttonAgregarArticuloVenta";
            buttonAgregarArticuloVenta.Size = new Size(35, 36);
            buttonAgregarArticuloVenta.TabIndex = 1;
            buttonAgregarArticuloVenta.Text = "+";
            buttonAgregarArticuloVenta.UseVisualStyleBackColor = true;
            buttonAgregarArticuloVenta.Click += this.buttonAgregarArticuloVenta_Click;
            // 
            // buttonEliminarArticuloVenta
            // 
            buttonEliminarArticuloVenta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEliminarArticuloVenta.Location = new Point(129, 137);
            buttonEliminarArticuloVenta.Name = "buttonEliminarArticuloVenta";
            buttonEliminarArticuloVenta.Size = new Size(35, 36);
            buttonEliminarArticuloVenta.TabIndex = 2;
            buttonEliminarArticuloVenta.Text = "-";
            buttonEliminarArticuloVenta.UseVisualStyleBackColor = true;
            // 
            // labelAgregarArticulo
            // 
            labelAgregarArticulo.AutoSize = true;
            labelAgregarArticulo.BackColor = Color.Transparent;
            labelAgregarArticulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAgregarArticulo.Location = new Point(225, 55);
            labelAgregarArticulo.Name = "labelAgregarArticulo";
            labelAgregarArticulo.Size = new Size(227, 40);
            labelAgregarArticulo.TabIndex = 3;
            labelAgregarArticulo.Text = "Agregar Articulo";
            // 
            // FormNuevaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(704, 522);
            Controls.Add(labelAgregarArticulo);
            Controls.Add(buttonEliminarArticuloVenta);
            Controls.Add(buttonAgregarArticuloVenta);
            Controls.Add(dataGridViewArticulosAgregados);
            Name = "FormNuevaVenta";
            Text = "NuevaVenta";
            ((System.ComponentModel.ISupportInitialize)dataGridViewArticulosAgregados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewArticulosAgregados;
        private Button buttonAgregarArticuloVenta;
        private Button buttonEliminarArticuloVenta;
        private Label labelAgregarArticulo;
    }
}