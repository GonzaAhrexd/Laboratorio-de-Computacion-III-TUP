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

namespace Muestra
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Al dar agregar, tomar los datos de los textbox y cargar a la base de datos
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "GONZA-LAPTOP";
            builder.InitialCatalog = "UNIVERSIDAD";
            builder.IntegratedSecurity = true;
            String connectionString = builder.ConnectionString;

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO alumnos (nombre, apellido, dni) VALUES (@nombre, @apellido, @dni)";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", textBox1.Text);
                    command.Parameters.AddWithValue("@apellido", textBox2.Text);
                    command.Parameters.AddWithValue("@dni", textBox3.Text);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
