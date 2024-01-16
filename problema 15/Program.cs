using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. " +
                "Se da o secventa de n numere. Sa se determine daca este bitonica. ");
            string[] t = Console.ReadLine().Split(' ');
            int[] numbers = new int[t.Length];
            for (int i = 0; i < t.Length; i++) numbers[i] = int.Parse(t[i]);


            int med = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
                if (numbers[i] >= numbers[med])
                    med = i;


            bool crescatoare = true;
            for (int i = 1; i < med; i++)
                if (numbers[i - 1] > numbers[i])
                    crescatoare = false;


            bool descrescatoare = true;
            for (int i = med; i < numbers.Length - 1; i++)
                if (numbers[i + 1] > numbers[i])
                    descrescatoare = false;

            if (crescatoare && descrescatoare) Console.WriteLine("Secventa este bitonica");
            else Console.WriteLine("Nu este o secventa este bitonica");
            Console.ReadKey();

        }
    }
}
