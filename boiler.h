#pragma once
#include <xlw/MyContainers.h>

using namespace xlw;

//<xlw:libraryname=IThermal_Boiler


double // t/h //applicable to coal¡¢fuel gas¡¢fuel oil//
FuelConsumption(
	double boilerOutput, // t/h
	double steamPressure, // MPaA
	double steamTemperature, //oC
	double BFWPressure, // MPaA
	double BFWTemperature, //oC
	double BWPressure, // MPaA
	double blowdownRate, // %
	double efficiency, // %
	double Qar_net // kJ/kg
);

double // Nm3/kg
TheoreticalDriedAir(
	double Car, // %
	double Har, // %
	double Oar, // %
	double Sar // %
);


//double // Nm3/kg
//theoreticalWetAirQuantity(
//	double theoreticalDriedAirQuantity, // Nm3/kg
//	double moistureContent // g/(kg driedAir) [10]
//);
//
//
//double // Nm3/kg 
//actualDriedAirQuantity(
//	double theoreticalDriedAirQuantity, // Nm3/kg
//	double coefficientOfExcessAir // [1.2]
//);


//double // Nm3/kg
//actualWetAirQuantity(
//	double theoreticalDriedAirQuantity, // Nm3/kg
//	double moistureContent, // g/(kg driedAir) [10]
//	double coefficientOfExcessAir // [1.2]
//);


double // Nm3/kg
ActualWetFlueGas_FurnaceOutlet(
	double Car, // %
	double Har, // %
	double Oar, // %
	double Nar, // %
	double Sar, // %
	double Mt, // %
	double coefficientOfExcessAir// [1.2]
);