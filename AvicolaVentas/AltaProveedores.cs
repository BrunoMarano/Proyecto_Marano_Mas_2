using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
#pragma warning disable CA1416
namespace AvicolaVentas
{
    public partial class fGestionProveedores : Form
    {
        private readonly string cadenaConexion = @"Data Source=localhost\SQLEXPRESS02;Initial Catalog=AvicolaSantaAna1;Integrated Security=True;TrustServerCertificate=True;";


        public fGestionProveedores()
        {
            InitializeComponent();
        }

        private void AltaProveedores_Load(object sender, EventArgs e)
        {
            cbFiltroEstado.Items.AddRange(new string[] { "Activos", "Inactivos", "Todos" });
            CargarProveedores("Activos");
            ObtenerProvincia();
            cbProvinciaProveedores.DisplayMember = "provincia";
            cbProvinciaProveedores.ValueMember = "id_provincia";

        }

        private void buttonSalirAltaProveedor_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //VALIDACIONES DE CAMPOS
        private void tNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void tCuitProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tEmailProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '_' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela el carácter
            }
        }
        //FIN VALIDACIONES DE CAMPOS

        //METODOS AUXILIARES
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
                            cbProvinciaProveedores.DataSource = tablaProvincias;
                            cbProvinciaProveedores.DisplayMember = "provincia";
                            cbProvinciaProveedores.ValueMember = "id_provincia";
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
                            cbCiudadProveedores.DataSource = tablaCiudades;
                            cbCiudadProveedores.DisplayMember = "ciudad";
                            cbCiudadProveedores.ValueMember = "id_ciudad";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ciudades: " + ex.Message);

            }
        }
        //CARGAR PROVEEDORES EN LA BASE DE DATOS
        private void GuardarProveedores()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO Proveedor (Nombre, cuit, Direccion, telefono, email, fecha_registro, id_ciudad, estado) " +
                                      "VALUES (@Nombre, @cuit, @Direccion, @telefono, @email, @fecha_registro, @id_ciudad, @estado)";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@cuit", tCuitProveedor.Text);
                        comando.Parameters.AddWithValue("@Nombre", tNombreProveedor.Text);
                        comando.Parameters.AddWithValue("@Direccion", tDireccionProveedor.Text);
                        comando.Parameters.AddWithValue("@fecha_registro", dtpFechaRegProv.Value);
                        comando.Parameters.AddWithValue("@email", tEmailProveedor.Text);
                        comando.Parameters.AddWithValue("@telefono", tTelefonoProveedor.Text);
                        comando.Parameters.AddWithValue("@id_ciudad", cbCiudadProveedores.SelectedValue);
                        comando.Parameters.AddWithValue("@estado", 0);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Proveedor guardado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el proveedores: " + ex.Message);
            }
        }
        // CARGAR PROVEEDORES EN EL DATAGRIDVIEW
        private void CargarProveedores(string filtroEstado)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = @"
                    SELECT
                        c.id_proveedor,
                        c.cuit, 
                        c.Nombre, 
                        c.telefono, 
                        c.email,
                        c.Direccion,
                        c.fecha_registro,
                        c.estado,
                        ci.id_ciudad,
                        ci.ciudad AS ciudad,
                        ci.id_provincia,
                        p.provincia AS provincia
                    FROM Proveedor c 
                    INNER JOIN Ciudad ci ON c.id_ciudad = ci.id_ciudad
                    INNER JOIN Provincia p ON ci.id_provincia = p.id_provincia
                    --WHERE c.estado = @estado
                    ORDER BY c.id_proveedor DESC";

                    if (filtroEstado == "Activos")
                    {
                        consulta = consulta.Replace("--WHERE c.estado = @estado", "WHERE c.estado = 1");
                    }
                    else if (filtroEstado == "Inactivos")
                    {
                        consulta = consulta.Replace("--WHERE c.estado = @estado", "WHERE c.estado = 0");
                    }
                    else
                    {
                        consulta = consulta.Replace("--WHERE c.estado = @estado", "");
                    }

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            DataTable tablaProveedor = new DataTable();
                            tablaProveedor.Load(lector);

                            dgvListadoProveedores.AutoGenerateColumns = true; // <<< clave
                            dgvListadoProveedores.DataSource = tablaProveedor;

                            // Formatear la fecha
                            if (dgvListadoProveedores.Columns.Contains("fecha_registro"))
                            {
                                dgvListadoProveedores.Columns["fecha_registro"].DefaultCellStyle.Format = "dd/MM/yyyy";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message);
            }
        }

        private void cbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProveedores(cbFiltroEstado.SelectedItem.ToString());
        }

        private void cbProvinciaProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvinciaProveedores.SelectedValue != null)
            {
                int id_provincia;
                if (int.TryParse(cbProvinciaProveedores.SelectedValue.ToString(), out id_provincia))
                {
                    CargarCiudades(id_provincia);
                }
            }
        }

        private void BGrabarCliente_Click(object sender, EventArgs e)
        {
            GuardarProveedores();
            CargarProveedores("");
            BLimpiarCampos_Click(sender, e);
            tNombreProveedor.Focus();
        }

        private void BLimpiarCampos_Click(object sender, EventArgs e)
        {
            tNombreProveedor.Clear();
            tCuitProveedor.Clear();
            tDireccionProveedor.Clear();
            tTelefonoProveedor.Clear();
            tEmailProveedor.Clear();
            dtpFechaRegProv.Value = DateTime.Now;
            cbProvinciaProveedores.SelectedIndex = -1;
            cbCiudadProveedores.SelectedIndex = -1;
        }

        private void BModificarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tCuitProveedor.Text))
            {
                MessageBox.Show("Por favor, ingrese el CUIT del proveedor a modificar.");
                return;
            }
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "UPDATE Proveedor SET Nombre = @Nombre, Direccion = @Direccion, cuit = @cuit, telefono = @telefono, fecha_registro = @fecha_registro, email = @email, id_ciudad = @id_ciudad WHERE cuit = @cuit";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@cuit", tCuitProveedor.Text);
                    comando.Parameters.AddWithValue("@Nombre", tNombreProveedor.Text);
                    comando.Parameters.AddWithValue("@Direccion", tDireccionProveedor.Text);
                    comando.Parameters.AddWithValue("@fecha_registro", dtpFechaRegProv.Value);
                    comando.Parameters.AddWithValue("@email", tEmailProveedor.Text);
                    comando.Parameters.AddWithValue("@telefono", tTelefonoProveedor.Text);
                    comando.Parameters.AddWithValue("@id_ciudad", cbCiudadProveedores.SelectedValue);
                    comando.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Cliente modificado exitosamente.");

            CargarProveedores("");
            BLimpiarCampos_Click(sender, e);
        }

        private void BEliminarCliente_Click(object sender, EventArgs e)
        {
            //Si presionas el botón eliminar cliente sin seleccionar un cliente, te avisa
            if (dgvListadoProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un proveedor para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Si seleccionas al cliente, te pide confirmación
            int id_proveedor = Convert.ToInt32(dgvListadoProveedores.SelectedRows[0].Cells["id_proveedor"].Value);
            string nombreProveedor = dgvListadoProveedores.SelectedRows[0].Cells["nombre"].Value?.ToString() ?? "";

            DialogResult confirmar = MessageBox.Show(
                $"¿Está seguro de que desea eliminar al proveedor '{nombreProveedor}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            //Eliminar cliente
            try
            {
                if (confirmar == DialogResult.Yes)
                {
                    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                    {
                        conexion.Open();
                        string consulta = "UPDATE Proveedor SET estado = 0 WHERE id_proveedor = @id_proveedor";
                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@id_proveedor", id_proveedor);
                            comando.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Proveedor eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProveedores("");
                    BLimpiarCampos_Click(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BBuscarProveedor_Click(object sender, EventArgs e)
        {
            string cuit = tCuitProveedor.Text.Trim();
            if (string.IsNullOrEmpty(cuit))
            {
                MessageBox.Show("Por favor, ingrese un CUIT para buscar.");
                return;
            }

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT * FROM Proveedor WHERE cuit = @cuit";
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@cuit", cuit);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgvListadoProveedores.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún proveedor con el CUIT proporcionado.");
                    }
                }
            }
        }

        private void dgvListadoProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvListadoProveedores.Rows[e.RowIndex];
                tCuitProveedor.Text = filaSeleccionada.Cells["cuit"].Value.ToString();
                tNombreProveedor.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                tDireccionProveedor.Text = filaSeleccionada.Cells["Direccion"].Value.ToString();
                tEmailProveedor.Text = filaSeleccionada.Cells["email"].Value.ToString();
                dtpFechaRegProv.Value = Convert.ToDateTime(filaSeleccionada.Cells["fecha_registro"].Value);
                tTelefonoProveedor.Text = filaSeleccionada.Cells["telefono"].Value.ToString();
                int idProvincia = Convert.ToInt32(filaSeleccionada.Cells["id_provincia"].Value);
                int idCiudad = Convert.ToInt32(filaSeleccionada.Cells["id_ciudad"].Value);

                cbProvinciaProveedores.SelectedValue = idProvincia; // Selecciona la provincia

                //Cargar las ciudades de esa provincia antes de seleccionar la ciudad
                CargarCiudades(idProvincia);
                cbCiudadProveedores.SelectedValue = idCiudad;
            }
        }
    }
}
#pragma warning restore CA1416
