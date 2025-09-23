namespace AvicolaVentas
{
    partial class FormClienteBajaModificacion
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
            dataGridViewClientes = new DataGridView();
            buttonBaja = new Button();
            buttonModificacionCliente = new Button();
            buttonSalirUsuarioBaja = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClientes.BackgroundColor = Color.Gainsboro;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(34, 53);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.Size = new Size(646, 338);
            dataGridViewClientes.TabIndex = 0;
            // 
            // buttonBaja
            // 
            buttonBaja.BackColor = Color.Silver;
            buttonBaja.Location = new Point(430, 462);
            buttonBaja.Name = "buttonBaja";
            buttonBaja.Size = new Size(107, 38);
            buttonBaja.TabIndex = 2;
            buttonBaja.Text = "Baja";
            buttonBaja.UseVisualStyleBackColor = false;
            // 
            // buttonModificacionCliente
            // 
            buttonModificacionCliente.BackColor = Color.Silver;
            buttonModificacionCliente.Location = new Point(573, 462);
            buttonModificacionCliente.Name = "buttonModificacionCliente";
            buttonModificacionCliente.Size = new Size(107, 38);
            buttonModificacionCliente.TabIndex = 3;
            buttonModificacionCliente.Text = "Modificacion";
            buttonModificacionCliente.UseVisualStyleBackColor = false;
            buttonModificacionCliente.Click += buttonModificacionCliente_Click;
            // 
            // buttonSalirUsuarioBaja
            // 
            buttonSalirUsuarioBaja.Location = new Point(34, 12);
            buttonSalirUsuarioBaja.Name = "buttonSalirUsuarioBaja";
            buttonSalirUsuarioBaja.Size = new Size(43, 23);
            buttonSalirUsuarioBaja.TabIndex = 1;
            buttonSalirUsuarioBaja.Text = "X";
            buttonSalirUsuarioBaja.UseVisualStyleBackColor = true;
            buttonSalirUsuarioBaja.Click += buttonSalirUsuarioBaja_Click;
            // 
            // FormClienteBajaModificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(704, 522);
            Controls.Add(buttonModificacionCliente);
            Controls.Add(buttonBaja);
            Controls.Add(buttonSalirUsuarioBaja);
            Controls.Add(dataGridViewClientes);
            MinimumSize = new Size(720, 561);
            Name = "FormClienteBajaModificacion";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewClientes;
        private Button buttonBaja;
        private Button buttonModificacionCliente;
        private Button buttonSalirUsuarioBaja;
    }
}