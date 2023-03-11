using ExcelDna.Integration;
using System;
using System.Data;
using System.Configuration;

namespace IThermal
{
    public class FreezeProtecion
    {
        private static string ConnectionString => ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;

        [ExcelFunction(Category = "IThermal_FreezeProtecion", Description = "determine if need heat tracing")]
        public static object HeatTracingRequirement(
                        [ExcelArgument(Name = "FluidType", Description = @"1:High Temperature Wet Gas 2:Low Temperature Wet Gas 3:Warm Process Liquid 4:Cool Process Liquid 5:Utility Water")] int fluidType,
                        [ExcelArgument(Name = "PipingConfiguration", Description = @"1:Free-Draining Stagnant or Deadleg(DN ≤50)2:Free-Draining Stagnant or Deadleg(DN >50) 3:Non-Free Draining Stagnant or Deadleg(DN ≤50) 4:Non-Free Draining Stagnant or Deadleg(DN >50) 5:Closed Coupled Low Point 6:Closed Coupled High Point 7:Transmitter Sensing Leg 8:Seal Loop or Level Bridle 9:Relief Device Outlet")] int pipingConfiguration
            )
        {
            object heatTracing = MySQLHelper.ExecuteScalar(ConnectionString, CommandType.Text, $"SELECT heat_tracing FROM heat_tracing WHERE fluid_type = {fluidType} AND piping_configuration = {pipingConfiguration}");
            if (null == heatTracing)
            {
                return ExcelError.ExcelErrorValue;
            }

            return Convert.ToBoolean(heatTracing);
        }

        [ExcelFunction(Category = "IThermal_FreezeProtecion", Description = "solve for insulation thickness for Freeze protection purpose\nmm")]
        public static object InsulationThickness4FreezeProtecion(
                        [ExcelArgument(Name = "FluidType", Description = @"1:High Temperature Wet Gas 2:Low Temperature Wet Gas 3:Warm Process Liquid 4:Cool Process Liquid 5:Utility Water")] int fluidType,
            [ExcelArgument(Name = "DN", Description = "DN\nmm")] int DN
            )
        {
            object insulationThickness = MySQLHelper.ExecuteScalar(ConnectionString, CommandType.Text, $"SELECT insulation_thickness FROM freeze_protecion WHERE fluid_type = {fluidType} AND dn = {DN}");
            if (null == insulationThickness)
            {
                return ExcelError.ExcelErrorValue;
            }

            return Convert.ToInt32(insulationThickness);
        }
    }
}
