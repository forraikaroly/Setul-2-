using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. ");
            Console.WriteLine("Introduceti lungimea secventei");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            Console.WriteLine("Introduceti numerele din secventa\n(dupa fiecare numar apasati tasta Enter)");
            for (int i = n; i > 0; i--)
            {
                int k = int.Parse(Console.ReadLine());
                s = s + (k % 10) * 10 + (k / 10);
            }
            Console.WriteLine("Suma inverselor numerelor din secventa este" + " " + s);
            Console.ReadKey();

        }
    }
}
