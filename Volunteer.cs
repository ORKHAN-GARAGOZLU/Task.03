using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Volunteer
    {
        static public string ReadString(string text)
        {
        l1:
            Console.Write(text);
            string value = Console.ReadLine();
            if (string.IsNullOrEmpty(value))
            {
                goto l1;
            }
            return value;

        }
        static public int ReadInt(string text)
        {
            int value;
        l1:
            Console.Write(text);
            string valuestr = Console.ReadLine();
            if (!int.TryParse(valuestr, out value))
            {
                goto l1;
            }
            return value;
        }
    }
}
