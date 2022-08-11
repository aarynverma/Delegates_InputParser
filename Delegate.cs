using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Delegate
    {
        public delegate string onWord(string a);

        public static string Isword(string a)
        {
            return $"{a} is a word";
        }

        public static string Isnumber(string a)
        {
            return $"{a} is a number";
        }

        public static string Isjunk(string a)
        {
            return $"{a} is a junk";
        }
    }
}
