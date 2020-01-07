#include <iostream>
#include <array>
#include <list>
#include <iterator>
#include "UDD.h"
using std::cout;
using std::cin;
using std::endl;

int main() {
	bool loop = true;
	char fN[64];
	char lN[64];
	int age = 0, maxID = 64;
	char *fND = new char[maxID];
	char *lND = new char[maxID];
	
	cout << "\nPlease enter your first name:\n";
	cin >> fND;
	cout << "\nPlease enter your last name:\n";
	cin >> lND;
	cout << "\nPlease enter your age:\n";
	cin >> age;
	UserDefData* uDD = new UserDefData(fND, lND, age);
	cout << "User Defined Data:\n";
	cout << uDD->fN << endl << uDD->lN << endl << uDD->age << endl;
	//fND = uDD->fN;
	//lND = uDD->lN;
	cout << "Dynamic Arrays:\n";
	cout << fND << endl << lND << endl << age << endl;
	delete[] fND;
	delete[] lND;
	
	return 0;
}