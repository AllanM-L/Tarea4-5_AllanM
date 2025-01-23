using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_5_AllanM
{
    public partial class frm_RegistrarUsuario : Form
    {
        private string connectionString = "Server=DESKTOP-6IIB0IE\\SQLEXPRESS;Database=UsuariosDB;Trusted_Connection=True;";

        public frm_RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Usuarios (Nombre, Apellido) VALUES (@Nombre, @Apellido)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", txt_Nombre.Text);
                        command.Parameters.AddWithValue("@Apellido", txt_Apellido.Text);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Usuario registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

