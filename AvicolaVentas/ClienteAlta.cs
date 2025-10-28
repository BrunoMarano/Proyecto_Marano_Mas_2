using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AvicolaVentas
{
    public partial class fGestionClientes : Form
    {
        private readonly string cadenaConexion = @"Data Source=FERNANDO\SQLEXPRESS02;Initial Catalog=AvicolaSantaAna1;Integrated Security=True;TrustServerCertificate=True;";

        public fGestionClientes()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                            cbProvinciaCliente.DataSource = tablaProvincias;
                            cbProvinciaCliente.DisplayMember = "provincia";
                            cbProvinciaCliente.ValueMember = "id_provincia";
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
                            cbCiudadCliente.DataSource = tablaCiudades;
                            cbCiudadCliente.DisplayMember = "ciudad";
                            cbCiudadCliente.ValueMember = "id_ciudad";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ciudades: " + ex.Message);
            }
        }
        private void fGestionClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
            ObtenerProvincia();
            cbProvinciaCliente.DisplayMember = "provincia";
            cbProvinciaCliente.ValueMember = "id_provincia";

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
                return "M";
            }
            else
            {
                return "F";
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

        //GRABAR DATOS EN LA BASE DE DATOS
        private void GuardarCliente()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO Cliente (dni, nombre, apellido, sexo, email, fecha_nacimiento, telefono, direccion, id_ciudad) " +
                                      "VALUES (@dni, @nombre, @apellido, @sexo, @email, @fecha_nacimiento, @telefono, @direccion, @id_ciudad)";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@dni", tDni.Text);
                        comando.Parameters.AddWithValue("@nombre", tNombreCliente.Text);
                        comando.Parameters.AddWithValue("@apellido", tApellidoCliente.Text);
                        comando.Parameters.AddWithValue("@fecha_nacimiento", dtpFechaNacCliente.Value);
                        comando.Parameters.AddWithValue("@sexo", obtenerSexo());
                        comando.Parameters.AddWithValue("@email", tEmailCliente.Text);
                        comando.Parameters.AddWithValue("@telefono", tTelCliente.Text);
                        comando.Parameters.AddWithValue("@direccion", tDirecciónCliente.Text);
                        comando.Parameters.AddWithValue("@id_ciudad", cbCiudadCliente.SelectedValue);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cliente guardado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message);
            }
        }
        // CARGAR CLIENTES EN EL DATAGRIDVIEW
        private void CargarClientes()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = @"
                SELECT
                    c.Id_cliente,
                    c.dni, 
                    c.nombre, 
                    c.apellido, 
                    c.sexo, 
                    c.email, 
                    c.fecha_nacimiento, 
                    c.telefono, 
                    c.direccion,
                    c.id_ciudad,
                    ci.ciudad AS ciudad,
                    ci.id_provincia,
                    p.provincia AS provincia
                FROM Cliente c
                INNER JOIN Ciudad ci ON c.id_ciudad = ci.id_ciudad
                INNER JOIN Provincia p ON ci.id_provincia = p.id_provincia
                ORDER BY c.Id_cliente DESC";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            DataTable tablaClientes = new DataTable();
                            tablaClientes.Load(lector);

                            dgvListadoClientes.AutoGenerateColumns = true; // <<< clave
                            dgvListadoClientes.DataSource = tablaClientes;

                            // Formatear la fecha
                            if (dgvListadoClientes.Columns.Contains("fecha_nacimiento"))
                            {
                                dgvListadoClientes.Columns["fecha_nacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }


        // GUARDAR CLIENTE
        private void BGrabarCliente_Click(object sender, EventArgs e)
        {
            GuardarCliente();
            CargarClientes();
            BLimpiarCampos_Click(sender, e);
            tDni.Focus();

            // Suponiendo que ya cargaste los datos
            int maxId = 0;

            // Buscar el Id_cliente máximo
            foreach (DataGridViewRow row in dgvListadoClientes.Rows)
            {
                if (!row.IsNewRow)
                {
                    int id = Convert.ToInt32(row.Cells["Id_cliente"].Value);
                    if (id > maxId)
                        maxId = id;
                }
            }

            // Colorear la fila con el Id_cliente máximo
            foreach (DataGridViewRow row in dgvListadoClientes.Rows)
            {
                if (!row.IsNewRow && Convert.ToInt32(row.Cells["Id_cliente"].Value) == maxId)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen; // el color que quieras
                    row.DefaultCellStyle.ForeColor = Color.Black;      // opcional: color de texto
                }
            }

        }

        // LIMPIAR CAMPOS
        private void BLimpiarCampos_Click(object sender, EventArgs e)
        {
            tDni.Clear();
            tNombreCliente.Clear();
            tApellidoCliente.Clear();
            rbMasculinoCliente.Checked = false;
            rbFemeninoCliente.Checked = false;
            tEmailCliente.Clear();
            tTelCliente.Clear();
            tDirecciónCliente.Clear();
            cbProvinciaCliente.SelectedIndex = -1;
            cbCiudadCliente.SelectedIndex = -1;
            dtpFechaNacCliente.Value = DateTime.Now;
        }

        private void tNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void tEmailCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbProvinciaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvinciaCliente.SelectedValue != null)
            {
                int id_provincia;
                if (int.TryParse(cbProvinciaCliente.SelectedValue.ToString(), out id_provincia))
                {
                    CargarCiudades(id_provincia);
                }
            }
        }

        private void BBuscarCliente_Click(object sender, EventArgs e)
        {
            string dni = tDni.Text.Trim();
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI para buscar.");
                return;
            }

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT * FROM Cliente WHERE dni = @dni";
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@dni", dni);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgvListadoClientes.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún cliente con el DNI proporcionado.");
                    }
                }
            }
        }

        private void dgvListadoClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvListadoClientes.Rows[e.RowIndex];
                tDni.Text = filaSeleccionada.Cells["dni"].Value.ToString();
                tNombreCliente.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                tApellidoCliente.Text = filaSeleccionada.Cells["apellido"].Value.ToString();
                string sexo = filaSeleccionada.Cells["sexo"].Value.ToString();
                if (sexo == "M")
                {
                    rbMasculinoCliente.Checked = true;
                }
                else if (sexo == "F")
                {
                    rbFemeninoCliente.Checked = true;
                }
                tDirecciónCliente.Text = filaSeleccionada.Cells["direccion"].Value.ToString();
                tEmailCliente.Text = filaSeleccionada.Cells["email"].Value.ToString();
                dtpFechaNacCliente.Value = Convert.ToDateTime(filaSeleccionada.Cells["fecha_nacimiento"].Value);
                tTelCliente.Text = filaSeleccionada.Cells["telefono"].Value.ToString();
                int idProvincia = Convert.ToInt32(filaSeleccionada.Cells["id_provincia"].Value);
                int idCiudad = Convert.ToInt32(filaSeleccionada.Cells["id_ciudad"].Value);

                cbProvinciaCliente.SelectedValue = idProvincia; // Selecciona la provincia

                // Cargar las ciudades de esa provincia antes de seleccionar la ciudad
                CargarCiudades(idProvincia);
                cbCiudadCliente.SelectedValue = idCiudad;
            }
        }

        private void BModificarCliente_Click(object sender, EventArgs e)
        {
            tDni.Enabled = false; // Deshabilitar el campo DNI para evitar modificaciones
            if (string.IsNullOrEmpty(tDni.Text))
            {
                MessageBox.Show("Por favor, ingrese el DNI del cliente a modificar.");
                return;
            }
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "UPDATE Cliente SET nombre = @nombre, apellido = @apellido, sexo = @sexo, email = @email, fecha_nacimiento = @fecha_nacimiento, telefono = @telefono, direccion = @direccion, id_ciudad = @id_ciudad WHERE dni = @dni";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@dni", tDni.Text);
                    comando.Parameters.AddWithValue("@nombre", tNombreCliente.Text);
                    comando.Parameters.AddWithValue("@apellido", tApellidoCliente.Text);
                    comando.Parameters.AddWithValue("@fecha_nacimiento", dtpFechaNacCliente.Value);
                    comando.Parameters.AddWithValue("@sexo", obtenerSexo());
                    comando.Parameters.AddWithValue("@email", tEmailCliente.Text);
                    comando.Parameters.AddWithValue("@telefono", tTelCliente.Text);
                    comando.Parameters.AddWithValue("@direccion", tDirecciónCliente.Text);
                    comando.Parameters.AddWithValue("@id_ciudad", cbCiudadCliente.SelectedValue);
                    comando.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Cliente modificado exitosamente.");
        }

        private void tApellidoCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}