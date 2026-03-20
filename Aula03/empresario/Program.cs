#include <iostream>
#include <iomanip>
using namespace std;

int main() {
    int numeroFuncionario;
    double horasTrabalhadas, valorPorHora;

    cout << "Digite o numero do funcionario: ";
    cin >> numeroFuncionario;

    cout << "Digite as horas trabalhadas: ";
    cin >> horasTrabalhadas;

    cout << "Digite o valor por hora: ";
    cin >> valorPorHora;

    double salario = horasTrabalhadas * valorPorHora;

    cout << fixed << setprecision(2);
    cout << "NUMERO = " << numeroFuncionario << endl;
    cout << "SALARIO = R$ " << salario << endl;

    return 0;
}