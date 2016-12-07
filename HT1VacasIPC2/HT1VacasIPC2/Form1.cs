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

        private void button2_Click_1(object sender, EventArgs e)
        {
            double x, y, w = 0;

            double resultado = 0;

            try
            {
                x = double.Parse(textBox5.Text);
                y = double.Parse(textBox6.Text);
                w = double.Parse(textBox7.Text);

                resultado = Math.Sqrt(x) - Math.Pow(y, 2) + w;

                textBox8.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Verifique Datos", "Alerta");
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            double Xuno, Xdos = 0;
            double temp = 0;
            int a, b, c = 0;


            try
            {
                a = int.Parse(this.textBox9.Text);
                b = int.Parse(this.textBox10.Text);
                c = int.Parse(this.textBox11.Text);

                temp = Math.Pow(b, 2) - (4 * a * c);

                a = 2 * a;

                if (Math.Sign(temp) == -1)
                {
                    temp = (Math.Sqrt(-temp)) / a;
                    Xuno = -b / a;
                    textBox12.Text = Xuno + "-" + temp.ToString() + "i";
                    textBox17.Text = Xuno + "+" + temp.ToString() + "i";


                }
                else
                {
                    temp = Math.Sqrt(temp);
                    Xuno = (-b - temp) / a;
                    Xdos = (-b + temp) / a;
                    textBox12.Text = Xuno.ToString();
                    textBox17.Text = Xdos.ToString();

                }

               
            }
            catch
            {
                MessageBox.Show("Verifique Datos", "Alerta");
            }

        }
    }
}
