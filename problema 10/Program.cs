using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se da o secventa de n numere. " +
    "Care este numarul maxim de numere consecutive egale din secventa. ");
            string[] t = Console.ReadLine().Split(' ');
            int max = 1;
            int nr = 1;
            for (int i = 1; i < t.Length; i++)
                if (int.Parse(t[i - 1]) == int.Parse(t[i])) nr++;
                else nr = 1;
            if (nr > max) max = nr;
            Console.WriteLine("Numarul maxim de numere consecutive egale din secventa este" + " " + max);
            Console.ReadKey();

        }
    }
}
