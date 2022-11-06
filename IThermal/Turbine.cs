using ExcelDna.Integration;


namespace IThermal
{
    public class Turbine
    {
        [ExcelFunction(Category = "IThermal_Turbine", Description = "solve for steam rate of a steam turbine\nkg/kW.h")]
        public static double SteamRate1(
            [ExcelArgument(Name = "Pi", Description = "inlet steam pressure\nMPaA")] double Pi,
            [ExcelArgument(Name = "Ti", Description = "inlet steam temperature\n℃")] double Ti,
            [ExcelArgument(Name = "Pe", Description = "exhaust steam pressure\nMPaA")] double Pe,
            [ExcelArgument(Name = "eta", Description = "relative internal efficiency of steam turbine\n(0~100)")] double eta)
        {
            double inletEnthalpy = IAPWS97.PT2H97(Pi, Ti);
            double inletEntropy = IAPWS97.PT2S97(Pi, Ti);
            double idealExhaustEnthalpy = IAPWS97.PS2H97(Pe, inletEntropy);
            double actualEnthalpyDrop = (inletEnthalpy - idealExhaustEnthalpy) * (eta / 100);

            // NEMA SM24-1991 2.5.1.1
            return 3600 / actualEnthalpyDrop;
        }

        [ExcelFunction(Category = "IThermal_Turbine", Description = "solve for steam rate of a steam turbine\nkg/kW.h")]
        public static double SteamRate2(
            [ExcelArgument(Name = "Pi", Description = "inlet steam pressure\nMPaA")] double Pi,
            [ExcelArgument(Name = "Ti", Description = "inlet steam temperature\n℃")] double Ti,
            [ExcelArgument(Name = "Pe", Description = "exhaust steam pressure\nMPaA")] double Pe,
            [ExcelArgument(Name = "Xe", Description = "exhaust dryness fraction\n(0~1)")] double Xe)
        {
            double inletEnthalpy = IAPWS97.PT2H97(Pi, Ti);
            double exhaustEnthalpy = IAPWS97.PX2H97(Pe, Xe);

            // NEMA SM24-1991 2.5.1.1
            return 3600 / (inletEnthalpy- exhaustEnthalpy);
        }


        [ExcelFunction(Category = "IThermal_Turbine", Description = "solve for exhaust temperaturen\n℃")]
        public static double ExhaustTemperature(
            [ExcelArgument(Name = "Pi", Description = "inlet steam pressure\nMPaA")] double Pi,
            [ExcelArgument(Name = "Ti", Description = "inlet steam temperature\n℃")] double Ti,
            [ExcelArgument(Name = "Pe", Description = "exhaust steam pressure\nMPaA")] double Pe,
            [ExcelArgument(Name = "eta", Description = "relative internal efficiency of steam turbine\n(0~100)")] double eta)
        {
            double inletEnthalpy = IAPWS97.PT2H97(Pi, Ti);
            double inletEntropy = IAPWS97.PT2S97(Pi, Ti);
            double idealExhaustEnthalpy = IAPWS97.PS2H97(Pe, inletEntropy);
            double actualEnthalpyDrop = (inletEnthalpy - idealExhaustEnthalpy) * (eta / 100);
            double exhaustEnthalpy = inletEnthalpy - actualEnthalpyDrop;

            return IAPWS97.PH2T97(Pe, exhaustEnthalpy);
        }

        [ExcelFunction(Category = "IThermal_Turbine", Description = "solve for exhaust dryness fraction\n(0~1)")]
        public static double ExhaustDrynessFraction(
            [ExcelArgument(Name = "Pi", Description = "inlet steam pressure\nMPaA")] double Pi,
            [ExcelArgument(Name = "Ti", Description = "inlet steam temperature\n℃")] double Ti,
            [ExcelArgument(Name = "Pe", Description = "exhaust steam pressure\nMPaA")] double Pe,
            [ExcelArgument(Name = "eta", Description = "relative internal efficiency of steam turbine\n(0~100)")] double eta)
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