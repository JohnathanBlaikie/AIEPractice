#pragma once

class UserDefData
{
public: 
	UserDefData();
	char fN[64];
	char lN[64];
	int age = 0;
	UserDefData(char fN[], char lN[], int age);
	~UserDefData();
};