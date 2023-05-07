using ExcelDna.Integration;

namespace Process.ThermalEngineer
{
    public class Turbine
    {
        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for steam rate of a steam turbine\nkg/kW.h")]
        public static double SteamRatebyTurbineEfficiency(
            [ExcelArgument(Name = "Pi", Description = "inlet steam pressure\nbara")] double Pi,
            [ExcelArgument(Name = "Ti", Description = "inlet steam temperature\n℃")] double Ti,
            [ExcelArgument(Name = "Pe", Description = "exhaust steam pressure\nbara")] double Pe,
            [ExcelArgument(Name = "eta", Description = "turbine efficiency\n(0~100)")] double eta)
        {
            double inletEnthalpy = IAPWS97.PT2H97(Pi, Ti);
            double inletEntropy = IAPWS97.PT2S97(Pi, Ti);
            double idealExhaustEnthalpy = IAPWS97.PS2H97(Pe, inletEntropy);
            double actualEnthalpyDrop = (inletEnthalpy - idealExhaustEnthalpy) * (eta / 100);

            // NEMA SM24-1991 2.5.1.1
            return 3600 / actualEnthalpyDrop;
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for steam rate of a steam turbine\nkg/kW.h")]
        public static double SteamRatebyExhaustSteamDryness(
            [ExcelArgument(Name = "Pi", Description = "inlet steam pressure\nbara")] double Pi,
            [ExcelArgument(Name = "Ti", Description = "inlet steam temperature\n℃")] double Ti,
            [ExcelArgument(Name = "Pe", Description = "exhaust steam pressure\nbara")] double Pe,
            [ExcelArgument(Name = "Xe", Description = "exhaust steam dryness fraction\n(0~1)")] double Xe)
        {
            double inletEnthalpy = IAPWS97.PT2H97(Pi, Ti);
            double exhaustEnthalpy = IAPWS97.PX2H97(Pe, Xe);

            // NEMA SM24-1991 2.5.1.1
            return 3600 / (inletEnthalpy - exhaustEnthalpy);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for exhaust steam temperaturen\n℃")]
        public static double ExhaustSteamTemperaturebyTurbineEfficiency(
            [ExcelArgument(Name = "Pi", Description = "inlet steam pressure\nbara")] double Pi,
            [ExcelArgument(Name = "Ti", Description = "inlet steam temperature\n℃")] double Ti,
            [ExcelArgument(Name = "Pe", Description = "exhaust steam pressure\nbara")] double Pe,
            [ExcelArgument(Name = "eta", Description = "turbine efficiency\n(0~100)")] double eta)
        {
            double inletEnthalpy = IAPWS97.PT2H97(Pi, Ti);
            double inletEntropy = IAPWS97.PT2S97(Pi, Ti);
            double idealExhaustEnthalpy = IAPWS97.PS2H97(Pe, inletEntropy);
            double actualEnthalpyDrop = (inletEnthalpy - idealExhaustEnthalpy) * (eta / 100);
            double exhaustEnthalpy = inletEnthalpy - actualEnthalpyDrop;

            return IAPWS97.PH2T97(Pe, exhaustEnthalpy);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for exhaust dryness fraction\n(0~1)")]
        public static double ExhaustSteamDrynessbyTurbineEfficiency(
            [ExcelArgument(Name = "Pi", Description = "inlet steam pressure\nbara")] double Pi,
            [ExcelArgument(Name = "Ti", Description = "inlet steam temperature\n℃")] double Ti,
            [ExcelArgument(Name = "Pe", Description = "exhaust steam pressure\nbara")] double Pe,
            [ExcelArgument(Name = "eta", Description = "turbine efficiency\n(0~100)")] double eta)
        {
            double inletEnthalpy = IAPWS97.PT2H97(Pi, Ti);
            double inletEntropy = IAPWS97.PT2S97(Pi, Ti);
            double idealExhaustEnthalpy = IAPWS97.PS2H97(Pe, inletEntropy);
            double actualEnthalpyDrop = (inletEnthalpy - idealExhaustEnthalpy) * (eta / 100);
            double exhaustEnthalpy = inletEnthalpy - actualEnthalpyDrop;

            return IAPWS97.PH2X97(Pe, exhaustEnthalpy);
        }
    }
}
