using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutorizacionProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = Autorizacion.Program.Something();
            Assert.AreEqual("Probando", result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string result2 = Autorizacion.Program.Something();
            Assert.AreEqual("lo que sea", result2);
        }

        [TestMethod]
        public void TestLoginTrue()
        {
            bool result = Autorizacion.Program.Login("jose", "123");
            Assert.AreEqual(true, result);
          
        }
        [TestMethod]
        public void TestLoginFalse()
        {
            bool result2 = Autorizacion.Program.Login("mal", "000");
            Assert.AreEqual(false, result2);
        }
    }
}
