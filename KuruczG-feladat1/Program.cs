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

             
            









        }
    }
}
