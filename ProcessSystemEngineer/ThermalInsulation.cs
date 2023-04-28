using ExcelDna.Integration;
using Process.Utility;
using System;

namespace Process.ProcessSystemEngineer
{
    public class ThermalInsulation
    {
        [ExcelFunction(Category = "IProcessSystemEngineer", Description = "Insulation of F2/F3 Designator")]
        public static object InsulationofFDesignator(
            [ExcelArgument(Name = "DN", Description = "Norminal Diameter of Pipe\nmm\n-1 denotes vessel")] int dn,
            [ExcelArgument(Name = "OT", Description = "Operating Temperature\n℃")] double ot,
            [ExcelArgument(Name = "DT", Description = "Design Temperature\n℃")] double dt)
        {
            if (ot == 0 && dt == 0)
            {
                return null;
            }
            string desigator = "";
            if (dt >= 0 && dt <= 230)
            {
                desigator = "F2";
            }
            else if (dt > 230)
            {
                desigator = "M2";
            }
            string sql = "SELECT MAX(dn) FROM F";
            int maxDN = Convert.ToInt32(SQLiteHelper.ExecuteScalar(sql));
            if (dn > maxDN)
            {
                dn = maxDN;
            }
            sql = $"SELECT insulation_thickness FROM F WHERE dn={dn} AND operating_temperature >= {ot} ORDER BY insulation_thickness LIMIT 1";
            object thickness = SQLiteHelper.ExecuteScalar(sql);

            return $"{desigator}-{thickness}mm";
        }

        [ExcelFunction(Category = "IProcessSystemEngineer", Description = "Insulation of M2/M3 Designator")]
        public static object InsulationofMDesignator(
            [ExcelArgument(Name = "DN", Description = "Norminal Diameter of Pipe\nmm\n-1 denotes vessel")] int dn,
            [ExcelArgument(Name = "OT", Description = "Operating Temperature\n℃")] double ot,
            [ExcelArgument(Name = "DT", Description = "Design Temperature\n℃")] double dt)
        {
            if (ot == 0 && dt == 0)
            {
                return null;
            }
            string desigator = "";
            if (dt >= 0 && dt <= 230)

            {
                desigator = "F3";
            }
            else if (dt > 230)
            {
                desigator = "M3";
            }
            string sql = "SELECT MAX(dn) FROM M";
            int maxDN = Convert.ToInt32(SQLiteHelper.ExecuteScalar(sql));
            if (dn > maxDN)
            {
                dn = maxDN;
            }
            sql = $"SELECT insulation_thickness FROM M WHERE dn={dn} AND operating_temperature >= {ot} ORDER BY insulation_thickness LIMIT 1";
            object thickness = SQLiteHelper.ExecuteScalar(sql);

            return $"{desigator}-{thickness}mm";
        }
    }
}
