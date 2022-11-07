using IThermal;
using System;
using System.Collections.Generic;
using Xunit;

namespace IThermalTests
{
    public class UtilityTests
    {
        //[Theory]
        //[MemberData(nameof(DataProvider))]
        public void DarcyFrictionFactorTest(double roughness, double diameter, double reynoldsNumber)
        {
            double frictionFactor = Convert.ToDouble(Utility.DarcyFrictionFactor(roughness, diameter, reynoldsNumber));
            double rightResult = -2 * Math.Log10(roughness / diameter / 3.7 + 2.51 / reynoldsNumber / Math.Sqrt(frictionFactor));

            Assert.Equal(1 / Math.Sqrt(frictionFactor), rightResult, 0.001);
        }

        public static IEnumerable<object[]> DataProvider
        {
            get
            {
                for (double i = 0.05; i <= 0.35; i += 0.1)
                {
                    for (double j = 25; j < 1000; j += 100)
                    {
                        for (double k = 4000; k < 50000; k += 1000)
                        {
                            yield return new object[] { i, j, k };
                        }
                    }
                }
            }
        }

        //[Fact]
        public void LinearInterpolationTest()
        {
            double[] xs = { 1, 2, 3.4, 6, 5.5, 12 };
            double[] ys = { 1.1, 8, 30, 25, 6, 28 };
            Assert.Equal(1.1, (double)Utility.LinearInterpolation(xs, ys, 1), 1e-5);
            Assert.Equal(28, (double)Utility.LinearInterpolation(xs, ys, 12), 1e-5);
            Assert.Equal(6, (double)Utility.LinearInterpolation(xs, ys, 5.5), 1e-5);
            Assert.Equal(4.55, (double)Utility.LinearInterpolation(xs, ys, 1.5), 1e-5);
        }
    }
}
