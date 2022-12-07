using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMinMax
{
    delegate bool VergleichsDelegate(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] intArr = new int[10];
            Console.WriteLine("Von den Zahlen:");
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = rnd.Next(1, 101);
                Console.Write(intArr[i] + " ");
            }
            int min = Limit(intArr, istKleiner);
            int min2 = Array.IndexOf(intArr, intArr.Min()) + 1; //Alternative ohne den ganzen Mist
            int max = Limit(intArr, istGroesser);
            int max2 = Array.IndexOf(intArr, intArr.Max()) + 1; //Alternative ohne den ganzen Mist
            Console.WriteLine($"\nist die {min + 1}. die Kleinste und die {max + 1}. die Groesste!");
            Console.WriteLine($"ist die {min2}. die Kleinste und die {max2}. die Groesste!");
        }

        static int Limit(int[] intArr, VergleichsDelegate vd)
        {
            int currMinMax = intArr[0];
            for (int i = 1; i < intArr.Length; i++)
                if (vd(intArr[i], currMinMax))
                    currMinMax = intArr[i];
            return Array.IndexOf(intArr, currMinMax);
        }

        static bool istKleiner(int a, int b)
        {
            return a < b;
        }

        static bool istGroesser(int a, int b)
        {
            return a > b;
        }
    }
}
