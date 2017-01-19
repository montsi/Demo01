using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Give first number: ");
            int number1 = int.Parse(Console.ReadLine());     
            Console.Write("Give second number: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Give third number: ");
            int number3 = int.Parse(Console.ReadLine());
            
            int sum = number1 + number2 + number3;      // summataan annetut luvut
            Console.Write("Sum of the three numbers is: " + sum);   // tulostetaan summa
            Console.Write("\n");
            double avg = sum / 3;                       // lasketaan lukujen keskiarvo ja lisätään reelilukumuuttujaan
            Console.Write("Average of the three numbers is: " + avg);
            Console.ReadLine();
        }
        
    }
}
