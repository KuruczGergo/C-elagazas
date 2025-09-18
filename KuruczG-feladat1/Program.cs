using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

            //4. feladat
            Console.Write("Adja meg az életkorát és eldöndtöm, hogy szavazhat-e: ");
            int eletkor = int.Parse(Console.ReadLine());
            if (eletkor >= 18)
            {
                Console.WriteLine("Szavazhat.");
            }
            else
            {
                Console.WriteLine("Nem szavazhat.");
            }

            //5. feladat
            Console.Write("Adjon meg egy osztályzatot (1-5): ");
            int osztalyzat = int.Parse(Console.ReadLine());
            if (osztalyzat == 5)
            {
                Console.WriteLine("Jeles");
            }
            else if (osztalyzat == 4)
            {
                Console.WriteLine("Jó");
            }
            else if (osztalyzat == 3)
            {
                Console.WriteLine("Közepes");
            }
            else if (osztalyzat == 2)
            {
                Console.WriteLine("Elégséges");
            }
            else if (osztalyzat == 1)
            {
                Console.WriteLine("Elégtelen");
            }
            else
            {
                Console.WriteLine("Hibás osztályzat!");
            }

            //6. feladat
            int randomszam = 13;
            Console.Write("Tippeljen egy számra 1 és 20 között: ");
            int tipp = int.Parse(Console.ReadLine());
            if (tipp < 1 || tipp > 20)
            {
                Console.WriteLine("Hibás tipp!");
            }
            else if (tipp == randomszam)
            {
                Console.WriteLine("Gratulálok, eltalálta a számot!");
            }
            else if (tipp < randomszam)
            {
                Console.WriteLine("A tipp kisebb, mint a szám.");
            }
            else
            {
                Console.WriteLine("A tipp nagyobb, mint a szám.");
            }

            //7. feladat
            Console.Write("Adjon meg egy számot és megmondom, hogy egy páros pozitív szam-e: ");
            int szam2 = int.Parse(Console.ReadLine());
            if (szam2 > 0 && szam2 % 2 == 0)
            {
                Console.WriteLine("A szám egy páros pozitív szám.");
            }
            else
            {
                Console.WriteLine("A szám nem egy páros pozitív szám.");
            }


            //8. feladat
            Console.Write("Adjon meg egy karaktert és eldöntöm, hogy szám vagy betű-e");
            char karakter = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsLetter(karakter))
            {
                Console.WriteLine("A karakter betű.");
            }
            else if (char.IsDigit(karakter))
            {
                Console.WriteLine("A karakter szám.");
            }
            else
            {
                Console.WriteLine("A karakter sem betű, sem szám.");
            }

            











        }
    }
}
