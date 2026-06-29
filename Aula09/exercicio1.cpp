#include <iostream>
#include <list>

using namespace std;

int main()
{
    list<float> notas;
    float nota, soma = 0, maior, menor;

    for (int i = 0; i < 5; i++)
    {
        cout << "Digite a nota " << i + 1 << ": ";
        cin >> nota;
        notas.push_back(nota);
    }

    auto it = notas.begin();
    maior = *it;
    menor = *it;

    cout << "\nNotas cadastradas:\n";

    for (float n : notas)
    {
        cout << n << " ";
        soma += n;

        if (n > maior)
            maior = n;

        if (n < menor)
            menor = n;
    }

    cout << "\n\nMaior nota: " << maior;
    cout << "\nMenor nota: " << menor;
    cout << "\nMedia: " << soma / notas.size() << endl;

    return 0;
}