using ExcelDna.Integration;

namespace IThermal
{
    public delegate void GeneralFun1(double param, ref double result, ref int zone);
    public delegate void GeneralFun2(double param1, double param2, ref double result, ref int zone);

    public static class IAPWS97
    {
        public static double Dispatcher(GeneralFun1 gf1, double param)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            gf1(param, ref result, ref zone);

            return result;
        }

        public static double Dispatcher(GeneralFun2 gf2, double param1, double param2)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            gf2(param1, param2, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for saturation temperature\n℃")]
        public static double P2T([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2T, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy of saturated water\nkJ/kg")]
        public static double P2HL([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2HL, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy of saturated water\nkJ/(kg.℃)")]
        public static double P2SL([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2SL, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume of saturated water\nm³/kg")]
        public static double P2VL([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2VL, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant pressure of saturated water\nkJ/(kg.℃)")]
        public static double P2CPL([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2CPL, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant volume of saturated water\nkJ/(kg.℃)")]
        public static double P2CVL([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2CVL, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for isentropic exponent of saturated water")]
        public static double P2KSL([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2KSL, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dynamic viscosity of saturated water\npa.s")]
        public static double P2ETAL([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2ETAL, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy of saturated steam\nkJ/kg")]
        public static double P2HG([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2HG, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy of saturated steam\nkJ/(kg.℃)")]
        public static double P2SG([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2SG, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume of saturated steam\nm³/kg")]
        public static double P2VG([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2VG, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant pressure of saturated steam\nkJ/(kg.℃)")]
        public static double P2CPG([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2CPG, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant volume of saturated steam\nkJ/(kg.℃)")]
        public static double P2CVG([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2CVG, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for isentropic exponent of saturated steam")]
        public static double P2KSG([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2KSG, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dynamic viscosity of saturated steam\npa.s")]
        public static double P2ETAG([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2ETAG, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for saturation pressure\nMPaA")]
        public static double T2P(
            [ExcelArgument(Name = "saturation temperature", Description = "℃")] double t)
        {
            return Dispatcher(UEwasp.T2P, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy of saturated water\nkJ/kg")]
        public static double T2HL([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2HL, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy of saturated water\nkJ/(kg.℃)")]
        public static double T2SL([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2SL, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume of saturated water\nm³/kg")]
        public static double T2VL([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2VL, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant pressure of saturated water\nkJ/(kg.℃)")]
        public static double T2CPL([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2CPL, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant volume of saturated water\nkJ/(kg.℃)")]
        public static double T2CVL([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2CVL, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for isentropic exponent of saturated water")]
        public static double T2KSL([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2KSL, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dynamic viscosity of saturated water\npa.s")]
        public static double T2ETAL([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2ETAL, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy of saturated steam\nkJ/kg")]
        public static double T2HG([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2HG, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy of saturated steam\nkJ/(kg.℃)")]
        public static double T2SG([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2SG, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume of saturated steam\nm³/kg")]
        public static double T2VG([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2VG, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant pressure of saturated steam\nkJ/(kg.℃)")]
        public static double T2CPG([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2CPG, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant volume of saturated steam\nkJ/(kg.℃)")]
        public static double T2CVG([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2CVG, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for isentropic exponent of saturated steam")]
        public static double T2KSG([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2KSG, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dynamic viscosity of saturated steam\npa.s")]
        public static double T2ETAG([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2ETAG, t);
        }


        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy\nkJ/kg")]
        public static double PT2H([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2H, p, t);
        }
        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy\nkJ/(kg.℃)")]
        public static double PT2S([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2S, p, t);
        }
        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume\nm³/kg")]
        public static double PT2V([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2V, p, t);
        }
        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant pressure\nkJ/(kg.℃)")]
        public static double PT2CP([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2CP, p, t);
        }
        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant volume\nkJ/(kg.℃)")]
        public static double PT2CV([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2CV, p, t);
        }
        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for isentropic exponent")]
        public static double PT2KS([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2KS, p, t);
        }
        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dynamic viscosity\npa.s")]
        public static double PT2ETA([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2ETA, p, t);
        }
        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dryness friction\n0~1")]
        public static double PT2X([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2X, p, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for temperature\n℃")]
        public static double PH2T([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.PH2T, p, h);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy\nkJ/(kg.℃)")]
        public static double PH2S([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.PH2S, p, h);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume\nm³/kg")]
        public static double PH2V([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.PH2V, p, h);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dryness friction\n0~1")]
        public static double PH2X([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.PH2X, p, h);
        }


        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for temperature\n℃")]
        public static double PS2T([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.PS2T, p, s);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy\nkJ/kg")]
        public static double PS2H([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.PS2H, p, s);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume\nm³/kg")]
        public static double PS2V([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.PS2V, p, s);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dryness friction\n0~1")]
        public static double PS2X([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.PS2X, p, s);
        }


        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for pressure\nMPaA")]
        public static double HS2P([ExcelArgument(Name = "P", Description = "enthalpy\nkJ/kg")] double h, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.HS2P, h, s);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for temperature\n℃")]
        public static double HS2T([ExcelArgument(Name = "P", Description = "enthalpy\nkJ/kg")] double h, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.HS2T, h, s);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume\nm³/kg")]
        public static double HS2V([ExcelArgument(Name = "P", Description = "enthalpy\nkJ/kg")] double h, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.HS2V, h, s);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dryness friction\n0~1")]
        public static double HS2X([ExcelArgument(Name = "P", Description = "enthalpy\nkJ/kg")] double h, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.HS2X, h, s);
        }


    }
}