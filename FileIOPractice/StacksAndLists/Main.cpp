#include <iostream>
#include <string>
#include <fstream>
#include "saL.h"
using namespace std;


int main() 
{
	tStack<int> test;

	test.pushBack(4);
	cout << test[0];
	//test.reserve[15];
	for (int i = 0; i < (int)test.tCap(); i++)
	{
		test[i] = rand() % 15;
	}

	for (int i = 0; i < (int)test.tCap(); i++)
	{
		if (test[i] > test[i + 1])
		{
			test.popBack();
		}
		else if (test[i] < test[i])
		{

		}
	}
	return 0;
}



#pragma region OldCode
	//stack(int size = SIZE);
	/*void push(x);
	X pop();
	X push();

	int size();
	bool isEmpty();
	bool isFull();
	
	~stack() {
		delete[] arr;
	}*/
#pragma endregion




