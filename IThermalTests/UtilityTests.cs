using IThermal;
using System;
using System.Collections.Generic;
using Xunit;

namespace IThermalTests
{
    public class UtilityTests
    {
        [Theory]
        [MemberData(nameof(DataProvider))]
        public void DarcyFrictionFactorTest(double roughness, double diameter, double reynoldsNumber)
        {
            double frictionFactor = Utility.DarcyFrictionFactor(roughness, diameter, reynoldsNumber);
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
                        for (double k = 4000; k < 50000; k += 2000)
                        {
                            yield return new object[] { i, j, k };
                        }
                    }
                }
            }
        }
    }
}
