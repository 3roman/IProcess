using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Process.Utility
{
    public class Common
    {
        [ExcelFunction(Category = "IEngineer", Description = "Convert NPS to DN")]
        public static object NPS2DN(
            [ExcelArgument(Name = "NPS", Description = "inch[\"1/8\",\"3/8\",\"1\",...\"80\"]")] string nps)
        {
            string sql = $"SELECT dn FROM nps2dn WHERE nps={nps}";

            return SQLiteHelper.ExecuteScalar(sql);
        }

        [ExcelFunction(Category = "IEngineer", Description = "Linear Interpolation")]
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
    }
}
