using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[] luvut = new int[5];   // tehdään luvut taulukko
            for (i = 0; i <= 4; i++)    // pyydetään ja luetaan viisi lukua taulukkoon
                {
                    Console.Write("Anna luku: ");
                    int luku = int.Parse(Console.ReadLine());                    
                    luvut[i] = luku;
                }
            Console.Write("Luvut päinvastaisessa järjestyksessä ovat: ");
            for (j = 4; j >= 1; j--) Console.Write(luvut[j] + ", "); // tulostetaan aloittaen viimeisestä
            Console.Write("ja " + luvut[0]);                           // tulostetaan viimeinen ilman pilkkua perässä
            Console.ReadLine();
        }
    }
}
