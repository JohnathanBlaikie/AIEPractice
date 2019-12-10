#include <iostream>
#include <array>
#include <list>
#include <iterator>
using std::cout;
using std::cin;
using std::endl;


int main() {
	int eChoice = 0;
	int dimX = 0, dimY = 0;
	int iR = 0, iC = 0, iD = 0;
	int rC = 0, cC = 0;
	while ((dimX <= 0 || dimX > 15) || (dimY <= 0 || dimY > 15)) {
		cout << "Tic-Tac-Toe\n\nPlease enter a number between 1 - 15 for the dimensions of your grid:\nDimension X: ";
		cin >> dimX;
		cout << "\nDimension Y: ";
		cin >> dimY;
		cout << endl;
	}
	//std::list 
	int dimA = dimX * dimY;
	char *gridArray = new char[dimA]; 
	int **gridArray2 = new int*[dimX];
	//int gALen = sizeof(gridArray) / sizeof(gridArray[0]);
	bool gamin = true;
	bool player1Turn = true;
	
	for (int i = 0; i < dimX; ++i) {
		gridArray2[i] = new int[dimY];
	}
	while (gamin) {
		int squareCounter = 1;
		for (int i = 0; i < dimY; i++)
		{
			cout << endl;
			for (int i = 0; i < dimX -1; i++)
			{
				if (i < dimY) {
					cout << "\t|";
				}
				else {
					cout << "\t";
				}
			}
			cout << endl;
#pragma region 1dArray
			for (int i = 0; i < dimX; i++) {
				

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
#pragma endregion
#pragma region 2dArray
//		for (int i = 0; i < dimX; i++) {
//
//
//			if (i < 1 && squareCounter < 10 && (gridArray2[squareCounter - 1][i] != 'X' && gridArray2[squareCounter - 1][i] != 'O')) {
//
//				cout << " __[" << squareCounter << "]__";
//			}
//			else if (i < 1 && squareCounter < 10 && (gridArray2[squareCounter - 1][i] == 'X' || gridArray2[squareCounter - 1][i] == 'O'))
//			{
//				cout << " __[" << gridArray[squareCounter - 1] << "]__";
//			}
//			else if (i >= 1 && squareCounter < 10 && (gridArray2[squareCounter - 1][i] == 'X' || gridArray2[squareCounter - 1][i] == 'O'))
//			{
//				cout << "|__[" << gridArray[squareCounter - 1] << "]__";
//			}
//
//
//			else if (i < 1 && squareCounter >= 10 && squareCounter < 100 && (gridArray2[squareCounter - 1][i] != 'X' && gridArray2[squareCounter - 1][i] != 'O'))
//			{
//				cout << " _[" << squareCounter << "]__";
//			}
//			else if (i < 1 && squareCounter >= 10 && (gridArray2[squareCounter - 1][i] == 'X' || gridArray2[squareCounter - 1][i] == 'O'))
//			{
//				cout << " __[" << gridArray[squareCounter - 1] << "]__";
//			}
//			else if (i >= 1 && squareCounter >= 10 && squareCounter < 100 && (gridArray2[squareCounter - 1][i] != 'X' && gridArray2[squareCounter - 1][i] != 'O'))
//			{
//				cout << "|_[" << squareCounter << "]__";
//			}
//			else if (i >= 1 && squareCounter >= 10 && (gridArray[squareCounter - 1] == 'X' || gridArray[squareCounter - 1] == 'O'))
//			{
//				cout << "|__[" << gridArray[squareCounter - 1] << "]__";
//			}
//
//
//			else if (i < 1 && squareCounter >= 100)
//			{
//				cout << " _[" << squareCounter << "]_";
//			}
//			else if (i >= 1 && squareCounter >= 100)
//			{
//				cout << "|_[" << squareCounter << "]_";
//			}
//
//
//			else
//			{
//				cout << "|__[" << squareCounter << "]__";
//			}
//
//			squareCounter++;
//		
//	}
#pragma endregion



		cout << "\nChosen tiles: \n";
		for (int j = 0; j < dimA; j++) {
			if (gridArray[j] == 'X' || gridArray[j] == 'O') {
				cout << j + 1 << " " << gridArray[j] << " ";
			}
		}
		cout << endl << endl;
		if (player1Turn) {
			cout << "Player 1, Choose a section: ";
			while (true) {
				cin >> eChoice;
				if (gridArray[eChoice - 1] != 'O')
				{
					gridArray[eChoice - 1] = 'X';
					break;
				}
				else {
					cout << "That section has already been chosen, please choose another.\n";
				}
			}
			player1Turn = false;
		}
		else {
			cout << "Player 2, Choose a section: ";
			while (true) {
				cin >> eChoice;
				if (gridArray[eChoice - 1] != 'X')
				{
					gridArray[eChoice - 1] = 'O';
					break;
				}
				else {
					cout << "That section has already been chosen, please choose another.\n";
				}
			}
			player1Turn = true;
		}
		iD = 0;
		if (dimX == dimY) {
			
			for (int i = 0; i < dimA; i += (dimX + 1))
			{
				if (gridArray[i] == 'O' && gridArray[i + (dimX + 1)]  == 'O' || gridArray[i] == 'X' && gridArray[i + (dimX + 1)] == 'X')
				{
					iD++;	
					if (iD == dimX - 1)
					{
						cout << "\nThe Game is Over!\n";
						gamin = false;
					}
				}
				else {
					iD = 0;
				}
			}
			iD = 0;
			for (int j = dimX-1; j < dimA; j += (dimX - 1))
			{
				if (gridArray[j] == 'O' && gridArray[j + (dimX - 1)] == 'O' || gridArray[j] == 'X' && gridArray[j + (dimX - 1)] == 'X')
				{
					iD++;
					if (iD == dimX - 1)
					{
						cout << "\nThe Game is Over!\n";
						gamin = false;
					}
				}
				else
				{
					iD = 0;
				}
			}
		}
		//rC = 0;
		
		for (int r = 0; r < dimY; r++) {
			iR = 0;
			for (rC=r*dimY; rC < (dimX * r)-1; rC++) 
			{
				if (gridArray[rC] == 'O' && gridArray[rC + 1] == 'O' || gridArray[rC] == 'X' && gridArray[rC + 1] == 'X') 
				{
					iR++;
					if (iR == dimX - 1)
					{
						cout << "\nThe Game is Over!\n";
						gamin = false;
					}
				}
				else
				{
					iR = 0;
				}
			}
			rC -= (dimX - 1);
			rC *= dimX;
		}
		cC = 0;
		for (int c = 0; c < dimX; c++) 
		{
			cC = c;
			for (cC; cC < dimA; cC += (dimX))
			{
				if (gridArray[cC] == 'O' && gridArray[cC + dimX] == 'O' || gridArray[cC] == 'X' && gridArray[cC + dimX] == 'X')
				{
					iC++;
					if (iC == dimY - 1)
					{
						cout << "\nThe Game is Over!\n";
						gamin = false;
					}
				}
				else {
					iC = 0;
				}
			}
		}
		int bruh = 0;
		for (int catsGame = 0; catsGame < dimA; catsGame++) {
			if (gridArray[catsGame] == 'X' || gridArray[catsGame] == 'O') {
				bruh++;
			}
			if (bruh == dimA) {
				cout << "\nThe game is a Tie!\n";
			}
		}
	}
		cin >> eChoice;



	delete gridArray;



}