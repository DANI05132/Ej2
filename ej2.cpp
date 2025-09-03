#include <iostream>
#include <vector>
using namespace std;
class Arreglo {
private:
    vector<string> Nombres;

public:
    void AgregarNombre(string nombre) {
        Nombres.push_back(nombre);
    }

    string ObtenerNombre(int posicion) {
        if (posicion >= 0 && posicion < Nombres.size())
            return Nombres[posicion];
        else
            return "Posicion invalida";
    }

    int Cantidad() {
        return Nombres.size();
    }
};

int main() {
    Arreglo Arr; 

    string Nombre;
    char Continuar;

    do {
        cout << "Ingrese su nombre: ";
        cin >> Nombre;
        Arr.AgregarNombre(Nombre);

        int UltimaPos = Arr.Cantidad() - 1;

        cout << "El nombre guardado en la posicion " << UltimaPos
             << " es: " << Arr.ObtenerNombre(UltimaPos) << endl;

        cout << "Desea continuar? (S/N): ";
        cin >> Continuar;

    } while (Continuar == 'S');

    return 0;
}