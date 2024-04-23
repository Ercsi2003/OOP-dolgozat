using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dolgozat
{
    
    internal class Szemelyauto : Jarmu
    {   
        Random random = new Random();
        public int UlesekSzama {  get; set; }
        public double Fogyasztas {  get; set; }
        public string Szín {  get; set; }


        public Szemelyauto(int ulesekSzama, double fogyasztas, string Szín, string gyarto, string modell, int evjarat, int alapAr, int kilometerallas) : base(gyarto, modell, evjarat, alapAr, kilometerallas)
        {
            UlesekSzama = ulesekSzama;
            Fogyasztas = fogyasztas;
        }

        public void KenyelmiExtraBeszerzese(string extra)
        {
            int extrakoltseg = random.Next(500, 50000);
            AlapAr += extrakoltseg;
        }

        public void SzínFrissitese(string ujSzin)
        {
            Szín = ujSzin;
        }

    }
}
