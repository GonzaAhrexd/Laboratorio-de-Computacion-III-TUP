namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Usuario
        {
            public string name { get; set; }
            public string surname { get; set; }
            public string gmail { get; set; }
            public string dni { get; set; }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crea un objeto usuarios y asigna los valores de los campos de texto
            Usuario usuarios = new Usuario();
            usuarios.name = textBox1.Text;
            usuarios.surname = textBox2.Text;
            usuarios.gmail = textBox3.Text;
            usuarios.dni = textBox4.Text;
            // Muestra los valores en un MessageBox
            MessageBox.Show("Nombre: " + usuarios.name + "\nApellido: " + usuarios.surname + "\nGmail: " + usuarios.gmail + "\nDNI: " + usuarios.dni);
            //Guardalo en un archivo csv
            using(StreamWriter file = new StreamWriter(@"C:\Users\gonza\OneDrive\UTN\TUP2_1\LabComputacion3\Ejercicios\Lab3\6- Archivos\WinFormsApp1\WinFormsApp1\text.csv", true))
            {
                file.WriteLine("Nombre: " + usuarios.name + ",\nApellido: " + usuarios.surname + ",\nGmail: " + usuarios.gmail + ",\nDNI: " + usuarios.dni);
                file.Close();
            }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
