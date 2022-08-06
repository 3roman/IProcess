#pragma once

#include <xlw/MyContainers.h>
#include <xlw/CellMatrix.h>
#include <xlw/DoubleOrNothing.h>
#include <xlw/ArgList.h>  

using namespace xlw;

//<xlw:libraryname=IThermal_IPAWS97


double // kJ/kg
PT2H97(const double p, // MPaA
	const double t // oC
);
double // kJ/(kg.oC)
PT2S97(const double p, // MPaA
	const double t // oC
);
double // kg/m3
PT2V97(const double p, // MPaA
	const double t // oC
);
double // kJ/(kg.oC)
PT2CP97(const double p, // MPaA
	const double t // oC
);
double // kJ/(kg.oC)
PT2CV97(const double p, // MPaA
	const double t // oC
);
double // 0~1
PT2KS97(const double p, // MPaA
	const double t // oC
);
double // Pa.s
PT2ETA97(const double p, // MPaA
	const double t // oC
);
double // mm²/s
PT2U97(const double p, // MPaA
	const double t // oC
);
double //oC
PH2T97(const double p, // MPaA
	const double h // kJ/kg
);
double // kJ/(kg.oC)
PH2S97(const double p, // MPaA
	const double h // kJ/kg
);
double // kg/m3
PH2V97(const double p, // MPaA
	const double h // kJ/kg
);
double // 0~1
PH2X97(const double p, // MPaA
	const double h // kJ/kg
);
double //oC
PS2T97(const double p, // MPaA
	const double s // kJ/(kg.oC)
);
double // kJ/kg
PS2H97(const double p, // MPaA
	const double s // kJ/(kg.oC)
);
double // kg/m3
PS2V97(const double p, // MPaA
	const double s // kJ/(kg.oC)
);
double //oC
PV2T97(const double p, // MPaA
	const double v // m3/kg
);
double // kJ/(kg.oC)
PV2S97(const double p, // MPaA
	const double v // m3/kg
);
double // kJ/kg
PV2H97(const double p, // MPaA
	const double v // m3/kg
);
double // MPaA
TH2P97(const double t, // oC
	const double h // kJ/kg
);
double // kJ/(kg.oC)
TH2S97(const double t, // oC
	const double h // kJ/kg
);
double // kg/m3
TH2V97(const double t, // oC
	const double h // kJ/kg
);
double // MPaA
TS2P97(const double t, // oC
	const double s // kJ/(kg.oC)
);
double // kJ/kg
TS2H97(const double t, // oC
	const double s // kJ/(kg.oC)
);
double // kg/m3
TS2V97(const double t, // oC
	const double s // kJ/(kg.oC)
);
double // MPaA
TV2P97(const double t, // oC
	const double v // m3/kg
);
double // kJ/kg
TV2H97(const double t, // oC
	const double v // m3/kg
);
double // kJ/(kg.oC)
TV2S97(const double t, // oC
	const double v // m3/kg
);
double // MPaA
HS2P97(const double h, // kJ/kg
	const double s // kJ/(kg.oC)
);
double // oC
HS2T97(const double h, // kJ/kg
	const double s // kJ/(kg.oC)
);
double // kg/m3
HS2V97(const double h, // kJ/kg
	const double s // kJ/(kg.oC)
);
double // MPaA
HV2P97(const double h, // kJ/kg
	const double v // m3/kg
);
double // oC
HV2T97(const double h, // kJ/kg
	const double v // m3/kg
);
double // kJ/(kg.oC)
HV2S97(const double h, // kJ/kg
	const double v // m3/kg
);
double // MPaA
SV2P97(const double s, // kJ/(kg.oc)
	const double v // m3/kg
);
double // oC
SV2T97(const double s, // kJ/(kg.oc)
	const double v // m3/kg
);
double // kJ/kg
SV2H97(const double s, // kJ/(kg.oc)
	const double v // m3/kg
);
double // oC
PX2T97(const double p, // kJ/(kg.oc)
	const double x // 0~1
);
double // kJ/kg
PX2H97(const double p, // kJ/(kg.oc)
	const double x // 0~1
);
double // kJ/(kg.oC)
PX2S97(const double p, // kJ/(kg.oc)
	const double x // 0~1
);
double // kg/m3
PX2V97(const double p, // kJ/(kg.oc)
	const double x // 0~1
);
double // oC
P2T97(const double p // MPaA
);
double // kJ/kg
P2HL97(const double p // MPaA
);
double // kJ/(kg.oC)
P2SL97(const double p // MPaA
);
double // m3/kg
P2VL97(double p // MPaA
);
double // kJ/(kg.oC)
P2CPL97(double p
);
double // kJ/(kg.oC)
P2CVL97(double p // MPaA
);
double
P2KSL97(double p // MPaA
);
double // mm2/s
P2ETAL97(double p // MPaA
);
double // Pa.s
P2UL97(double p // MPaA
);
double // kJ/kg
P2HG97(const double p // MPaA
);
double // kJ/(kg.oC)
P2SG97(const double p // MPaA
);
double // m3/kg
P2VG97(double p // MPaA
);
double // kJ/(kg.oC)
P2CPG97(double p
);
double // kJ/(kg.oC)
P2CVG97(double p // MPaA
);
double 
P2KSG97(double p // MPaA
);
double // mm2/s
P2ETAG97(double p // MPaA
);
double // Pa.s
P2UG97(double p // MPaA
);
double // oC
T2P97(const double t // oC
);
double // kJ/kg
T2HL97(const double t // oC
);
double // kJ/(kg.oC)
T2SL97(const double t // oC
);
double // m3/kg
T2VL97(double t // oC
);
double // kJ/(kg.oC)
T2CPL97(double p
);
double // kJ/(kg.oC)
T2CVL97(double t // oC
);
double
T2KSL97(double t // oC
);
double // mm2/s
T2ETAL97(double t // oC
);
double // Pa.s
T2UL97(double t // oC
);
double // kJ/kg
T2HG97(const double t // oC
);
double // kJ/(kg.oC)
T2SG97(const double t // oC
);
double // m3/kg
T2VG97(double t // oC
);
double // kJ/(kg.oC)
T2CPG97(double p
);
double // kJ/(kg.oC)
T2CVG97(double t // oC
);
double
T2KSG97(double t // oC
);
double // mm2/s
T2ETAG97(double t // oC
);
double // Pa.s
T2UG97(double t // oC
);