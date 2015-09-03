#include <iostream>
#include <algorithm>
#include <iostream>
#include <fstream>
#include <cstdio>
#include <string>

#define N 9

using namespace std;

bool checkCol(int _sudoku[N][N], int _nx, int _n)
{
	for (int col = 0; col < N; col++)
	{
		if (_sudoku[col][_nx] == _n)
		{
			return true;
		}
	}
	return false;
}

bool checkRow(int _sudoku[N][N], int _ny, int _n)
{
	for (int row = 0; row < N; row++)
	{
		if (_sudoku[_ny][row] == _n)
		{
			return true;
		}
	}
	return false;
}

bool checkBlock(int _sudoku[N][N], int _nx, int _ny, int _n)
{
	int v = _nx / 3;
	int h = _ny / 3;
	for (int row = 0; row < 3; row++)
	{
		for (int col = 0; col < 3; col++)
		{
			if (_sudoku[v*3 + row][h*3 + col] == _n)
				return true;
		}
	}
	return false;
}

bool check(int _sudoku[N][N], int _nx, int _ny, int _n)
{
	return !checkRow(_sudoku, _nx, _n) && !checkCol(_sudoku, _ny, _n) && !checkBlock(_sudoku, _nx, _ny, _n);
}

bool nextEmpty(int _sudoku[N][N], int& _nx, int& _ny)
{
	for (_nx = 0; _nx < N; _nx++)
		for (_ny = 0; _ny < N; _ny++)
			if (_sudoku[_nx][_ny] == 0)
				return true;
	return false;
}

bool solve(int _sudoku[N][N])
{
	int nx = 0, ny = 0;
	if (!nextEmpty(_sudoku, nx, ny))
	{
		return true;
	}
	for (int i = 1; i <= 9; i++)
	{
		if (check(_sudoku, nx, ny, i))
		{
			_sudoku[nx][ny] = i;
			if (solve(_sudoku))
			{
				return true;
			}
			_sudoku[nx][ny] = 0;
		}
	}
	return false;
}

int main() {
	int sudoku[N][N];
	int problemNum = 0;
	string inputString;
	ifstream fin("sudoku.in");
	ofstream fout("sudoku.out");
	while (true)
	{
		fin >> problemNum;
		if (problemNum == -1)
		{
			fout << problemNum;
			return 0;
		}
		for (int i = 0; i < N; i++)
		{
			fin >> inputString;
			for (int j = 0; j < N; j++)
			{
				sudoku[i][j] = inputString[j] - '0';
			}
		}
		solve(sudoku);
		fout << problemNum << endl;
		for (int i = 0; i < N; i++)
		{
			for (int j = 0; j < N; j++)
			{
				fout << sudoku[i][j];
			}
			fout << endl;
		}
	}
	return 0;
}
