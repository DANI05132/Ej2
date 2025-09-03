const prompt = require('prompt-sync')();

class Arreglo {
    constructor() {
        this.nombres = [];
    }

    agregarNombre(nombre) {
        this.nombres.push(nombre);
    }

    obtenerNombre(posicion) {
        if (posicion >= 0 && posicion < this.nombres.length)
            return this.nombres[posicion];
        else
            return "Posición inválida";
    }

    cantidad() {
        return this.nombres.length;
    }
}

const arr = new Arreglo();
let continuar;

do {
    let nombre = prompt("Ingrese su nombre: ");
    arr.agregarNombre(nombre);

    let ultimaPos = arr.cantidad() - 1;
    console.log(`El nombre guardado en la posición ${ultimaPos} es: ${arr.obtenerNombre(ultimaPos)}`);

    continuar = prompt("¿Desea continuar? (S/N): ").toUpperCase();
} while (continuar === "S");