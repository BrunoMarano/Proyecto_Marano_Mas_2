namespace AvicolaVentas
{
    partial class FBajaModificacionProducto
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
            dataGridViewProducto = new DataGridView();
            buttonBajaProducto = new Button();
            buttonModificacionProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducto
            // 
            dataGridViewProducto.BackgroundColor = Color.Silver;
            dataGridViewProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducto.Location = new Point(34, 53);
            dataGridViewProducto.Name = "dataGridViewProducto";
            dataGridViewProducto.Size = new Size(646, 338);
            dataGridViewProducto.TabIndex = 0;
            // 
            // buttonBajaProducto
            // 
            buttonBajaProducto.BackColor = Color.Gainsboro;
            buttonBajaProducto.Location = new Point(430, 462);
            buttonBajaProducto.Name = "buttonBajaProducto";
            buttonBajaProducto.Size = new Size(107, 38);
            buttonBajaProducto.TabIndex = 1;
            buttonBajaProducto.Text = "Eliminar";
            buttonBajaProducto.UseVisualStyleBackColor = false;
            // 
            // buttonModificacionProducto
            // 
            buttonModificacionProducto.BackColor = Color.Gainsboro;
            buttonModificacionProducto.Location = new Point(562, 462);
            buttonModificacionProducto.Name = "buttonModificacionProducto";
            buttonModificacionProducto.Size = new Size(107, 38);
            buttonModificacionProducto.TabIndex = 2;
            buttonModificacionProducto.Text = "Modificar";
            buttonModificacionProducto.UseVisualStyleBackColor = false;
            buttonModificacionProducto.Click += buttonModificacionProducto_Click;
            // 
            // FBajaModificacionProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(704, 522);
            Controls.Add(buttonModificacionProducto);
            Controls.Add(buttonBajaProducto);
            Controls.Add(dataGridViewProducto);
            Name = "FBajaModificacionProducto";
            Text = "Baja-Modificacion Producto";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProducto;
        private Button buttonBajaProducto;
        private Button buttonModificacionProducto;
    }
}