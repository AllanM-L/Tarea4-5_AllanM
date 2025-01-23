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
    public partial class frm_MenuPrincipal : Form
    {
        private string connectionString = "Server=DESKTOP-6IIB0IE\\SQLEXPRESS;Database=UsuariosDB;Trusted_Connection=True;";

        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void CargarUsuarios()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, Nombre, Apellido FROM Usuarios";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgv_Usuarios.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Asistencia_Click(object sender, EventArgs e)
        {

        }

        private void btn_Respaldos_Click(object sender, EventArgs e)
        {

        }

        private void btn_RestaurarBD_Click(object sender, EventArgs e)
        {

        }

        private void btn_Personal_Click(object sender, EventArgs e)
        {

        }


        private void frm_MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_Usuarios_Click_1(object sender, EventArgs e)
        {
            btn_Registrar.Visible = true;
            btn_Recargar.Visible = true;
            dgv_Usuarios.Visible = true;
            
        }

        private void btn_Registrar_Click_1(object sender, EventArgs e)
        {
            using (var frm = new frm_RegistrarUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void btn_Recargar_Click_1(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
    }
}

