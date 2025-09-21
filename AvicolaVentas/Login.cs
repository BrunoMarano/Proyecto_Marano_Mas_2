using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
using SqlDataAdapter = Microsoft.Data.SqlClient.SqlDataAdapter;
using SqlDataReader = Microsoft.Data.SqlClient.SqlDataReader;

namespace AvicolaVentas
{
    public partial class FLogin : Form

    {

        string connectionString = @"Server=localhost\SQLEXPRESS; Database=AvicolaSantaAna; Trusted_Connection=True; TrustServerCertificate=True;";
        public FLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TBusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void BIniciar_sesion_Click(object sender, EventArgs e)
        {
            
            string usuario = TBusuario.Text.Trim();
            string contraseña = TContraseña.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Ingrese usuario y contraseña.");
                return;
            }

            

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT id_usuario, Nombre, Apellido, id_rol 
                 FROM Usuario 
                 WHERE (Nombre + ' ' + Apellido = @Usuario)
                   AND contraseña = @Contraseña 
                   AND baja = 0";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 200).Value = usuario;
                    cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar, 600).Value = contraseña;

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int? idUsuario = reader["id_usuario"] != DBNull.Value ? Convert.ToInt32(reader["id_usuario"]) : 0;
                            int? idRol = reader["id_rol"] != DBNull.Value ? Convert.ToInt32(reader["id_rol"]) : 0;

                            string? nombre = reader["Nombre"] != DBNull.Value ? reader["Nombre"].ToString() : "";
                            string? apellido = reader["Apellido"] != DBNull.Value ? reader["Apellido"].ToString() : "";

                            string? nombreCompleto = nombre + " " + apellido;

                            // Abrir formulario principal
                            this.Hide();
                            FormMenu menu = new FormMenu(idUsuario, nombreCompleto, idRol);
                            menu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos, o el usuario está dado de baja.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                    }
                }
            }
        }

    }
}

