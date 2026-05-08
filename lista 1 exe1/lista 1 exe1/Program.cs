using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lista_1_exe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l;
            int a;

            Console.WriteLine("digite um valor para uns dos lados: ");
            l = int.Parse(Console.ReadLine());

            a = l * l;

            Console.WriteLine("A área do quadrado que tem lado de {0} é {1}", l, a);


        }
    }
}
