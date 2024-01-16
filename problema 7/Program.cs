using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        Console.WriteLine("Se da o secventa de n numere. " +
                "Sa se determine cea mai mare si cea mai mica valoare din secventa. ");
            string[] t = Console.ReadLine().Split(' ');
            int max = int.Parse(t[0]);
            int min = int.Parse(t[0]); 
            for (int i = 0; i < t.Length; i++)
            { 
                if (int.Parse(t[i]) > max) max = int.Parse(t[i]);
                if (int.Parse(t[i]) < min) min = int.Parse(t[i]);
            }
            Console.WriteLine("Cea mai mare valoare este" + " " + max + " " +
                              "si cea mai mica valoare este" + " " + min);
            Console.ReadKey();
            

        }
    }
}
