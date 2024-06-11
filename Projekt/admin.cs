using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text=="" || comboBox1.Text=="")
            {
                MessageBox.Show("Nisu ispunjena sva polja.");
            }
            else
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\jani\\Desktop\\inf\\carter02\\Projekt\\Resources\\Skiperi.txt");
                sw.Write(textBox1.Text + ", " + comboBox1.Text + ", " + textBox2.Text + Environment.NewLine);
                sw.Close();
                textBox1 = null;
                comboBox1 = null;
                textBox2 = null;
                MessageBox.Show("Dodan novi skiper.");
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox3.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Nisu ispunjena sva polja.");
            }
            else
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\jani\\Desktop\\inf\\carter02\\Projekt\\Resources\\Flota.txt");
                sw.Write(textBox4.Text + ", " + comboBox2.Text + ", " + textBox3.Text + Environment.NewLine);
                sw.Close();
                textBox4 = null;
                comboBox2 = null;
                textBox3 = null;
                MessageBox.Show("Dodan novi brod u flotu.");
            }
        }
    }
}
