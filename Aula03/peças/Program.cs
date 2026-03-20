#include <iostream>
#include <iomanip>
using namespace std;

int main() {
    int cod1, cod2;
    int qtd1, qtd2;
    double valor1, valor2;

    cout << "Digite o codigo da peca 1, quantidade e valor unitario: ";
    cin >> cod1 >> qtd1 >> valor1;

    cout << "Digite o codigo da peca 2, quantidade e valor unitario: ";
    cin >> cod2 >> qtd2 >> valor2;

    double total = (qtd1 * valor1) + (qtd2 * valor2);

    cout << fixed << setprecision(2);
    cout << "VALOR A PAGAR = R$ " << total << endl;

    return 0;
}