using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossKlein
{
    internal class Character
    {
        public static void UpperCase(string s)
        {
            Console.WriteLine("String in Großbuchstaben: " + s.ToUpper());
        }

        public static void LowerCase(string s)
        {
            Console.WriteLine("String in Kleinbuchstaben: " + s.ToLower());
        }

        public static void UpperLower(string s)
        {
            string revUpLow = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]) && s[i] < 97) //Großbuchstabe
                    revUpLow += (char)(s[i] + 32);    //wird zu Kleinbuchstaben

                else if (Char.IsLetter(s[i]) && s[i] > 96) //Kleinbuchstabe
                    revUpLow += (char)(s[i] - 32);         //wird zu Großbuchstaben

                else
                    revUpLow += s[i]; //Kein Buchstabe = keine Veränderung
            }
            Console.WriteLine("String in umgekehrter Groß-/Kleinschreibung: " + revUpLow);
        }
    }
}
