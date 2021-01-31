//
//
//                                                                    Test.h
//

#ifndef TEST_H
#define TEST_H

#include <xlw/MyContainers.h>
#include <xlw/CellMatrix.h>
#include <xlw/DoubleOrNothing.h>
#include <xlw/ArgList.h>  

    
using namespace xlw;

//<xlw:libraryname=IAPWS-IF97 for microsoft excel XLL add-in

double // h:kJ/kg
pt_h(double p, // p:MPag
    double t // t:oC 
);

#endif
