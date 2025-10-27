using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms;

namespace AvicolaVentas
{
    public partial class FLogin : Form

    {

        string connectionString = @"Data Source=FERNANDO\SQLEXPRESS02;Initial Catalog=AvicolaSantaAna1;Integrated Security=True;TrustServerCertificate=True;";
        public FLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.Opacity = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TBusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TContrase�a_TextChanged(object sender, EventArgs e)
        {

        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.Location = new Point(100, 100); // Fuerza una posici�n visible
            this.ShowInTaskbar = true;

        }

        private void BIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = TBUsuario.Text.Trim();
            string contrase�a = TBContrase�a.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrase�a))
            {
                MessageBox.Show("Ingrese usuario y contrase�a.");
                return;
            }



            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT id_usuario, Nombre, Apellido, id_rol, Dni 
                 FROM Usuario 
                 WHERE (Dni = @Usuario)
                   AND contrase�a = @Contrase�a 
                   AND baja = 0";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@Usuario", SqlDbType.Int).Value = int.Parse(usuario);
                    cmd.Parameters.Add("@Contrase�a", SqlDbType.VarChar, 600).Value = contrase�a;

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int? idUsuario = reader["id_usuario"] != DBNull.Value ? Convert.ToInt32(reader["id_usuario"]) : 0;
                            int? idRol = reader["id_rol"] != DBNull.Value ? Convert.ToInt32(reader["id_rol"]) : 0;
                            int? Dni = reader["Dni"] != DBNull.Value ? Convert.ToInt32(reader["Dni"]) : 0;

                            string? nombre = reader["Nombre"] != DBNull.Value ? reader["Nombre"].ToString() : "";
                            string? apellido = reader["Apellido"] != DBNull.Value ? reader["Apellido"].ToString() : "";

                            string? nombreCompleto = nombre + " " + apellido;

                            // Abrir formulario principal
                            this.Hide();
                            FormMenu menu = new FormMenu(idUsuario, nombreCompleto, idRol, Dni);
                            menu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contrase�a incorrectos, o el usuario est� dado de baja.");
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

