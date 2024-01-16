using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive " +
                           "(rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). " +
                            "Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
            string[] t = Console.ReadLine().Split(' ');
            int[] numbers = new int[t.Length];
            for (int i = 0; i < t.Length; i++) numbers[i] = Convert.ToInt32(t[i]);
            bool crescatoare = true;
            if (numbers[0] == numbers[numbers.Length - 1]) crescatoare = false;
            else
            {
                for (int i = 1; i < numbers.Length - 1; i++)
                    if (numbers[i - 1] > numbers[i])
                        crescatoare = false;
            }

            if (crescatoare) Console.WriteLine("Secventa este crescatoare rotita");
            else Console.WriteLine("Secventa  nu este crescatoare rotita");
            Console.ReadKey();

        }
    }
}
