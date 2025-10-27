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
    public partial class fGestionProveedores : Form
    {
        public fGestionProveedores()
        {
            InitializeComponent();
        }

        private void AltaProveedores_Load(object sender, EventArgs e)
        {
            // Aquí podés inicializar valores si querés.
            // Por ejemplo limpiar campos o cargar combos.
        }

        private void buttonLimpiarProveedores_Click_1(object sender, EventArgs e)
        {
            // Aquí podés limpiar los campos del formulario
            textBoxNombreProveedor.Text = "";
            textBoxTelefonoProveedor.Text = "";
            textBoxCuitProveedor.Text = ""; // CUIT
            textBoxDireccionProveedor.Text = "";
            comboBoxProvinciaProveedor.SelectedIndex = -1; // Provincia
            comboBoxCiudadProveedor.SelectedIndex = -1; // Ciudad
        }

        private void textBoxDireccionProveedor_TextChanged(object sender, EventArgs e)
        {
            // Aquí podés poner código que quieras ejecutar cuando cambie el texto.
            // Si no necesitas nada, podés dejarlo vacío.
        }

        private void textBoxNombreProveedor_TextChanged(object sender, EventArgs e)
        {
            // Podés agregar validaciones acá más adelante.
            // Por ejemplo: verificar que no esté vacío, o filtrar caracteres.
        }

        private void buttonSalirAltaProveedor_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void textBoxTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("NO SE PERMITEN LETRAS", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; // Cancela la tecla presionada

            }
        }

        private void textBoxCuitProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCuitProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("NO SE PERMITEN LETRAS", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; // Cancela la tecla presionada

            }
        }

        private void buttonCrearProveedor_Click(object sender, EventArgs e)
        {

        }
    }
}
