namespace AvicolaVentas
{
    partial class FRespaldo
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
            button1 = new Button();
            saveFileDialog = new SaveFileDialog();
            LRespaldo = new Label();
            LFechaRespaldo = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(344, 184);
            button1.Name = "button1";
            button1.Size = new Size(143, 69);
            button1.TabIndex = 0;
            button1.Text = "Generar Respaldo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LRespaldo
            // 
            LRespaldo.AutoSize = true;
            LRespaldo.BackColor = Color.Transparent;
            LRespaldo.Location = new Point(252, 284);
            LRespaldo.Name = "LRespaldo";
            LRespaldo.Size = new Size(156, 15);
            LRespaldo.TabIndex = 1;
            LRespaldo.Text = "Ultimo respaldo realizado el:";
            // 
            // LFechaRespaldo
            // 
            LFechaRespaldo.AutoSize = true;
            LFechaRespaldo.Location = new Point(414, 284);
            LFechaRespaldo.Name = "LFechaRespaldo";
            LFechaRespaldo.Size = new Size(16, 15);
            LFechaRespaldo.TabIndex = 2;
            LFechaRespaldo.Text = "...";
            
            // 
            // FRespaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(864, 502);
            Controls.Add(LFechaRespaldo);
            Controls.Add(LRespaldo);
            Controls.Add(button1);
            Name = "FRespaldo";
            Text = "Respaldo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private SaveFileDialog saveFileDialog;
        private Label LRespaldo;
        private Label LFechaRespaldo;
    }
}