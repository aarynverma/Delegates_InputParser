using static Delegates.ConsoleReader;

namespace Delegates
{
    class Program
    {
       
        static void Main(string[] args)
        {
            ConsoleReader reader = new ConsoleReader();
            /*reader.Run(Delegate.word, Delegate.number, Delegate.junk);*/
            reader.Run(Delegate.word, Delegate.number, Delegate.junk);

        }
    }
}
