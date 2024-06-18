using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Projekt
{
    public static class Prijave
    {

        public static List<string> dobij_korisnike()
        {
            List<string> korisnici = new List<string>();
            var fileLocation = File.ReadAllLines("../../Resources/Korisnici.txt");
            List<string> lines = new List<string>(fileLocation);

            for (int i = 0; i < lines.Count; i++)
            {

                string line = lines[i];
                korisnici.Add(line);

            }

            return korisnici;
        }

        public static List<string> imena()
        {
            List<string> korisnici = new List<string>();
            var fileLocation = File.ReadAllLines("../../Resources/Korisnici.txt");
            List<string> lines = new List<string>(fileLocation);
            string v = ",";

            for (int i = 0; i < lines.Count; i++)
            {

                string line = lines[i].Split(v.ToCharArray()).ToList()[0];
                korisnici.Add(line);

            }

            return korisnici;
        }

        public static void zapisi(string filepath, List<string> crte)
        {

            StreamWriter sw = new StreamWriter(filepath);
            
            foreach (var x in crte)
            {

                sw.WriteLine(x);

            }
            sw.Close();

        }

    }
}
