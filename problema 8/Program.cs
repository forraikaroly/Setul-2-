using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determianti al n-lea numar din sirul lui Fibonacci. " +
    "Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). " +
    "Exemplu: 0, 1, 1, 2, 3, 5, 8 ...");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Numarul din sirul lui Fibonacci este" + " " + fib(n));
            Console.ReadKey();
        }
        static int fib(int n)
        {
            if (n == 1) return n;
            else if (n == 0) return 0;
            else return fib(n - 1) + fib(n - 2);

        }
    }
}
