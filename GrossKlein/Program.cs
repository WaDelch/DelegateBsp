using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossKlein
{
    delegate void CharacterDelegate(string s);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib mal was ein:");
            string s = Console.ReadLine();
            CharacterDelegate upper = Character.UpperCase;
            CharacterDelegate lower = Character.LowerCase;
            CharacterDelegate revUpLow = Character.UpperLower;
            CharacterDelegate upperLower = upper + lower + revUpLow;

            //upper(s);
            //lower(s);
            //revUpLow(s);
            Console.WriteLine("===========");
            upperLower(s);
        }
    }
}
