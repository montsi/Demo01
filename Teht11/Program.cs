using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna kokonaisluku: ");
            int luku = int.Parse(Console.ReadLine());
            int rivinro, sarakenro;

            for (rivinro = 1; rivinro <= luku; rivinro++) // silmukka pyörii kunnes rivinro on pienempi tai yhtäsuuri kuin annettu luku, rivinro kasvaa
            {
                for (sarakenro = 1; sarakenro <= rivinro; sarakenro++)  // tulostetaan niin monta kertaa kuin sarakenro, sarakenro kasvaa
                {
                    Console.Write("*");
                }
                Console.WriteLine();        // rivi vaihtuu vasta kun edellinen silmukka on pyörinyt vaaditun määrän
            }
            Console.ReadLine();
        }
    }
}
