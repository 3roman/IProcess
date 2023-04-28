using ExcelDna.Integration;


namespace Process.ThermalEngineer
{
    public class LetdownStation
    {
        [ExcelFunction(Category = "IThermalEngineer", Description = "calculate secondary steam flowrate for letdown station")]
        public static object LetdownStation2(
            [ExcelArgument(Name = "p1", Description = "primary steam pressure\nbarA")] double p1,
            [ExcelArgument(Name = "t1", Description = "primary steam temperature\n℃")] double t1,
            [ExcelArgument(Name = "p2", Description = "secondary steam pressure\nbarA")] double p2,
            [ExcelArgument(Name = "t2", Description = "secondary steam temperature\n℃")] double t2,
            [ExcelArgument(Name = "p3", Description = "quench water pressure\nbarA")] double p3,
            [ExcelArgument(Name = "t3", Description = "quench water temperature\n℃")] double t3,
            [ExcelArgument(Name = "f1", Description = "primary steam flowrate\nkg/h")] double f2)
        {
            double h1 = IAPWS97.PT2H97(p1, t1);
            double h2 = IAPWS97.PT2H97(p2, t2);
            double h3 = IAPWS97.PT2H97(p3, t3);

            return f2 * (h1 - h3) / (h2 - h3);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "calculate primary steam flowrate for letdown station")]
        public static object LetdownStation1(
            [ExcelArgument(Name = "p1", Description = "primary steam pressure\nbarA")] double p1,
            [ExcelArgument(Name = "t1", Description = "primary steam temperature\n℃")] double t1,
            [ExcelArgument(Name = "p2", Description = "secondary steam pressure\nbarA")] double p2,
            [ExcelArgument(Name = "t2", Description = "secondary steam temperature\n℃")] double t2,
            [ExcelArgument(Name = "p3", Description = "quench water pressure\nbarA")] double p3,
            [ExcelArgument(Name = "t3", Description = "quench water temperature\n℃")] double t3,
            [ExcelArgument(Name = "f2", Description = "secondary steam flowrate\nkg/h")] double f2)
        {
            double h1 = IAPWS97.PT2H97(p1, t1);
            double h2 = IAPWS97.PT2H97(p2, t2);
            double h3 = IAPWS97.PT2H97(p3, t3);

            return f2 * (h2 - h3) / (h1 - h3);
        }
    }
}
