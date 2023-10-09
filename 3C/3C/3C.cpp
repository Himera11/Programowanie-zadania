#include <iostream>
using namespace std;

/*
Zadania:
* Napisz funkcjê, która dla kolekcji danych liczbowych obliczy œredni¹ arytmetyczn¹.
* Napisz funkcjê, która dla kolekcji danych liczbowych policzy ile jest liczb wiêkszych od œredniej arytmetycznej.
* Napisz funkcje, która dla kolekcji danych liczbowych przeniesie te liczby do innej kolekcji w odwrotnej kolejnoœci.
* Napisz funkcje, która dla kolekcji danych liczbowych obliczy czêstotliwoœæ wystêpowania danej liczby.
* Napisz funkcjê, która dla kolekcji danych liczbowych znajdzie najd³u¿szy rosn¹cy podci¹g.
* Napisz funkcjê, która dla kolekcji danych liczbowych przeniesie te liczby do osobnych kolekcji liczb parzystych i nieparzystych.
*
*/

void Zad1()
{
	const int size = 5;
	int numbers[size];
	float amount = 0;

	for (int i = 0; i < size; i++)
	{
		cout << "Podaj " << i << " liczbe:\n";
		cin >> numbers[i];
		amount += numbers[i];
	}
	amount = amount / size;
	cout << amount;
}

void Zad2()
{
	int bignumbers = 0;
	const int size = 5;
	int numbers[size];
	float amount = 0;

	for (int i = 0; i < size; i++)
	{
		cout << "Podaj " << i << " liczbe:\n";
		cin >> numbers[i];
		amount += numbers[i];
	}
	amount = amount / size;
	cout << amount << endl;

	for (int i = 0; i < size; i++)
	{
		if (numbers[i] > amount)
		{
			cout << numbers[i] << endl;
			bignumbers++;
		}
	}
	cout << bignumbers;
}

void Zad3()
{
	const int size = 5;
	int numbers[size];
	int numbersback[size];

	for (int i = 0; i < size; i++)
	{
		cout << "Podaj " << i << " liczbe:\n";
		cin >> numbers[i];
	}
	for (int i = 0; i < size; i++)
	{
		numbersback[i] = numbers[size - 1 - i];
	}

	for (int i = 0; i < size; i++)
	{
		cout << numbersback[i];
	}

}


void Zad4()
{
	const int size = 5;
	int numbers[size];
	const int size2 = 101;
	int counter[size2];

	for (int i = 0; i < size; i++)
	{
		cout << "Podaj " << i << " liczbe:\n";
		cin >> numbers[i];
	}
	for (int i = 0; i < size2; i++)
	{
		counter[i] = 0;
	}
	for (int i = 0; i < size; i++)
	{
		counter[numbers[i]]++;
	}
	for (int i = 0; i < size2; i++)
	{
		cout << i << "=" << counter[i] << endl;
	}
}

void Zad6()
{
	const int size = 5;
	int numbers[size];
	int pair[size];
	int notpair[size];
	int counterpair = 0;
	int counternotpair = 0;


	for (int i = 0; i < size; i++)
	{
		cout << "Podaj " << i << " liczbe:\n";
		cin >> numbers[i];
	}
	for (int i = 0; i < size; i++)
	{
		pair[i] = 0;
	}
	for (int i = 0; i < size; i++)
	{
		notpair[i] = 0;
	}
	for (int i = 0; i < size; i++)
	{
		if (numbers[i] % 2 == 0)
		{
			pair[counterpair] = numbers[i];
			counterpair++;
		}
		else
		{
		notpair[counternotpair] = numbers[i];
		counternotpair++;
		}
}
	for (int i = 0; i < counterpair; i++)
	{
		cout << " parzyste " << pair[i];
	}
	for (int i = 0; i < counternotpair; i++)
	{
		cout << " nie parzyste " << notpair[i];
	}
}

int main()
{
	Zad3();
}


