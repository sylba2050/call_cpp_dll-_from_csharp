#include "arithmetic.h"

extern "C" {
	__declspec(dllexport) int __stdcall add(int a, int b) {
		return a + b;
	}
}