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
using Microsoft.Data.SqlClient;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
using SqlDataAdapter = Microsoft.Data.SqlClient.SqlDataAdapter;

namespace AvicolaVentas
{
    public partial class FAltaUsuario : Form
    {

        string connectionString = @"Server=localhost\SQLEXPRESS; Database=AvicolaSantaAna; Trusted_Connection=True; TrustServerCertificate=True;";



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
            CargarRoles();
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
            LimpiarCampos();

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

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBDniUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private String BotonSexo()
        {

            if (RBHombreUsuario.Checked)
            {
                return "Hombre";
            }
            else if (RBMujerUsuario.Checked)
            {
                return "Mujer";
            }
            else
            {
                return "";
            }

        }

        private void LimpiarCampos()
        {
            TBNombreUsuario.Text = "";
            TBApellidoUsuario.Text = "";
            TBDniUsuario.Text = "(Sin puntos ni comas)";
            TBCorreoUsuario.Text = "";
            TBTelefonoUsuario.Text = "";

            RBHombreUsuario.Checked = false;
            RBMujerUsuario.Checked = false;

            DTPFechaNacimientoUsuario.Value = DateTime.Today;
            DTPFechaNacimientoUsuario.Checked = false;

            comboBoxRolUsuario.SelectedIndex = -1;

            PBImagenUsuario.Image = Properties.Resources.Huevo_Neutro;
        }

        private void AgregarUsuario()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuario (Dni, Nombre, Apellido, Correo, Telefono, Sexo, Fecha_Nacimiento, contraseña,baja, id_rol) " +
                    "VALUES (@Dni, @Nombre, @Apellido, @Correo, @Telefono, @Sexo, @Fecha_Nacimiento, @Contraseña, @baja, @Rol)";
                SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn);
                if (DTPFechaNacimientoUsuario.Value.Date < DateTime.Today)
                {
                    cmd.Parameters.AddWithValue("@Nombre", TBNombreUsuario.Text);
                    cmd.Parameters.AddWithValue("@Apellido", TBApellidoUsuario.Text);
                    cmd.Parameters.AddWithValue("@Correo", TBCorreoUsuario.Text);
                    cmd.Parameters.AddWithValue("@Dni", int.Parse(TBDniUsuario.Text));
                    cmd.Parameters.AddWithValue("@Telefono", TBTelefonoUsuario.Text);
                    cmd.Parameters.AddWithValue("@Sexo", BotonSexo());
                    cmd.Parameters.Add("@Fecha_Nacimiento", SqlDbType.Date).Value = DTPFechaNacimientoUsuario.Value.Date;
                    cmd.Parameters.AddWithValue("@Contraseña", textBoxContraseñaUsuario.Text);
                    cmd.Parameters.AddWithValue("@baja", 0); // por defecto activo
                    cmd.Parameters.Add("@Rol", SqlDbType.Int).Value = comboBoxRolUsuario.SelectedValue;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Error al cargar la fecha");
                }
            }

            LimpiarCampos();
        }

        private void comboBoxRolUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarRoles()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Id_rol, Rol FROM Rol";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBoxRolUsuario.DataSource = dt;
                    comboBoxRolUsuario.DisplayMember = "Rol";     // Lo que ve el usuario
                    comboBoxRolUsuario.ValueMember = "Id_rol";    // Lo que se guarda
                    comboBoxRolUsuario.SelectedIndex = -1;        // Que no haya seleccionado al inicio
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar roles: " + ex.Message);
                }
            }
        }

        private void comboBoxRolUsuario_Load(object sender, EventArgs e)
        {



        }

        private void BAltaUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario();
        }
    }
}

