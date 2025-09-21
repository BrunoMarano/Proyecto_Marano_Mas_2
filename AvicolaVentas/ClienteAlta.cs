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
    public partial class fGestionClientes : Form
    {
        public fGestionClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fGestionClientes_Load(object sender, EventArgs e)
        {
            //cbProvinciaCliente.DataSource = ObtenerProvincia();
            cbProvinciaCliente.DisplayMember = "NombreProvincia";
            cbProvinciaCliente.ValueMember = "IdProvincia";
        }

        private void tNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void tApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void tDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private string obtenerSexo()
        {
            if (rbMasculinoCliente.Checked)
            {
                return "Masculino";
            }
            else if (rbFemeninoCliente.Checked)
            {
                return "Femenino";
            }
            else
            {
                return "Otro";
            }
        }

        private void tEmailCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '_' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela el carácter
            }
        }

        private void tTelCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bLimpiarCliente_Click(object sender, EventArgs e)
        {
            tNombreCliente.Clear();
            tApellidoCliente.Clear();
            tDni.Clear();
            rbMasculinoCliente.Checked = false;
            rbFemeninoCliente.Checked = false;
            tEmailCliente.Clear();
            tTelCliente.Clear();
            tDirecciónCliente.Clear();
            cbProvinciaCliente.SelectedIndex = -1;
            cbCiudadCliente.DataSource = null;
        }
    }
}
