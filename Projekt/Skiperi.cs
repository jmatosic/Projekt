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
        public static string odabrani="";
        public Skiperi()
        {
            InitializeComponent();
        }

        private void Skiperi_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var fileLocation = File.ReadAllLines("C:\\Users\\jani\\Desktop\\inf\\carter02\\Projekt\\Resources\\Skiperi.txt");
            List<string> lines = new List<string>(fileLocation);

            for(int i= 0; i < lines.Count; i++)
            {
                listBox1.Items.Add(lines[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabrani = listBox1.SelectedItem.ToString();
            Form1 form1Form = new Form1();
            form1Form.ShowDialog();
        }
    }
}
