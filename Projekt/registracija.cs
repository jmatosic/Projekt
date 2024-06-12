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
            if(textBox1.Text=="" || textBox2.Text=="" || textBox3.Text=="")
            {
                MessageBox.Show("Sva polja moraju bit popunjena!");
            }
            else if(textBox2.Text!=textBox3.Text)
            {
                MessageBox.Show("Šifra ne vrijedi!");
            }
            else if(textBox1.Text=="bilo koje korisnicko ime iz Korisnici.txt")
            {
                MessageBox.Show("Korisničko ime već postoji!");
            }
            else
            {
                this.Close();
                prijava prijavaForm = new prijava();
                prijavaForm.ShowDialog();

            }
        }
    }
}
