#include "iapws97.h"

double kcal2kj(double kcal)
{
	return kcal * 4.1816;
}

double Qgr_ar2Qnet_ar(double Qgr_ar, double Har, double Mt)
{
	return Qgr_ar - 226.1 * Har - 25.1 * Mt;
}

double adBase2arBase(double Mt, double Mad)
{
	return (100 - Mt) / (100 - Mad);
}

double adBase2dBase(double Mad)
{
	return 100 / (100 - Mad);
}

double adBase2dafBase(double Aad, double Mad)
{
	return 100 / (100 - Mad - Aad);
}

double arBase2adBase(double Mad, double Mt)
{
	return (100 - Mad) / (100 - Mt);
}

double arBase2dBase(double Mt)
{
	return 100 / (100 - Mt);
}
//
double arBase2dafBase(double Aar, double Mt)
{
	return 100 / (100 - Mt - Aar);
}

double dBase2adBase(double Mad)
{
	return (100 - Mad) / 100;
}

double dBase2arBase(double Mt)
{
	return (100 - Mt) / 100;
}

double dBase2dafBase(double Ad)

{
	return 100 / (100 - Ad);
}

double dafBase2adBase(double Mad, double Aad)
{
	return (100 - Mad - Aad) / 100;
}

double dafBase2arBase(double Mt, double Aar)
{
	return (100 - Mt - Aar) / 100;
}

double dafBase2dBase(double Ad)
{
	return (100 - Ad) / 100;
}