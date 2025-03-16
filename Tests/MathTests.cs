using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void AddTest()
        {
            Assert.AreEqual(5, 2 + 3);
        }

        [Test]
        public void SubtractTest()
        {
            Assert.AreEqual(1, 3 - 2);
        }

        [Test]
        public void MultiplyTest()
        {
            Assert.AreEqual(6, 2 * 3);
        }

        [Test]
        public void DivideTest()
        {
            Assert.AreEqual(2, 6 / 3);
        }
    }
}
