using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevuygulama2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int   x = 20;
            int y = 13;
            int z = 42;
            Console.WriteLine(23 == 55 && 76 > 45 && 5 < 12);//False
            Console.WriteLine(23>=23 && 45!=18);//True
            Console.WriteLine(x>y && z==y && z<x);//False
            Console.WriteLine(z>x && y<x);//True
            Console.WriteLine(x!=z || y<=z);//True
            Console.ReadLine();//
        }
    }
}
