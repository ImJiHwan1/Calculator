#include "CalLib.h"

CalInterface::CalInterface()
{
}

CalInterface::~CalInterface()
{
}

int CalInterface::Add(int a, int b) {
	return (a + b);
}

int CalInterface::Sub(int a, int b) {
	return (a - b);
}

int CalInterface::Mul(int a, int b) {
	return (a * b);
}

int CalInterface::Div(int a, int b) {
	if (b == 0) return 0;
	else return (a / b);
}