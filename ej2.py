class Arreglo:
    def __init__(self):
        self.nombres = []

    def agregar_nombre(self, nombre):
        self.nombres.append(nombre)

    def obtener_nombre(self, posicion):
        if 0 <= posicion < len(self.nombres):
            return self.nombres[posicion]
        else:
            return "Posición inválida"

    def cantidad(self):
        return len(self.nombres)


def main():
    arr = Arreglo()
    while True:
        nombre = input("Ingrese su nombre: ")
        arr.agregar_nombre(nombre)

        ultima_pos = arr.cantidad() - 1
        print(f"El nombre guardado en la posición {ultima_pos} es: {arr.obtener_nombre(ultima_pos)}")

        continuar = input("Desea continuar? (S/N): ").upper()
        if continuar != 'S':
            break


if __name__ == "__main__":
    main()