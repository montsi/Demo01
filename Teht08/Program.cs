using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ensimmäinen luku: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)             //vertailut
            {
                Console.WriteLine("Suurin luku on: " + num1);
            }
            if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Suurin luku on: " + num2);
            }
            if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("Suurin luku on: " + num3);
            }         
            Console.ReadLine();
        }
    }
}
