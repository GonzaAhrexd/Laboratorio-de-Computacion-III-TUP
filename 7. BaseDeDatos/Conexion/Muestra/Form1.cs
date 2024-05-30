using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;  // Asegúrate de que estás usando el espacio de nombres correcto

namespace Muestra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Opcional: Cargar los datos al cargar el formulario
            refresco();
        }

        public void refresco()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "GONZA-LAPTOP";
            builder.InitialCatalog = "UNIVERSIDAD";
            builder.IntegratedSecurity = true;
            String connectionString = builder.ConnectionString;

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM alumnos";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    using(SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        // Asegúrate de que dataGridView1 esté inicializado
                        if(dataGridView1 != null)
                        {
                            dataGridView1.DataSource = table;
                            dataGridView1.Columns[0].HeaderText = "Nombre";
                            dataGridView1.Columns[1].HeaderText = "Apellido";
                            dataGridView1.Columns[2].HeaderText = "DNI";
                        }
                        else
                        {
                            MessageBox.Show("dataGridView1 no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            refresco();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abre el form2
            Form2 form2 = new Form2(); 
                form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
