namespace AvicolaVentas
{
    partial class Baja_ModificarUsuario
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
            BModificarUsuario = new Button();
            BBajaUsuario = new Button();
            DGPanelCliente = new DataGridView();
            LListadoUsuarios = new Label();
            ((System.ComponentModel.ISupportInitialize)DGPanelCliente).BeginInit();
            SuspendLayout();
            // 
            // BModificarUsuario
            // 
            BModificarUsuario.BackColor = Color.Silver;
            BModificarUsuario.Location = new Point(500, 463);
            BModificarUsuario.Name = "BModificarUsuario";
            BModificarUsuario.Size = new Size(107, 38);
            BModificarUsuario.TabIndex = 6;
            BModificarUsuario.Text = "Modificacion";
            BModificarUsuario.UseVisualStyleBackColor = false;
            BModificarUsuario.Click += BModificarUsuario_Click;
            // 
            // BBajaUsuario
            // 
            BBajaUsuario.BackColor = Color.Silver;
            BBajaUsuario.Location = new Point(368, 463);
            BBajaUsuario.Name = "BBajaUsuario";
            BBajaUsuario.Size = new Size(107, 38);
            BBajaUsuario.TabIndex = 5;
            BBajaUsuario.Text = "Baja";
            BBajaUsuario.UseVisualStyleBackColor = false;
            // 
            // DGPanelCliente
            // 
            DGPanelCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGPanelCliente.BackgroundColor = Color.Gainsboro;
            DGPanelCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGPanelCliente.Location = new Point(86, 47);
            DGPanelCliente.Name = "DGPanelCliente";
            DGPanelCliente.Size = new Size(550, 410);
            DGPanelCliente.TabIndex = 4;
            // 
            // LListadoUsuarios
            // 
            LListadoUsuarios.AutoSize = true;
            LListadoUsuarios.BackColor = Color.Transparent;
            LListadoUsuarios.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline);
            LListadoUsuarios.Location = new Point(59, 11);
            LListadoUsuarios.Name = "LListadoUsuarios";
            LListadoUsuarios.Size = new Size(194, 28);
            LListadoUsuarios.TabIndex = 7;
            LListadoUsuarios.Text = "Listado de usuarios";
            // 
            // Baja_ModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(704, 522);
            Controls.Add(LListadoUsuarios);
            Controls.Add(BModificarUsuario);
            Controls.Add(BBajaUsuario);
            Controls.Add(DGPanelCliente);
            Name = "Baja_ModificarUsuario";
            Text = "Baja_ModificarUsuario";
            ((System.ComponentModel.ISupportInitialize)DGPanelCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BModificarUsuario;
        private Button BBajaUsuario;
        private DataGridView DGPanelCliente;
        private Label LListadoUsuarios;
    }
}