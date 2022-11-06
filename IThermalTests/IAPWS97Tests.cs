using IThermal;
using Xunit;


namespace IThermalTests
{
    public class IAPWS97Tests
    {
        [Theory]
        [InlineData(179.885633532603, 1)]
        public void P2T97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.P2T97(input1), 5);
        }

        [Theory]
        [InlineData(762.682849362246, 1)]
        public void P2HL97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.P2HL97(input1), 5);
        }

        [Theory]
        [InlineData(2.138431361995, 1)]
        public void P2SL97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.P2SL97(input1), 5);
        }

        [Theory]
        [InlineData(0.001127233747, 1)]
        public void P2VL97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.P2VL97(input1), 5);
        }

        [Theory]
        [InlineData(4.405112054234, 1)]
        public void P2CPL97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.P2CPL97(input1), 5);
        }

        [Theory]
        [InlineData(3.396748017650, 1)]
        public void P2CVL97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.P2CVL97(input1), 5);
        }

        [Theory]
        [InlineData(1718.062721120949, 1)]
        public void P2KSL97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.P2KSL97(input1), 5);
        }

        [Theory]
        [InlineData(1.502393e-004, 1)]
        public void P2ETAL97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.P2ETAL97(input1), 5);
        }

        [Theory]
        [InlineData(2777.119540782831, 1)]
        public void P2HG97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.P2HG97(input1), 5);
        }

        [Theory]
        [InlineData(6.584979003191, 1)]
        public void P2SG97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.P2SG97(input1), 5);
        }

        [Theory]
        [InlineData(0.194348885018, 1)]
        public void P2VG97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.P2VG97(input1), 5);
        }

        [Theory]
        [InlineData(2.714984765391, 1)]
        public void P2CPG97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.P2CPG97(input1), 5);
        }

        [Theory]
        [InlineData(1.930338138009, 1)]
        public void P2CVG97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.P2CVG97(input1), 5);
        }

        [Theory]
        [InlineData(1.290950099991, 1)]
        public void P2KSG97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.P2KSG97(input1), 5);
        }

        [Theory]
        [InlineData(1.502160e-005, 1)]
        public void P2ETAG97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.P2ETAG97(input1), 5);
        }


        [Theory]
        [InlineData(8.587708329557, 300)]
        public void T2P97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.T2P97(input1), 5);
        }

        [Theory]
        [InlineData(1344.771339019730, 300)]
        public void T2HL97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.T2HL97(input1), 5);
        }

        [Theory]
        [InlineData(3.254740550494, 300)]
        public void T2SL97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.T2SL97(input1), 5);
        }

        [Theory]
        [InlineData(0.001404222962, 300)]
        public void T2VL97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.T2VL97(input1), 5);
        }

        [Theory]
        [InlineData(5.751523265645, 300)]
        public void T2CPL97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.T2CPL97(input1), 5);
        }

        [Theory]
        [InlineData(3.052471442249, 300)]
        public void T2CVL97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.T2CVL97(input1), 5);
        }

        [Theory]
        [InlineData(68.623427883524, 300)]
        public void T2KSL97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.T2KSL97(input1), 5);
        }

        [Theory]
        [InlineData(8.589645e-005, 300)]
        public void T2ETAL97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.T2ETAL97(input1), 5);
        }

        [Theory]
        [InlineData(2749.573742543974, 300)]
        public void T2HG97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.T2HG97(input1), 5);
        }

        [Theory]
        [InlineData(5.705763616827, 300)]
        public void T2SG97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.T2SG97(input1), 5);
        }

        [Theory]
        [InlineData(0.021663064746, 300)]
        public void T2VG97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.T2VG97(input1), 5);
        }

        [Theory]
        [InlineData(6.223086805503, 300)]
        public void T2CPG97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.T2CPG97(input1), 5);
        }

        [Theory]
        [InlineData(2.972419092365, 300)]
        public void T2CVG97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.T2CVG97(input1), 5);
        }

        [Theory]
        [InlineData(1.242655044703, 300)]
        public void T2KSG97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.T2KSG97(input1), 5);
        }

        [Theory]
        [InlineData(1.965121e-005, 300)]
        public void T2ETAG97Test(double expection, double input1)
        {
            Assert.Equal(expection, IAPWS97.T2ETAG97(input1), 5);
        }

        [Theory]
        [InlineData(3434.476096638799, 5, 500)]
        public void PT2H97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PT2H97(input1, input2), 5);
        }

        [Theory]
        [InlineData(6.977803603653, 5, 500)]
        public void PT2S97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PT2S97(input1, input2), 5);
        }

        [Theory]
        [InlineData(0.068582919318, 5, 500)]
        public void PT2V97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PT2V97(input1, input2), 5);
        }

        [Theory]
        [InlineData(2.332985846968, 5, 500)]
        public void PT2CP97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PT2CP97(input1, input2), 5);
        }

        [Theory]
        [InlineData(1.753336897432, 5, 500)]
        public void PT2CV97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PT2CV97(input1, input2), 5);
        }

        [Theory]
        [InlineData(1.277207885609, 5, 500)]
        public void PT2KS97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PT2KS97(input1, input2), 5);
        }

        [Theory]
        [InlineData(2.868066e-005, 5, 500)]
        public void PT2ETA97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PT2ETA97(input1, input2), 5);
        }

        [Theory]
        [InlineData(1, 5, 500)]
        public void PT2X97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PT2X97(input1, input2), 5);
        }

        [Theory]
        [InlineData(528.146198265104, 5, 3500)]
        public void PH2T97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PH2T97(input1, input2), 5);
        }

        [Theory]
        [InlineData(7.061047496013, 5, 3500)]
        public void PH2S97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PH2S97(input1, input2), 5);
        }

        [Theory]
        [InlineData(0.071474841913, 5, 3500)]
        public void PH2V97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PH2V97(input1, input2), 5);
        }

        [Theory]
        [InlineData(-1, 5, 3500)]
        public void PH2X97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PH2X97(input1, input2), 5);
        }


        [Theory]
        [InlineData(918.38917075266, 5, 8)]
        public void PS2T97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PS2T97(input1, input2), 5);
        }

        [Theory]
        [InlineData(4425.403200544131, 5, 8)]
        public void PS2H97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PS2H97(input1, input2), 5);
        }

        [Theory]
        [InlineData(0.10942629644, 5, 8)]
        public void PS2V97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PS2V97(input1, input2), 5);
        }

        [Theory]
        [InlineData(-1, 5, 8)]
        public void PS2X97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PS2X97(input1, input2), 5);
        }


        [Theory]
        [InlineData(513.741750296760, 5, 0.07)]
        public void PV2T97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PV2T97(input1, input2), 5);
        }

        [Theory]
        [InlineData(3466.497864022123, 5, 0.07)]
        public void PV2H97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PV2H97(input1, input2), 5);
        }

        [Theory]
        [InlineData(7.018857248529, 5, 0.07)]
        public void PV2S97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PV2S97(input1, input2), 5);
        }

        [Theory]
        [InlineData(-1, 5, 0.07)]
        public void PV2X97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PV2X97(input1, input2), 5);
        }


        [Theory]
        [InlineData(212.384536014978, 2, 0.8)]
        public void PX2T97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PX2T97(input1, input2), 5);
        }

        [Theory]
        [InlineData(2420.431684833667, 2, 0.8)]
        public void PX2H97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PX2H97(input1, input2), 5);
        }

        [Theory]
        [InlineData(5.560736288345, 2, 0.8)]
        public void PX2S97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PX2S97(input1, input2), 5);
        }

        [Theory]
        [InlineData(0.079899785579, 2, 0.8)]
        public void PX2V97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.PX2V97(input1, input2), 5);
        }


        [Theory]
        [InlineData(7.947560130182, 500, 3400)]
        public void TH2P97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.TH2P97(input1, input2), 5);
        }

        [Theory]
        [InlineData(6.730033591752, 500, 3400)]
        public void TH2S97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.TH2S97(input1, input2), 5);
        }

        [Theory]
        [InlineData(0.042064308369, 500, 3400)]
        public void TH2V97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.TH2V97(input1, input2), 5);
        }

        [Theory]
        [InlineData(1, 500, 3400)]
        public void TH2X97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.TH2X97(input1, input2), 5);
        }


        [Theory]
        [InlineData(0.605042152158, 500, 8)]
        public void TS2P97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.TS2P97(input1, input2), 5);
        }

        [Theory]
        [InlineData(3483.275536964718, 500, 8)]
        public void TS2H97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.TS2H97(input1, input2), 5);
        }

        [Theory]
        [InlineData(0.587046040535, 500, 8)]
        public void TS2V97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.TS2V97(input1, input2), 5);
        }

        [Theory]
        [InlineData(-1, 500, 8)]
        public void TS2X97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.TS2X97(input1, input2), 5);
        }


        [Theory]
        [InlineData(6.756480608878, 500, 0.05)]
        public void TV2P97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.TV2P97(input1, input2), 5);
        }

        [Theory]
        [InlineData(3414.115428777327, 500, 0.05)]
        public void TV2H97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.TV2H97(input1, input2), 5);
        }

        [Theory]
        [InlineData(6.818876042048, 500, 0.05)]
        public void TV2S97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.TV2S97(input1, input2), 5);
        }

        [Theory]
        [InlineData(-1, 500, 0.05)]
        public void TV2X97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.TV2X97(input1, input2), 5);
        }


        [Theory]
        [InlineData(8.587708329557, 300, 0.9)]
        public void TX2P97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.TX2P97(input1, input2), 5);
        }

        [Theory]
        [InlineData(2609.093502191549, 300, 0.9)]
        public void TX2H97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.TX2H97(input1, input2), 5);
        }

        [Theory]
        [InlineData(5.460661310194, 300, 0.9)]
        public void TX2S97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.TX2S97(input1, input2), 5);
        }

        [Theory]
        [InlineData(0.019637180568, 300, 0.9)]
        public void TX2V97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.TX2V97(input1, input2), 5);
        }


        [Theory]
        [InlineData(0.634053738355, 3500, 8)]
        public void HS2P97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.HS2P97(input1, input2), 5);
        }

        [Theory]
        [InlineData(507.899910238862, 3500, 8)]
        public void HS2T97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.HS2T97(input1, input2), 5);
        }

        [Theory]
        [InlineData(0.565892175197, 3500, 8)]
        public void HS2V97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.HS2V97(input1, input2), 5);
        }

        [Theory]
        [InlineData(-1, 3500, 8)]
        public void HS2X97Test(double expection, double input1, double input2)
        {
            Assert.Equal(expection, IAPWS97.HS2X97(input1, input2), 5);
        }
    }
}
