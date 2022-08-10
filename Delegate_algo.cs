using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Delegates
{
    public class ConsoleReader
    {
        public void Run(Delegate.onWord word, Delegate.onNumber number, Delegate.onJunk junk)
        {
            while (true)
            {
                Console.WriteLine("Enter the value");
                string input = Console.ReadLine(); 
                if (input == "")
                {
                    break;
                }
                string response = Response(input, word, number, junk);
                Console.WriteLine(response);
            }
        }
        public string Response(string input, Delegate.onWord word, Delegate.onNumber number, Delegate.onJunk junk)
        {
            if (input.All(char.IsLetter))
            {
                return word(input);
            }
            else if (input.All(char.IsDigit) == false && input.All(char.IsLetterOrDigit))
            {
                return word(input);
            }
            else if(input.All(char.IsDigit))
            {
                return number(input);
            }
            else
            {
                return junk(input);
            }

        }
    }
}
