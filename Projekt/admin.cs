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
using System.Xml.Serialization;

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
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Nisu ispunjena sva polja.");
            }
            else
            {
                List<string> list = new List<string>();
                StreamReader sr = new StreamReader("../../Resources/Skiperi.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    list.Add(line);


                }
                sr.Close();

                StreamWriter sw = new StreamWriter("../../Resources/Skiperi.txt");
                list.Add(textBox1.Text + ", " + comboBox1.Text + ", " + textBox2.Text + Environment.NewLine);
                foreach (var x in list)
                {

                    sw.WriteLine(x);

                }
                sw.Close();

                textBox1.Text = null;
                comboBox1.Text = null;
                textBox2.Text = null;
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
                List<string> list = new List<string>();
                StreamReader sr = new StreamReader("../../Resources/Flota.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    list.Add(line);


                }
                sr.Close();

                StreamWriter sw = new StreamWriter("../../Resources/Flota.txt");
                list.Add(textBox4.Text + ", " + comboBox2.Text + ", " + textBox3.Text + Environment.NewLine);
                foreach (var x in list)
                {

                    sw.WriteLine(x);

                }
                sw.Close();
                textBox4.Text = null;
                comboBox2.Text = null;
                textBox3.Text = null;
                MessageBox.Show("Dodan novi brod u flotu.");
            }
        }
    }
}
