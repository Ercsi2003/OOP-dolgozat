using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemelyauto szemelyauto = new Szemelyauto(5, 6.5, "Fehér","Toyota","Corolla",2021,8000000,15000);

            Terepjaro terepjaro = new Terepjaro("4WD", true, 3500, "Land Rover", "Defender", 2020, 15000000, 20000);

            Autoszalon autoszalon = new Autoszalon();


            

            autoszalon.UjJarmuHozzaadasa(szemelyauto);
            autoszalon.UjJarmuHozzaadasa(terepjaro);
            autoszalon.UgyfelHozzaadasa("Taylor Swift", "California, Hightown Road 54.", "06207823755");
            autoszalon.JarmuEladasa("Toyota", "Corolla", 0);
            autoszalon.JarmuKereses("Land Rover", "Defender");
            autoszalon.JarmuvekListazasa();
            
            Console.ReadLine();
        }
    }
}
