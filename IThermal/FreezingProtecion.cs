using ExcelDna.Integration;
using System;
using System.Data;
using System.Linq;

namespace IThermal
{
    public class FreezeProtecion
    {
        [ExcelFunction(Category = "IThermal_FreezeProtecion", Description = "determine if need heat tracing")]
        public static object HeatTracingRequirement(
                        [ExcelArgument(Name = "FluidType", Description = @"1:High Temperature Wet Gas 2:Low Temperature Wet Gas 3:Warm Process Liquid 4:Cool Process Liquid 5:Utility Water")] int fluidType,
                        [ExcelArgument(Name = "PipingConfiguration", Description = @"1:Free-Draining Stagnant or Deadleg(DN ≤50)2:Free-Draining Stagnant or Deadleg(DN >50) 3:Non-Free Draining Stagnant or Deadleg(DN ≤50) 4:Non-Free Draining Stagnant or Deadleg(DN >50) 5:Closed Coupled Low Point 6:Closed Coupled High Point 7:Transmitter Sensing Leg 8:Seal Loop or Level Bridle 9:Relief Device Outlet")] int pipingConfiguration
            )
        {
            var heatTracing = IThermal.heat_tracing.AsEnumerable();
            int needHeatTracing = heatTracing
                                .Where(row => row.Field<int>("fluid_type") == fluidType && row.Field<int>("piping_configuration") == pipingConfiguration)
                                .Select(row => row.Field<int>("heat_tracing"))
                                .First();

            return Convert.ToBoolean(needHeatTracing);
        }

        [ExcelFunction(Category = "IThermal_FreezeProtecion", Description = "solve for insulation for Freeze protection purpose\nmm")]
        public static object Insulation4FreezeProtecion(
                        [ExcelArgument(Name = "FluidType", Description = @"1:High Temperature Wet Gas 2:Low Temperature Wet Gas 3:Warm Process Liquid 4:Cool Process Liquid 5:Utility Water")] int fluidType,
            [ExcelArgument(Name = "DN", Description = "DN\nmm")] int DN
            )
        {
            var freezeProtecion = IThermal.freeze_protecion.AsEnumerable();
            int insulationThickness = freezeProtecion
                                .Where(row => row.Field<int>("fluid_type") == fluidType && row.Field<int>("dn") == DN)
                                .Select(row => row.Field<int>("insulation_thickness"))
                                .First();

            return insulationThickness;
        }
    }
}
