using ExcelDna.Integration;
using System;

namespace IThermal
{
    public class Condenser
    {
        [ExcelFunction(Category = "IThermal_Condenser", Description = "solve for condenser pressure\nMPaA")]
        public static double CondenserPressure(
            [ExcelArgument(Name = "tcw", Description = "cooling water temperature\n℃")] double tcw,
            [ExcelArgument(Name = "Δt1", Description = "cooling water temperature rise[≤10]\n℃")] double Δt1,
            [ExcelArgument(Name = "Δt2", Description = "hot terminal temperature difference[≥2.8]\n℃")] double Δt2
            )
        {
            double ts = tcw + Δt1 + Δt2;
            double pk = Math.Pow((ts + 100) / 78.72, 7.46) * 1e-4;

            return pk;
        }

        [ExcelFunction(Category = "IThermal_Condenser", Description = "solve for condensation water temperature\n℃")]
        public static double CondensationWaterTemperature(
            [ExcelArgument(Name = "pc", Description = "condenser pressure\nMPaA")] double pc,
            [ExcelArgument(Name = "Δt", Description = "subcoold temperature of condensation water[≤3]\n℃")] double Δt
            )
        {
            return IAPWS97.P2T97(pc) - Δt;
        }
    }
}
