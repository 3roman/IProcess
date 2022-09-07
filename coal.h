#pragma once
#include <xlw/MyContainers.h>


using namespace xlw;
//<xlw:libraryname=IThermal_Coal


double // kJ/kg
kcal2kj(
	double kcal // kcal/kJ
);

double // kJ/kg
Qgr_ar2Qnet_ar(
	double Qgr_ar, // kJ/kg
	double Har, // %
	double Mt // %
);

double // 0~1
arBase2adBase(
	double Mad, // %
	double Mt // %
);

double // 0~1
arBase2dBase(
	double Mt // %
);

double // 0~1
arBase2dafBase(
	double Aar, // %
	double Mt // %
);

double // 0~1
adBase2arBase(
	double Mt, // %
	double Mad // %
);

double // 0~1
adBase2dBase(
	double Mad // %
);

double // 0~1
adBase2dafBase(
	double Aad, // %
	double Mad // %
);

double  // 0~1
dBase2adBase(
	double Mad // %
);

double // 0~1
dBase2arBase(
	double Mt // %
);

double // 0~1
dBase2dafBase(
	double Ad // %
);

double // 0~1
dafBase2arBase(
	double Mt, // %
	double Aar // %
);

double // 0~1
dafBase2adBase(
	double Mad, // %
	double Aad // %
);

double // 0~1
dafBase2dBase(
	double Ad // %
);