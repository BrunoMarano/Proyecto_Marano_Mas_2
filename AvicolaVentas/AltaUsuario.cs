using System.Data;
using System.Data.Sql;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Drawing;

namespace AvicolaVentas
{
    public partial class fGestionUsuarios : Form
    {
        private readonly string cadenaConexion = @"Data Source=FERNANDO\SQLEXPRESS02;Initial Catalog=AvicolaSantaAna1;Integrated Security=True;TrustServerCertificate=True;";

        public fGestionUsuarios()
        {
            InitializeComponent();
        }

        private void fGestionUsuarios_Load(object sender, EventArgs e)
        {
            ObtenerRol();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODOS
        //OBTENER ROL DEL USUARIO DESDE LA BASE DE DATOS
        private void ObtenerRol()
        {
            // Implementación para obtener roles de usuarios desde la base de datos
            string consulta = "SELECT Id_rol, rol FROM Rol";
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            DataTable tablaUsuario = new DataTable();
                            tablaUsuario.Load(lector);
                            cbRolUsuario.DataSource = tablaUsuario;
                            cbRolUsuario.DisplayMember = "rol";
                            cbRolUsuario.ValueMember = "Id_rol";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener roles: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            tDniUsuario.Text = "";
            tNombreUsuario.Text = "";
            tApellidoUsuario.Text = "";
            dtpFechaNacUsuario.Value = DateTime.Today;
            cbSexoUsuario.SelectedIndex = -1;
            tDireccionUsuario.Text = "";
            tEmailUsuario.Text = "";
            tCelularUsuario.Text = "";
            tContraseñaUsuario.Text = "";
            cbRolUsuario.SelectedIndex = -1;
        }

        private void AgregarUsuario()
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "INSERT INTO Usuario (Dni, Nombre, Apellido, Correo, Telefono, Sexo, Fecha_Nacimiento, contraseña,baja, id_rol, direccion) " +
                    "VALUES (@Dni, @Nombre, @Apellido, @Correo, @Telefono, @Sexo, @Fecha_Nacimiento, @Contraseña, @baja, @Rol, @direccion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                if (dtpFechaNacUsuario.Value.Date < DateTime.Today)
                {
                    cmd.Parameters.AddWithValue("@Nombre", tNombreUsuario.Text);
                    cmd.Parameters.AddWithValue("@Apellido", tApellidoUsuario.Text);
                    cmd.Parameters.AddWithValue("@Correo", tEmailUsuario.Text);
                    cmd.Parameters.AddWithValue("@Dni", int.Parse(tDniUsuario.Text));
                    cmd.Parameters.AddWithValue("@Telefono", tCelularUsuario.Text);
                    cmd.Parameters.AddWithValue("@direccion", tDireccionUsuario.Text);
                    //cmd.Parameters.AddWithValue("@Sexo", cbSexoUsuario().Text);
                    cmd.Parameters.Add("@Fecha_Nacimiento", SqlDbType.Date).Value = dtpFechaNacUsuario.Value.Date;
                    cmd.Parameters.AddWithValue("@Contraseña", tContraseñaUsuario.Text);
                    cmd.Parameters.AddWithValue("@baja", 0); // por defecto activo
                    cmd.Parameters.Add("@Rol", SqlDbType.Int).Value = cbRolUsuario.SelectedValue;

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



        //RESTRICCIONES DE LOS CAMPOS

        private void tDniUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void tApellidoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void tCelularUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tEmailUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '_' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela el carácter
            }
        }

        private void tContraseñaUsuario_TextChanged(object sender, EventArgs e)
        {
            string patron = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$";
            if (Regex.IsMatch(tContraseñaUsuario.Text, patron))
            {
                lEstadoContraseña.Text = "✔ Contraseña segura";
                lEstadoContraseña.ForeColor = Color.Green;
            }
            else
            {
                lEstadoContraseña.Text = "❌ Debe tener mayúscula, minúscula, número y símbolo";
                lEstadoContraseña.ForeColor = Color.Red;
            }


        }


        //BOTONES
        private void BLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}

