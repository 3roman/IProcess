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
        public static double P2T97([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2T, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy of saturated water\nkJ/kg")]
        public static double P2HL97([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2HL, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy of saturated water\nkJ/(kg.℃)")]
        public static double P2SL97([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2SL, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume of saturated water\nm³/kg")]
        public static double P2VL97([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2VL, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant pressure of saturated water\nkJ/(kg.℃)")]
        public static double P2CPL97([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2CPL, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant volume of saturated water\nkJ/(kg.℃)")]
        public static double P2CVL97([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2CVL, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for isentropic exponent of saturated water")]
        public static double P2KSL97([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2KSL, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dynamic viscosity of saturated water\npa.s")]
        public static double P2ETAL97([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2ETAL, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy of saturated steam\nkJ/kg")]
        public static double P2HG97([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2HG, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy of saturated steam\nkJ/(kg.℃)")]
        public static double P2SG97([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2SG, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume of saturated steam\nm³/kg")]
        public static double P2VG97([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2VG, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant pressure of saturated steam\nkJ/(kg.℃)")]
        public static double P2CPG97([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2CPG, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant volume of saturated steam\nkJ/(kg.℃)")]
        public static double P2CVG97([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2CVG, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for isentropic exponent of saturated steam")]
        public static double P2KSG97([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2KSG, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dynamic viscosity of saturated steam\npa.s")]
        public static double P2ETAG97([ExcelArgument(Name = "P", Description = "saturation pressure\nMPaA")] double p)
        {
            return Dispatcher(UEwasp.P2ETAG, p);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for saturation pressure\nMPaA")]
        public static double T2P97(
            [ExcelArgument(Name = "saturation temperature", Description = "℃")] double t)
        {
            return Dispatcher(UEwasp.T2P, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy of saturated water\nkJ/kg")]
        public static double T2HL97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2HL, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy of saturated water\nkJ/(kg.℃)")]
        public static double T2SL97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2SL, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume of saturated water\nm³/kg")]
        public static double T2VL97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2VL, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant pressure of saturated water\nkJ/(kg.℃)")]
        public static double T2CPL97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2CPL, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant volume of saturated water\nkJ/(kg.℃)")]
        public static double T2CVL97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2CVL, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for isentropic exponent of saturated water")]
        public static double T2KSL97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2KSL, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dynamic viscosity of saturated water\npa.s")]
        public static double T2ETAL97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2ETAL, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy of saturated steam\nkJ/kg")]
        public static double T2HG97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2HG, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy of saturated steam\nkJ/(kg.℃)")]
        public static double T2SG97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2SG, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume of saturated steam\nm³/kg")]
        public static double T2VG97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2VG, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant pressure of saturated steam\nkJ/(kg.℃)")]
        public static double T2CPG97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2CPG, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant volume of saturated steam\nkJ/(kg.℃)")]
        public static double T2CVG97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2CVG, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for isentropic exponent of saturated steam")]
        public static double T2KSG97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2KSG, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dynamic viscosity of saturated steam\npa.s")]
        public static double T2ETAG97([ExcelArgument(Name = "T", Description = "saturation temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.T2ETAG, t);
        }


        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy\nkJ/kg")]
        public static double PT2H97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2H, p, t);
        }
        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy\nkJ/(kg.℃)")]
        public static double PT2S97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2S, p, t);
        }
        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume\nm³/kg")]
        public static double PT2V97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2V, p, t);
        }
        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant pressure\nkJ/(kg.℃)")]
        public static double PT2CP97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2CP, p, t);
        }
        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific heat at constant volume\nkJ/(kg.℃)")]
        public static double PT2CV97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2CV, p, t);
        }
        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for isentropic exponent")]
        public static double PT2KS97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2KS, p, t);
        }
        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dynamic viscosity\npa.s")]
        public static double PT2ETA97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2ETA, p, t);
        }
        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dryness friction\n(0~1/-1)")]
        public static double PT2X97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "T", Description = "temperature\n℃")] double t)
        {
            return Dispatcher(UEwasp.PT2X, p, t);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for temperature\n℃")]
        public static double PH2T97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.PH2T, p, h);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy\nkJ/(kg.℃)")]
        public static double PH2S97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.PH2S, p, h);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume\nm³/kg")]
        public static double PH2V97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.PH2V, p, h);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dryness friction\n((0~1/-1)/-1])")]
        public static double PH2X97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.PH2X, p, h);
        }


        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for temperature\n℃")]
        public static double PS2T97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.PS2T, p, s);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy\nkJ/kg")]
        public static double PS2H97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.PS2H, p, s);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume\nm³/kg")]
        public static double PS2V97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.PS2V, p, s);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dryness friction\n(0~1/-1)")]
        public static double PS2X97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.PS2X, p, s);
        }


        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for temperature\n℃")]
        public static double PV2T97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "V", Description = "specific volume\nm³/kg")] double v)
        {
            return Dispatcher(UEwasp.PV2T, p, v);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy\nkJ/kg")]
        public static double PV2H97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "V", Description = "specific volume\nm³/kg")] double v)
        {
            return Dispatcher(UEwasp.PV2H, p, v);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy\nkJ/(kg.℃)")]
        public static double PV2S97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "V", Description = "specific volume\nm³/kg")] double v)
        {
            return Dispatcher(UEwasp.PV2S, p, v);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dryness friction\n(0~1/-1)")]
        public static double PV2X97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "V", Description = "specific volume\nm³/kg")] double v)
        {
            return Dispatcher(UEwasp.PV2X, p, v);
        }


        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for temperature\n℃")]
        public static double PX2T97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "X", Description = "dryness friction\n(0~1)")] double x)
        {
            return Dispatcher(UEwasp.PX2T, p, x);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy\nkJ/kg")]
        public static double PX2H97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "X", Description = "dryness friction\n(0~1)")] double x)
        {
            return Dispatcher(UEwasp.PX2H, p, x);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy\nkJ/(kg.℃)")]
        public static double PX2S97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "X", Description = "dryness friction\n(0~1)")] double x)
        {
            return Dispatcher(UEwasp.PX2S, p, x);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume\nm³/kg")]
        public static double PX2V97([ExcelArgument(Name = "P", Description = "pressure\nMPaA")] double p, [ExcelArgument(Name = "X", Description = "dryness friction\n(0~1)")] double x)
        {
            return Dispatcher(UEwasp.PX2V, p, x);
        }


        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for pressure\nMPaA")]
        public static double TH2P97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.TH2P, t, h);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy\nkJ/(kg.℃)")]
        public static double TH2S97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.TH2S, t, h);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume\nm³/kg")]
        public static double TH2V97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.TH2V, t, h);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dryness friction\n(0~1/-1)")]
        public static double TH2X97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h)
        {
            return Dispatcher(UEwasp.TH2X, t, h);
        }


        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for pressure\nMPaA")]
        public static double TS2P97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.TS2P, t, s);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy\nkJ/kg")]
        public static double TS2H97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.TS2H, t, s);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume\nm³/kg")]
        public static double TS2V97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.TS2V, t, s);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dryness friction\n(0~1/-1)")]
        public static double TS2X97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.TS2X, t, s);
        }


        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for pressure\nMPaA")]
        public static double TV2P97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "V", Description = "specific volume\nm³/kg)")] double v)
        {
            return Dispatcher(UEwasp.TV2P, t, v);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy\nkJ/kg")]
        public static double TV2H97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "V", Description = "specific volume\nm³/kg)")] double v)
        {
            return Dispatcher(UEwasp.TV2H, t, v);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy\nkJ/(kg.℃)")]
        public static double TV2S97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "V", Description = "specific volume\nm³/kg)")] double v)
        {
            return Dispatcher(UEwasp.TV2S, t, v);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dryness friction\n(0~1/-1)")]
        public static double TV2X97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "V", Description = "specific volume\nm³/kg)")] double v)
        {
            return Dispatcher(UEwasp.TV2X, t, v);
        }



        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for pressure\nMPaA")]
        public static double TX2P97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "X", Description = "dryness friction\n(0~1)")] double x)
        {
            return Dispatcher(UEwasp.TX2P, t, x);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for enthalpy\nkJ/kg")]
        public static double TX2H97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "X", Description = "dryness friction\n(0~1)")] double x)
        {
            return Dispatcher(UEwasp.TX2H, t, x);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for entropy\nkJ/(kg.℃)")]
        public static double TX2S97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "X", Description = "dryness friction\n(0~1)")] double x)
        {
            return Dispatcher(UEwasp.TX2S, t, x);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume\nm³/kg")]
        public static double TX2V97([ExcelArgument(Name = "T", Description = "temperature\n℃")] double t, [ExcelArgument(Name = "X", Description = "dryness friction\n(0~1)")] double x)
        { 
            return Dispatcher(UEwasp.TX2V, t, x);
        }


        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for pressure\nMPaA")]
        public static double HS2P97([ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.HS2P, h, s);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for temperature\n℃")]
        public static double HS2T97([ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.HS2T, h, s);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for specific volume\nm³/kg")]
        public static double HS2V97([ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.HS2V, h, s);
        }

        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for dryness friction\n(0~1/-1)")]
        public static double HS2X97([ExcelArgument(Name = "H", Description = "enthalpy\nkJ/kg")] double h, [ExcelArgument(Name = "S", Description = "entropy\nkJ/(kg.℃)")] double s)
        {
            return Dispatcher(UEwasp.HS2X, h, s);
        }
    }
}