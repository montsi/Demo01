using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[] pisteet = new int[5];   // tehdään taulukko
            for (i = 0; i <= 4; i++)    // pyydetään ja luetaan viisi lukua taulukkoon
            {
                Console.Write("Anna hypyn pisteet: ");
                int luku = int.Parse(Console.ReadLine());
                pisteet[i] = luku;
            }
            for ()
            {
                if (pisteet[0] > pisteet[])             //vertailut
                {
                    Console.WriteLine("Suurin luku on: " + num1);
                }
            }
            Console.ReadLine();
        }
    }
}
