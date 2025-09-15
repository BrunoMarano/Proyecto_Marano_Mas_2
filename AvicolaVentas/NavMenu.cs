using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvicolaVentas
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelClientes.Visible = false;
            panelProductos.Visible = false;
            panelProveedores.Visible = false;
            panelVenta.Visible = false;
            panelUsuario.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelClientes.Visible == true)
            {
                panelClientes.Visible = false;
            }
            if (panelProductos.Visible == true)
            {
                panelProductos.Visible = false;
            }
            if (!panelProveedores.Visible == true)
            {
                panelProveedores.Visible = false;
            }
            if (panelVenta.Visible == true)
            {
                panelVenta.Visible = false;
            }
            if (panelUsuario.Visible == true)
            {
                panelUsuario.Visible = false;
            }
            if (panelVenta.Visible == true)
            {
                panelVenta.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            //codigo//
            hideSubMenu();
        }



        private void BClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientes);

        }

        private void BProductos_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelProductos);
        }

        private void BPorveedores_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProveedores);
        }

        private void BVenta_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelVenta);
        }

        private void BUsuario_Click_1(object sender, EventArgs e)
        {
            Show(panelUsuario);
        }


        private void buttonAltaCliente_Click(object sender, EventArgs e)
        {
            //codigo//
            hideSubMenu();
        }

        private void buttonModificacionClientes_Click(object sender, EventArgs e)
        {
            //codigo//
            hideSubMenu();
        }

        private void buttonAltaProveedores_Click(object sender, EventArgs e)
        {
            //codigo//
            hideSubMenu();
        }

        private void buttonBajaProveedores_Click(object sender, EventArgs e)
        {
            //codigo//
            hideSubMenu();
        }

        private void buttonMofidicacionProveedores_Click(object sender, EventArgs e)
        {
            //codigo//
            hideSubMenu();
        }

        private void buttonAltaProductos_Click(object sender, EventArgs e)
        {
            //codigo//
            hideSubMenu();
        }

        private void buttonBajaProductos_Click(object sender, EventArgs e)
        {
            //codigo//
            hideSubMenu();
        }

        private void buttonModificacionProductos_Click(object sender, EventArgs e)
        {
            //codigo//
            hideSubMenu();
        }

        private void buttonNuevaVenta_Click(object sender, EventArgs e)
        {
            //codigo//
            hideSubMenu();
        }

        private void buttonEliminarVenta_Click(object sender, EventArgs e)
        {
            //codigo//
            hideSubMenu();
        }

        private void buttonMisVentas_Click(object sender, EventArgs e)
        {
            //codigo//
            hideSubMenu();
        }

        private void buttonAltaUsuario_Click(object sender, EventArgs e)
        {
            //codigo//
            hideSubMenu();
        }

        private void buttonBajaUsuario_Click(object sender, EventArgs e)
        {
            //codigo//
            hideSubMenu();
        }

        private void buttonModificacionUsuario_Click(object sender, EventArgs e)
        {
            //codigo//
            hideSubMenu();
        }

        private Form activeForm = null;
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

        private void buttonModificacionCliente_Click(object sender, EventArgs e)
        {

        }

        private void buttonModificacionUsuariuo_Click(object sender, EventArgs e)
        {

        }

        private void buttonAltaCliente_Click_1(object sender, EventArgs e)
        {
            abrirPanelContenedor(new FAltaUsuario());
            hideSubMenu();
        }
    }
}
