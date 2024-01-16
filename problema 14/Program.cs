using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa monotona prin rotiri succesive. " +
               "Determinati daca o secventa de n numere este o secventa monotona rotita. ");
            string[] t = Console.ReadLine().Split(' ');

            int[] numbers = new int[t.Length];
            for (int i = 0; i < t.Length; i++) numbers[i] = int.Parse(t[i]);

            bool crescatoare = true;
            bool descrescatoare = true;

            if (numbers[0] == numbers[numbers.Length - 1]) crescatoare = false;
            else
            {
                for (int i = 1; i < numbers.Length - 1; i++)
                {
                    if (numbers[i - 1] > numbers[i]) crescatoare = false;
                    if (numbers[i - 1] < numbers[i]) descrescatoare = false;
                }
            }

            if (crescatoare) Console.WriteLine("Secventa este monoton crescatoare rotita");
            else if (descrescatoare) Console.WriteLine("Secventa este monoton descrescatoare rotita");
            else Console.WriteLine("Secventa nu este monoton rotita");
            Console.ReadKey();
        }
    }
}
