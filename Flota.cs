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
    public partial class Flota : Form
    {
        public string odabrani;
        public string skiper { get; set; }
        public bool sortiraj_uzlaznjo;
        public Flota( string skiper )
        {
            this.skiper = skiper;
            InitializeComponent();
        }



        private void Flota_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            odabrani = null;
            sortiraj_uzlaznjo = true;
            izborSvi.Checked = true;
            listBox1.DataSource = Prijave.ucitaj_brodove( odabrani ,"Flota.txt", sortiraj_uzlaznjo);

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            odabrani = listBox1.SelectedItem.ToString();
            Form1 form1Form = new Form1(this.skiper, odabrani);
            form1Form.ShowDialog();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            odabrani = null;
            listBox1.DataSource = Prijave.ucitaj_brodove(odabrani, "Flota.txt", sortiraj_uzlaznjo);



        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            odabrani = " gliser";
            listBox1.DataSource = Prijave.ucitaj_brodove(odabrani, "Flota.txt", sortiraj_uzlaznjo);


        }

        private void izborJedrilica_CheckedChanged(object sender, EventArgs e)
        {
            odabrani = " jedrilica";
            listBox1.DataSource = Prijave.ucitaj_brodove( odabrani, "Flota.txt", sortiraj_uzlaznjo);

 

        }

        private void izborKatamaran_CheckedChanged(object sender, EventArgs e)
        {
            odabrani = " katamaran";

            listBox1.DataSource = Prijave.ucitaj_brodove(odabrani, "Flota.txt", sortiraj_uzlaznjo);


        }

        private void cijene_uzlazno_Click(object sender, EventArgs e)
        {
            sortiraj_uzlaznjo = true;
            listBox1.DataSource = Prijave.ucitaj_brodove( odabrani, "Flota.txt", sortiraj_uzlaznjo);

        }

        private void cijene_silazno_Click(object sender, EventArgs e)
        {

            sortiraj_uzlaznjo = false;
            listBox1.DataSource = Prijave.ucitaj_brodove(odabrani, "Flota.txt", sortiraj_uzlaznjo);

        }
    }
}
