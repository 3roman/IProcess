using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IThermal
{
    public class Utility
    {
        [ExcelFunction(Category = "IThermal_Utility", Description = "Linear Interpolation")]
        public static object LinearInterpolation(
            [ExcelArgument(Name = "xArray", Description = "1-D array of x axis")] double[] xs,
            [ExcelArgument(Name = "yArray", Description = "1-D array of y axis")] double[] ys,
            [ExcelArgument(Name = "x", Description = "x value of interpolating point")] double x)
        {
            Dictionary<double, double> pairs = new Dictionary<double, double>();
            for (int i = 0; i < xs.Length; i++)
            {
                pairs.Add(xs[i], ys[i]);
            }
            Dictionary<double, double> sortedPairs = pairs.OrderBy(p => p.Key).ToDictionary(p => p.Key, o => o.Value);

            int idx = -1;
            foreach (var pair in sortedPairs)
            {
                if (Math.Abs(x - pair.Key) <= 1e-5)
                {
                    return pair.Value;
                }
            }

            foreach (var pair in sortedPairs)
            {
                if (x > pair.Key)
                {
                    idx = pairs.Keys.ToList().IndexOf(pair.Key);
                    double x1 = xs[idx];
                    double x2 = xs[idx + 1];
                    double y1 = ys[idx];
                    double y2 = ys[idx + 1];
                    double slope = (y2 - y1) / (x2 - x1);

                    return y1 + (x - x1) * slope;
                }
            }

            return ExcelError.ExcelErrorGettingData;
        }

        [ExcelFunction(Category = "IThermal_Utility", Description = "calculate darcy friction factor")]
        public static object DarcyFrictionFactor(
            [ExcelArgument(Name = "ε", Description = "absolute roughness inside the pipe\nmm")] double ε,
            [ExcelArgument(Name = "Di", Description = "pipe inner diameter\nmm")] double Di,
            [ExcelArgument(Name = "Re", Description = "reynolds number")] double Re)
        {
            // references:
            // https://arxiv.org/pdf/0810.5564.pdf
            // http://www.docin.com/p-1773318871.html
            if (Re < 4000)
            {
                return ExcelError.ExcelErrorGettingData;
            }

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

        [ExcelFunction(Category = "IThermal_Utility", Description = "calculate primary steam flowrate for letdown station")]
        public static object LetdownStation(
            [ExcelArgument(Name = "p1", Description = "primary steam pressure\nMPaA")] double p1,
            [ExcelArgument(Name = "t1", Description = "primary steam temperature\n℃")] double t1,
            [ExcelArgument(Name = "p2", Description = "secondary steam pressure\nMPaA")] double p2,
            [ExcelArgument(Name = "t2", Description = "secondary steam temperature\n℃")] double t2,
            [ExcelArgument(Name = "p3", Description = "desuperheated water pressure\nMPaA")] double p3,
            [ExcelArgument(Name = "t3", Description = "desuperheated water temperature\n℃")] double t3,
            [ExcelArgument(Name = "f2", Description = "secondary steam flowrate\nkg/h")] double f2)
        {
            double h1 = IAPWS97.PT2H97(p1, t1);
            double h2 = IAPWS97.PT2H97(p2, t2);
            double h3 = IAPWS97.PT2H97(p3, t3);

            return f2 * (h2 - h3) / (h1 - h3);
        }

        [ExcelFunction(Category = "IThermal_Utility", Description = "convert inch to dn")]
        public static object NPS2DN([ExcelArgument(Name = "NPS", Description = "inch(shall right parenthesised)\n[1/2\",1-1/2\",3\"]")] string nps)
        {
           Dictionary<string, int> paris = new Dictionary<string, int>
           {
               {"1/8\"",6},
                {"1/4\"",8},
                {"3/8\"",10},
                {"1/2\"",15},
                {"3/4\"",20},
                {"1\"",25},
                {"1-1/4\"",32},
                {"1-1/2\"",40},
                {"2\"",50},
                {"2-1/2\"",65},
                {"3\"",80},
                {"4\"",100},
                {"5\"",125},
                {"6\"",150},
                {"8\"",200},
                {"10\"",250},
                {"12\"",300},
                {"14\"",350},
                {"16\"",400},
                {"18\"",450},
                {"20\"",500},
                {"24\"",600},
                {"26\"",650},
                {"28\"",700},
                {"30\"",750},
                {"32\"",800},
                {"34\"",850},
                {"36\"",900},
                {"40\"",1000},
                {"42\"",1050},
                {"44\"",1100},
                {"46\"",1150},
                {"48\"",1200},
                {"52\"",1300},
                {"56\"",1400},
                {"60\"",1500},
                {"64\"",1600},
                {"68\"",1700},
                {"72\"",1800},
                {"76\"",1900},
                {"80\"",2000}
           };

            if (!paris.ContainsKey(nps))
            {
                return ExcelError.ExcelErrorNA;
            }

            return paris[nps];
        }
    }
}
