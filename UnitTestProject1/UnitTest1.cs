using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_to_Laba1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 3680;
            int result = Laba1.Program.Time(n);
            Assert.AreEqual(20, result);
        }
    }
}
