#include <iostream>
using namespace std;

struct Heroi {
    string Nome;
    string Poder;
    int Pontuacao;
};

Heroi herois[5];
Heroi equipe[3];

int quantidadeHerois = 0;

void cadastrarHeroi() {
    if (quantidadeHerois >= 5) {
        cout << "Limite de herois atingido.\n";
        return;
    }

    cout << "Nome: ";
    getline(cin >> ws, herois[quantidadeHerois].Nome);

    cout << "Poder: ";
    getline(cin, herois[quantidadeHerois].Poder);

    cout << "Pontuacao: ";
    cin >> herois[quantidadeHerois].Pontuacao;

    quantidadeHerois++;
}

void selecionarEquipe() {
    int indice;

    for (int i = 0; i < quantidadeHerois; i++) {
        cout << i << " - " << herois[i].Nome << endl;
    }

    for (int i = 0; i < 3; i++) {
        cout << "Escolha o heroi " << i + 1 << ": ";
        cin >> indice;

        equipe[i] = herois[indice];
    }
}

int calcularPontuacaoTotal() {
    int soma = 0;

    for (int i = 0; i < 3; i++) {
        soma += equipe[i].Pontuacao;
    }

    return soma;
}

void exibirEquipe() {
    cout << "\nEquipe selecionada:\n";

    for (int i = 0; i < 3; i++) {
        cout << equipe[i].Nome << " - "
             << equipe[i].Poder << " - "
             << equipe[i].Pontuacao << endl;
    }

    cout << "Pontuacao total: "
         << calcularPontuacaoTotal() << endl;
}

int main() {
    int opcao;

    do {
        cout << "\n1 - Cadastrar Heroi\n";
        cout << "2 - Selecionar Equipe\n";
        cout << "3 - Exibir Equipe\n";
        cout << "4 - Sair\n";
        cout << "Opcao: ";
        cin >> opcao;

        switch (opcao) {
            case 1:
                cadastrarHeroi();
                break;

            case 2:
                selecionarEquipe();
                break;

            case 3:
                exibirEquipe();
                break;
        }

    } while (opcao != 4);

    return 0;
}