#include <iostream>
#include <list>
#include <vector>
#include <string>

using namespace std;

int main()
{
    int x;
    cout << "Quantidade de nomes: ";
    cin >> x;

    list<string> nomes;

    for (int i = 0; i < x; i++)
    {
        string nome;
        cin >> nome;
        nomes.push_back(nome);
    }

    vector<list<string>> linhas;

    for (string nome : nomes)
    {
        bool inserido = false;

        for (int i = 0; i < linhas.size(); i++)
        {
            bool existe = false;

            for (string n : linhas[i])
            {
                if (n.size() == nome.size())
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                auto it = linhas[i].begin();

                while (it != linhas[i].end() && it->size() < nome.size())
                    it++;

                linhas[i].insert(it, nome);
                inserido = true;
                break;
            }
        }

        if (!inserido)
        {
            list<string> nova;
            nova.push_back(nome);
            linhas.push_back(nova);
        }
    }

    for (auto linha : linhas)
    {
        bool primeiro = true;

        for (string nome : linha)
        {
            if (!primeiro)
                cout << ", ";

            cout << nome;
            primeiro = false;
        }

        cout << endl;
    }

    return 0;
} 