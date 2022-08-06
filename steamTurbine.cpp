#include "iapws97.h"

double steamRateOfSingleStageTurbine(
    double inletPressure,
    double inletTemperature,
    double exhaustPressure,
    double efficiency
    )
{
    double h1 = PT2H97(inletPressure, inletTemperature);
    double s1 = PT2S97(inletPressure, inletTemperature);
    double h20 = PS2H97(exhaustPressure, s1);

    return 3600 / ((h1 - h20) * efficiency);
}  

double exhaustTemperatureOfSingleStageTurbine(
    double inletPressure,
    double inletTemperature,
    double exhaustPressure,
    double efficiency)
{
    double h1 = PT2H97(inletPressure, inletTemperature);
    double s1 = PT2S97(inletPressure, inletTemperature);
    double h20 = PS2H97(exhaustPressure, s1);
    double h2 = h1 - (h1 - h20) * efficiency;

    return PH2T97(exhaustPressure, h2);
}

double exhaustDrynessOfSingleStageTurbine(
    double inletPressure,
    double inletTemperature,
    double exhaustPressure,
    double efficiency)
{
    double h1 = PT2H97(inletPressure, inletTemperature);
    double s1 = PT2S97(inletPressure, inletTemperature);
    double h20 = PS2H97(exhaustPressure, s1);
    double h2 = h1 - (h1 - h20) * efficiency;

    return PH2X97(inletPressure, h2);
}