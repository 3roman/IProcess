#include"cppinterface.h"
#include "uewasp97.h"
#include "pch.h"
#pragma warning (disable : 4996)

/////////////////////////////////////////////////////////////////////
double P_T(double p)
{
	double ret;
	int range;
	P2T97(p, &ret, &range);

	return ret;
}

double P_HL(double p)
{
	double ret;
	int range;
	P2HL97(p, &ret, &range);

	return ret;
}

double P_HG(double p)
{
	double ret;
	int range;
	P2HG97(p, &ret, &range);

	return ret;
}

double P_SL(double p)
{
	double ret;
	int range;
	P2SL97(p, &ret, &range);

	return ret;
}

double P_SG(double p)
{
	double ret;
	int range;
	P2SG97(p, &ret, &range);

	return ret;
}

double P_VL(double p)
{
	double ret;
	int range;
	P2VL97(p, &ret, &range);

	return ret;
}

double P_VG(double p)
{
	double ret;
	int range;
	P2VG97(p, &ret, &range);

	return ret;
}

double P_ETAL(double p)
{
	double ret;
	int range;
	P2ETAL97(p, &ret, &range);

	return ret;
}

double P_ETAG(double p)
{
	double ret;
	int range;
	P2ETAG97(p, &ret, &range);

	return ret;
}

/////////////////////////////////////////////////////////////////////
double T_P(double t)
{
	double ret;
	int range;
	T2P97(t, &ret, &range);

	return ret;
}

double T_HL(double t)
{
	double ret;
	int range;
	T2HL97(t, &ret, &range);

	return ret;
}

double T_HG(double t)
{
	double ret;
	int range;
	T2HG97(t, &ret, &range);

	return ret;
}

double T_SL(double t)
{
	double ret;
	int range;
	T2SL97(t, &ret, &range);

	return ret;
}

double T_SG(double t)
{
	double ret;
	int range;
	T2SG97(t, &ret, &range);

	return ret;
}

double T_VL(double t)
{
	double ret;
	int range;
	T2VL97(t, &ret, &range);

	return ret;
}

double T_VG(double t)
{
	double ret;
	int range;
	T2VG97(t, &ret, &range);

	return ret;
}

double T_ETAL(double t)
{
	double ret;
	int range;
	T2ETAL97(t, &ret, &range);

	return ret;
}

double T_ETAG(double t)
{
	double ret;
	int range;
	T2ETAG97(t, &ret, &range);

	return ret;
}
///////////////////////////////////////////////////////////
double PT_H(double p, double t)
{
	double ret;
	int range;
	PT2H97(p, t, &ret, &range);

	return ret;
}

double PT_S(double p, double t)
{
	double ret;
	int range;
	PT2S97(p, t, &ret, &range);

	return ret;
}

double PT_V(double p, double t)
{
	double ret;
	int range;
	PT2V97(p, t, &ret, &range);

	return ret;
}

double PT_ETA(double p, double t)
{
	double ret;
	int range;
	PT2ETA97(p, t, &ret, &range);

	return ret;
}
///////////////////////////////////////////////////////////
double PS_T(double p, double s)
{
	double ret;
	int range;
	PS2T97(p, s, &ret, &range);

	return ret;
}

double PS_H(double p, double s)
{
	double ret;
	int range;
	PS2H97(p, s, &ret, &range);

	return ret;
}

double PS_V(double p, double s)
{
	double ret;
	int range;
	PS2V97(p, s, &ret, &range);

	return ret;
}

///////////////////////////////////////////////////////////
double PH_T(double p, double h)
{
	double ret;
	int range;
	PH2T97(p, h, &ret, &range);

	return ret;
}

double PH_S(double p, double h)
{
	double ret;
	int range;
	PH2S97(p, h, &ret, &range);

	return ret;
}

double PH_V(double p, double h)
{
	double ret;
	int range;
	PH2V97(p, h, &ret, &range);

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

