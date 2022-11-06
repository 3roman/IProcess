using ExcelDna.Integration;
using System;

namespace IThermal
{
    public class Utility
    {
        [ExcelFunction(Category = "IThermal_Utility", Description = "Linear Interpolation")]
        public static double LinearInterpolation(
            [ExcelArgument(Name = "xArray", Description = "1-D array of x axis")] double[] xs,
            [ExcelArgument(Name = "yArray", Description = "1-D array of y axis")] double[] ys,
            [ExcelArgument(Name = "x", Description = "x value of interpolating point")] double x)
        {
            //TODO
            int i = 0;
            for (; i < xs.Length; i++)
            {
                if (xs[i] > x)
                {
                    break;
                }
            }
            double x1 = xs[i - 1];
            double x2 = xs[i];
            double y1 = ys[i - 1];
            double y2 = ys[i];
            double slope = (y2 - y1) / (x2 - x1);

            return y1 + (x - x1) * slope;
        }

        [ExcelFunction(Category = "IThermal_Utility", Description = "calculate darcy friction factor")]
#if DEBUG
        public static double DarcyFrictionFactor(
            [ExcelArgument(Name = "ε", Description = "absolute roughness inside the pipe\nmm")] double ε,
            [ExcelArgument(Name = "Di", Description = "pipe inner diameter\nmm")] double Di,
            [ExcelArgument(Name = "Re", Description = "reynolds number")] double Re)
#else
public static object DarcyFrictionFactor(
            [ExcelArgument(Name = "ε", Description = "absolute roughness inside the pipe\nmm")] double ε,
            [ExcelArgument(Name = "Di", Description = "pipe inner diameter\nmm")] double Di,
            [ExcelArgument(Name = "Re", Description = "reynolds number")] double Re)
#endif
        {
            // references:
            // https://arxiv.org/pdf/0810.5564.pdf
            // http://www.docin.com/p-1773318871.html
#if DEBUG
#else
if (Re < 4000)
            {
                return ExcelError.ExcelErrorNA;
            }
#endif
            double k = ε / Di;
            const double T = 0.333333333333333333;
            double x1 = k * Re * 0.123968186335417556;
            double x2 = Math.Log(Re) - 0.779397488455682028;
            double f = x2 - 0.2;

            double e = (Math.Log(x1 + f) - 0.2) / (1.0 + x1 + f);
            f -= (1.0d + x1 + f + 0.5d * e) * e * (x1 + f) / (1.0 + x1 + f + e * (1.0 + e * T));
            if ((x1 + x2) < 5.7)
            {
                e = (Math.Log(x1 + f) + f - x2) / (1.0d + x1 + f);
                f -= (1.0 + x1 + f + 0.5 * e) * e * (x1 + f) / (1.0 + x1 + f + e * (1.0 + e * T));
            }
            f = 1.151292546497022842 / f;

            // Debug.WriteLine(f * f);
            return f * f;
        }
    }
}
