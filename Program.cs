using static Delegates.ConsoleReader;

namespace Delegates
{
    class Program
    {
       
        static void Main(string[] args)
        {
            ConsoleReader reader = new ConsoleReader();
            reader.Run(Delegate.Isword, Delegate.Isnumber, Delegate.Isjunk);

        }
    }
}
