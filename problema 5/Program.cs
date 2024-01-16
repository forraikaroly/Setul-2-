using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. " +
                  "Se considera ca primul element din secventa este pe pozitia 0. ");
            string[] t = Console.ReadLine().Split(' ');

            int nr = 0;
            for (int i = 0; i < t.Length; i++)
                if (int.Parse(t[i]) == i)
                    nr++;
            Console.WriteLine(nr);
            Console.ReadKey();

        }
    }
}
