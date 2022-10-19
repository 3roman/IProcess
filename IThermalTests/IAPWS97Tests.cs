using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IThermal.Tests
{
    [TestClass()]
    public class IAPWS97Tests
    {
        private const double delta = 1e-5;

        [TestMethod()]
        [DataRow(179.885633532603, 1)]
        public void P2TTest(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.P2T(input1), delta);
        }
    }
}