using ExcelDna.Integration;
using System.Data;
using System.Linq;

namespace IThermal
{
    public class Insulation
    {
        [ExcelFunction(Category = "IThermal_Insulation", Description = "solve for insulation for heat conversation purpose")]
        public static object Insulation4HeatConversation(
            [ExcelArgument(Name = "DN", Description = "norminal diameter of pipe\nmm")] double dn,
            [ExcelArgument(Name = "OT", Description = "operating temperature\n℃")] double ot
            )
        {
            var heatConversationTable = IThermal.AP_STD.Tables["heat_conversation"].AsEnumerable();
            var maxDN = heatConversationTable.Max(row => row.Field<int>("dn"));
            if (dn > maxDN)
            {
                dn = maxDN;
            }
            var insulationThickness = heatConversationTable
                                .Where(row => row.Field<int>("dn") == dn && row.Field<int>("operating_temperature") >= ot)
                                .OrderBy(row => row.Field<int>("insulation_thickness"))
                                .Select(row => row.Field<int>("insulation_thickness"))
                                .First();
            var designator = heatConversationTable
                                .Where(row => row.Field<int>("dn") == dn && row.Field<int>("operating_temperature") >= ot)
                                .OrderBy(row => row.Field<int>("insulation_thickness"))
                                .Select(row => row.Field<string>("designator"))
                                .First();

            return $"{designator}-{insulationThickness}";
        }

        [ExcelFunction(Category = "IThermal_Insulation", Description = "solve for insulation for personnel protection purpose")]
        public static object Insulation4PersonnelProtection(
            [ExcelArgument(Name = "DN", Description = "norminal diameter of pipe\nmm")] double dn,
            [ExcelArgument(Name = "OT", Description = "operating temperature\n℃")] double ot
            )
        {
            var personnelProtectionTable = IThermal.AP_STD.Tables["personnel_protection"].AsEnumerable();
            var maxDN = personnelProtectionTable.Max(row => row.Field<int>("dn"));
            if (dn > maxDN)
            {
                dn = maxDN;
            }
            var insulationThickness = personnelProtectionTable
                                .Where(row => row.Field<int>("dn") == dn && row.Field<int>("operating_temperature") >= ot)
                                .OrderBy(row => row.Field<int>("insulation_thickness"))
                                .Select(row => row.Field<int>("insulation_thickness"))
                                .First();
            var designator = personnelProtectionTable
                                .Where(row => row.Field<int>("dn") == dn && row.Field<int>("operating_temperature") >= ot)
                                .OrderBy(row => row.Field<int>("insulation_thickness"))
                                .Select(row => row.Field<string>("designator"))
                                .First();

            return $"{designator}-{insulationThickness}";
        }

        [ExcelFunction(Category = "IThermal_Insulation", Description = "solve for insulation for freeze protection purpose")]
        public static object Insulation4FreezeProtecion(
                        [ExcelArgument(Name = "FluidType", Description = @"1:high temperature wet gas/warm process liquid 2:low temperature wet gas/cool process liquid 5:utility water")] int fluidType,
            [ExcelArgument(Name = "DN", Description = "DN\nmm")] int DN
            )
        {
            var freezeProtecionTable = IThermal.AP_STD.Tables["freeze_protection"].AsEnumerable();
            var insulationThickness = freezeProtecionTable
                                .Where(row => row.Field<int>("fluid_type") == fluidType && row.Field<int>("dn") == DN)
                                .Select(row => row.Field<int>("insulation_thickness"))
                                .First();

            var designator = freezeProtecionTable
                                .Where(row => row.Field<int>("fluid_type") == fluidType && row.Field<int>("dn") == DN)
                                .Select(row => row.Field<string>("designator"))
                                .First();

            return $"N5-{insulationThickness}{designator}";
        }
    }
}
