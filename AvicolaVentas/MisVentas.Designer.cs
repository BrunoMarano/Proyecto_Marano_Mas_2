namespace AvicolaVentas
{
    partial class FMisVentas
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
            LMisVentas = new Label();
            DGVMisVentas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVMisVentas).BeginInit();
            SuspendLayout();
            // 
            // LMisVentas
            // 
            LMisVentas.AutoSize = true;
            LMisVentas.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline);
            LMisVentas.Location = new Point(83, 28);
            LMisVentas.Name = "LMisVentas";
            LMisVentas.Size = new Size(115, 28);
            LMisVentas.TabIndex = 0;
            LMisVentas.Text = "Mis Ventas";
            // 
            // DGVMisVentas
            // 
            DGVMisVentas.BackgroundColor = Color.Silver;
            DGVMisVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMisVentas.Location = new Point(43, 70);
            DGVMisVentas.Name = "DGVMisVentas";
            DGVMisVentas.Size = new Size(614, 315);
            DGVMisVentas.TabIndex = 1;
            // 
            // FMisVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(704, 522);
            Controls.Add(DGVMisVentas);
            Controls.Add(LMisVentas);
            Name = "FMisVentas";
            Text = "MisVentas";
            ((System.ComponentModel.ISupportInitialize)DGVMisVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LMisVentas;
        private DataGridView DGVMisVentas;
    }
}