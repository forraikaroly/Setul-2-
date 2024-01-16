using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se da o secventa de n numere. " +
    "Sa se determine daca numerele din secventa sunt in ordine crescatoare. ");
            bool crescatoare = true;
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 1; i < t.Length; i++)
                if (int.Parse(t[i - 1]) > int.Parse(t[i])) crescatoare = false;
            if (crescatoare) Console.WriteLine("Numerele sunt in ordine crescatoare");
            else Console.WriteLine("Numerele nu sunt in ordine crescatoare");
            Console.ReadKey();

        }
    }
}
