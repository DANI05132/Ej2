import java.util.ArrayList;
import java.util.Scanner;

class Arreglo {
    private ArrayList<String> nombres = new ArrayList<>();

    public void agregarNombre(String nombre) {
        nombres.add(nombre);
    }

    public String obtenerNombre(int posicion) {
        if (posicion >= 0 && posicion < nombres.size())
            return nombres.get(posicion);
        else
            return "Posición inválida";
    }

    public int cantidad() {
        return nombres.size();
    }
}

public class ej2 {
    public static void main(String[] args) {
        Arreglo arr = new Arreglo();
        Scanner sc = new Scanner(System.in);
        String nombre;
        String continuar;

        do {
            System.out.print("Ingrese su nombre: ");
            nombre = sc.nextLine();
            arr.agregarNombre(nombre);

            int ultimaPos = arr.cantidad() - 1;
            System.out.println("El nombre guardado en la posición " + ultimaPos + " es: " + arr.obtenerNombre(ultimaPos));

            System.out.print("Desea continuar? (S/N): ");
            continuar = sc.nextLine().toUpperCase();

        } while (continuar.equals("S"));

        sc.close();
    }
}