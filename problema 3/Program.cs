using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculati suma si produsul numerelor de la 1 la n. ");
            int n = int.Parse(Console.ReadLine());
            int produs = 1;
            for (int i = 1; i <= n; i++) produs *= i;
            Console.WriteLine("Suma =" + " " + (n * (n + 1)) / 2 + "," +
                              "Produsul =" + " " + produs);
            Console.ReadKey();


        }
    }
}
