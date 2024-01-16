using System;

Console.WriteLine("Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");
string[] t = Console.ReadLine().Split(' ');

int nrn = 0;
int nr0 = 0;
int nrp = 0;

for (int i = 0; i < t.Length; i++)
{
    int n = int.Parse(t[i]);
    if (n == 0) nr0++;
    else if (n < 0) nrn++;
    else nrp++;
}
Console.WriteLine("Numere negative :" + " " + nrn +
                  "Numere egale cu zero :" + " " + nr0 +
                  "Numere pare :" + " " + nrp);
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
