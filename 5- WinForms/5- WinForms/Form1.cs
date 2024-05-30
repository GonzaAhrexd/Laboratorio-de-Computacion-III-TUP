namespace _5__WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Haz una suma en una nueva ventana como los  alert de javascript
            MessageBox.Show("La suma es: " + (Convert.ToInt32(num1.Text) + Convert.ToInt32(num2.Text)));



        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La resta es: " + (Convert.ToInt32(num1.Text) - Convert.ToInt32(num2.Text)));

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La resta es: " + (Convert.ToInt32(num1.Text) - Convert.ToInt32(num2.Text)));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La suma es: " + (Convert.ToInt32(num1.Text) + Convert.ToInt32(num2.Text)));


        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La resta es: " + (Convert.ToInt32(num1.Text) - Convert.ToInt32(num2.Text)));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La multiplicación es: " + (Convert.ToInt32(num1.Text) * Convert.ToInt32(num2.Text)));

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La división es: " + (Convert.ToDouble(num1.Text) / Convert.ToDouble(num2.Text)));

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Abre  el  From2
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
