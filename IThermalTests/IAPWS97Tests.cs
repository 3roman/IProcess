using IThermal;
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

        [TestMethod()]
        [DataRow(762.682849362246, 1)]
        public void P2HLTest(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.P2HL(input1), delta);
        }

        [TestMethod()]
        [DataRow(2.138431361995, 1)]
        public void P2SLTest(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.P2SL(input1), delta);
        }

        [TestMethod()]
        [DataRow(0.001127233747, 1)]
        public void P2VLTest(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.P2VL(input1), delta);
        }

        [TestMethod()]
        [DataRow(4.405112054234, 1)]
        public void P2CPLTest(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.P2CPL(input1), delta);
        }

        [TestMethod()]
        [DataRow(3.396748017650, 1)]
        public void P2CVLTest(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.P2CVL(input1), delta);
        }

        [TestMethod()]
        [DataRow(1718.062721120949, 1)]
        public void P2KSLTest(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.P2KSL(input1), delta);
        }

        [TestMethod()]
        [DataRow(1.502393e-004, 1)]
        public void P2ETALTest(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.P2ETAL(input1), delta);
        }

        [TestMethod()]
        [DataRow(2777.119540782831, 1)]
        public void P2HGTEST(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.P2HG(input1), delta);
        }

        [TestMethod()]
        [DataRow(6.584979003191, 1)]
        public void P2SGTEST(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.P2SG(input1), delta);
        }

        [TestMethod()]
        [DataRow(0.194348885018, 1)]
        public void P2VGTEST(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.P2VG(input1), delta);
        }

        [TestMethod()]
        [DataRow(2.714984765391, 1)]
        public void P2CPGTEST(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.P2CPG(input1), delta);
        }

        [TestMethod()]
        [DataRow(1.930338138009, 1)]
        public void P2CVGTEST(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.P2CVG(input1), delta);
        }

        [TestMethod()]
        [DataRow(1.290950099991, 1)]
        public void P2KSGTEST(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.P2KSG(input1), delta);
        }

        [TestMethod()]
        [DataRow(1.502160e-005, 1)]
        public void P2ETAGTEST(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.P2ETAG(input1), delta);
        }


        [TestMethod()]
        [DataRow(8.587708329557, 300)]
        public void T2TPest(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.T2P(input1), delta);
        }

        [TestMethod()]
        [DataRow(1344.771339019730, 300)]
        public void T2HLTest(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.T2HL(input1), delta);
        }

        [TestMethod()]
        [DataRow(3.254740550494, 300)]
        public void T2SLTest(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.T2SL(input1), delta);
        }

        [TestMethod()]
        [DataRow(0.001404222962, 300)]
        public void T2VLTest(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.T2VL(input1), delta);
        }

        [TestMethod()]
        [DataRow(5.751523265645, 300)]
        public void T2CPLTest(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.T2CPL(input1), delta);
        }

        [TestMethod()]
        [DataRow(3.052471442249, 300)]
        public void T2CVLTest(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.T2CVL(input1), delta);
        }

        [TestMethod()]
        [DataRow(68.623427883524, 300)]
        public void T2KSLTest(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.T2KSL(input1), delta);
        }

        [TestMethod()]
        [DataRow(8.589645e-005, 300)]
        public void T2ETALTest(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.T2ETAL(input1), delta);
        }

        [TestMethod()]
        [DataRow(2749.573742543974, 300)]
        public void T2HGTEST(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.T2HG(input1), delta);
        }

        [TestMethod()]
        [DataRow(5.705763616827, 300)]
        public void T2SGTEST(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.T2SG(input1), delta);
        }

        [TestMethod()]
        [DataRow(0.021663064746, 300)]
        public void T2VGTEST(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.T2VG(input1), delta);
        }

        [TestMethod()]
        [DataRow(6.223086805503, 300)]
        public void T2CPGTEST(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.T2CPG(input1), delta);
        }

        [TestMethod()]
        [DataRow(2.972419092365, 300)]
        public void T2CVGTEST(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.T2CVG(input1), delta);
        }

        [TestMethod()]
        [DataRow(1.242655044703, 300)]
        public void T2KSGTEST(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.T2KSG(input1), delta);
        }

        [TestMethod()]
        [DataRow(1.965121e-005, 300)]
        public void T2ETAGTEST(double expection, double input1)
        {
            Assert.AreEqual(expection, IAPWS97.T2ETAG(input1), delta);
        }

    }
}