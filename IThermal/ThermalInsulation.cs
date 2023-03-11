using ExcelDna.Integration;
using System;
using System.Data;
using System.Configuration;

namespace IThermal
{
    public class ThermalInsulation
    {
        private static string ConnectionString => ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;

        [ExcelFunction(Category = "IThermal_ThermalInsulation", Description = "solve for insulation thickness for heat conversation purpose\nmm")]
        public static object InsulationThickness4HeatConversation(
            [ExcelArgument(Name = "DN", Description = "norminal diameter of pipe\nmm")] double dn,
            [ExcelArgument(Name = "OT", Description = "operating temperature\n℃")] double ot
            )
        {
            object maxDN = MySQLHelper.ExecuteScalar(ConnectionString, CommandType.Text, @"SELECT MAX(DN) FROM heat_conversation");
            if (dn > Convert.ToInt32(maxDN))
            {
                dn = Convert.ToInt32(maxDN);
            }
            object thickness = MySQLHelper.ExecuteScalar(ConnectionString, CommandType.Text, $"SELECT insulation_thickness FROM heat_conversation WHERE dn = {dn} AND operating_temperature >= {ot} ORDER BY insulation_thickness LIMIT 1");
            object designator = MySQLHelper.ExecuteScalar(ConnectionString, CommandType.Text, $"SELECT designator FROM heat_conversation WHERE dn = {dn} AND operating_temperature >= {ot} ORDER BY insulation_thickness LIMIT 1");
            if (null == thickness || null == designator)
            {
                return ExcelError.ExcelErrorValue;
            }

            return Convert.ToString(designator) + "-" + Convert.ToString(thickness);
        }

        [ExcelFunction(Category = "IThermal_ThermalInsulation", Description = "solve for insulation thickness for personnel protection purpose\nmm")]
        public static object InsulationThickness4PersonnelProtection(
            [ExcelArgument(Name = "DN", Description = "norminal diameter of pipe\nmm")] double dn,
            [ExcelArgument(Name = "OT", Description = "operating temperature\n℃")] double ot
            )
        {
            object maxDN = MySQLHelper.ExecuteScalar(ConnectionString, CommandType.Text, @"SELECT MAX(DN) FROM personnel_protection");
            if (dn > Convert.ToInt32(maxDN))
            {
                dn = Convert.ToInt32(maxDN);
            }
            object thickness = MySQLHelper.ExecuteScalar(ConnectionString, CommandType.Text, $"SELECT insulation_thickness FROM personnel_protection WHERE dn = {dn} AND operating_temperature >= {ot} ORDER BY insulation_thickness LIMIT 1");
            object designator = MySQLHelper.ExecuteScalar(ConnectionString, CommandType.Text, $"SELECT designator FROM personnel_protection WHERE dn = {dn} AND operating_temperature >= {ot} ORDER BY insulation_thickness LIMIT 1");
            if (null == thickness || null == designator)
            {
                return ExcelError.ExcelErrorValue;
            }

            return Convert.ToString(designator) + "-" + Convert.ToString(thickness);
        }
    }
}
