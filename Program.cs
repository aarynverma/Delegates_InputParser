using System;
using System.Text.RegularExpressions;
namespace Help
{
    class ConsoleReader
    {
        public delegate void onWord(string a);
        public delegate void onNumber(string a);
        public delegate void onJunk(string a);


        public void word(string a)
        {
            if(a.All(char.IsLetter) == true)
            Console.WriteLine("onWord");
            else if(a.All(char.IsLetterOrDigit) == true && a.All(char.IsDigit) == false)
            Console.WriteLine("onWord and Number");
        }

        public void number(string a)
        {
            if(a.All(char.IsDigit) == true)
            Console.WriteLine("onNumber");
        }

        public void junk(string a)
        {
            if (CheckSpecialChar(a) == true)
                Console.WriteLine("onJunk");
        }
        static void Main(string[] args)
        {



            Console.WriteLine("Enter the value");
            string text = Console.ReadLine();

            ConsoleReader Obj = new ConsoleReader();


            onWord obj1 = new onWord(Obj.word);
            onNumber obj2 = new onNumber(Obj.number);
            onJunk obj3 = new onJunk(Obj.junk);

            obj1(text);
            obj2(text);
            obj3(text);


           /* if ()
            {
                Console.WriteLine("OnJunk");
            }
            else if () 
            {
                Console.WriteLine("OnWord");
            }
            else if ()
            {
                Console.WriteLine("OnNumber");
            }*/

        }
        public static bool CheckInt(string input)
        {
            int number = 0;
            return int.TryParse(input, out number);
        }

        public static bool CheckSpecialChar(string input)
        {
            Regex rgx = new Regex("[^A-Za-z0-9]");
            bool hasSpecialChars = rgx.IsMatch(input);
            return hasSpecialChars;
        }
    }
}
