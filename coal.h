#pragma once
#include <xlw/MyContainers.h>
using namespace xlw;
//<xlw:libraryname=IThermal_Coal

double // kJ/kg
kcal2kj(double kcal // kcal/kJ
);

double // kJ/kg
Qgr_ar2Qnet_ar(
	double Qgr_ar, // kJ/kg
	double Har, // 0~100
	double Mt // 0~100
);

double // 0~1
adBase2arBase(
	double Mar, // 0~100
	double Mad // 0~100
);

double // 0~1
adBase2dBase(
	double Mad // 0~100
);

double // 0~1
adBase2dafBase(
	double Aad, // 0~100
	double Mad // 0~100
);

double // 0~1
arBase2adBase(
	double Mad, // 0~100
	double Mar // 0~100
);

double // 0~1
arBase2dBase(
	double Mar // 0~100
);

double // 0~1
arBase2dafBase(
	double Aar, // 0~100
	double Mar // 0~100
);

double  // 0~1
dBase2adBase(
	double Mad // 0~100
);

double // 0~1
dBase2arBase(
	double Mar // 0~100
);

double // 0~1
dBase2dafBase(
	double Ad // 0~100
);

double // 0~1
dafBase2adBase(
	double Mad, // 0~100
	double Aad // 0~100
);

double // 0~1
dafBase2arBase(
	double Mar, // 0~100
	double Aar // 0~100
);

double // 0~1
dafBase2dBase(
	double Ad // 0~100
);