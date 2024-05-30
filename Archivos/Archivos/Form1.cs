namespace Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Función para leer desde el explorador de archivos un texto
           OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files | *.txt";
            openFileDialog.Title = "Texto";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                // Read the file using the filePath
                // Example code:
                string fileText = File.ReadAllText(filePath);
                textoAMostrar.Text = fileText;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files | *.txt";
            saveFileDialog.Title = "Texto";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                // Save the file using the filePath
                // Example code:
                File.WriteAllText(filePath, textoAMostrar.Text);
            }
        }
    }
}
