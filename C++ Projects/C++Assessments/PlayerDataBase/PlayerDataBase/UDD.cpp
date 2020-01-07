#include "UDD.h"
#include <string.h>


UserDefData::UserDefData() {

}

UserDefData::UserDefData(char tFN[], char tLN[], int tAge) {
	int tempInt1 = 0, tempInt2 = 0;

	tempInt1 = strlen(tFN);
	for (int i = 0; i < tempInt1; i++) {
		fN[i] = tFN[i];
	}
	fN[tempInt1] = '\0';

	tempInt2 = strlen(tLN);
	for (int i = 0; i < strlen(tLN); i++) {
		lN[i] = tLN[i];
	}
	lN[tempInt2] = '\0';
	
	age = tAge;

}


UserDefData::~UserDefData() {}