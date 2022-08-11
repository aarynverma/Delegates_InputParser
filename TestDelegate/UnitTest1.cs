using Delegate = Delegates.Delegate;
namespace TestDelegate
{
    public class UnitTest1
    {
        [Fact]
        public void DataIsWord()
        {
            ConsoleReader obj = new ConsoleReader();
            string data = "Aryan";
            string res = Delegates.Delegate.Isword(data);
            Assert.Equal("Aryan is a word", res);
        }

        [Fact]
        public void DataIsNumber()
        {
            string data = "123";
            string res = Delegates.Delegate.Isnumber(data);
            Assert.Equal("123 is a number", res);
        }
        [Fact]
        public void DataIsJunk()
        {
            string data = "!@#";
            string res = Delegates.Delegate.Isjunk(data);
            Assert.Equal("!@# is a junk", res);
        }
        [Fact]
        public void ResponseData()
        {
            ConsoleReader reader = new ConsoleReader();
            string name = "aryan";
            string result = reader.Response(name, Delegate.Isword, Delegate.Isnumber, Delegate.Isjunk);
            Assert.Equal($"{name} is a word", result);
        }
    }
}