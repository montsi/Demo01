using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ikäsi: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 18) Console.Write("alaikäinen");  // verrataan annettua ikää, ehdon toteutuessa tulostetaan kommentti
            else if (age >= 18 && age <= 65) Console.Write("aikuinen");
            else Console.Write("seniori");

            Console.ReadLine();
        }
    }
}
