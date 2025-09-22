namespace ModificaciónProductos
{
    public partial class ModificarCliente : Form
    {
        public ModificarCliente()
        {
            InitializeComponent();
        }

        private void LProvinciaModifCliente_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TBNombreModifCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBNombreModifCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TBApellidoModifCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TBDniModifCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private string obtenerSexo()
        {
            if (RBMasculinoModifCliente.Checked)
            {
                return "Masculino";
            }
            else if (RBFemeninoModifCliente.Checked)
            {
                return "Femenino";
            }
            else
            {
                return "Otro";
            }
        }

        private void TBEmailModifCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '_' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela el carácter
            }
        }

        private void TTelModifCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBDireccionModifCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBDireccionModifCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
