using NUnit.Framework;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string ans = Program.Prefix("hello");
            Assert.That(ans.Equals("5,1:hello"),("Test Failed"));
        }

        [Test]
        public void Test2(){
            string ans = Program.Prefix("");
            Assert.That(ans.Equals("0,0:"),"Test Failed");
        }

        [Test]
        public void Test3(){
            string ans = Program.Prefix("what    ...  did you say?? ");
            Assert.That(ans.Equals("27,5:what    ...  did you say?? "),"Test Failed");
        }
    }
}