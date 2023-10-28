using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public static class Kepregeny
    {
        public static List<ISzuperhos> szuperhosok;
        public static void Szereplok(string fajlnev)
        {
            StreamReader sr = new StreamReader(fajlnev);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] kaksi = sor.Split(' ');
                if (kaksi[0] == "Batman")
                {
                    Batman b = new Batman();
                    for (int i = 1; i < Convert.ToInt32(kaksi[1]); i++)
                    {
                        b.KutyutKeszit();
                    }
                    szuperhosok.Add(b);
                }
                else if (kaksi[0] == "Vasember")
                {
                    Vasember v = new Vasember(21,true);
                    for (int i = 1; i < Convert.ToInt32(kaksi[1]); i++)
                    {
                        v.KutyutKeszit();
                    }
                    szuperhosok.Add(v);
                }

            }
        }
        public static void Szuperhosok()
        {
            foreach (var item in szuperhosok)
            {
                Console.WriteLine(item);
            }
        }
    }
}
