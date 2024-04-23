using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dolgozat
{
    internal class Ugyfel
    {
        public string Nev {  get; set; }
        public string Cim { get; set; }
        public string TelefonSzam { get; set; }
        public List<Jarmu> vasarlasiElozmenyek {  get; set; } = new List<Jarmu>();

        public Ugyfel(string nev, string cim, string telefonSzam)
        {
            Nev = nev;
            Cim = cim;
            TelefonSzam = telefonSzam;
        }

        public void MegvasaroltJarmu(Jarmu jarmu)
        {
            Console.WriteLine($"A {jarmu.Gyarto} {jarmu.Modell} hozzáadása sikeres volt!");
            vasarlasiElozmenyek.Add(jarmu);
        }
    }
}
