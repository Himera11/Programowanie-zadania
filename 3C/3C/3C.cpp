#include <iostream>
using namespace std;

/*
Zadania:
* Napisz funkcj�, kt�ra dla kolekcji danych liczbowych obliczy �redni� arytmetyczn�.
* Napisz funkcj�, kt�ra dla kolekcji danych liczbowych policzy ile jest liczb wi�kszych od �redniej arytmetycznej.
* Napisz funkcje, kt�ra dla kolekcji danych liczbowych przeniesie te liczby do innej kolekcji w odwrotnej kolejno�ci.
* Napisz funkcje, kt�ra dla kolekcji danych liczbowych obliczy cz�stotliwo�� wyst�powania danej liczby.
* Napisz funkcj�, kt�ra dla kolekcji danych liczbowych znajdzie najd�u�szy rosn�cy podci�g.
* Napisz funkcj�, kt�ra dla kolekcji danych liczbowych przeniesie te liczby do osobnych kolekcji liczb parzystych i nieparzystych.
*
*/

void Zad1()
{
	const int rozmiar = 5;
	int liczby[rozmiar];
	float suma = 0;

	for (int i = 0; i < rozmiar; i++)
	{
		cout << "Podaj " << i << " liczbe:\n";
		cin >> liczby[i];
		suma += liczby[i];
	}
	suma = suma / rozmiar;
	cout << suma;
}

void Zad2()
{
	int liczbywieksze = 0;
	const int rozmiar = 5;
	int liczby[rozmiar];
	float suma = 0;

	for (int i = 0; i < rozmiar; i++)
	{
		cout << "Podaj " << i << " liczbe:\n";
		cin >> liczby[i];
		suma += liczby[i];
	}
	suma = suma / rozmiar;
	cout << suma<<endl;

	for (int i = 0; i < rozmiar; i++)
	{
		if (liczby[i] > suma)
		{
			cout << liczby[i] << endl;
			liczbywieksze++;
		}
	}
	cout << liczbywieksze;
}

void Zad3()
{
	const int rozmiar = 5;
	int liczby[rozmiar];
	int liczbytyl[rozmiar];

	for (int i = 0; i < rozmiar; i++)
	{
		cout << "Podaj " << i << " liczbe:\n";
		cin >> liczby[i];
	}
	for (int i = 0; i < rozmiar; i++)
	{
		liczbytyl[i] = liczby[rozmiar - 1 - i];
	}

	for (int i = 0; i < rozmiar; i++)
	{
		cout << liczbytyl[i];
	}
	
}


void Zad4()
{
	const int rozmiar = 5;
	int liczby[rozmiar];
	const int rozmiar2 = 101;
	int liczniki[rozmiar2];

	for (int i = 0; i < rozmiar; i++)
	{
		cout << "Podaj " << i << " liczbe:\n";
		cin >> liczby[i];
	}
	for (int i = 0; i < rozmiar2; i++)
	{
		liczniki[i] = 0;
	}
	for (int i = 0; i < rozmiar; i++)
	{
		liczniki[liczby[i]]++;
	}
	for (int i = 0; i < rozmiar2; i++)
	{
		cout << i << "=" << liczniki[i] << endl;
	}
}

void Zad6()
{
	const int rozmiar = 5;
	int liczby[rozmiar];
	int par[rozmiar];
	int niepar[rozmiar];

	for (int i = 0; i < rozmiar; i++)
	{
		cout << "Podaj " << i << " liczbe:\n";
		cin >> liczby[i];
	}
	for (int i = 0; i < rozmiar; i++)
	{
		if (liczby[i] % 2 == 0)
		{
			par[i] = liczby[i];
		}
		else
			niepar[i] = liczby[i];
	}
}

int main()
{
	Zad4();

}


