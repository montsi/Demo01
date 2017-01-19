using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            Console.Write("Anna luku: ");
            int luku = int.Parse(Console.ReadLine());
            while (luku != 0)           // jatketaan niin kauan kun annettu luku ei ole 0 ..
            {
                summa = summa + luku;               // summataan lukuja
                Console.Write("Anna luku: ");
                luku = int.Parse(Console.ReadLine());
            }
            Console.Write("Antamiesi lukujen summa on: " + summa);
            Console.ReadLine();
        }
    }
}
