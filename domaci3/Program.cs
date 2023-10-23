using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci2
{
    class Program
    {
        static void Main(string[] args)
        {
            int celzijus;
            Console.WriteLine("Unesite temperaturu u Celzijusima:\n");
            celzijus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Temperatura u Farenhajtima jednaka {0}\n", celzijus*18/10+32);
            Console.WriteLine("Temperatura u Kelvinima jednaka {0}\n", celzijus+273);

        }
    }
}

