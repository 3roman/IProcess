
#include"cppinterface.h"
#include "uewasp97.h"
#include "pch.h"
#pragma warning (disable : 4996)


short // echoes a short
EchoShort(short x // number to be echoed
           )
{
    return x;
}

/////////////////////////////////////////////////////////////////////
double P_T(double P)
{
	double ret;
	int range;
	P2T97(P, &ret, &range);

	return ret;
}

double P_HL(double P)
{
	double ret;
	int range;
	P2HL97(P, &ret, &range);

	return ret;
}

double P_HG(double P)
{
	double ret;
	int range;
	P2HG97(P, &ret, &range);

	return ret;
}

double P_SL(double P)
{
	double ret;
	int range;
	P2SL97(P, &ret, &range);

	return ret;
}

double P_SG(double P)
{
	double ret;
	int range;
	P2SG97(P, &ret, &range);

	return ret;
}

double P_VL(double P)
{
	double ret;
	int range;
	P2VL97(P, &ret, &range);

	return ret;
}
double P_VG(double P)
{
	double ret;
	int range;
	P2VG97(P, &ret, &range);

	return ret;
}

/////////////////////////////////////////////////////////////////////
double T_P(double T)
{
	double ret;
	int range;
	T2P97(T, &ret, &range);

	return ret;
}

double T_HL(double T)
{
	double ret;
	int range;
	T2HL97(T, &ret, &range);

	return ret;
}

double T_HG(double T)
{
	double ret;
	int range;
	T2HG97(T, &ret, &range);

	return ret;
}

double T_SL(double T)
{
	double ret;
	int range;
	T2SL97(T, &ret, &range);

	return ret;
}

double T_SG(double T)
{
	double ret;
	int range;
	T2SG97(T, &ret, &range);

	return ret;
}

double T_VL(double T)
{
	double ret;
	int range;
	T2VL97(T, &ret, &range);

	return ret;
}
double T_VG(double T)
{
	double ret;
	int range;
	T2VG97(T, &ret, &range);

	return ret;
}
///////////////////////////////////////////////////////////
double PT_H(double P, double T)
{
	double ret;
	int range;
	PT2H97(P, T, &ret, &range);

	return ret;
}

double PT_S(double P, double T)
{
	double ret;
	int range;
	PT2S97(P, T, &ret, &range);

	return ret;
}

double PT_V(double P, double T)
{
	double ret;
	int range;
	PT2V97(P, T, &ret, &range);

	return ret;
}
///////////////////////////////////////////////////////////
double PS_T(double P, double S)
{
	double ret;
	int range;
	PS2T97(P, S, &ret, &range);

	return ret;
}

double PS_H(double P, double S)
{
	double ret;
	int range;
	PS2H97(P, S, &ret, &range);

	return ret;
}

double PS_V(double P, double S)
{
	double ret;
	int range;
	PS2V97(P, S, &ret, &range);

	return ret;
}

///////////////////////////////////////////////////////////
double PH_T(double P, double H)
{
	double ret;
	int range;
	PH2T97(P, H, &ret, &range);

	return ret;
}

double PH_S(double P, double H)
{
	double ret;
	int range;
	PH2S97(P, H, &ret, &range);

	return ret;
}

double PH_V(double P, double H)
{
	double ret;
	int range;
	PH2V97(P, H, &ret, &range);

	return ret;
}
///////////////////////////////////////////////////////////
double SolveExtractionEnthalpy(double p1, double t1, double p2, double eta)
{
	double h1 = PT_H(p1, t1);
	double s1 = PT_S(p1, t1);

	double h0 = PS_H(p2, s1);
	double h2 = h1 - ((h1 - h0) * eta / 100);

	return h2;
}

double SolveExtractionTemperature(double p1, double t1, double p2, double eta)
{
	double h2 = SolveExtractionEnthalpy(p1, t1, p2, eta);
	double t2 = PH_T(p2, h2);

	return t2;
}

