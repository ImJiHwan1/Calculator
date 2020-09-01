#include "CallDll.h"
CalInterface* pCal;
//동적 라이브러리 초기화 함수
extern "C" __declspec(dllexport) bool EngineInit()
{
	pCal = new CalInterface();
	return true;
}
//동적 라이브러리 해제 함수
extern "C" __declspec(dllexport) void EngineRelease()
{
	delete pCal;
}
// 동적 라이브러리 호출 함수
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