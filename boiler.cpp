#include "iapws97.h"

double FuelConsumption(
	double boilerOutput,
	double steamPressure,
	double steamTemperature,
	double BFWPressure,
	double BFWTemperature,
	double DrumPressure,
	double blowdownRate,
	double efficiency,
	double Qar_net
)
{
	double steamEnthalpy = PT2H97(steamPressure, steamTemperature);
	double BFWEnthalpy = PT2H97(BFWPressure, BFWTemperature);
	double BWEnthalpy = P2HL97(DrumPressure);

	return (boilerOutput * 1000 * (steamEnthalpy - BFWEnthalpy) + boilerOutput * 1000 * blowdownRate * 0.01 * (BWEnthalpy - BFWEnthalpy)) / Qar_net / (efficiency * 0.01) / 1000;
}

double TheoreticalDriedAir(
	double Car,
	double Har,
	double Oar,
	double Sar
)
{
	return 0.0889 * (Car + 0.375 * Sar) + 0.265 * Har - 0.0333 * Oar;
}

double ActualWetFlueGas_FurnaceOutlet(
	double Car,
	double Har,
	double Oar,
	double Nar,
	double Sar,
	double Mt,
	double excessAirRatio
)
{
	double moistureContent = 10;
	double theoreticalDriedAirQuantity = 0.0889 * (Car + 0.375 * Sar) + 0.265 * Har - 0.0333 * Oar;
	return (1 + 0.0016 * moistureContent) * excessAirRatio * theoreticalDriedAirQuantity + 0.0555 * (Har + 0.144 * Nar + 0.126 * Oar) + 0.0124 * Mt;
}
