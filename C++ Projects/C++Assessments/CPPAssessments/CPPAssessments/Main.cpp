#include <iostream>
#include <array>
#include <list>
#include <iterator>
using std::cout;
using std::cin;
using std::endl;


int main() {
	int eChoice = 0;
	int dim1 = 0, dim2 = 0;
	while ((dim1 <= 0 || dim1 > 15) && (dim2 <= 0 || dim2 > 15)) {
		cout << "Tic-Tac-Toe\n\nPlease enter a number between 1 - 15 for the dimensions of your grid:\nDimension X: ";
		cin >> dim1;
		cout << "\nDimension Y: ";
		cin >> dim2;
		cout << endl;
	}
	//std::list 
	int yep = dim1 * dim2;
	char *gridArray = new char[yep]; 
	int gALen = sizeof(gridArray) / sizeof(gridArray[0]);
	bool gamin = true;
	bool player1Turn = true;
	
	while (gamin) {
		int squareCounter = 1;
		for (int i = 0; i < dim2; i++)
		{
			cout << endl;
			for (int i = 0; i < dim1 -1; i++)
			{
				if (i < dim2) {
					cout << "\t|";
				}
				else {
					cout << "\t";
				}
			}
			cout << endl;
			for (int i = 0; i < dim1; i++) {
				

				if (i < 1 && squareCounter < 10 && (gridArray[squareCounter -1] != 'X' && gridArray[squareCounter -1] != 'O')) {
					
					cout << " __[" << squareCounter << "]__";
				}
				else if (i < 1 && squareCounter < 10 && (gridArray[squareCounter -1] == 'X' || gridArray[squareCounter -1] == 'O'))
				{
					cout << " __[" << gridArray[squareCounter - 1] << "]__";
				}
				else if (i >= 1 && squareCounter < 10 && (gridArray[squareCounter - 1] == 'X' || gridArray[squareCounter - 1] == 'O'))
				{
					cout << "|__[" << gridArray[squareCounter - 1] << "]__";
				}


				else if (i < 1 && squareCounter >= 10 && squareCounter < 100 && (gridArray[squareCounter - 1] != 'X' && gridArray[squareCounter - 1] != 'O'))
				{
					cout << " _[" << squareCounter << "]__";
				}
				else if (i < 1 && squareCounter >= 10 && (gridArray[squareCounter - 1] == 'X' || gridArray[squareCounter - 1] == 'O'))
				{
					cout << " __[" << gridArray[squareCounter - 1] << "]__";
				}
				else if (i >= 1 && squareCounter >= 10 && squareCounter < 100 && (gridArray[squareCounter - 1] != 'X' && gridArray[squareCounter - 1] != 'O'))
				{
					cout << "|_[" << squareCounter << "]__";
				}
				else if (i >= 1 && squareCounter >= 10 && (gridArray[squareCounter - 1] == 'X' || gridArray[squareCounter - 1] == 'O'))
				{
					cout << "|__[" << gridArray[squareCounter - 1] << "]__";
				}


				else if (i < 1 && squareCounter >= 100)
				{
					cout << " _[" << squareCounter << "]_";
				}
				else if (i >= 1 && squareCounter >= 100)
				{
					cout << "|_[" << squareCounter << "]_";
				}
				

				else
				{
					cout << "|__[" << squareCounter << "]__";
				}

				squareCounter++;
			}
		}



		cout << "\nChosen tiles: \n";
		for (int j = 0; j < yep; j++) {
			if (gridArray[j] == 'X' || gridArray[j] == 'O') {
				cout << j + 1 << " " << gridArray[j] << " ";
			}
		}
		cout << endl << endl;
		if (player1Turn) {
			cout << "Player 1, Choose a section: ";
			cin >> eChoice;
			gridArray[eChoice - 1] = 'X';
			player1Turn = false;
		}
		else {
			cout << "Player 2, Choose a section: ";
			cin >> eChoice;
			gridArray[eChoice - 1] = 'O';
			player1Turn = true;
		}
		//cin >> eChoice;
	}


	delete gridArray;



}