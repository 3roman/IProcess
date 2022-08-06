#pragma once
#include <xlw/MyContainers.h>

using namespace xlw;

//<xlw:libraryname=IThermal_SteamTurbine


double // kg/kW.h
steamRateOfSingleStageTurbine(
    double inletPressure, // MPaA
    double inletTemperature, // oC
    double exhaustPressure, // MPaA
    double efficiency // 0~1
    );

double // oC
exhaustTemperatureOfSingleStageTurbine(
    double inletPressure, // MPaA
    double inletTemperature, // oC
    double exhaustPressure, // MPaA
    double efficiency // 0~1
);

double // 0~1
exhaustDrynessOfSingleStageTurbine(
    double inletPressure, // MPaA
    double inletTemperature, // oC
    double exhaustPressure, // MPaA
    double efficiency // 0~1
);