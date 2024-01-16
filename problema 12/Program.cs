using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. " +
                "De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.");
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numerele din secventa\n(dupa fiecare numar apasati tasta Enter)");
            int groups = 0;
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if (x != 0 && y == 0)
                    groups++;
                x = y;
            }
            Console.WriteLine("Sunt" + " " + groups + " " + "grupuri de numere consecutive");
            Console.ReadKey();
        }
    }
}
