#pragma once
#ifndef __PROCESS_H__
#define __PROCESS_H__

class CalInterface
{
public:
	CalInterface();
	virtual ~CalInterface();
	int Add(int a, int b);
	int Sub(int a, int b);
	int Mul(int a, int b);
	int Div(int a, int b);
};
#endif // !__PROCESS_H__
