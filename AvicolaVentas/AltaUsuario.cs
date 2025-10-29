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
            ObtenerProvincia();
            ObtenerRol();
            CargarUsuario();
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
        //LIMPIAR LOS CAMPOS
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
            cbProvinciaUsuario.SelectedIndex = -1;
            cbCiudadUsuario.DataSource = null;
            lEstadoContraseña.Text = "";
        }

        //AGREGAR USUARIO A LA BASE DE DATOS
        private void AgregarUsuario()
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "INSERT INTO Usuario (Dni, Nombre, Apellido, Correo, Telefono, Sexo, Fecha_Nacimiento, contraseña,baja, id_rol, direccion, id_ciudad) " +
                    "VALUES (@Dni, @Nombre, @Apellido, @Correo, @Telefono, @Sexo, @Fecha_Nacimiento, @Contraseña, @baja, @Rol, @direccion, @id_ciudad)";
                SqlCommand cmd = new SqlCommand(query, conn);
                if (dtpFechaNacUsuario.Value.Date < DateTime.Today)
                {
                    cmd.Parameters.AddWithValue("@Nombre", tNombreUsuario.Text);
                    cmd.Parameters.AddWithValue("@Apellido", tApellidoUsuario.Text);
                    cmd.Parameters.AddWithValue("@Correo", tEmailUsuario.Text);
                    cmd.Parameters.AddWithValue("@Dni", int.Parse(tDniUsuario.Text));
                    cmd.Parameters.AddWithValue("@Telefono", tCelularUsuario.Text);
                    cmd.Parameters.AddWithValue("@direccion", tDireccionUsuario.Text);
                    cmd.Parameters.AddWithValue("@Sexo", cbSexoUsuario.Text);
                    cmd.Parameters.Add("@Fecha_Nacimiento", SqlDbType.Date).Value = dtpFechaNacUsuario.Value.Date;
                    cmd.Parameters.AddWithValue("@Contraseña", tContraseñaUsuario.Text);
                    cmd.Parameters.AddWithValue("@baja", 0); // por defecto activo
                    cmd.Parameters.Add("@Rol", SqlDbType.Int).Value = cbRolUsuario.SelectedValue;
                    cmd.Parameters.AddWithValue("@id_ciudad", cbCiudadUsuario.SelectedValue);

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

        // OBTENER PROVINCIAS DESDE LA BASE DE DATOS
        private void ObtenerProvincia()
        {
            // Implementación para obtener provincias desde la base de datos
            string consulta = "SELECT id_provincia, provincia FROM Provincia";
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            DataTable tablaProvincias = new DataTable();
                            tablaProvincias.Load(lector);
                            cbProvinciaUsuario.DataSource = tablaProvincias;
                            cbProvinciaUsuario.DisplayMember = "provincia";
                            cbProvinciaUsuario.ValueMember = "id_provincia";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las provincias: " + ex.Message);
            }
        }

        // CARGAR CIUDADES SEGUN PROVINCIA SELECCIONADA
        private void CargarCiudades(int idProvincia)
        {
            // Implementación para obtener ciudades desde la base de datos según la provincia seleccionada
            string consulta = "SELECT id_ciudad, ciudad FROM Ciudad WHERE id_provincia = @id_provincia";
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id_provincia", idProvincia);
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            DataTable tablaCiudades = new DataTable();
                            tablaCiudades.Load(lector);
                            cbCiudadUsuario.DataSource = tablaCiudades;
                            cbCiudadUsuario.DisplayMember = "ciudad";
                            cbCiudadUsuario.ValueMember = "id_ciudad";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ciudades: " + ex.Message);
            }
        }

        //CARGAR USUARIO EN EL DATAGRIDVIEW DESDE LA BASE DE DATOS
        private void CargarUsuario()
        {
            // Implementación para cargar usuarios desde la base de datos en el dataGridView
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "SELECT u.Id_usuario, u.Dni, u.Nombre, u.Apellido, u.Correo, u.Telefono, u.Sexo, u.Fecha_Nacimiento, r.rol AS Rol, u.direccion " +
                                  "FROM Usuario u " +
                                  "JOIN Rol r ON u.id_rol = r.Id_rol " +
                                  "WHERE u.baja = 0"; // Solo usuarios activos
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            DataTable tablaUsuario = new DataTable();
                            tablaUsuario.Load(lector);
                            dgvListadoUsuarios.DataSource = tablaUsuario;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar usuarios: " + ex.Message);
                }
            }
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

        private void BGrabarUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario();
            CargarUsuario();
        }

        private void cbProvinciaUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvinciaUsuario.SelectedValue != null)
            {
                int id_provincia;
                if (int.TryParse(cbProvinciaUsuario.SelectedValue.ToString(), out id_provincia))
                {
                    CargarCiudades(id_provincia);
                }
            }
        }
    }
}

