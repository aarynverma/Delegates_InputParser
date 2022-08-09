using System;
using System.Text.RegularExpressions;
using Delegates_InputParser;
using static Delegates_InputParser.DelegateFunction;

namespace Help
{
    class ConsoleReader
    {
        private onWord word;
        private onNumber number;
        private onJunk junk;

        static void Main(string[] args)
        {

            static void run(onWord, onJunk, onNumber)
            {

                Console.WriteLine("Enter the value");
                string text = Console.ReadLine();
/*
                    string text = Console.ReadLine();*/

                for (int i = 0; i < Console.Read(); i++)
                {

                    ConsoleReader Obj = new ConsoleReader();

                    onWord obj1 = new onWord(Obj.word);
                    onNumber obj2 = new onNumber(Obj.number);
                    onJunk obj3 = new onJunk(Obj.junk);

                    obj1(text);
                    obj2(text);
                    obj3(text);

            }
                }

        }


    }
}
