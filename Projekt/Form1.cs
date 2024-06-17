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

        public string skiper { get; set; }
        public string brod { get; set; }
        public Form1(string skiper, string brod)
        {
            this.skiper = skiper;
            this.brod = brod;
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Flota flotaForm = new Flota(this.skiper);
            this.Close();
            flotaForm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Skiperi skiperiForm = new Skiperi(this.brod);
            this.Close();
            skiperiForm.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.skiper != "")
            {

                textBox1.Text = this.skiper;


            }
            if (this.brod != "")
            {

                textBox2.Text = this.brod;

            }

        }


    }
}
