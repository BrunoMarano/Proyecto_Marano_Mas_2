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
        private void tPrecioProd_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tPrecioProd.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número positivo.");
                tPrecioProd.Text = string.Empty;
                return;
            }
        }

        private void tStockProd_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tStockProd.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero positivo.");
                tStockProd.Text = string.Empty;
                return;
            }
        }

        private void tCostoProducto_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tCostoProducto.Text, out decimal costo) || costo < 0)
            {
                MessageBox.Show("El costo debe ser un número positivo.");
                tCostoProducto.Text = string.Empty;
                return;
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

        }

        private void CargarCombos()
        {
            CargarCategorias();
            CargarProveedores();
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
    }
}

