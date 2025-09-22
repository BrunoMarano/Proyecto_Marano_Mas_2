namespace AvicolaVentas
{
    partial class FLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            PLogin = new Panel();
            BIniciar_sesion = new Button();
            TContraseña = new TextBox();
            TBusuario = new TextBox();
            LTitulo_login = new Label();
            PLogin.SuspendLayout();
            SuspendLayout();
            // 
            // PLogin
            // 
            PLogin.BackColor = Color.Gold;
            PLogin.BorderStyle = BorderStyle.FixedSingle;
            PLogin.Controls.Add(BIniciar_sesion);
            PLogin.Controls.Add(TContraseña);
            PLogin.Controls.Add(TBusuario);
            PLogin.Controls.Add(LTitulo_login);
            PLogin.Location = new Point(123, 48);
            PLogin.Name = "PLogin";
            PLogin.Size = new Size(254, 164);
            PLogin.TabIndex = 3;
            // 
            // BIniciar_sesion
            // 
            BIniciar_sesion.FlatStyle = FlatStyle.Flat;
            BIniciar_sesion.Location = new Point(19, 130);
            BIniciar_sesion.Name = "BIniciar_sesion";
            BIniciar_sesion.Size = new Size(219, 23);
            BIniciar_sesion.TabIndex = 6;
            BIniciar_sesion.Text = "Iniciar Sesion";
            BIniciar_sesion.UseVisualStyleBackColor = true;
            BIniciar_sesion.Click += BIniciar_sesion_Click;
            // 
            // TContraseña
            // 
            TContraseña.Location = new Point(65, 101);
            TContraseña.Name = "TContraseña";
            TContraseña.PasswordChar = '*';
            TContraseña.Size = new Size(132, 23);
            TContraseña.TabIndex = 5;
            TContraseña.Tag = "Contraseña";
            TContraseña.Text = "123";
            TContraseña.TextChanged += TContraseña_TextChanged;
            // 
            // TBusuario
            // 
            TBusuario.Location = new Point(65, 60);
            TBusuario.Name = "TBusuario";
            TBusuario.Size = new Size(132, 23);
            TBusuario.TabIndex = 4;
            TBusuario.Tag = "Usuario";
            TBusuario.Text = "DNI";
            TBusuario.TextChanged += TBusuario_TextChanged;
            // 
            // LTitulo_login
            // 
            LTitulo_login.AutoSize = true;
            LTitulo_login.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTitulo_login.Location = new Point(79, 21);
            LTitulo_login.Name = "LTitulo_login";
            LTitulo_login.Size = new Size(105, 21);
            LTitulo_login.TabIndex = 3;
            LTitulo_login.Text = "Inicie  Sesion";
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(491, 238);
            Controls.Add(PLogin);
            Name = "FLogin";
            Text = "Bienvenido";
            Load += FLogin_Load;
            PLogin.ResumeLayout(false);
            PLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PLogin;
        private TextBox TContraseña;
        private TextBox TBusuario;
        private Label LTitulo_login;
        private Button BIniciar_sesion;
    }
}
