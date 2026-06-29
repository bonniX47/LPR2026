#include <iostream>
#include <list>
#include <map>
#include <algorithm>
#include <string>

using namespace std;

struct Piloto
{
    string nome;
    string equipe;
    int pontuacao;
};

void CadastrarPiloto(list<Piloto> &pilotos)
{
    Piloto p;

    cout << "Nome: ";
    cin >> p.nome;

    cout << "Equipe: ";
    cin >> p.equipe;

    cout << "Pontuacao: ";
    cin >> p.pontuacao;

    pilotos.push_back(p);
}

void ExibirRanking(list<Piloto> pilotos)
{
    pilotos.sort([](Piloto a, Piloto b)
    {
        return a.pontuacao > b.pontuacao;
    });

    cout << "\nRanking:\n";

    int posicao = 1;

    for (Piloto p : pilotos)
    {
        cout << posicao << " - " << p.nome << " | "
             << p.equipe << " | "
             << p.pontuacao << endl;
        posicao++;
    }
}

double CalcularPontuacaoMedia(list<Piloto> pilotos)
{
    int soma = 0;

    for (Piloto p : pilotos)
        soma += p.pontuacao;

    return (double)soma / pilotos.size();
}

void ExibirMelhorEquipe(list<Piloto> pilotos)
{
    map<string, int> equipes;

    for (Piloto p : pilotos)
        equipes[p.equipe] += p.pontuacao;

    string melhorEquipe;
    int maiorPontuacao = -1;

    for (auto e : equipes)
    {
        if (e.second > maiorPontuacao)
        {
            maiorPontuacao = e.second;
            melhorEquipe = e.first;
        }
    }

    cout << "Melhor equipe: " << melhorEquipe << endl;
    cout << "Pontuacao total: " << maiorPontuacao << endl;
}

int main()
{
    list<Piloto> pilotos;

    for (int i = 0; i < 10; i++)
    {
        cout << "\nPiloto " << i + 1 << endl;
        CadastrarPiloto(pilotos);
    }

    ExibirRanking(pilotos);

    double media = CalcularPontuacaoMedia(pilotos);

    cout << "\nMedia de pontos: " << media << endl;

    int acimaMedia = 0;

    for (Piloto p : pilotos)
    {
        if (p.pontuacao > media)
            acimaMedia++;
    }

    cout << "Pilotos acima da media: " << acimaMedia << endl;

    ExibirMelhorEquipe(pilotos);

    return 0;
}