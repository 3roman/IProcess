using ExcelDna.Integration;
using System.Runtime.InteropServices;

namespace IThermal
{
    public static class IAPWS97
    {
        [ExcelFunction(Category = "IThermal_IAPWS97", Description = "solve for saturation temperature  ℃")]
        public static double P2T(
            [ExcelArgument(Name = "P", Description = "saturation pressure  MPaA")] double p)
        {
            UEwasp.SETSTD_WASP(97);

            double result = 0;
            int zone = 0;
            UEwasp.P2T(p, ref result, ref zone);

            return result;
        }
    }

    public static class UEwasp
    {
        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void SETSTD_WASP(int stdid);

        [DllImport("UEwasp.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void P2T(double p, ref double t, ref int r);
    }
}