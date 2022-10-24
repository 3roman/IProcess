using System.Runtime.InteropServices;

namespace IThermal
{
	public class UEwasp
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
		public static extern void HS2P(double h, double s, ref double p, ref int z);
		[DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern void HS2T(double h, double s, ref double t, ref int z);
		[DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern void HS2V(double h, double s, ref double v, ref int z);
		[DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern void HS2X(double h, double s, ref double x, ref int z);
	}
}