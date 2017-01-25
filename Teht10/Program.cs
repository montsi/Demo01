using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[] { 1, 2, 33, 44, 55, 66, 77, 96, 100};
            /*luvut[0] = 1;                   // alustetaan taulukkopaikkojen arvot
            luvut[1] = 2;
            luvut[2] = 33;
            luvut[3] = 44;
            luvut[4] = 55;
            luvut[5] = 66;
            luvut[6] = 77;
            luvut[7] = 96;
            luvut[8] = 100;*/

            for (int i = 0; i < luvut.Length; i++) // loopataan niin kauan kunnes taulukon kaikki paikat on käyty läpi
            {
                if (i % 2 != 0) Console.WriteLine(luvut[i] + " HEP"); // jos luku on parillinen tulostetaan lisäksi "HEP"
                 
                else Console.WriteLine(luvut[i]);
            }
            Console.ReadLine();
        }
    }
}
