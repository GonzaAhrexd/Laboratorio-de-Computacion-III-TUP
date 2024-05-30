using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abre el form 1 al hacer click
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtener datos desde el text.txt
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\gonza\OneDrive\UTN\TUP2_1\LabComputacion3\Ejercicios\Lab3\6- Archivos\WinFormsApp1\WinFormsApp1\text.txt");
            //Mostrar los datos en el dataGridView
            foreach(string line in lines)
            {
                dataGridView1.Rows.Add(line);
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
