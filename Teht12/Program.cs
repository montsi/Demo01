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
            for (i = 0; i <= 4; i++) 
                {
                    Console.Write("Anna luku: ");
                    int luku = int.Parse(Console.ReadLine());
                    int[] luvut = new int[5];
                    luvut[i] = luku;
                }
            for (j = 5; j >= luvut.Lenght; j--) Console.WriteLine("luku");
            Console.ReadLine();
        }
    }
}
