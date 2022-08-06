#include <xlw/MyContainers.h>
using namespace xlw;


double LinearInterpolation(const MyArray& xs, const MyArray& ys, double x)
{
	int index = -1;
	for (unsigned int i = 0; i < xs.size(); i++)
	{
		if (x < xs[i])
		{
			index = i - 1;
			break;
		}
	}
	double slope = (ys[index + 1] - ys[index]) / (xs[index + 1] - xs[index]);

	return ys[index] + slope * (x - xs[index]);
}