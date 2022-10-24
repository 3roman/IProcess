using ExcelDna.Integration;
using System;

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


        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for saturation temperature\n℃")]
        public static double P2T ([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
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

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume of saturated water\nkg/m³")]
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

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume of saturated steam\nkg/m³")]
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

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume of saturated water\nkg/m³")]
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

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume of saturated steam\nkg/m³")]
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
    }
}