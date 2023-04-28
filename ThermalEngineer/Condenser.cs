using ExcelDna.Integration;
using System;

namespace Process.ThermalEngineer
{
    public class Condenser
    {
        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for condensing pressure\nMPaA")]
        public static double CondenserPressure(
            [ExcelArgument(Name = "tcw", Description = "cooling water temperature\n℃")] double tcw,
            [ExcelArgument(Name = "Δt1", Description = "cooling water temperature rise[≤10]\n℃")] double Δt1,
            [ExcelArgument(Name = "Δt2", Description = "terminal temperature difference[≥2.8]\n℃")] double Δt2
            )
        {
            double ts = tcw + Δt1 + Δt2;
            double pk = Math.Pow((ts + 100) / 78.72, 7.46) * 1e-4;

            return pk;
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for condensate temperature\n℃")]
        public static double CondensateTemperature(
            [ExcelArgument(Name = "pc", Description = "condenser pressure\nbarA")] double pc,
            [ExcelArgument(Name = "Δt", Description = "condensate depression[≤3]\n℃")] double Δt
            )
        {
            return IAPWS97.P2T97(pc) - Δt;
        }
    }
}
