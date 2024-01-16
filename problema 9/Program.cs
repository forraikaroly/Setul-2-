using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sa se determine daca o secventa de n numere este monotona. " +
                "Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. ");
            string[] t = Console.ReadLine().Split(' ');
            bool crescatoare = true;
            bool descrescatoare = true;
            for (int i = 1; i < t.Length; i++)
                if (int.Parse(t[i - 1]) > int.Parse(t[i]))
                    crescatoare = false;
                else if (int.Parse(t[i]) < int.Parse(t[i]))
                    descrescatoare = false;
            if (crescatoare) Console.WriteLine("Secventa este monoton crescatoare");
            else if (descrescatoare) Console.WriteLine("Secventa este monoton descrescatoare");
            else Console.WriteLine("Secventa nu este monotona");
            Console.ReadKey();

        }
    }
}
