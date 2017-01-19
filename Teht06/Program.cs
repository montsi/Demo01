using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ajomatka kilometreina: ");
            double matka = double.Parse(Console.ReadLine());
            double kulutus = 7.02 / 100 * matka;    // lasketaan kulutus ja lisätään liukulukumuutujaan
            double kustannus = kulutus * 1.595;
            string eurot = kustannus.ToString("N2");    // muutetaan kustannukset euroina merkkijonoksi kahden desimaalin tarkkuudella

            Console.WriteLine("Bensaa kuluu: " + kulutus + " litraa, kustannus " + eurot + " euroa.");
            Console.ReadLine();
        }
    }
}
