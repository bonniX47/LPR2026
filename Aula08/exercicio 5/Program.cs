#include <iostream>
using namespace std;

struct Chamado {
    int Numero;
    string Solicitante;
    string Setor;
    int Prioridade;
    string Status;
    string Descricao;
};

Chamado chamados[10];
int quantidadeChamados = 0;

string classificarPrioridade(int prioridade) {
    if (prioridade == 1)
        return "Baixa";
    else if (prioridade == 2)
        return "Media";
    else
        return "Alta";
}

void cadastrarChamado() {
    if (quantidadeChamados >= 10) {
        cout << "Limite atingido.\n";
        return;
    }

    cout << "Numero: ";
    cin >> chamados[quantidadeChamados].Numero;

    cout << "Solicitante: ";
    getline(cin >> ws, chamados[quantidadeChamados].Solicitante);

    cout << "Setor: ";
    getline(cin, chamados[quantidadeChamados].Setor);

    cout << "Prioridade (1 a 3): ";
    cin >> chamados[quantidadeChamados].Prioridade;

    cout << "Descricao: ";
    getline(cin >> ws, chamados[quantidadeChamados].Descricao);

    chamados[quantidadeChamados].Status = "Aberto";

    quantidadeChamados++;
}

void listarChamados() {
    for (int i = 0; i < quantidadeChamados; i++) {
        cout << "\nNumero: " << chamados[i].Numero << endl;
        cout << "Solicitante: " << chamados[i].Solicitante << endl;
        cout << "Setor: " << chamados[i].Setor << endl;
        cout << "Prioridade: "
             << classificarPrioridade(chamados[i].Prioridade) << endl;
        cout << "Status: " << chamados[i].Status << endl;
        cout << "Descricao: " << chamados[i].Descricao << endl;
    }
}

void atualizarStatus() {
    int numero;

    cout << "Numero do chamado: ";
    cin >> numero;

    for (int i = 0; i < quantidadeChamados; i++) {
        if (chamados[i].Numero == numero) {
            int opcao;

            cout << "1 - Em andamento\n";
            cout << "2 - Resolvido\n";
            cout << "3 - Cancelado\n";
            cin >> opcao;

            if (opcao == 1)
                chamados[i].Status = "Em andamento";
            else if (opcao == 2)
                chamados[i].Status = "Resolvido";
            else if (opcao == 3)
                chamados[i].Status = "Cancelado";
        }
    }
}

void estatisticas() {
    int abertos = 0;
    int andamento = 0;
    int resolvidos = 0;
    int cancelados = 0;

    for (int i = 0; i < quantidadeChamados; i++) {
        if (chamados[i].Status == "Aberto")
            abertos++;
        else if (chamados[i].Status == "Em andamento")
            andamento++;
        else if (chamados[i].Status == "Resolvido")
            resolvidos++;
        else if (chamados[i].Status == "Cancelado")
            cancelados++;
    }

    cout << "\nAbertos: " << abertos << endl;
    cout << "Em andamento: " << andamento << endl;
    cout << "Resolvidos: " << resolvidos << endl;
    cout << "Cancelados: " << cancelados << endl;
}

int main() {
    int opcao;

    do {
        cout << "\n1 - Cadastrar chamado\n";
        cout << "2 - Listar chamados\n";
        cout << "3 - Atualizar status\n";
        cout << "4 - Estatisticas\n";
        cout << "5 - Sair\n";
        cout << "Opcao: ";
        cin >> opcao;

        switch (opcao) {
            case 1:
                cadastrarChamado();
                break;

            case 2:
                listarChamados();
                break;

            case 3:
                atualizarStatus();
                break;

            case 4:
                estatisticas();
                break;
        }

    } while (opcao != 5);

    return 0;
}