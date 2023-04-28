using ExcelDna.Integration;
using System.Runtime.InteropServices;

namespace Process.ThermalEngineer
{
    public class IAPWS97
    {
        private delegate void GeneralFun1(double param, ref double result, ref int zone);
        private delegate void GeneralFun2(double param1, double param2, ref double result, ref int zone);

        private static double Dispatcher(GeneralFun1 gf1, double param)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            gf1(param, ref result, ref zone);

            return result;
        }

        private static double Dispatcher(GeneralFun2 gf2, double param1, double param2)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            gf2(param1, param2, ref result, ref zone);

            return result;
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for saturation temperature\n℃")]
        public static double P2T97([ExcelArgument(Name = "P", Description = "saturation pressure\nbarA")] double p)
        {
            return Dispatcher(UEwasp.P2T, p / 10);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for enthalpy of saturated water\nkJ/kg")]
        public static double P2HL97([ExcelArgument(Name = "P", Description = "saturation pressure\nbarA")] double p)
        {
            return Dispatcher(UEwasp.P2HL, p / 10);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for entropy of saturated water\nkJ/(kg.℃)")]
        public static double P2SL97([ExcelArgument(Name = "P", Description = "saturation pressure\nbarA")] double p)
        {
            return Dispatcher(UEwasp.P2SL, p / 10);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific volume of saturated water\nm³/kg")]
        public static double P2VL97([ExcelArgument(Name = "P", Description = "saturation pressure\nbarA")] double p)
        {
            return Dispatcher(UEwasp.P2VL, p / 10);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific heat at constant pressure of saturated water\nkJ/(kg.℃)")]
        public static double P2CPL97([ExcelArgument(Name = "P", Description = "saturation pressure\nbarA")] double p)
        {
            return Dispatcher(UEwasp.P2CPL, p / 10);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific heat at constant volume of saturated water\nkJ/(kg.℃)")]
        public static double P2CVL97([ExcelArgument(Name = "P", Description = "saturation pressure\nbarA")] double p)
        {
            return Dispatcher(UEwasp.P2CVL, p / 10);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for isentropic exponent of saturated water")]
        public static double P2KSL97([ExcelArgument(Name = "P", Description = "saturation pressure\nbarA")] double p)
        {
            return Dispatcher(UEwasp.P2KSL, p / 10);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for dynamic viscosity of saturated water\npa.s")]
        public static double P2ETAL97([ExcelArgument(Name = "P", Description = "saturation pressure\nbarA")] double p)
        {
            return Dispatcher(UEwasp.P2ETAL, p / 10);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for enthalpy of saturated steam\nkJ/kg")]
        public static double P2HG97([ExcelArgument(Name = "P", Description = "saturation pressure\nbarA")] double p)
        {
            return Dispatcher(UEwasp.P2HG, p / 10);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for entropy of saturated steam\nkJ/(kg.℃)")]
        public static double P2SG97([ExcelArgument(Name = "P", Description = "saturation pressure\nbarA")] double p)
        {
            return Dispatcher(UEwasp.P2SG, p / 10);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific volume of saturated steam\nm³/kg")]
        public static double P2VG97([ExcelArgument(Name = "P", Description = "saturation pressure\nbarA")] double p)
        {
            return Dispatcher(UEwasp.P2VG, p / 10);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific heat at constant pressure of saturated steam\nkJ/(kg.℃)")]
        public static double P2CPG97([ExcelArgument(Name = "P", Description = "saturation pressure\nbarA")] double p)
        {
            return Dispatcher(UEwasp.P2CPG, p / 10);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific heat at constant volume of saturated steam\nkJ/(kg.℃)")]
        public static double P2CVG97([ExcelArgument(Name = "P", Description = "saturation pressure\nbarA")] double p)
        {
            return Dispatcher(UEwasp.P2CVG, p / 10);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for isentropic exponent of saturated steam")]
        public static double P2KSG97([ExcelArgument(Name = "P", Description = "saturation pressure\nbarA")] double p)
        {
            return Dispatcher(UEwasp.P2KSG, p / 10);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for dynamic viscosity of saturated steam\npa.s")]
        public static double P2ETAG97([ExcelArgument(Name = "P", Description = "saturation pressure\nbarA")] double p)
        {
            return Dispatcher(UEwasp.P2ETAG, p / 10);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for saturation pressure\nbarA")]
        public static double T2P97(
            [ExcelArgument(Name = "saturation temperature", Description = "℃")] double t)
        {
            return Dispatcher(UEwasp.T2P, t) * 10;
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for enthalpy of saturated water\nkJ/kg")]
        public static double T2HL97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2HL, t);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for entropy of saturated water\nkJ/(kg.℃)")]
        public static double T2SL97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2SL, t);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific volume of saturated water\nm³/kg")]
        public static double T2VL97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2VL, t);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific heat at constant pressure of saturated water\nkJ/(kg.℃)")]
        public static double T2CPL97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2CPL, t);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific heat at constant volume of saturated water\nkJ/(kg.℃)")]
        public static double T2CVL97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2CVL, t);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for isentropic exponent of saturated water")]
        public static double T2KSL97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2KSL, t);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for dynamic viscosity of saturated water\npa.s")]
        public static double T2ETAL97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2ETAL, t);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for enthalpy of saturated steam\nkJ/kg")]
        public static double T2HG97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2HG, t);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for entropy of saturated steam\nkJ/(kg.℃)")]
        public static double T2SG97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2SG, t);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific volume of saturated steam\nm³/kg")]
        public static double T2VG97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2VG, t);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific heat at constant pressure of saturated steam\nkJ/(kg.℃)")]
        public static double T2CPG97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2CPG, t);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific heat at constant volume of saturated steam\nkJ/(kg.℃)")]
        public static double T2CVG97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2CVG, t);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for isentropic exponent of saturated steam")]
        public static double T2KSG97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2KSG, t);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for dynamic viscosity of saturated steam\npa.s")]
        public static double T2ETAG97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2ETAG, t);
        }


        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for enthalpy\nkJ/kg")]
        public static double PT2H97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2H, p / 10, t);
        }
        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for entropy\nkJ/(kg.℃)")]
        public static double PT2S97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2S, p / 10, t);
        }
        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific volume\nm³/kg")]
        public static double PT2V97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2V, p / 10, t);
        }
        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific heat at constant pressure\nkJ/(kg.℃)")]
        public static double PT2CP97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2CP, p / 10, t);
        }
        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific heat at constant volume\nkJ/(kg.℃)")]
        public static double PT2CV97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2CV, p / 10, t);
        }
        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for isentropic exponent")]
        public static double PT2KS97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2KS, p / 10, t);
        }
        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for dynamic viscosity\npa.s")]
        public static double PT2ETA97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2ETA, p / 10, t);
        }
        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for dryness friction\n(0~1/-1)")]
        public static double PT2X97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2X, p / 10, t);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for temperature\n℃")]
        public static double PH2T97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.PH2T, p / 10, h);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for entropy\nkJ/(kg.℃)")]
        public static double PH2S97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.PH2S, p / 10, h);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific volume\nm³/kg")]
        public static double PH2V97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.PH2V, p / 10, h);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for dryness friction\n((0~1/-1)/-1])")]
        public static double PH2X97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.PH2X, p / 10, h);
        }


        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for temperature\n℃")]
        public static double PS2T97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.PS2T, p / 10, s);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for enthalpy\nkJ/kg")]
        public static double PS2H97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.PS2H, p / 10, s);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific volume\nm³/kg")]
        public static double PS2V97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.PS2V, p / 10, s);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for dryness friction\n(0~1/-1)")]
        public static double PS2X97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.PS2X, p / 10, s);
        }


        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for temperature\n℃")]
        public static double PV2T97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "V", Description = "specific volume\nm³/kg")] double v)
        {
            return Dispatcher(UEwasp.PV2T, p / 10, v);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for enthalpy\nkJ/kg")]
        public static double PV2H97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "V", Description = "specific volume\nm³/kg")] double v)
        {
            return Dispatcher(UEwasp.PV2H, p / 10, v);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for entropy\nkJ/(kg.℃)")]
        public static double PV2S97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "V", Description = "specific volume\nm³/kg")] double v)
        {
            return Dispatcher(UEwasp.PV2S, p / 10, v);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for dryness friction\n(0~1/-1)")]
        public static double PV2X97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "V", Description = "specific volume\nm³/kg")] double v)
        {
            return Dispatcher(UEwasp.PV2X, p / 10, v);
        }


        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for temperature\n℃")]
        public static double PX2T97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "X", Description = "dryness friction\n(0~1)")] double x)
        {
            return Dispatcher(UEwasp.PX2T, p / 10, x);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for enthalpy\nkJ/kg")]
        public static double PX2H97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "X", Description = "dryness friction\n(0~1)")] double x)
        {
            return Dispatcher(UEwasp.PX2H, p / 10, x);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for entropy\nkJ/(kg.℃)")]
        public static double PX2S97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "X", Description = "dryness friction\n(0~1)")] double x)
        {
            return Dispatcher(UEwasp.PX2S, p / 10, x);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific volume\nm³/kg")]
        public static double PX2V97([ExcelArgument(Name = "P", Description = "pressure\nbarA")] double p, [ExcelArgument(Name = "X", Description = "dryness friction\n(0~1)")] double x)
        {
            return Dispatcher(UEwasp.PX2V, p / 10, x);
        }


        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for pressure\nbarA")]
        public static double TH2P97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.TH2P, t, h) * 10;
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for entropy\nkJ/(kg.℃)")]
        public static double TH2S97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.TH2S, t, h);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific volume\nm³/kg")]
        public static double TH2V97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.TH2V, t, h);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for dryness friction\n(0~1/-1)")]
        public static double TH2X97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.TH2X, t, h);
        }


        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for pressure\nbarA")]
        public static double TS2P97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.TS2P, t, s) * 10;
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for enthalpy\nkJ/kg")]
        public static double TS2H97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.TS2H, t, s);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific volume\nm³/kg")]
        public static double TS2V97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.TS2V, t, s);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for dryness friction\n(0~1/-1)")]
        public static double TS2X97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.TS2X, t, s);
        }


        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for pressure\nbarA")]
        public static double TV2P97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "V", Description = "specific volume\nm³/kg)")] double v)
        {
            return Dispatcher(UEwasp.TV2P, t, v) * 10;
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for enthalpy\nkJ/kg")]
        public static double TV2H97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "V", Description = "specific volume\nm³/kg)")] double v)
        {
            return Dispatcher(UEwasp.TV2H, t, v);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for entropy\nkJ/(kg.℃)")]
        public static double TV2S97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "V", Description = "specific volume\nm³/kg)")] double v)
        {
            return Dispatcher(UEwasp.TV2S, t, v);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for dryness friction\n(0~1/-1)")]
        public static double TV2X97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "V", Description = "specific volume\nm³/kg)")] double v)
        {
            return Dispatcher(UEwasp.TV2X, t, v);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for pressure\nbarA")]
        public static double TX2P97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "X", Description = "dryness friction\n(0~1)")] double x)
        {
            return Dispatcher(UEwasp.TX2P, t, x) * 10;
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for enthalpy\nkJ/kg")]
        public static double TX2H97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "X", Description = "dryness friction\n(0~1)")] double x)
        {
            return Dispatcher(UEwasp.TX2H, t, x);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for entropy\nkJ/(kg.℃)")]
        public static double TX2S97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "X", Description = "dryness friction\n(0~1)")] double x)
        {
            return Dispatcher(UEwasp.TX2S, t, x);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific volume\nm³/kg")]
        public static double TX2V97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "X", Description = "dryness friction\n(0~1)")] double x)
        {
            return Dispatcher(UEwasp.TX2V, t, x);
        }


        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for pressure\nbarA")]
        public static double HS2P97([ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.HS2P, h, s) * 10;
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for temperature\n℃")]
        public static double HS2T97([ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.HS2T, h, s);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for specific volume\nm³/kg")]
        public static double HS2V97([ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.HS2V, h, s);
        }

        [ExcelFunction(Category = "IThermalEngineer", Description = "solve for dryness friction\n(0~1/-1)")]
        public static double HS2X97([ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.HS2X, h, s);
        }
    }

    class UEwasp
    {
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void SETSTD_WASP(int x);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2CPG(double P, ref double CP, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2CPL(double P, ref double CP, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2CVG(double P, ref double CV, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2CVL(double P, ref double CV, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2EG(double P, ref double E, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2EL(double P, ref double E, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2EPSG(double P, ref double EPS, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2EPSL(double P, ref double EPS, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2ETAG(double P, ref double ETA, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2ETAL(double P, ref double ETA, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2HG(double P, ref double H, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2HL(double P, ref double H, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2KSG(double P, ref double KS, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2KSL(double P, ref double KS, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2NG(double P, ref double N, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2NL(double P, ref double N, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2PRNG(double P, ref double PRN, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2PRNL(double P, ref double PRN, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2RAMDG(double P, ref double RAMD, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2RAMDL(double P, ref double RAMD, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2SG(double P, ref double S, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2SL(double P, ref double S, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2SSPG(double P, ref double SSP, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2SSPL(double P, ref double SSP, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2T(double P, ref double T, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2UG(double P, ref double U, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2UL(double P, ref double U, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2VG(double P, ref double V, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2VL(double P, ref double V, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2CPG(double T, ref double CP, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2CPL(double T, ref double CP, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2CVG(double T, ref double CV, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2CVL(double T, ref double CV, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2EG(double T, ref double E, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2EL(double T, ref double E, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2EPSG(double T, ref double EPS, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2EPSL(double T, ref double EPS, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2ETAG(double T, ref double ETA, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2ETAL(double T, ref double ETA, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2HG(double T, ref double H, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2HL(double T, ref double H, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2KSG(double T, ref double KS, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2KSL(double T, ref double KS, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2NG(double T, ref double N, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2NL(double T, ref double N, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2PRNG(double T, ref double TRN, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2PRNL(double T, ref double TRN, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2RAMDG(double T, ref double RAMD, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2RAMDL(double T, ref double RAMD, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2SG(double T, ref double S, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2SL(double T, ref double S, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2SSPG(double T, ref double SSP, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2SSPL(double T, ref double SSP, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2P(double T, ref double P, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2UG(double T, ref double U, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2UL(double T, ref double U, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2VG(double T, ref double V, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void T2VL(double T, ref double V, ref int zone);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PT2H(double p, double t, ref double h, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PT2S(double p, double t, ref double s, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PT2V(double p, double t, ref double v, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PT2CP(double p, double t, ref double cp, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PT2CV(double p, double t, ref double cv, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PT2KS(double p, double t, ref double ks, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PT2ETA(double p, double t, ref double eta, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PT2X(double p, double t, ref double x, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PH2T(double p, double h, ref double t, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PH2S(double p, double h, ref double s, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PH2V(double p, double h, ref double v, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PH2X(double p, double h, ref double x, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PS2T(double p, double s, ref double t, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PS2H(double p, double s, ref double h, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PS2V(double p, double s, ref double v, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PS2X(double p, double s, ref double x, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PV2T(double p, double v, ref double t, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PV2H(double p, double v, ref double h, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PV2S(double p, double v, ref double s, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PV2X(double p, double v, ref double x, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PX2T(double p, double x, ref double t, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PX2H(double p, double x, ref double h, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PX2S(double p, double x, ref double s, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PX2V(double p, double x, ref double v, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TH2P(double t, double h, ref double p, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TH2S(double t, double h, ref double s, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TH2V(double t, double h, ref double v, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TH2X(double t, double h, ref double x, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TS2P(double t, double s, ref double p, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TS2H(double t, double s, ref double h, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TS2V(double t, double s, ref double v, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TS2X(double t, double s, ref double x, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TV2P(double t, double v, ref double p, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TV2H(double t, double v, ref double h, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TV2S(double t, double v, ref double s, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TV2X(double t, double v, ref double x, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TX2P(double t, double x, ref double p, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TX2H(double t, double x, ref double h, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TX2S(double t, double x, ref double s, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TX2V(double t, double x, ref double v, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void HS2P(double h, double s, ref double p, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void HS2T(double h, double s, ref double t, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void HS2V(double h, double s, ref double v, ref int z);
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void HS2X(double h, double s, ref double x, ref int z);
    }
}