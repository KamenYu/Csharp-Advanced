namespace BlueOrigin.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class AstronautTests
    {
        private Astronaut a;

        [SetUp]
        public void Setup()
        {
            a = new Astronaut("A", 67);
        }

        [Test]
        public void TestCtor()
        {
            Assert.IsNotNull(a);
        }

        [Test]
        public void TestNameProp()
        {
            string name = "A";
            Assert.AreEqual(name, a.Name);
        }

        [Test]
        public void TestOxygenProp()
        {
            double ox = 67;
            Assert.AreEqual(ox, a.OxygenInPercentage);
        }

    }
}
