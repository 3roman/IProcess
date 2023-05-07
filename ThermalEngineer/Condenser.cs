using ExcelDna.Integration;
using System;

namespace Process.ThermalEngineer
{
    public class Condenser
    {
        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for condensing pressure\nMPaA")]
        public static double CondensingPressure(
            [ExcelArgument(Name = "tcw", Description = "cooling water temperature\n℃")] double tcw,
            [ExcelArgument(Name = "Δt1", Description = "cooling water temperature rise[≤10]\n℃")] double Δt1,
            [ExcelArgument(Name = "Δt2", Description = "terminal temperature difference[≥2.8]\n℃")] double Δt2
            )
        {
            double ts = tcw + Δt1 + Δt2;
            double pk = Math.Pow((ts + 100) / 78.72, 7.46) * 1e-4;

            return pk;
        }
    }
}
