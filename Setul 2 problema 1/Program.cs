using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_problema_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se da o secventa de n numere. Sa se determine cate din ele sunt pare. ");
            int n = int.Parse(Console.ReadLine());
            int nr = 0;
            for (int i = 0; i < n; i++)
                if (i % 2 == 0) nr++;
            Console.WriteLine("In secventa de" + " " + n + " " + "numere sunt" + " " + nr + " " + "numere pare");
            Console.ReadKey();
        }
    }
}
