using konsola;

namespace testProj
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3,zadanieKonsola.liczZnaki("bruh", "hur"));
        }

        [TestMethod]
        public void TestMethod2() 
        {
            Assert.AreEqual("abcc", zadanieKonsola.usunDupli("aabbcc"));
        }
    }
}
