namespace AvicolaVentas
{
    partial class AgregarArticuloVenta
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
            dataGridViewVenta = new DataGridView();
            buttonEliminarArticuloVenta = new Button();
            buttonAgregarArticuloVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVenta).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewVenta
            // 
            dataGridViewVenta.BackgroundColor = Color.Gainsboro;
            dataGridViewVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVenta.GridColor = Color.Gainsboro;
            dataGridViewVenta.Location = new Point(34, 53);
            dataGridViewVenta.Name = "dataGridViewVenta";
            dataGridViewVenta.Size = new Size(646, 338);
            dataGridViewVenta.TabIndex = 0;
            // 
            // buttonEliminarArticuloVenta
            // 
            buttonEliminarArticuloVenta.BackColor = Color.Silver;
            buttonEliminarArticuloVenta.Location = new Point(573, 462);
            buttonEliminarArticuloVenta.Name = "buttonEliminarArticuloVenta";
            buttonEliminarArticuloVenta.Size = new Size(107, 38);
            buttonEliminarArticuloVenta.TabIndex = 1;
            buttonEliminarArticuloVenta.Text = "Eliminar";
            buttonEliminarArticuloVenta.UseVisualStyleBackColor = false;
            // 
            // buttonAgregarArticuloVenta
            // 
            buttonAgregarArticuloVenta.BackColor = Color.Silver;
            buttonAgregarArticuloVenta.Location = new Point(430, 462);
            buttonAgregarArticuloVenta.Name = "buttonAgregarArticuloVenta";
            buttonAgregarArticuloVenta.Size = new Size(107, 38);
            buttonAgregarArticuloVenta.TabIndex = 2;
            buttonAgregarArticuloVenta.Text = "Agregar";
            buttonAgregarArticuloVenta.UseVisualStyleBackColor = false;
            // 
            // NuevaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(704, 522);
            Controls.Add(buttonAgregarArticuloVenta);
            Controls.Add(buttonEliminarArticuloVenta);
            Controls.Add(dataGridViewVenta);
            Name = "NuevaVenta";
            Text = "Agregar Articulo";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewVenta;
        private Button buttonEliminarArticuloVenta;
        private Button buttonAgregarArticuloVenta;
    }
}