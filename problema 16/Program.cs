using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive" +
                              " (rotire = primul element devine ultimul). Se da o secventa de n numere. " +
                              "Se cere sa se determine daca este o secventa bitonica rotita. ");
            String[] t = Console.ReadLine().Split(' ');
            int[] v = new int[t.Length];
            for (int i = 0; i < t.Length; i++) v[i] = int.Parse(t[i]);


            bool secventaBitonica = false;
            for (int i = 0; i < v.Length; i++)
            {

                int med = 0;
                for (int j = 0; j < v.Length - 1; j++)
                    if (v[j] >= v[med])
                        med = j;
                bool crescatoare = true;
                for (int j = 1; j < med; j++)
                    if (v[j - 1] > v[j])
                        crescatoare = false;
                bool descrescatoare = true;
                for (int j = med; j < v.Length - 1; j++)
                    if (v[j + 1] > v[j])
                        descrescatoare = false;

                if (descrescatoare && crescatoare) secventaBitonica = true;


                int aux = v[v.Length - 1];
                for (int j = v.Length - 1; j > 0; j--) v[j] = v[j - 1];
                v[0] = aux;
            }

            if (secventaBitonica) Console.WriteLine("Secventa este bitonica rotita");
            else Console.WriteLine("Secventa nu este bitonica rotita");
            Console.ReadKey();

        }
    }
}
