#include <iostream>

using namespace std;

int main() {
    int matriz[4][4] = {
        {0, 524, 521, 882},
        {524, 0, 434, 586},
        {521, 434, 0, 429},
        {882, 586, 429, 0}
    };

    int origem, destino;

    while (true) {
        cin >> origem >> destino;

        if (origem == destino) {
            break;
        }

        if (origem >= 0 && origem < 4 && destino >= 0 && destino < 4) {
            cout << matriz[origem][destino] << " km" << endl;
        }
    }

    return 0;
}