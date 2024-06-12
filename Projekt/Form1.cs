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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Flota flotaForm = new Flota();  
            flotaForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Skiperi skiperiForm = new Skiperi();
            skiperiForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Skiperi.odabrani;
            textBox2.Text = Flota.odabrani;
        }


    }
}
