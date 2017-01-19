using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            int points;
            Console.Write("Give students points: ");
            string line = Console.ReadLine();  
            points = int.Parse(line); 
            // Which number..
            switch (points)
            {
                case 0: 
                case 1: Console.Write("Students number is: 0"); break;
                case 2: 
                case 3: Console.Write("Students number is: 1"); break;
                case 4:
                case 5: Console.Write("Students number is: 2"); break;
                case 6:
                case 7: Console.Write("Students number is: 3"); break;
                case 8:
                case 9: Console.Write("Students number is: 4"); break;
                case 10:
                case 11:
                case 12: Console.Write("Students number is: 5"); break;
                default: Console.Write("Wrong amount of points"); break;

            }
            Console.ReadLine();
        }
    }
}
