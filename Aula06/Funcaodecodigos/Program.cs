#include <iostream>
#include <locale>
using namespace std;

void exercicio1()
{
    int quantidade;
    cout << "Digite a quantidade de números a serem inseridos: ";
    cin >> quantidade;

    int soma = 0;
    int contador = 0;
    
    while (quantidade > 0) {
        int numero;
        cout << "Digite um número: ";
        cin >> numero;

        if (numero % 2 == 0) {
            soma += numero;
            contador++;
        }
        quantidade--;
    }

    if (contador > 0) {
        double media = static_cast<double>(soma) / contador;
        cout << "A média dos números pares é: " << media << endl;
    } else {
        cout << "Nenhum número par foi digitado." << endl;
    }
}

void exercicio3()
{
    int soma = 0;
    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }
    cout << "A soma dos números ímpares múltiplos de 3 de 50 a 500 é: " << soma << endl;
}

void exercicio4()
{
    cout << "Digite um número: ";
    int numero;
    cin >> numero;

    int quadrado = numero * numero;
    int somaDigitos = 0;

    while (quadrado > 0) {
        somaDigitos += quadrado % 10;
        quadrado /= 10;
    }

    cout << "A soma dos dígitos do quadrado de " << numero << " é: " << somaDigitos << endl;
}

int main()
{
    setlocale(LC_ALL, "pt_BR.utf8");

    int opcao = 0;

    while (opcao != 4)
    {
        cout << "\n===== MENU =====\n";
        cout << "1 - Exercício 1\n";
        cout << "2 - Exercício 3\n";
        cout << "3 - Exercício 4\n";
        cout << "4 - Sair\n";
        cout << "Escolha: ";
        cin >> opcao;

        if (opcao == 1) exercicio1();
        if (opcao == 2) exercicio3();
        if (opcao == 3) exercicio4();
        if (opcao == 4) cout << "Encerrando...\n";
    }

    return 0;
}