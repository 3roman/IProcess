using ExcelDna.Integration;

namespace IThermal
{
    public static class IAPWS97
    {
        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for saturation temperature\n℃")]
        public static double P2T(
            [ExcelArgument(Name = "saturation pressure", Description = "MPaA")] double p)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.P2T(p, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy of saturated water\nkJ/kg")]
        public static double P2HL([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.P2HL(p, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy of saturated water\nkJ/(kg.℃)")]
        public static double P2SL([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.P2SL(p, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume of saturated water\nkg/m³")]
        public static double P2VL([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.P2VL(p, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant pressure of saturated water\nkJ/(kg.℃)")]
        public static double P2CPL([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.P2CPL(p, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant volume of saturated water\nkJ/(kg.℃)")]
        public static double P2CVL([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.P2CVL(p, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for isentropic exponent of saturated water")]
        public static double P2KSL([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.P2KSL(p, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dynamic viscosity of saturated water\npa.s")]
        public static double P2ETAL([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.P2ETAL(p, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy of saturated steam\nkJ/kg")]
        public static double P2HG([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.P2HG(p, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy of saturated steam\nkJ/(kg.℃)")]
        public static double P2SG([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.P2SG(p, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume of saturated steam\nkg/m³")]
        public static double P2VG([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.P2VG(p, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant pressure of saturated steam\nkJ/(kg.℃)")]
        public static double P2CPG([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.P2CPG(p, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant volume of saturated steam\nkJ/(kg.℃)")]
        public static double P2CVG([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.P2CVG(p, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for isentropic exponent of saturated steam")]
        public static double P2KSG([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.P2KSG(p, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dynamic viscosity of saturated steam\npa.s")]
        public static double P2ETAG([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.P2ETAG(p, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for saturation pressure\nMPaA")]
        public static double T2P(
            [ExcelArgument(Name = "saturation temperature", Description = "℃")] double t)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.T2P(t, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy of saturated water\nkJ/kg")]
        public static double T2HL([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.T2HL(t, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy of saturated water\nkJ/(kg.℃)")]
        public static double T2SL([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.T2SL(t, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume of saturated water\nkg/m³")]
        public static double T2VL([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.T2VL(t, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant pressure of saturated water\nkJ/(kg.℃)")]
        public static double T2CPL([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.T2CPL(t, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant volume of saturated water\nkJ/(kg.℃)")]
        public static double T2CVL([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.T2CVL(t, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for isentropic exponent of saturated water")]
        public static double T2KSL([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.T2KSL(t, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dynamic viscosity of saturated water\npa.s")]
        public static double T2ETAL([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.T2ETAL(t, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy of saturated steam\nkJ/kg")]
        public static double T2HG([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.T2HG(t, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy of saturated steam\nkJ/(kg.℃)")]
        public static double T2SG([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.T2SG(t, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume of saturated steam\nkg/m³")]
        public static double T2VG([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.T2VG(t, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant pressure of saturated steam\nkJ/(kg.℃)")]
        public static double T2CPG([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.T2CPG(t, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant volume of saturated steam\nkJ/(kg.℃)")]
        public static double T2CVG([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.T2CVG(t, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for isentropic exponent of saturated steam")]
        public static double T2KSG([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.T2KSG(t, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dynamic viscosity of saturated steam\npa.s")]
        public static double T2ETAG([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.T2ETAG(t, ref result, ref zone);

            return result;
        }
    }
}