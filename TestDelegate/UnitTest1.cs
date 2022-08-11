namespace TestDelegate
{
    public class UnitTest1
    {
        [Fact]
        public void DataIsWord()
        {
            string data = "Aryan";
            string res = Delegates.Delegate.word(data);
            Assert.Equal("Aryan is a word", res);
        }
       
        [Fact]
        public void DataIsNumber()
        {
            string data = "123";
            string res = Delegates.Delegate.number(data);
            Assert.Equal("123 is a number", res);
        }
        [Fact]
        public void DataIsJunk()
        {
            string data = "!@#";
            string res = Delegates.Delegate.junk(data);
            Assert.Equal("!@# is a junk", res);
        }
    }
}