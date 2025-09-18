using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuruczG_feladat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adjon meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());

            if (szam % 2 == 0)
            {
                Console.WriteLine("A szám páros.");
            }
            else
            {
                Console.WriteLine("A szám páratlan.");
            }

        //2. feladat
            if (szam > 0)
            {
                Console.WriteLine("A szám pozitív.");
            }
            else if (szam < 0)
            {
                Console.WriteLine("A szám negatív.");
            }
            else
            {
                Console.WriteLine("A szám nulla.");
            }

        //3. feladat 
            Console.Write("Adjon meg egy számot (1-12) között és megmondom melyik évszakban van: ");
            int honap = int.Parse(Console.ReadLine());
            if (honap == 12 || honap == 1 || honap == 2)
            {
                Console.WriteLine("Tél");
            }
            else if (honap >= 3 && honap <= 5)
            {
                Console.WriteLine("Tavasz");
            }
            else if (honap >= 6 && honap <= 8)
            {
                Console.WriteLine("Nyár");
            }
            else if (honap >= 9 && honap <= 11)
            {
                Console.WriteLine("Ősz");
            }
            else
            {
                Console.WriteLine("Hibás hónap szám!");
            }

            








        }
    }
}
