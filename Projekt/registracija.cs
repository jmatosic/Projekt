using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class registracija : Form
    {
        public registracija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Sva polja moraju bit popunjena!");
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Šifra ne vrijedi!");
            }
            else if (Prijave.imena().Contains(textBox1.Text))
            {
                MessageBox.Show("Korisničko ime već postoji!");
            }
            else
            {
                List<string> list = new List<string>();
                list = Prijave.dobij_korisnike();
                list.Add(textBox1.Text + ", " + textBox2.Text);
                Prijave.zapisi("../../Resources/Korisnici.txt", list);

                this.Close();

            }
        }
    }
}
