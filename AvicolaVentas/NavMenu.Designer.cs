namespace AvicolaVentas
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panelMenu = new Panel();
            panelUsuario = new Panel();
            buttonModificacionUsuariuo = new Button();
            buttonBajaUsuario = new Button();
            buttonAltaUsuario = new Button();
            BUsuario = new Button();
            panelVenta = new Panel();
            buttonMisVentas = new Button();
            buttonEliminarVenta = new Button();
            buttonNuevaVenta = new Button();
            BVenta = new Button();
            panelProductos = new Panel();
            buttonModificacionProducto = new Button();
            buttonBajaProducto = new Button();
            buttonAltaProducto = new Button();
            BProductos = new Button();
            panelProveedores = new Panel();
            buttonModificacionProveedores = new Button();
            buttonBajaProveedores = new Button();
            buttonAltaProveedores = new Button();
            BPorveedores = new Button();
            panelClientes = new Panel();
            buttonModificacionCliente = new Button();
            buttonBajaCliente = new Button();
            buttonAltaCliente = new Button();
            BClientes = new Button();
            label1 = new Label();
            panelLogo = new Panel();
            pcLogo = new PictureBox();
            panelApp = new Panel();
            panelContenedor = new Panel();
            PLogoAvicola = new Panel();
            LMBienvenido = new Label();
            panelMenu.SuspendLayout();
            panelUsuario.SuspendLayout();
            panelVenta.SuspendLayout();
            panelProductos.SuspendLayout();
            panelProveedores.SuspendLayout();
            panelClientes.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcLogo).BeginInit();
            panelApp.SuspendLayout();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.DarkGray;
            panelMenu.Controls.Add(panelUsuario);
            panelMenu.Controls.Add(BUsuario);
            panelMenu.Controls.Add(panelVenta);
            panelMenu.Controls.Add(BVenta);
            panelMenu.Controls.Add(panelProductos);
            panelMenu.Controls.Add(BProductos);
            panelMenu.Controls.Add(panelProveedores);
            panelMenu.Controls.Add(BPorveedores);
            panelMenu.Controls.Add(panelClientes);
            panelMenu.Controls.Add(BClientes);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(214, 561);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // panelUsuario
            // 
            panelUsuario.Controls.Add(buttonModificacionUsuariuo);
            panelUsuario.Controls.Add(buttonBajaUsuario);
            panelUsuario.Controls.Add(buttonAltaUsuario);
            panelUsuario.Dock = DockStyle.Top;
            panelUsuario.Location = new Point(0, 913);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(227, 125);
            panelUsuario.TabIndex = 13;
            // 
            // buttonModificacionUsuariuo
            // 
            buttonModificacionUsuariuo.BackColor = Color.Gray;
            buttonModificacionUsuariuo.Dock = DockStyle.Top;
            buttonModificacionUsuariuo.FlatAppearance.BorderSize = 0;
            buttonModificacionUsuariuo.Font = new Font("Segoe UI", 11.25F);
            buttonModificacionUsuariuo.Location = new Point(0, 80);
            buttonModificacionUsuariuo.Name = "buttonModificacionUsuariuo";
            buttonModificacionUsuariuo.Padding = new Padding(50, 0, 0, 0);
            buttonModificacionUsuariuo.Size = new Size(227, 40);
            buttonModificacionUsuariuo.TabIndex = 7;
            buttonModificacionUsuariuo.Text = "Modificacion";
            buttonModificacionUsuariuo.TextAlign = ContentAlignment.MiddleLeft;
            buttonModificacionUsuariuo.UseVisualStyleBackColor = false;
            buttonModificacionUsuariuo.Click += buttonModificacionUsuariuo_Click;
            // 
            // buttonBajaUsuario
            // 
            buttonBajaUsuario.BackColor = Color.Gray;
            buttonBajaUsuario.Dock = DockStyle.Top;
            buttonBajaUsuario.FlatAppearance.BorderSize = 0;
            buttonBajaUsuario.Font = new Font("Segoe UI", 11.25F);
            buttonBajaUsuario.Location = new Point(0, 40);
            buttonBajaUsuario.Name = "buttonBajaUsuario";
            buttonBajaUsuario.Padding = new Padding(50, 0, 0, 0);
            buttonBajaUsuario.Size = new Size(227, 40);
            buttonBajaUsuario.TabIndex = 6;
            buttonBajaUsuario.Text = "Baja";
            buttonBajaUsuario.TextAlign = ContentAlignment.MiddleLeft;
            buttonBajaUsuario.UseVisualStyleBackColor = false;
            // 
            // buttonAltaUsuario
            // 
            buttonAltaUsuario.BackColor = Color.Gray;
            buttonAltaUsuario.Dock = DockStyle.Top;
            buttonAltaUsuario.FlatAppearance.BorderSize = 0;
            buttonAltaUsuario.Font = new Font("Segoe UI", 11.25F);
            buttonAltaUsuario.Location = new Point(0, 0);
            buttonAltaUsuario.Name = "buttonAltaUsuario";
            buttonAltaUsuario.Padding = new Padding(50, 0, 0, 0);
            buttonAltaUsuario.Size = new Size(227, 40);
            buttonAltaUsuario.TabIndex = 5;
            buttonAltaUsuario.Text = "Alta";
            buttonAltaUsuario.TextAlign = ContentAlignment.MiddleLeft;
            buttonAltaUsuario.UseVisualStyleBackColor = false;
            // 
            // BUsuario
            // 
            BUsuario.BackColor = Color.Gold;
            BUsuario.Dock = DockStyle.Top;
            BUsuario.FlatAppearance.BorderSize = 0;
            BUsuario.FlatStyle = FlatStyle.Flat;
            BUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BUsuario.Location = new Point(0, 856);
            BUsuario.Name = "BUsuario";
            BUsuario.Padding = new Padding(20, 0, 0, 0);
            BUsuario.Size = new Size(227, 57);
            BUsuario.TabIndex = 12;
            BUsuario.Text = "Usuario";
            BUsuario.TextAlign = ContentAlignment.MiddleLeft;
            BUsuario.UseVisualStyleBackColor = false;
            BUsuario.Click += BUsuario_Click_1;
            // 
            // panelVenta
            // 
            panelVenta.Controls.Add(buttonMisVentas);
            panelVenta.Controls.Add(buttonEliminarVenta);
            panelVenta.Controls.Add(buttonNuevaVenta);
            panelVenta.Dock = DockStyle.Top;
            panelVenta.Location = new Point(0, 731);
            panelVenta.Name = "panelVenta";
            panelVenta.Size = new Size(227, 125);
            panelVenta.TabIndex = 11;
            // 
            // buttonMisVentas
            // 
            buttonMisVentas.BackColor = Color.Gray;
            buttonMisVentas.Dock = DockStyle.Top;
            buttonMisVentas.FlatAppearance.BorderSize = 0;
            buttonMisVentas.Font = new Font("Segoe UI", 11.25F);
            buttonMisVentas.Location = new Point(0, 80);
            buttonMisVentas.Name = "buttonMisVentas";
            buttonMisVentas.Padding = new Padding(50, 0, 0, 0);
            buttonMisVentas.Size = new Size(227, 40);
            buttonMisVentas.TabIndex = 7;
            buttonMisVentas.Text = "Mis Ventas";
            buttonMisVentas.TextAlign = ContentAlignment.MiddleLeft;
            buttonMisVentas.UseVisualStyleBackColor = false;
            // 
            // buttonEliminarVenta
            // 
            buttonEliminarVenta.BackColor = Color.Gray;
            buttonEliminarVenta.Dock = DockStyle.Top;
            buttonEliminarVenta.FlatAppearance.BorderSize = 0;
            buttonEliminarVenta.Font = new Font("Segoe UI", 11.25F);
            buttonEliminarVenta.Location = new Point(0, 40);
            buttonEliminarVenta.Name = "buttonEliminarVenta";
            buttonEliminarVenta.Padding = new Padding(50, 0, 0, 0);
            buttonEliminarVenta.Size = new Size(227, 40);
            buttonEliminarVenta.TabIndex = 6;
            buttonEliminarVenta.Text = "Eliminar Venta";
            buttonEliminarVenta.TextAlign = ContentAlignment.MiddleLeft;
            buttonEliminarVenta.UseVisualStyleBackColor = false;
            // 
            // buttonNuevaVenta
            // 
            buttonNuevaVenta.BackColor = Color.Gray;
            buttonNuevaVenta.Dock = DockStyle.Top;
            buttonNuevaVenta.FlatAppearance.BorderSize = 0;
            buttonNuevaVenta.Font = new Font("Segoe UI", 11.25F);
            buttonNuevaVenta.Location = new Point(0, 0);
            buttonNuevaVenta.Name = "buttonNuevaVenta";
            buttonNuevaVenta.Padding = new Padding(50, 0, 0, 0);
            buttonNuevaVenta.Size = new Size(227, 40);
            buttonNuevaVenta.TabIndex = 5;
            buttonNuevaVenta.Text = "Nueva Venta";
            buttonNuevaVenta.TextAlign = ContentAlignment.MiddleLeft;
            buttonNuevaVenta.UseVisualStyleBackColor = false;
            // 
            // BVenta
            // 
            BVenta.BackColor = Color.Gold;
            BVenta.Dock = DockStyle.Top;
            BVenta.FlatAppearance.BorderSize = 0;
            BVenta.FlatStyle = FlatStyle.Flat;
            BVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVenta.Location = new Point(0, 674);
            BVenta.Name = "BVenta";
            BVenta.Padding = new Padding(20, 0, 0, 0);
            BVenta.Size = new Size(227, 57);
            BVenta.TabIndex = 10;
            BVenta.Text = "Ventas";
            BVenta.TextAlign = ContentAlignment.MiddleLeft;
            BVenta.UseVisualStyleBackColor = false;
            BVenta.Click += BVenta_Click_1;
            // 
            // panelProductos
            // 
            panelProductos.Controls.Add(buttonModificacionProducto);
            panelProductos.Controls.Add(buttonBajaProducto);
            panelProductos.Controls.Add(buttonAltaProducto);
            panelProductos.Dock = DockStyle.Top;
            panelProductos.Location = new Point(0, 549);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new Size(227, 125);
            panelProductos.TabIndex = 9;
            // 
            // buttonModificacionProducto
            // 
            buttonModificacionProducto.BackColor = Color.Gray;
            buttonModificacionProducto.Dock = DockStyle.Top;
            buttonModificacionProducto.FlatAppearance.BorderSize = 0;
            buttonModificacionProducto.Font = new Font("Segoe UI", 11.25F);
            buttonModificacionProducto.Location = new Point(0, 80);
            buttonModificacionProducto.Name = "buttonModificacionProducto";
            buttonModificacionProducto.Padding = new Padding(50, 0, 0, 0);
            buttonModificacionProducto.Size = new Size(227, 40);
            buttonModificacionProducto.TabIndex = 7;
            buttonModificacionProducto.Text = "Modificacion";
            buttonModificacionProducto.TextAlign = ContentAlignment.MiddleLeft;
            buttonModificacionProducto.UseVisualStyleBackColor = false;
            // 
            // buttonBajaProducto
            // 
            buttonBajaProducto.BackColor = Color.Gray;
            buttonBajaProducto.Dock = DockStyle.Top;
            buttonBajaProducto.FlatAppearance.BorderSize = 0;
            buttonBajaProducto.Font = new Font("Segoe UI", 11.25F);
            buttonBajaProducto.Location = new Point(0, 40);
            buttonBajaProducto.Name = "buttonBajaProducto";
            buttonBajaProducto.Padding = new Padding(50, 0, 0, 0);
            buttonBajaProducto.Size = new Size(227, 40);
            buttonBajaProducto.TabIndex = 6;
            buttonBajaProducto.Text = "Baja";
            buttonBajaProducto.TextAlign = ContentAlignment.MiddleLeft;
            buttonBajaProducto.UseVisualStyleBackColor = false;
            // 
            // buttonAltaProducto
            // 
            buttonAltaProducto.BackColor = Color.Gray;
            buttonAltaProducto.Dock = DockStyle.Top;
            buttonAltaProducto.FlatAppearance.BorderSize = 0;
            buttonAltaProducto.Font = new Font("Segoe UI", 11.25F);
            buttonAltaProducto.Location = new Point(0, 0);
            buttonAltaProducto.Name = "buttonAltaProducto";
            buttonAltaProducto.Padding = new Padding(50, 0, 0, 0);
            buttonAltaProducto.Size = new Size(227, 40);
            buttonAltaProducto.TabIndex = 5;
            buttonAltaProducto.Text = "Alta";
            buttonAltaProducto.TextAlign = ContentAlignment.MiddleLeft;
            buttonAltaProducto.UseVisualStyleBackColor = false;
            // 
            // BProductos
            // 
            BProductos.BackColor = Color.Gold;
            BProductos.Dock = DockStyle.Top;
            BProductos.FlatAppearance.BorderSize = 0;
            BProductos.FlatStyle = FlatStyle.Flat;
            BProductos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BProductos.Location = new Point(0, 492);
            BProductos.Name = "BProductos";
            BProductos.Padding = new Padding(20, 0, 0, 0);
            BProductos.Size = new Size(227, 57);
            BProductos.TabIndex = 8;
            BProductos.Text = "Productos";
            BProductos.TextAlign = ContentAlignment.MiddleLeft;
            BProductos.UseVisualStyleBackColor = false;
            BProductos.Click += BProductos_Click_1;
            // 
            // panelProveedores
            // 
            panelProveedores.Controls.Add(buttonModificacionProveedores);
            panelProveedores.Controls.Add(buttonBajaProveedores);
            panelProveedores.Controls.Add(buttonAltaProveedores);
            panelProveedores.Dock = DockStyle.Top;
            panelProveedores.Location = new Point(0, 367);
            panelProveedores.Name = "panelProveedores";
            panelProveedores.Size = new Size(227, 125);
            panelProveedores.TabIndex = 7;
            // 
            // buttonModificacionProveedores
            // 
            buttonModificacionProveedores.BackColor = Color.Gray;
            buttonModificacionProveedores.Dock = DockStyle.Top;
            buttonModificacionProveedores.FlatAppearance.BorderSize = 0;
            buttonModificacionProveedores.Font = new Font("Segoe UI", 11.25F);
            buttonModificacionProveedores.Location = new Point(0, 80);
            buttonModificacionProveedores.Name = "buttonModificacionProveedores";
            buttonModificacionProveedores.Padding = new Padding(50, 0, 0, 0);
            buttonModificacionProveedores.Size = new Size(227, 40);
            buttonModificacionProveedores.TabIndex = 7;
            buttonModificacionProveedores.Text = "Modificacion";
            buttonModificacionProveedores.TextAlign = ContentAlignment.MiddleLeft;
            buttonModificacionProveedores.UseVisualStyleBackColor = false;
            // 
            // buttonBajaProveedores
            // 
            buttonBajaProveedores.BackColor = Color.Gray;
            buttonBajaProveedores.Dock = DockStyle.Top;
            buttonBajaProveedores.FlatAppearance.BorderSize = 0;
            buttonBajaProveedores.Font = new Font("Segoe UI", 11.25F);
            buttonBajaProveedores.Location = new Point(0, 40);
            buttonBajaProveedores.Name = "buttonBajaProveedores";
            buttonBajaProveedores.Padding = new Padding(50, 0, 0, 0);
            buttonBajaProveedores.Size = new Size(227, 40);
            buttonBajaProveedores.TabIndex = 6;
            buttonBajaProveedores.Text = "Baja";
            buttonBajaProveedores.TextAlign = ContentAlignment.MiddleLeft;
            buttonBajaProveedores.UseVisualStyleBackColor = false;
            // 
            // buttonAltaProveedores
            // 
            buttonAltaProveedores.BackColor = Color.Gray;
            buttonAltaProveedores.Dock = DockStyle.Top;
            buttonAltaProveedores.FlatAppearance.BorderSize = 0;
            buttonAltaProveedores.Font = new Font("Segoe UI", 11.25F);
            buttonAltaProveedores.Location = new Point(0, 0);
            buttonAltaProveedores.Name = "buttonAltaProveedores";
            buttonAltaProveedores.Padding = new Padding(50, 0, 0, 0);
            buttonAltaProveedores.Size = new Size(227, 40);
            buttonAltaProveedores.TabIndex = 5;
            buttonAltaProveedores.Text = "Alta";
            buttonAltaProveedores.TextAlign = ContentAlignment.MiddleLeft;
            buttonAltaProveedores.UseVisualStyleBackColor = false;
            // 
            // BPorveedores
            // 
            BPorveedores.BackColor = Color.Gold;
            BPorveedores.Dock = DockStyle.Top;
            BPorveedores.FlatAppearance.BorderSize = 0;
            BPorveedores.FlatStyle = FlatStyle.Flat;
            BPorveedores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BPorveedores.Location = new Point(0, 310);
            BPorveedores.Name = "BPorveedores";
            BPorveedores.Padding = new Padding(20, 0, 0, 0);
            BPorveedores.Size = new Size(227, 57);
            BPorveedores.TabIndex = 6;
            BPorveedores.Text = "Proveedores";
            BPorveedores.TextAlign = ContentAlignment.MiddleLeft;
            BPorveedores.UseVisualStyleBackColor = false;
            BPorveedores.Click += BPorveedores_Click;
            // 
            // panelClientes
            // 
            panelClientes.Controls.Add(buttonModificacionCliente);
            panelClientes.Controls.Add(buttonBajaCliente);
            panelClientes.Controls.Add(buttonAltaCliente);
            panelClientes.Dock = DockStyle.Top;
            panelClientes.Location = new Point(0, 185);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(227, 125);
            panelClientes.TabIndex = 5;
            // 
            // buttonModificacionCliente
            // 
            buttonModificacionCliente.BackColor = Color.Gray;
            buttonModificacionCliente.Dock = DockStyle.Top;
            buttonModificacionCliente.FlatAppearance.BorderSize = 0;
            buttonModificacionCliente.Font = new Font("Segoe UI", 11.25F);
            buttonModificacionCliente.Location = new Point(0, 80);
            buttonModificacionCliente.Name = "buttonModificacionCliente";
            buttonModificacionCliente.Padding = new Padding(50, 0, 0, 0);
            buttonModificacionCliente.Size = new Size(227, 40);
            buttonModificacionCliente.TabIndex = 7;
            buttonModificacionCliente.Text = "Modificacion";
            buttonModificacionCliente.TextAlign = ContentAlignment.MiddleLeft;
            buttonModificacionCliente.UseVisualStyleBackColor = false;
            buttonModificacionCliente.Click += buttonModificacionCliente_Click;
            // 
            // buttonBajaCliente
            // 
            buttonBajaCliente.BackColor = Color.Gray;
            buttonBajaCliente.Dock = DockStyle.Top;
            buttonBajaCliente.FlatAppearance.BorderSize = 0;
            buttonBajaCliente.Font = new Font("Segoe UI", 11.25F);
            buttonBajaCliente.Location = new Point(0, 40);
            buttonBajaCliente.Name = "buttonBajaCliente";
            buttonBajaCliente.Padding = new Padding(50, 0, 0, 0);
            buttonBajaCliente.Size = new Size(227, 40);
            buttonBajaCliente.TabIndex = 6;
            buttonBajaCliente.Text = "Baja";
            buttonBajaCliente.TextAlign = ContentAlignment.MiddleLeft;
            buttonBajaCliente.UseVisualStyleBackColor = false;
            // 
            // buttonAltaCliente
            // 
            buttonAltaCliente.BackColor = Color.Gray;
            buttonAltaCliente.Dock = DockStyle.Top;
            buttonAltaCliente.FlatAppearance.BorderSize = 0;
            buttonAltaCliente.Font = new Font("Segoe UI", 11.25F);
            buttonAltaCliente.Location = new Point(0, 0);
            buttonAltaCliente.Name = "buttonAltaCliente";
            buttonAltaCliente.Padding = new Padding(50, 0, 0, 0);
            buttonAltaCliente.Size = new Size(227, 40);
            buttonAltaCliente.TabIndex = 5;
            buttonAltaCliente.Text = "Alta";
            buttonAltaCliente.TextAlign = ContentAlignment.MiddleLeft;
            buttonAltaCliente.UseVisualStyleBackColor = false;
            buttonAltaCliente.Click += buttonAltaCliente_Click_1;
            // 
            // BClientes
            // 
            BClientes.BackColor = Color.Gold;
            BClientes.Dock = DockStyle.Top;
            BClientes.FlatAppearance.BorderSize = 0;
            BClientes.FlatStyle = FlatStyle.Flat;
            BClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BClientes.Location = new Point(0, 128);
            BClientes.Name = "BClientes";
            BClientes.Padding = new Padding(20, 0, 0, 0);
            BClientes.Size = new Size(227, 57);
            BClientes.TabIndex = 2;
            BClientes.Text = "Clientes";
            BClientes.TextAlign = ContentAlignment.MiddleLeft;
            BClientes.UseVisualStyleBackColor = false;
            BClientes.Click += BClientes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(-17, 103);
            label1.Name = "label1";
            label1.Size = new Size(244, 25);
            label1.TabIndex = 0;
            label1.Text = "_____________________________";
            label1.Click += label1_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pcLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(227, 128);
            panelLogo.TabIndex = 0;
            // 
            // pcLogo
            // 
            pcLogo.Image = Properties.Resources.logoAvicola;
            pcLogo.Location = new Point(0, -3);
            pcLogo.Name = "pcLogo";
            pcLogo.Size = new Size(261, 128);
            pcLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcLogo.TabIndex = 0;
            pcLogo.TabStop = false;
            pcLogo.Click += pcLogo_Click;
            // 
            // panelApp
            // 
            panelApp.Controls.Add(panelContenedor);
            panelApp.Dock = DockStyle.Fill;
            panelApp.Location = new Point(214, 0);
            panelApp.Name = "panelApp";
            panelApp.Size = new Size(720, 561);
            panelApp.TabIndex = 1;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Gainsboro;
            panelContenedor.BackgroundImage = Properties.Resources.Fondo;
            panelContenedor.Controls.Add(PLogoAvicola);
            panelContenedor.Controls.Add(LMBienvenido);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(720, 561);
            panelContenedor.TabIndex = 2;
            // 
            // PLogoAvicola
            // 
            PLogoAvicola.AutoSize = true;
            PLogoAvicola.BackColor = Color.Transparent;
            PLogoAvicola.BackgroundImage = (Image)resources.GetObject("PLogoAvicola.BackgroundImage");
            PLogoAvicola.BorderStyle = BorderStyle.FixedSingle;
            PLogoAvicola.Location = new Point(221, 181);
            PLogoAvicola.Name = "PLogoAvicola";
            PLogoAvicola.Size = new Size(202, 205);
            PLogoAvicola.TabIndex = 4;
            // 
            // LMBienvenido
            // 
            LMBienvenido.AutoSize = true;
            LMBienvenido.BackColor = Color.Transparent;
            LMBienvenido.Font = new Font("Constantia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LMBienvenido.ForeColor = SystemColors.ControlText;
            LMBienvenido.Location = new Point(161, 99);
            LMBienvenido.Name = "LMBienvenido";
            LMBienvenido.Size = new Size(335, 59);
            LMBienvenido.TabIndex = 3;
            LMBienvenido.Text = "BIENVENIDO";
            LMBienvenido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 561);
            Controls.Add(panelApp);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(950, 600);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelUsuario.ResumeLayout(false);
            panelVenta.ResumeLayout(false);
            panelProductos.ResumeLayout(false);
            panelProveedores.ResumeLayout(false);
            panelClientes.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcLogo).EndInit();
            panelApp.ResumeLayout(false);
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private PictureBox pcLogo;
        private Panel panelApp;
        private Label label1;
        private Button BClientes;
        private Panel panelContenedor;
        private Panel PLogoAvicola;
        private Label LMBienvenido;
        private Panel panelClientes;
        private Button buttonModificacionCliente;
        private Button buttonBajaCliente;
        private Button buttonAltaCliente;
        private Button BProductos;
        private Panel panelProveedores;
        private Button buttonModificacionProveedores;
        private Button buttonBajaProveedores;
        private Button buttonAltaProveedores;
        private Button BPorveedores;
        private Panel panelProductos;
        private Button buttonModificacionProducto;
        private Button buttonBajaProducto;
        private Button buttonAltaProducto;
        private Panel panelUsuario;
        private Button buttonModificacionUsuariuo;
        private Button buttonBajaUsuario;
        private Button buttonAltaUsuario;
        private Button BUsuario;
        private Panel panelVenta;
        private Button buttonMisVentas;
        private Button buttonEliminarVenta;
        private Button buttonNuevaVenta;
        private Button BVenta;
    }
}