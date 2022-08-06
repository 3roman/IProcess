#pragma once
#include <xlw/MyContainers.h>
using namespace xlw;

//<xlw:libraryname=IThermal_Utils

double
LinearInterpolation(
	const MyArray& xs,
	const MyArray& ys,
	double x
);