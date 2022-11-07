using IThermal;
using Xunit;

namespace IThermalTests
{
    public class TurbineTests
    {
        [Theory]
        [InlineData(3.7115997, 4.3, 450, 0.01, 85)]
        public void SteamRate1Test(double ex, double p1, double p2, double p3, double p4)
        {
            Assert.Equal(ex, Turbine.SteamRate1(p1, p2, p3, p4), 5);
        }

        [Theory]
        [InlineData(3.6654075, 4.3, 450, 0.01, 0.9)]
        public void SteamRate2Test(double ex, double p1, double p2, double p3, double p4)
        {
            Assert.Equal(ex, Turbine.SteamRate2(p1, p2, p3, p4), 5);
        }

        [Theory]
        [InlineData(45.807542, 4.3, 450, 0.01, 85)]
        public void ExhaustTemperatureTest(double ex, double p1, double p2, double p3, double p4)
        {
            Assert.Equal(ex, Turbine.ExhaustTemperature(p1, p2, p3, p4), 5);
        }

        [Theory]
        [InlineData(0.9051, 4.3, 450, 0.01, 85)]
        public void ExhaustDrynessFractionTest(double ex, double p1, double p2, double p3, double p4)
        {
            Assert.Equal(ex, Turbine.ExhaustDrynessFraction(p1, p2, p3, p4), 3);
        }
    }
}
