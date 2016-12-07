using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;//para abrir archivos.

namespace HT1VacasIPC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, z = 0;
            int resultado = 0;



          

            try {
                x = int.Parse(this.textBox1.Text);
                y = int.Parse(this.textBox2.Text);
                z = int.Parse(this.textBox3.Text);
                resultado = x + y * z;
                textBox4.Text = resultado.ToString();

            }
            catch {
                MessageBox.Show("Verifique Datos", "Alerta");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           


        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
           
            


           

        }
    }
}
