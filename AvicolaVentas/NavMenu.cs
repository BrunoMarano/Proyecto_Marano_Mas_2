using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace AvicolaVentas
{
    public partial class FormMenu : Form
    {
        private int? IDUsuario;
        private string NombreUsuario;
        private int? IdRol;
        private int? DniUsuario;


        public FormMenu(int? id_usuario, string nombre, int? idRol, int? Dni)
        {
            InitializeComponent();

            IDUsuario = id_usuario;
            NombreUsuario = nombre;
            IdRol = idRol;
            DniUsuario = Dni;

            labelUsuarioBienvenido.Text = NombreUsuario;

            switch (IdRol)
            {
                case 1: // ADMIN
                    LModificarRol.Text = "Administrador";
                    LModificarUsuario.Text = NombreUsuario;
                    break;
                case 2: // GERENTE
                    LModificarRol.Text = "Gerente";
                    LModificarUsuario.Text = NombreUsuario;

                    break;
                case 3: // VENDEDOR
                    LModificarRol.Text = "Vendedor";
                    LModificarUsuario.Text = NombreUsuario;
                    break;
            }
            ConfigurarPermisos(IdRol);
        }

        private void ConfigurarPermisos(int? rol)
        {
            // 1 = ADMIN, 2 = GERENTE, 3 = VENDEDOR
            switch (rol)
            {
                case 1: // ADMIN
                    BUsuarios.Enabled = true;
                    BProductos.Enabled = true;
                    BProveedores.Enabled = true;
                    BVentas.Visible = false;
                    BClientes.Visible = false;
                    BReportes.Visible = false;
                    break;
                case 2: // GERENTE
                    BReportes.Enabled = true;
                    BUsuarios.Visible = false;
                    BProductos.Visible = false;
                    BProveedores.Visible = false;
                    BVentas.Visible = false;
                    BClientes.Visible = false;
                    break;
                case 3: // VENDEDOR
                    BVentas.Enabled = true;
                    BClientes.Enabled = true;
                    BProductos.Enabled = true;
                    BUsuarios.Visible = false;
                    BProveedores.Visible = false;
                    BReportes.Visible = false;
                    break;
            }
        }


        private void pcLogo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BClientes_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear(); // Limpiar panel
            fGestionClientes clientesForm = new fGestionClientes();
            clientesForm.TopLevel = false; // Para poder mostrarlo dentro del panel
            clientesForm.Dock = DockStyle.Fill; // Que ocupe todo el panel
            clientesForm.FormBorderStyle = FormBorderStyle.None;
            panelContenedor.Controls.Add(clientesForm);
            clientesForm.Show();
        }

        private void BProductos_Click_1(object sender, EventArgs e)
        {
            switch (IdRol)
            {
                case 1: // ADMIN
                    panelContenedor.Controls.Clear(); // Limpiar panel
                    fGestionProductos productosForm = new fGestionProductos();
                    productosForm.TopLevel = false; // Para poder mostrarlo dentro del panel
                    productosForm.Dock = DockStyle.Fill; // Que ocupe todo el panel
                    panelContenedor.Controls.Add(productosForm);
                    productosForm.Show();
                    break;
                case 2: // GERENTE
                    break;
                case 3: // VENDEDOR
                    panelContenedor.Controls.Clear(); // Limpiar panel
                    fBuscarProductos buscarProductosForm = new fBuscarProductos();
                    buscarProductosForm.TopLevel = false; // Para poder mostrarlo dentro del panel
                    buscarProductosForm.Dock = DockStyle.Fill; // Que ocupe todo el panel
                    panelContenedor.Controls.Add(buscarProductosForm);
                    buscarProductosForm.Show();
                    break;
            }
        }

        private void BPorveedores_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear(); // Limpiar panel
            fGestionProveedores proveedoresForm = new fGestionProveedores();
            proveedoresForm.TopLevel = false; // Para poder mostrarlo dentro del panel
            proveedoresForm.Dock = DockStyle.Fill; // Que ocupe todo el panel
            panelContenedor.Controls.Add(proveedoresForm);
            proveedoresForm.Show();
        }

        private void BVentas_Click_1(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear(); // Limpiar panel
            fGestionVentas ventasForm = new fGestionVentas();
            ventasForm.TopLevel = false; // Para poder mostrarlo dentro del panel
            ventasForm.Dock = DockStyle.Fill; // Que ocupe todo el panel
            panelContenedor.Controls.Add(ventasForm);
            ventasForm.Show();
        }

        private void BUsuario_Click_1(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear(); // Limpiar panel
            fGestionUsuarios clientesForm = new fGestionUsuarios();
            clientesForm.TopLevel = false; // Para poder mostrarlo dentro del panel
            clientesForm.Dock = DockStyle.Fill; // Que ocupe todo el panel
            panelContenedor.Controls.Add(clientesForm);
            clientesForm.Show();
        }

        private Form? activeForm = null;
        private void abrirPanelContenedor(Form formularioHijo)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioHijo);
            panelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void PLogoAvicola_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LModificarRol_Click(object sender, EventArgs e)
        {

        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult preguntarCierre = MessageBox.Show(
                "¿Estas seguro que deseas cerrar sesión?", 
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(preguntarCierre == DialogResult.Yes) { 
                FLogin loginForm = new FLogin();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
