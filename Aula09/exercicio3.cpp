#include <iostream>
#include <list>
#include <algorithm>
#include <cstdlib>
#include <ctime>

using namespace std;

int main()
{
    srand(time(0));

    list<int> numeros;

    for (int i = 0; i < 100; i++)
        numeros.push_back(rand() % 101);

    numeros.sort();

    cout << "Lista ordenada:\n";
    for (int n : numeros)
        cout << n << " ";
    cout << endl;

    numeros.remove_if([](int n)
    {
        return n % 2 == 0;
    });

    cout << "\nLista sem os numeros pares:\n";
    for (int n : numeros)
        cout << n << " ";
    cout << endl;

    cout << "\nNumeros repetidos:\n";

    bool repetiu = false;

    for (auto it = numeros.begin(); it != numeros.end(); )
    {
        int valor = *it;
        int cont = 0;

        auto aux = it;

        while (aux != numeros.end() && *aux == valor)
        {
            cont++;
            aux++;
        }

        if (cont > 1)
        {
            cout << valor << " aparece " << cont << " vezes" << endl;
            repetiu = true;
        }

        it = aux;
    }

    if (!repetiu)
        cout << "Nao existem numeros repetidos." << endl;

    return 0;
} 