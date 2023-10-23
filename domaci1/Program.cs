using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci1
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj1, broj2;
            Console.WriteLine("Unesite prvi broj:\n");
            broj1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj:\n");
            broj2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}\n", broj1, broj2, broj1+broj2);
            Console.WriteLine("{0} - {1} = {2}\n", broj1, broj2, broj1-broj2);
            Console.WriteLine("{0} * {1} = {2}\n", broj1, broj2, broj1*broj2);
            Console.WriteLine("{0} / {1} = {2}\n", broj1, broj2, broj1/broj2);
            Console.WriteLine("{0} % {1} = {2}\n", broj1, broj2, broj1%broj2);
        }
    }
}
