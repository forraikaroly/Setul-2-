using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa." +
               " Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor." +
               " De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. ");
            string[] t = Console.ReadLine().Split(' ');
            Stack<String> stack = new Stack<String>();
            int stackMaxSize = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (stack.Count != 0 && t[i].Equals("1") && stack.Peek().Equals("0")) stack.Pop();
                else stack.Push(t[i]);

                if (stack.Count > stackMaxSize) stackMaxSize = stack.Count;
            }

            if (stack.Count == 0) Console.WriteLine("Secventa este corecta. Nivel maxim incubare: " + stackMaxSize);
            else Console.WriteLine("Secventa este incorecta.");
        }
    }
}
