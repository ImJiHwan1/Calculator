#pragma once
#include "../(LIBs)/CalLib.h"
#pragma comment(lib, "./(LIBs)/CalLib.lib")
#ifdef __cplusplus
extern "C" {
#endif
//���� ���̺� ȣ���Լ�
	__declspec(dllexport) bool EngineInit();
	__declspec(dllexport) void EngineRelease();
	__declspec(dllexport) int EngineAdd(int a, int b);
	__declspec(dllexport) int EngineSub(int a, int b);
	__declspec(dllexport) int EngineDiv(int a, int b);

#ifdef __cplusplus
}

#endif