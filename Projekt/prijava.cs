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
    public partial class prijava : Form
    {
        public prijava()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Unesite korisničko ime i lozinku!");
            }
            // else if(textBox1.Text!="bilo kojjem kosinickom imenu iz baze podataka" || textBox2.Text!="bilo kojoj lozinci iz baze podataka")
            //{
            //   MessageBox.Show("Neispravno korisničko ime ili lozinka!");
            //}
            else
            {
                List<string> list = Prijave.dobij_korisnike();

                foreach (var x in list)
                {
                    if (x == textBox1.Text + ", " + textBox2.Text)
                    {
                        this.Hide();
                        Form1 form1Form = new Form1("", "");
                        form1Form.ShowDialog();

                    }

                }
                MessageBox.Show("Pogrešni podatci");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            registracija registracijaForm = new registracija();
            registracijaForm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "admin123")
            {

                admin adminForm = new admin();
                adminForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Netočna šifra!");
            }

        }


    }
}
