using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dolgozat
{
    internal class Autoszalon
    {
        public List<Jarmu> jarmuvek {  get; set; }
        public List<Ugyfel> kliensek { get; set; }
        public Autoszalon()
        {
            jarmuvek = new List<Jarmu>();
            kliensek = new List<Ugyfel>();
        }

        public void UjJarmuHozzaadasa(Jarmu jarmu)
        {
            jarmuvek.Add(jarmu);
        }

        public bool JarmuEladasa(string gyarto, string modell, int kliensindex)
        {
            foreach (Jarmu jarmu in jarmuvek)
            {
                if(jarmu.Gyarto == gyarto && jarmu.Modell == modell)
                {
                    jarmuvek.Remove(jarmu);
                    kliensek[kliensindex].MegvasaroltJarmu(jarmu);
                    Console.WriteLine($"A {gyarto} {modell} autó megvásárlása sikeres volt!");
                    return true;

                }

            }
            Console.WriteLine($"A {gyarto} {modell} autó megvásárlása sikertelen volt!");
            return false;
        }

        public Jarmu JarmuKereses(string gyarto, string modell)
        {
            foreach (Jarmu jarmu in jarmuvek)
            {
                if(jarmu.Gyarto == gyarto && jarmu.Modell == modell)
                {
                    Console.WriteLine($"A keresett autó ({gyarto} {modell}) megtalálva!");
                    return jarmu;
                }
            }
            Console.WriteLine($"A keresett autó ({gyarto} {modell}) megtalálása sikertelen, nincs készleten!");
            return null;
        }

        public void JarmuvekListazasa()
        {
            foreach (Jarmu jarmu in jarmuvek)
            {
                jarmu.JarmuInfo();
            }
        }

        public void UgyfelHozzaadasa(string nev, string cim, string telefonSzam)
        {
            Console.WriteLine("");
            kliensek.Add(new Ugyfel(nev, cim, telefonSzam));
        }
    }
}
