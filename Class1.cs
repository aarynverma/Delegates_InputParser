using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Delegates_InputParser
{
    public class DelegateFunction
    {
        public delegate void onWord(string a);
        public delegate void onNumber(string a);
        public delegate void onJunk(string a);

        public void word(string a)
        {
            if (a.All(char.IsLetter) == true)
                Console.WriteLine("onWord");
            else if (a.All(char.IsLetterOrDigit) == true && a.All(char.IsDigit) == false)
                Console.WriteLine("onWord");
        }

        public void number(string a)
        {
            if (a.All(char.IsDigit) == true)
                Console.WriteLine("onNumber");
        }

        public void junk(string a)
        {
            if (CheckSpecialChar(a) == true)
                Console.WriteLine("onJunk");
        }

        public static bool CheckSpecialChar(string input)
        {
            Regex rgx = new Regex("[^A-Za-z0-9]");
            bool hasSpecialChars = rgx.IsMatch(input);
            return hasSpecialChars;
        }

    }
}
