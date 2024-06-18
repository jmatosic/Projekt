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

        public static List<string> ucitaj_brodove(string filter, string filepath, bool uzlazno)
        {

            var fileLocation = File.ReadAllLines("../../Resources/" + filepath);
            List<string> lines = new List<string>(fileLocation);

            List<Tuple<string, int>> skiperi = new List<Tuple<string, int>>();
            string v = ",";

            for (int i = 0; i < lines.Count; i++)
            {

                if (lines[i] != null && lines[i] != "")
                {
                    string uzeto = lines[i].Split(v.ToCharArray()).ToList()[2].Trim();
                    int novi = int.Parse(uzeto);
                    (string upisano, int upisani) = (lines[i], novi);
                    skiperi.Add(new Tuple<string, int>(upisano, upisani));
                }

            }
            lines = new List<string>();
            if (uzlazno)
            {
                skiperi = skiperi.OrderBy(x => x.Item2).ToList();
            }
            else {

                skiperi = skiperi.OrderBy(x => x.Item2).Reverse().ToList();

            }
            
            if (filter == null)
            {
                foreach (var x in skiperi)
                {

                    lines.Add(x.Item1);

                }
            }
            else
            {

                foreach (var x in skiperi)
                {
                    if ( x.Item1.Split( v.ToCharArray() ).ToList()[1] == filter ) {
                        lines.Add(x.Item1);
                    }
                }

            }
            return lines;

        }

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
