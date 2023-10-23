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
            int broj1, broj2;
            Console.WriteLine("Unesite prvu stranu pravougaonika:\n");
            broj1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite drugu stranu pravougaonika:\n");
            broj2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dijagonala pravougaonika jednaka {0}\n", Math.Sqrt(broj1*broj1+broj2*broj2));
        }
    }
}
