#include <iostream>
using namespace std;

struct Livro {
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    float Preco;
};

int main() {
    Livro livros[3];

    float precoTotal = 0;
    int totalPaginas = 0;

    for (int i = 0; i < 3; i++) {
        cout << "Livro " << i + 1 << endl;

        cout << "Titulo: ";
        getline(cin >> ws, livros[i].Titulo);

        cout << "Autor: ";
        getline(cin, livros[i].Autor);

        cout << "Ano de publicacao: ";
        cin >> livros[i].AnoPublicacao;

        cout << "Numero de paginas: ";
        cin >> livros[i].NumeroPaginas;

        cout << "Preco: ";
        cin >> livros[i].Preco;

        precoTotal += livros[i].Preco;
        totalPaginas += livros[i].NumeroPaginas;

        cout << endl;
    }

    cout << "Preco total dos livros: " << precoTotal << endl;
    cout << "Media de paginas: " << totalPaginas / 3.0 << endl;

    return 0;
}