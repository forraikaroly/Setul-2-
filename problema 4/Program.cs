using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. " +
                             "Se considera ca primul element din secventa este pe pozitia zero. " +
                             "Daca numarul nu se afla in secventa raspunsul va fi -1. ");
            string[] t = Console.ReadLine().Split(' ');
            int a = int.Parse(Console.ReadLine());
            int[] v = new int[t.Length];
            for (int i = 0; i < t.Length; i++)
                v[i] = int.Parse(t[i]);
            Console.WriteLine(Array.IndexOf(v, a));
            Console.ReadKey();

        }
    }
}
