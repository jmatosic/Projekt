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
        public static string odabrani = "";
        public Skiperi(string brod)
        {
            this.brod = brod;
            InitializeComponent();
        }

        private void Skiperi_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var fileLocation = File.ReadAllLines("../../Resources/Skiperi.txt");
            List<string> lines = new List<string>(fileLocation);

            List<Tuple<string, int>> skiperi = new List<Tuple<string, int>>();
            string v = ",";

            for (int i = 0; i < lines.Count; i++)
            {

                if (lines[i]!=null && lines[i] != "")
                {
                string uzeto = lines[i].Split(v.ToCharArray()).ToList()[2].Trim();
                int novi = int.Parse(uzeto);
                (string upisano, int upisani) = (lines[i], novi);
                skiperi.Add(new Tuple<string, int>(upisano, upisani));
                }

            }
            lines = new List<string>();
            skiperi = skiperi.OrderBy(x => x.Item2).Reverse().ToList();
            foreach (var x in skiperi)
            {

                lines.Add(x.Item1);

            }

            listBox1.DataSource = lines;

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
    }
}
