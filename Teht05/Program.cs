using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna sekunnit: ");
            int allSeconds = int.Parse(Console.ReadLine());

            int hours = allSeconds / 3600;      // jaetaan annetut sekunnit tunnin sekuntimäärällä
            int minutes = allSeconds / 60 % 60;     // jaetaan se määrä sekunteja minuuteiksi joka on 60:lla jaollinen
            int seconds = allSeconds % 60;      

            Console.WriteLine("Antamasi sekunnit voidaan ilmaista muodossa: Tunnit " + hours + " Minuutit " + minutes + " Sekunnit " + seconds);
            Console.ReadLine();
        }
    }
}
