using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna vuosiluku: ");
            int vuosiluku = int.Parse(Console.ReadLine());      

            if ((vuosiluku % 4 == 0 && vuosiluku % 100 != 0) || (vuosiluku % 400 == 0)) // tulostetaan "karkausvuosi" jos luku on jaollinen 4:llä, mutta ei ole tasavuosisata(pl. 400 jaolliset)
            {
                Console.WriteLine( "Antamasi vuosiluku on karkausvuosi");
            }
            else Console.WriteLine("Antamasi vuosiluku ei ole karkausvuosi");
                  
            Console.ReadLine();
        }
    }
}
