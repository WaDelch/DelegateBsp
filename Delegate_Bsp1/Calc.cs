using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Bsp1
{
    internal class Calc
    {
        public static int addThis(int i1, int i2)
        {
            Console.WriteLine("Summe: " + (i1 + i2));
            return i1 + i2;
        }

        public static int subThis(int i1, int i2)
        {
            Console.WriteLine("Differenz: " + (i1 - i2));
            return i1 - i2;
        }

        public static int multThis(int i1, int i2)
        {
            Console.WriteLine("Produkt: " + (i1 * i2));
            return i1 * i2;
        }

        public static int divThis(int i1, int i2)
        {
            Console.WriteLine("Quotient: " + (i1 / i2));
            return i1 / i2;
        }
    }
}
