using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Bsp1
{
    internal class Program
    {
        private delegate int calcThis(int is1, int is2);

        static void Main(string[] args)
        {
            calcThis addi = new calcThis(Calc.addThis);
            calcThis subbi = Calc.subThis;
            calcThis multi = Calc.multThis;
            calcThis divi = Calc.divThis;

            calcThis fullCalc = addi + subbi + multi + divi;

            int[] intArr = { 2, 3, 4, 5 };
            Umwandeln(intArr, fullCalc);
        }

        static void Umwandeln(int[] werte, calcThis doThis)
        {
            Random rnd = new Random();
            int zahl = 0;
            for (int i = 0; i < werte.Length; i++)
            {
                System.Threading.Thread.Sleep(3);               
                zahl = rnd.Next(1, 8);
                System.Threading.Thread.Sleep(3);
                Console.WriteLine($"Zahlen: {werte[i]} und {zahl}");
                werte[i] = doThis(werte[i], zahl);
                Console.WriteLine("===============");
            }
        }
    }
}
