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
        public static string odabrani = "";

        public Flota()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabrani = listBox1.SelectedItem.ToString();
            Form1 form1Form = new Form1();
            form1Form.ShowDialog();
        }

        private void Flota_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var fileLocation = File.ReadAllLines("C:\\Users\\jani\\Desktop\\inf\\carter02\\Projekt\\Resources\\Flota.txt");
            List<string> lines = new List<string>(fileLocation);

            for (int i = 0; i < lines.Count; i++)
            {
                listBox1.Items.Add(lines[i]);
            }
        }
    }
}
