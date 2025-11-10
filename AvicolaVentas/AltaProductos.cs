using Microsoft.Data.SqlClient;
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
    public partial class fGestionProductos : Form
    {
        private readonly string cadenaConexion = @"Data Source=localhost\SQLEXPRESS02;Initial Catalog=AvicolaSantaAna1;Integrated Security=True;TrustServerCertificate=True;";


        public fGestionProductos()
        {
            InitializeComponent();
        }

        private void AltaProductos_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        //VALIDACIONES DE CAMPOS
        private void tPrecioProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void tStockProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tCostoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbCategoriaProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularStockMinimo();

            if (cbCategoriaProd.SelectedValue != null && cbCategoriaProd.SelectedValue is int)
            {
                int idCategoria = Convert.ToInt32(cbCategoriaProd.SelectedValue);
                CargarTiposProducto(idCategoria);
            }

        }

        //METODOS AUXILIARES
        private void CalcularStockMinimo()
        {
            // Por ahora, un valor base según categoría
            int stockMinimo = 0;

            if (cbCategoriaProd.SelectedItem == null)
            {
                tStockMinimo.Text = "0";
                return;
            }

            string categoria = cbCategoriaProd.SelectedItem.ToString();

            switch (categoria)
            {
                case "Pollos":
                    stockMinimo = 15;
                    break;
                case "Huevos":
                    stockMinimo = 150;
                    break;
                case "Fiambres":
                    stockMinimo = 8;
                    break;
                case "Congelados":
                    stockMinimo = 10;
                    break;
                case "Envasados":
                    stockMinimo = 20;
                    break;
                default:
                    stockMinimo = 10;
                    break;
            }

            tStockMinimo.Text = stockMinimo.ToString();
        }

        private void BGrabarProducto_Click(object sender, EventArgs e)
        {
            GuardarProductos();
            CargarProductos("");
            BLimpiarCampos_Click(sender, e);
        }

        private void CargarCombos()
        {
            CargarCategorias();
            CargarProveedoresEnCombo();
            CargarProductos("");
        }

        private void CargarCategorias()
        {
            string query = "SELECT id_categoria, descripcion FROM Categoria WHERE estado = 1";
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                cbCategoriaProd.DataSource = dt;
                cbCategoriaProd.DisplayMember = "descripcion";
                cbCategoriaProd.ValueMember = "id_categoria";
            }
        }

        private void CargarProveedoresEnCombo()
        {
            string consulta = "SELECT id_proveedor, Nombre FROM Proveedor WHERE estado = 1";
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbProveedorProd.DataSource = dt;
                cbProveedorProd.DisplayMember = "Nombre";
                cbProveedorProd.ValueMember = "id_proveedor";
            }
        }

        private void CargarTiposProducto(int idCategoria)
        {
            string query = "SELECT id_tipo, nombre FROM TipoProducto WHERE id_categoria = @idCategoria";
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cbTipoProducto.DisplayMember = "nombre";
                cbTipoProducto.ValueMember = "id_tipo";
                cbTipoProducto.DataSource = dt;
            }
        }

        private void CargarProveedores()
        {
            string query = "SELECT id_proveedor, nombre FROM Proveedor";
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                cbProveedorProd.DataSource = dt;
                cbProveedorProd.DisplayMember = "nombre";
                cbProveedorProd.ValueMember = "id_proveedor";
            }
        }

        private void GuardarProductos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // 1️⃣ Insertar en la tabla Productos
                    string insertarProducto = @"INSERT INTO Producto (precio, stock, stock_minimo, estado, id_categoria, id_tipo)
                                        OUTPUT INSERTED.id_producto
                                        VALUES (@precio, @stock, @stock_minimo, @estado, @id_categoria, @id_tipo)";

                    int idProductoGenerado;

                    using (SqlCommand comando = new SqlCommand(insertarProducto, conexion))
                    {
                        comando.Parameters.AddWithValue("@precio", Convert.ToDecimal(tPrecioProd.Text));
                        comando.Parameters.AddWithValue("@stock", Convert.ToInt32(tStockProd.Text));
                        comando.Parameters.AddWithValue("@stock_minimo", Convert.ToInt32(tStockMinimo.Text));
                        comando.Parameters.AddWithValue("@estado", 1);
                        comando.Parameters.AddWithValue("@id_categoria", Convert.ToInt32(cbCategoriaProd.SelectedValue));
                        comando.Parameters.AddWithValue("@id_tipo", Convert.ToInt32(cbTipoProducto.SelectedValue));

                        idProductoGenerado = (int)comando.ExecuteScalar(); // Devuelve el ID generado
                    }

                    // 2️⃣ Insertar en la tabla Producto_Proveedor
                    string insertarRelacion = @"INSERT INTO Producto_Proveedor (costo, id_proveedor, id_producto)
                                        VALUES (@costo, @id_proveedor, @id_producto)";

                    using (SqlCommand comando2 = new SqlCommand(insertarRelacion, conexion))
                    {
                        comando2.Parameters.AddWithValue("@costo", Convert.ToDecimal(tCostoProducto.Text));
                        comando2.Parameters.AddWithValue("@id_proveedor", Convert.ToInt32(cbProveedorProd.SelectedValue));
                        comando2.Parameters.AddWithValue("@id_producto", idProductoGenerado);

                        comando2.ExecuteNonQuery();
                    }

                    MessageBox.Show("✅ Producto guardado correctamente");
                    CargarProductos(""); // Recarga el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al guardar el producto: " + ex.Message);
            }
        }
        // CARGAR PROVEEDORES EN EL DATAGRIDVIEW
        private void CargarProductos(string filtroEstado)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = @"
                SELECT 
                    p.id_producto AS id_producto,
                    p.precio AS Precio,
                    p.stock AS Stock,
                    p.stock_minimo AS [Stock Mínimo],
                    CASE 
                        WHEN p.estado = 1 THEN 'Activo'
                        WHEN p.estado = 0 THEN 'Inactivo'
                        ELSE 'Desconocido'
                    END AS Estado,
                    t.nombre AS TipoProducto,
                    pr.nombre AS Proveedor,
                    pp.costo AS Costo
                FROM Producto p
                INNER JOIN TipoProducto t ON p.id_tipo = t.id_tipo
                INNER JOIN Producto_Proveedor pp ON p.id_producto = pp.id_producto
                INNER JOIN Proveedor pr ON pp.id_proveedor = pr.id_proveedor
                ORDER BY p.id_producto DESC";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvListadoProductos.AutoGenerateColumns = true;
                    dgvListadoProductos.DataSource = tabla;

                    // Opcional: ajustar encabezados y tamaño de columnas
                    dgvListadoProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvListadoProductos.Columns["id_producto"].Width = 60;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar los productos: " + ex.Message);
            }
        }

        private void BLimpiarCampos_Click(object sender, EventArgs e)
        {
            cbCategoriaProd.SelectedIndex = -1;
            cbTipoProducto.DataSource = null;
            cbProveedorProd.SelectedIndex = -1;
            tPrecioProd.Clear();
            tStockProd.Clear();
            tStockMinimo.Clear();
            tCostoProducto.Clear();
        }

        private void BModificarProducto_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "UPDATE Producto SET precio = @precio, stock = @stock, stock_minimo = @stock_minimo, estado = @estado, id_tipo = @id_tipo";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@precio", Convert.ToDecimal(tPrecioProd.Text));
                    comando.Parameters.AddWithValue("@stock", Convert.ToInt32(tStockProd.Text));
                    comando.Parameters.AddWithValue("@stock_minimo", Convert.ToInt32(tStockMinimo.Text));
                    comando.Parameters.AddWithValue("@estado", 1);
                    comando.Parameters.AddWithValue("@id_tipo", Convert.ToInt32(cbTipoProducto.SelectedValue));
                    comando.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Cliente modificado exitosamente.");

            CargarProductos("");
            BLimpiarCampos_Click(sender, e);
        }

        private void dgvListadoProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvListadoProductos.Rows[e.RowIndex];
                cbTipoProducto.Text = filaSeleccionada.Cells["TipoProducto"].Value.ToString();
                tPrecioProd.Text = filaSeleccionada.Cells["Precio"].Value.ToString();
                tCostoProducto.Text = filaSeleccionada.Cells["Costo"].Value.ToString();
                tStockProd.Text = filaSeleccionada.Cells["Stock"].Value.ToString();
                tStockMinimo.Text = filaSeleccionada.Cells["Stock Mínimo"].Value.ToString();
                cbProveedorProd.Text = filaSeleccionada.Cells["Proveedor"].Value.ToString();

                CargarCategorias();
                CargarProveedores();

            }
        }

        private void BEliminarProducto_Click(object sender, EventArgs e)
        {
            //Si presionas el botón eliminar cliente sin seleccionar un cliente, te avisa
            if (dgvListadoProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Si seleccionas al cliente, te pide confirmación
            int id_proveedor = Convert.ToInt32(dgvListadoProductos.SelectedRows[0].Cells["Id_producto"].Value);

            DialogResult confirmar = MessageBox.Show(
                $"¿Está seguro de que desea eliminar este producto'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            //Eliminar productos
            try
            {
                if (confirmar == DialogResult.Yes)
                {
                    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                    {
                        conexion.Open();
                        string consulta = "UPDATE Producto SET estado = 0 WHERE id_producto = @id_producto";
                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@id_producto", id_proveedor);
                            comando.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Proveedor eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos("");
                    BLimpiarCampos_Click(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

