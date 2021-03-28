#ifndef TEST_H
#define TEST_H

#include <xlw/MyContainers.h>
#include <xlw/CellMatrix.h>
#include <xlw/DoubleOrNothing.h>
#include <xlw/ArgList.h> 


using namespace xlw;

//<xlw:libraryname=ThermalLibrary

double P_HG(double P);
double P_HL(double P);
double P_SG(double P);
double P_SL(double P);
double P_T(double P);
double P_VG(double P);
double P_VL(double P);
double PH_S(double P, double H);
double PH_T(double P, double H);
double PH_V(double P, double H);
double PS_H(double P, double S);
double PS_T(double P, double S);
double PS_V(double P, double S);
double PT_H(double P, double T);
double PT_S(double P, double T);
double PT_V(double P, double T);
double T_HG(double T);
double T_HL(double T);
double T_P(double T); 
double T_SG(double T);
double T_SL(double T);
double T_VG(double T);
double T_VL(double T);
double SolveExtractionEnthalpy(double p1, double t1, double p2, double eta);
double SolveExtractionTemperature(double p1, double t1, double p2, double eta);
#endif
