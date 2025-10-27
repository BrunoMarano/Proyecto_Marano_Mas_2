using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AvicolaVentas
{
    public partial class fGestionVentas : Form
    {
        // Cadena de conexión como variable de instancia
        private readonly string cadenaConexion = @"Data Source=FERNANDO\SQLEXPRESS02;Initial Catalog=AvicolaSantaAna1;Integrated Security=True;TrustServerCertificate=True;";

        public fGestionVentas()
        {
            InitializeComponent();
        }

        private async void FormNuevaVenta_Load(object sender, EventArgs e)
        {
            await CargarClientesAsync();
            await CargarProductosAsync();
        }

        private void buttonAgregarArticuloVenta_Click(object sender, EventArgs e)
        {
            AgregarArticuloVenta formularioHijo = new AgregarArticuloVenta();
            formularioHijo.Show();
        }

        private void bVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cargar clientes de forma asincrónica
        private async Task CargarClientesAsync()
        {
            using var conexion = new SqlConnection(cadenaConexion);
            await conexion.OpenAsync();

            string consulta = "SELECT Id_cliente, Nombre FROM Cliente";
            using var comando = new SqlCommand(consulta, conexion);
            using var lector = await comando.ExecuteReaderAsync();

            var tablaClientes = new DataTable();
            tablaClientes.Load(lector);

            cClienteVenta.DataSource = tablaClientes;
            cClienteVenta.DisplayMember = "Nombre";
            cClienteVenta.ValueMember = "Id_cliente";
            cClienteVenta.SelectedIndex = -1;
        }

        // Cargar productos de forma asincrónica
        private async Task CargarProductosAsync()
        {
            using var conexion = new SqlConnection(cadenaConexion);
            await conexion.OpenAsync();

            string consulta = "SELECT id_producto, descripcion, precio FROM Producto";
            using var comando = new SqlCommand(consulta, conexion);
            using var lector = await comando.ExecuteReaderAsync();

            var tablaProductos = new DataTable();
            tablaProductos.Load(lector);

            cProductoVenta.DataSource = tablaProductos;
            cProductoVenta.DisplayMember = "descripcion";
            cProductoVenta.ValueMember = "Id_producto";
            cProductoVenta.SelectedIndex = -1;
        }

        private void cProductoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cProductoVenta.SelectedItem is DataRowView fila) // fila solo existe aquí
            {
                decimal precio = fila["precio"] != DBNull.Value
                                ? Convert.ToDecimal(fila["precio"])
                                : 0;

                tPrecioVenta.Text = precio.ToString("F2");
            }
            else
            {
                tPrecioVenta.Text = "0.00";
            }

            ActualizarTotal();
        }

        private void lTotalVenta_Click(object sender, EventArgs e)
        {

        }

        private void tTotalVenta_TextChanged(object sender, EventArgs e)
        {
            tTotalVenta.ReadOnly = true;
        }

        private void ActualizarTotal()
        {
            if (decimal.TryParse(tPrecioVenta.Text, out decimal precio) &&
            decimal.TryParse(tCantidadVenta.Text, out decimal cantidad))
            {
                decimal total = precio * cantidad;
                tTotalVenta.Text = total.ToString("F2");
            }
            else
            {
                tTotalVenta.Text = "0.00";
            }
        }

        private void BCargarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Recuperar datos del formulario
                int id_cliente = Convert.ToInt32(cClienteVenta.SelectedValue);
                string id_usuario = "admin"; // o el usuario logueado
                DateTime fecha_venta = DateTime.Now;
                decimal totalVenta = Convert.ToDecimal(tTotalVenta.Text);

                int id_venta;

                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();

                    // 2️⃣ Insertar la venta y obtener idVenta
                    string sqlInsertVenta = @"INSERT INTO venta (Id_cliente, fecha_venta, id_usuario, total_venta)
                                            VALUES (@Id_cliente, @fecha_venta, @id_usuario, @total_venta);
                                            SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(sqlInsertVenta, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id_cliente", id_cliente);
                        cmd.Parameters.AddWithValue("@fecha_venta", fecha_venta);
                        cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                        cmd.Parameters.AddWithValue("@total_venta", totalVenta);

                        id_venta = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 3️⃣ Insertar los productos en venta_detalle
                    foreach (DataGridViewRow fila in dgListadoVentas.Rows)
                    {
                        if (fila.Cells["id_producto"].Value != null)
                        {
                            int id_producto = Convert.ToInt32(fila.Cells["Id_producto"].Value);
                            int cantidad = Convert.ToInt32(fila.Cells["cantidad"].Value);
                            decimal precio = Convert.ToDecimal(fila.Cells["precio"].Value);

                            string sqlDetalle = @"INSERT INTO venta_detalle (Id_venta, id_producto, cantidad, precio)
                                                VALUES (@Id_venta, @id_producto, @cantidad, @precio);";

                            using (SqlCommand cmdDetalle = new SqlCommand(sqlDetalle, conn))
                            {
                                cmdDetalle.Parameters.AddWithValue("@Id_venta", id_venta);
                                cmdDetalle.Parameters.AddWithValue("@Id_producto", id_producto);
                                cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad);
                                cmdDetalle.Parameters.AddWithValue("@precio", precio);

                                cmdDetalle.ExecuteNonQuery();
                            }
                        }
                    }
                }

                // 4️⃣ Cargar automáticamente los productos de la venta en dgListadoVentas
                CargarDetalleVenta(id_venta);

                // 5️⃣ Limpiar controles del formulario
                cClienteVenta.SelectedIndex = -1;
                tTotalVenta.Clear();
                // Si tienes otro control para agregar productos, limpiarlos también

                MessageBox.Show("Venta registrada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message);
            }
        }

        // Método para cargar productos de una venta en dgListadoVentas
        private void CargarDetalleVenta(int id_venta)
        {
            string sql = @"SELECT vd.Id_producto, p.descripcion, vd.cantidad, vd.precio, (vd.cantidad*vd.precio) as subtotal
                         FROM venta_detalle vd
                         INNER JOIN producto p ON vd.Id_producto = p.Id_producto
                         WHERE vd.Id_venta = @Id_venta";

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_venta", id_venta);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgListadoVentas.DataSource = dt;
                }
            }
        }

        private void dgListadoVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

