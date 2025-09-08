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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        // Se ejecuta al cargar el formulario
        private void Menu_Load(object sender, EventArgs e)
        {
            // Acá va el código que quieras al abrir el form
        }

        // Evento al hacer clic en "Clientes"
        private void BClientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón Clientes presionado");
        }

        // Evento al hacer clic en "Proveedores"
        private void BProveedores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón Proveedores presionado");
        }

        private void BUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
