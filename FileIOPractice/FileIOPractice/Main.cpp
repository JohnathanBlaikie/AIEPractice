#include <iostream>
#include <fstream>
#include <string>
using std::cout;
using std::cin;
using std::endl;


int main()
{
	std::fstream file;
	std::string tString;
	bool isAlive = true;
	float tFloat = 0;
	int tNum = 0;
	char * cart = new char[tNum];
	char ans;

	file.open("MyLog.txt", std::ios::out);
	if (file.is_open()) {
		file << "WOW I LOVE C++";
	}
	else
	{
		file << "Beefed";
	}
	file.close();


	while (true)
	{
		cout << "Would you like to [L]oad a previous profile, create a [N]ew profile, or [D]elete the current data.\n";
		cin >> ans;
		tolower(ans);
		if (ans == 'n') {
			cout << "Please enter your name\n\n";
			cin >> cart;
			cout << "Are you currently alive?\n[Y] [N]\n";
			cin >> ans;
			tolower(ans);
			if (ans == 'y') {
				isAlive = true;
			}
			else if (ans == 'n') {
				isAlive = false;
			}
			else
			{
				cout << "Right, I'm going to assume you are. Though you may not be as truthful as I thought.\n";
				isAlive = true;
			}
			cout << "Enter a number";
			cin >> tFloat;

			file.open("Save.txt", std::ios::out);
			if (file.is_open()) {
				file << isAlive << endl << tFloat << endl << tNum << endl << cart;
			}
			else
			{
				file << "Ouchie";
			}
			file.close();
			break;
		}
		else if (ans == 'l')
		{

			int i = 0;
			file.open("Save.txt", std::ios::in);
			
			if (file.is_open()) {
				while (std::getline(file, tString)) {
					cout << tString << "\n";
					//cout << isAlive << endl << tFloat << endl << tNum << endl << cart;
				}
			}
			//cout << isAlive << endl << tFloat << endl << tNum << endl << cart;
			file.close();
			break;
		}
		else if (ans == 'd') {
			file.open("Save.txt", std::ios::out);
			file << endl;
			file.close();
			break;
		}
	}
	cin >> ans;
	return 0;
}