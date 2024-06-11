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
        public Skiperi()
        {
            InitializeComponent();
        }

        private void Skiperi_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\jani\\Desktop\\inf\\carter02\\Projekt\\Resources\\Skiperi.txt");
            listBox1.Text = sr.ReadToEnd();
            sr.Close();
        }


    }
}
