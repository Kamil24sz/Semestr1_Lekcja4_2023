using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Średnia_Ocen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int matematyka = int.Parse(textBox1.Text);
            int polski = int.Parse(textBox2.Text);
            int fizyka = int.Parse(textBox3.Text);
            int angielski = int.Parse(textBox4.Text);
            int informatyka = int.Parse(textBox5.Text);

            int suma = matematyka + polski + fizyka
            + angielski + informatyka;

            //rzotowanie - konwersja typów
            float srednia = (float)suma / 5;

            textBox6.Text = srednia.ToString();


        }
    }
}
