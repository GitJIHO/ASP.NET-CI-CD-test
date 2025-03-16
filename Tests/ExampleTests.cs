using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ExampleTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(2, 1 + 1);
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue("hello".StartsWith("h"));
        }

        [Test]
        public void Test3()
        {
            Assert.IsFalse(string.IsNullOrEmpty("world"));
        }
    }
}
