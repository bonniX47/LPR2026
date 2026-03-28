#include <iostream>
using namespace std;

int main() {
    double horasDia;
    cin >> horasDia;

    double horasSemana = horasDia * 5;
    double total = 0;
    int dias = 0;

    while (total < 1000) {
        total += horasDia;
        dias++;
    }

    double semanas = dias / 5.0;
    double meses = semanas / 4.5;

    cout << horasSemana << endl;
    cout << dias << endl;
    cout << semanas << endl;
    cout << meses;

    return 0;
}