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

        public static string word(string a)
        {
            return $"{a} is a word";
        }

        public static string number(string a)
        {
            return $"{a} is a number";
        }

        public static string junk(string a)
        {
            return $"{a} is a junk";
        }
    }
}
