using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dolgozat
{
    internal class Terepjaro : Jarmu
    {
        Random random = new Random();
        public string Hajtas {  get; set; }
        public bool OffRoadKepessegek {  get; set; }
        public int VontatoKepesseg { get; set; }

        public Terepjaro(string hajtas, bool offRoadKepessegek, int vontatoKepesseg, string gyarto, string modell, int evjarat, int alapAr, int kilometerallas) : base(gyarto, modell, evjarat, alapAr,kilometerallas)
        {
            Hajtas = hajtas;
            OffRoadKepessegek = offRoadKepessegek;
            VontatoKepesseg = vontatoKepesseg;
        }

        public void OffRoadCsomagFelszerel()
        {
            int offroadcsomagAr = random.Next(1000, 20000);
            AlapAr += offroadcsomagAr;
            OffRoadKepessegek = true;
        }

        public void VontatoKepessegBeallitasa(int kepesseg)
        {
            VontatoKepesseg = kepesseg;
        }
    }
}
