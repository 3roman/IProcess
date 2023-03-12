using ExcelDna.Integration;
using System.Data;
using System.Linq;

namespace IThermal
{
    public class ThermalInsulation
    {
        [ExcelFunction(Category = "IThermal_ThermalInsulation", Description = "solve for insulation for heat conversation purpose\nmm")]
        public static object Insulation4HeatConversation(
            [ExcelArgument(Name = "DN", Description = "norminal diameter of pipe\nmm")] double dn,
            [ExcelArgument(Name = "OT", Description = "operating temperature\n℃")] double ot
            )
        {
            var heatConversation = IThermal.heat_conversation.AsEnumerable();
            int maxDN = heatConversation.Max(row => row.Field<int>("dn"));
            if (dn > maxDN)
            {
                dn = maxDN;
            }
            int insulationThickness = heatConversation
                                .Where(row => row.Field<int>("dn") == dn && row.Field<int>("operating_temperature") >= ot)
                                .OrderBy(row => row.Field<int>("insulation_thickness"))
                                .Select(row => row.Field<int>("insulation_thickness"))
                                .First();
            string designator = heatConversation
                                .Where(row => row.Field<int>("dn") == dn && row.Field<int>("operating_temperature") >= ot)
                                .OrderBy(row => row.Field<int>("insulation_thickness"))
                                .Select(row => row.Field<string>("designator"))
                                .First();

            return $"{designator}-{insulationThickness}";
        }

        [ExcelFunction(Category = "IThermal_ThermalInsulation", Description = "solve for insulation for personnel protection purpose\nmm")]
        public static object Insulation4PersonnelProtection(
            [ExcelArgument(Name = "DN", Description = "norminal diameter of pipe\nmm")] double dn,
            [ExcelArgument(Name = "OT", Description = "operating temperature\n℃")] double ot
            )
        {
            var heatConversation = IThermal.personnel_protection.AsEnumerable();
            int maxDN = heatConversation.Max(row => row.Field<int>("dn"));
            if (dn > maxDN)
            {
                dn = maxDN;
            }
            int insulationThickness = heatConversation
                                .Where(row => row.Field<int>("dn") == dn && row.Field<int>("operating_temperature") >= ot)
                                .OrderBy(row => row.Field<int>("insulation_thickness"))
                                .Select(row => row.Field<int>("insulation_thickness"))
                                .First();
            string designator = heatConversation
                                .Where(row => row.Field<int>("dn") == dn && row.Field<int>("operating_temperature") >= ot)
                                .OrderBy(row => row.Field<int>("insulation_thickness"))
                                .Select(row => row.Field<string>("designator"))
                                .First();

            return $"{designator}-{insulationThickness}";
        }
    }
}
