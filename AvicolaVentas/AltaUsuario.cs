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
    public partial class FAltaUsuario : Form
    {
        public FAltaUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FAltaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void TBDniUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("NO SE PERMITEN LETRAS", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; // Cancela la tecla presionada
                
            }
           
        }

        private void TBNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("NO SE PERMITEN NUMEROS", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            
        }

        private void TBApellidoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("NO SE PERMITEN NUMEROS", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                
            }
            
        }

        private void TBTelefonoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("NO SE PERMITEN LETRAS", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; // Cancela la tecla presionada
                
            }
            
        }

        private void DTPFechaNacimientoUsuario_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BLimpiarAltaUsuario_Click(object sender, EventArgs e)
        {
            TBNombreUsuario.Text = "";
            TBApellidoUsuario.Text = "";
            TBDniUsuario.Text = "(Opcional)";
            TBCorreoUsuario.Text = "";
            TBDirrecionUsuariuo.Text = "";
            TBTelefonoUsuario.Text = "";

            RBHombreUsuario.Checked = false;
            RBMujerUsuario.Checked = false;

            DTPFechaNacimientoUsuario.Value = DateTime.Today;
            DTPFechaNacimientoUsuario.Checked = false;

            PBImagenUsuario.Image = Properties.Resources.Huevo_Neutro;


        }

        private void PBImagenUsuario_Click(object sender, EventArgs e)
        {

        }

        private void RBHombreUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (RBHombreUsuario.Checked)
            {
                PBImagenUsuario.Image = Properties.Resources.Huevo_Hombre;

            }
        }

        private void RBMujerUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMujerUsuario.Checked)
            {
                PBImagenUsuario.Image = Properties.Resources.Huevo_Mujer;

            }
        }
    }
}
