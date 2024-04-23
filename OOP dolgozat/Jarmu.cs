using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dolgozat
{
    internal class Jarmu
    {
        public string Gyarto {  get; set; }
        public string Modell { get; set; }
        public int Evjarat { get; set; }
        public int AlapAr {  get; set; }
        public int Kilometerallas { get; set; }

        public Jarmu(string gyarto, string modell, int evjarat, int alapAr, int kilometerallas)
        {
            Gyarto = gyarto;
            Modell = modell;
            Evjarat = evjarat;
            AlapAr = alapAr;
            Kilometerallas = kilometerallas;
        }

        public void JarmuInfo()
        {
            Console.WriteLine($"Gyártó: {Gyarto} \n Modell: {Modell} \n Évjárat: {Evjarat} \n Alap ár: {AlapAr} \n Kilóméterállás: {Kilometerallas}");
        }

        public int ArKalkulacio()
        {
            int price = AlapAr -= (Evjarat * 1000);
            return price;
        }

        public void KmAllasFrissites(int km)
        {
            Kilometerallas += km;
        }
    }
}
