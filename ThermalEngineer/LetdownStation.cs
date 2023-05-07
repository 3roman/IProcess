using ExcelDna.Integration;


namespace Process.ThermalEngineer
{
    public class LetdownStation
    {
        [ExcelFunction(Category = "IThermalEngineer", Description = "calculate primary steam flowrate for letdown station")]
        public static object LetdownStation4PrimarySteam(
            [ExcelArgument(Name = "p1", Description = "primary steam pressure\nbara")] double p1,
            [ExcelArgument(Name = "t1", Description = "primary steam temperature\n℃")] double t1,
            [ExcelArgument(Name = "p2", Description = "secondary steam pressure\nbara")] double p2,
            [ExcelArgument(Name = "t2", Description = "secondary steam temperature\n℃")] double t2,
            [ExcelArgument(Name = "p3", Description = "quench water pressure\nbara")] double p3,
            [ExcelArgument(Name = "t3", Description = "quench water temperature\n℃")] double t3,
            [ExcelArgument(Name = "f2", Description = "secondary steam flowrate\nkg/h")] double f2)
        {
            double h1 = IAPWS97.PT2H97(p1, t1);
            double h2 = IAPWS97.PT2H97(p2, t2);
            double hw = IAPWS97.PT2H97(p3, t3);

            return f2 * (h2 - hw) / (h1 - hw);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "calculate secondary steam flowrate for letdown station")]
        public static object LetdownStation4SecondarySteam(
            [ExcelArgument(Name = "p1", Description = "primary steam pressure\nbara")] double p1,
            [ExcelArgument(Name = "t1", Description = "primary steam temperature\n℃")] double t1,
            [ExcelArgument(Name = "p2", Description = "secondary steam pressure\nbara")] double p2,
            [ExcelArgument(Name = "t2", Description = "secondary steam temperature\n℃")] double t2,
            [ExcelArgument(Name = "p3", Description = "quench water pressure\nbara")] double p3,
            [ExcelArgument(Name = "t3", Description = "quench water temperature\n℃")] double t3,
            [ExcelArgument(Name = "f1", Description = "primary steam flowrate\nkg/h")] double f2)
        {
            double h1 = IAPWS97.PT2H97(p1, t1);
            double h2 = IAPWS97.PT2H97(p2, t2);
            double hw = IAPWS97.PT2H97(p3, t3);

            return f2 * (h1 - hw) / (h2 - hw);
        }
    }
}
