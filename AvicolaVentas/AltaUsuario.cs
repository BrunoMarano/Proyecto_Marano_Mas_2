using Google.Protobuf.WellKnownTypes;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AvicolaVentas
{
    public partial class fGestionUsuarios : Form
    {
        private readonly string cadenaConexion = @"Data Source=localhost\SQLEXPRESS02;Initial Catalog=AvicolaSantaAna1;Integrated Security=True;TrustServerCertificate=True;";

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
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(tDniUsuario.Text) ||
                string.IsNullOrWhiteSpace(tNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(tApellidoUsuario.Text) ||
                string.IsNullOrWhiteSpace(tEmailUsuario.Text) ||
                string.IsNullOrWhiteSpace(tContraseñaUsuario.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            // Validar fecha de nacimiento
            if (dtpFechaNacUsuario.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor o igual a la actual.");
                return;
            }

            // Calcular el hash de la contraseña
            string hashContraseña = HashPassword(tContraseñaUsuario.Text);

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conn.Open();

                    // 🔍 Verificar si ya existe el usuario (por DNI o correo)
                    string checkQuery = @"SELECT COUNT(*) FROM Usuario 
                                  WHERE Dni = @Dni OR Correo = @Correo";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Dni", int.Parse(tDniUsuario.Text));
                        checkCmd.Parameters.AddWithValue("@Correo", tEmailUsuario.Text.Trim());

                        int existe = (int)checkCmd.ExecuteScalar();
                        if (existe > 0)
                        {
                            MessageBox.Show("El usuario con ese DNI o correo ya existe.");
                            return;
                        }
                    }

                    // 🧩 Si no existe, insertar
                    string insertQuery = @"INSERT INTO Usuario 
                (Dni, Nombre, Apellido, Correo, Telefono, Sexo, Fecha_Nacimiento, contraseña, baja, id_rol, direccion, id_ciudad)
                VALUES 
                (@Dni, @Nombre, @Apellido, @Correo, @Telefono, @Sexo, @Fecha_Nacimiento, @Contraseña, @Baja, @Rol, @Direccion, @Id_Ciudad)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Dni", int.Parse(tDniUsuario.Text));
                        cmd.Parameters.AddWithValue("@Nombre", tNombreUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@Apellido", tApellidoUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@Correo", tEmailUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@Telefono", tCelularUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@Direccion", tDireccionUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@Sexo", cbSexoUsuario.Text);
                        cmd.Parameters.Add("@Fecha_Nacimiento", SqlDbType.Date).Value = dtpFechaNacUsuario.Value.Date;
                        cmd.Parameters.AddWithValue("@Contraseña", hashContraseña);
                        cmd.Parameters.AddWithValue("@Baja", 0);
                        cmd.Parameters.Add("@Rol", SqlDbType.Int).Value = Convert.ToInt32(cbRolUsuario.SelectedValue);
                        cmd.Parameters.Add("@Id_Ciudad", SqlDbType.Int).Value = Convert.ToInt32(cbCiudadUsuario.SelectedValue);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario cargado correctamente.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error al insertar en la base de datos: {ex.Message}");
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

        private string HashPassword(string password)
        {
            // Implementación de hashing de contraseña (por ejemplo, usando SHA256)
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
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

            // Suponiendo que ya cargaste los datos
            int maxId = 0;

            // Buscar el Id_cliente máximo
            foreach (DataGridViewRow row in dgvListadoUsuarios.Rows)
            {
                if (!row.IsNewRow)
                {
                    int id = Convert.ToInt32(row.Cells["Id_usuario"].Value);
                    if (id > maxId)
                        maxId = id;
                }
            }

            foreach (DataGridViewRow row in dgvListadoUsuarios.Rows)
            {
                if (!row.IsNewRow && Convert.ToInt32(row.Cells["Id_usuario"].Value) == maxId)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen; // el color que quieras
                    row.DefaultCellStyle.ForeColor = Color.Black;      // opcional: color de texto
                }
            }
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

        private void dgvListadoUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

