#define _CRT_SECURE_NO_WARNINGS 1
#include <iostream>
#include<cstring>
using std::cout;
using std::cin;
using std::endl;

int main()
{
	char name[] = "Johnathan";
	name[9] = '\0';
	char newName[64];
	char blank[64];
	cout << name << endl;
	cout << strlen(name) << endl;
	
	/*int ASCIIval = 'A';
	cout << ASCIIval << endl;
	char ASCIIBack = ASCIIval + 32;
	cout << ASCIIBack << endl;*/

	cout << "Please enter your name\n";
	cin >> newName;
	cout << strlen(newName) << endl;
	newName[strlen(newName)] = '\0';
	
	for (int i = 0; i < strlen(newName); i++)
	{
		int j = newName[i];
		if (j = 65 && j <= 90)
		{
			j += 32;
			char k = j;
			newName[i] = k;
		}
	}

	cout << newName << endl;

	//strcat(blank, name);
	//strcat_s(blank, 5, name);
	//cout << blank << endl;
	
	if (strcmp(name, newName) == 0) {
		cout << "names match!" << endl;
	}
	else {
		cout << "names don't match!" << endl;
	}

	cout << "What is your favorite color?";
	char favoriteColor[46];
	cin >> favoriteColor;
	//char tolower(favoriteColor[strlen(favoriteColor)]);
	tolower(favoriteColor[0]);
	cout << favoriteColor;
	while (true);

	return 0;
}
int ASCIItoInt(int x) {
	return x;
}