#include <iostream>
#include <fstream>
#include <string>
using std::cout;
using std::cin;
using std::endl;

struct Data {
	int health;
	int attack;
};

int main() {


	Data data;
	data.health = 100;
	data.attack = 15;

	std::fstream file;
	file.open("data.dat", std::ios::out | std::ios::binary);
	file.write((char*)&data, sizeof(Data));
	file.close();
	
	
	return 0;
	
	//std::ios::binary
}