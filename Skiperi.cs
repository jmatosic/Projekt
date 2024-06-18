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
    public partial class Skiperi : Form
    {
        public string brod { get; set; }
        public string odabrani;
        public bool uzlazno;
        public Skiperi(string brod)
        {
            this.brod = brod;
            InitializeComponent();
        }

        private void Skiperi_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            uzlazno = false;
            odabrani = null;
            listBox1.DataSource = Prijave.ucitaj_brodove( odabrani, "Skiperi.txt", uzlazno );
            sviIzbor.Checked = true;


        }



        private void listBox1_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                odabrani = listBox1.SelectedItem.ToString();

                Form1 form1Form = new Form1(odabrani, this.brod);

                form1Form.ShowDialog();
                this.Close();
            }
        }

        private void sviIzbor_CheckedChanged(object sender, EventArgs e)
        {

            odabrani = null;
            listBox1.DataSource = Prijave.ucitaj_brodove(odabrani, "Skiperi.txt", uzlazno);

        }

        private void muskiIzbor_CheckedChanged(object sender, EventArgs e)
        {
            odabrani = " muško";
            listBox1.DataSource = Prijave.ucitaj_brodove(odabrani, "Skiperi.txt", uzlazno);
        }

        private void zeneIzbor_CheckedChanged(object sender, EventArgs e)
        {
            odabrani = " žensko";
            listBox1.DataSource = Prijave.ucitaj_brodove(odabrani, "Skiperi.txt", uzlazno);
        }

        private void godine_silazno_Click(object sender, EventArgs e)
        {

            uzlazno = false;
            listBox1.DataSource = Prijave.ucitaj_brodove(odabrani, "Skiperi.txt", uzlazno);

        }

        private void godine_uzalzno_Click(object sender, EventArgs e)
        {

            uzlazno = true;
            listBox1.DataSource = Prijave.ucitaj_brodove(odabrani, "Skiperi.txt", uzlazno);

        }
    }
}
