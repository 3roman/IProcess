#ifndef TEST_H
#define TEST_H

#include <xlw/MyContainers.h>
#include <xlw/CellMatrix.h>
#include <xlw/DoubleOrNothing.h>
#include <xlw/ArgList.h> 


using namespace xlw;

//<xlw:libraryname=ThermalLibrary

double P_HG(double p);
double P_HL(double p);
double P_SG(double p);
double P_SL(double p);
double P_T(double p);
double P_VG(double p);
double P_VL(double p);
double P_ETAG(double p);
double P_ETAL(double p);
double PH_S(double p, double h);
double PH_T(double p, double h);
double PH_V(double p, double h);
double PS_H(double p, double s);
double PS_T(double p, double s);
double PS_V(double p, double s);
double PT_H(double p, double t);
double PT_S(double p, double t);
double PT_V(double p, double t);
double PT_ETA(double p, double t);
double T_HG(double t);
double T_HL(double t);
double T_P(double t); 
double T_SG(double t);
double T_SL(double t);
double T_VG(double t);
double T_VL(double t);
double T_ETAG(double t);
double T_ETAL(double t);
double SolveExtractionEnthalpy(double p1, double t1, double p2, double eta);
double SolveExtractionTemperature(double p1, double t1, double p2, double eta);
#endif
