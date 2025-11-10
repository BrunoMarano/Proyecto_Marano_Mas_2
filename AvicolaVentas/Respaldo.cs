using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace AvicolaVentas
{
    public partial class FRespaldo : Form
    {
        public FRespaldo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog seleccion = new SaveFileDialog();
            seleccion.Filter = "Archivo de respaldo (*.bak)|*.bak";
            seleccion.Title = "Seleccionar archivo de respaldo";

            // Ruta inicial absoluta (usa la carpeta del programa)
            seleccion.InitialDirectory = Path.Combine(Application.StartupPath, "base de datos", "backup");

            // Nombre sugerido con fecha y hora
            seleccion.FileName = "Respaldo_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak";

            if (seleccion.ShowDialog() == DialogResult.OK)
            {
                string ruta = seleccion.FileName;

                // Cadena de conexión a SQL Server
                string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;";

                // Nombre de tu base de datos
                string nombreBase = "AvicolaSantaAna1";

                // Comando BACKUP DATABASE
                string consulta = $@"
            BACKUP DATABASE [{nombreBase}] 
            TO DISK = N'{ruta}' 
            WITH INIT, 
                 SKIP, 
                 NAME = N'{nombreBase} - Respaldo manual', 
                 STATS = 10;
        ";

                try
                {
                    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }

                    // Mostrar la fecha del respaldo
                    LFechaRespaldo.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                    MessageBox.Show("✅ Respaldo realizado con éxito.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al realizar el respaldo:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
