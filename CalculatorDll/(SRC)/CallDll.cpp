#include "CallDll.h"
CalInterface* pCal;
//���� ���̺귯�� �ʱ�ȭ �Լ�
extern "C" __declspec(dllexport) bool EngineInit()
{
	pCal = new CalInterface();
	return true;
}
//���� ���̺귯�� ���� �Լ�
extern "C" __declspec(dllexport) void EngineRelease()
{
	delete pCal;
}
// ���� ���̺귯�� ȣ�� �Լ�
extern "C" __declspec(dllexport) int EngineAdd(int a, int b)
{
	return pCal->Add(a, b);
}
extern "C" __declspec(dllexport) int EngineSub(int a, int b)
{
	return pCal->Sub(a, b);
}
extern "C" __declspec(dllexport) int EngineMul(int a, int b)
{
	return pCal->Mul(a, b);
}
extern "C" __declspec(dllexport) int EngineDiv(int a, int b)
{
	return pCal->Div(a, b);
}