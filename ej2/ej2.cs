using System;
using System.Collections.Generic;

class Arreglo
{
    private List<string> Nombres = new List<string>();

    public void AgregarNombre(string nombre)
    {
        Nombres.Add(nombre);
    }

    public string ObtenerNombre(int posicion)
    {
        if (posicion >= 0 && posicion < Nombres.Count)
            return Nombres[posicion];
        else
            return "Posición inválida";
    }

    public int Cantidad()
    {
        return Nombres.Count;
    }
}

class Program
{
    static void Main()
    {
        Arreglo Arr = new Arreglo();
        string Nombre;
        char Continuar;

        do
        {
            Console.Write("Ingrese su nombre: ");
            Nombre = Console.ReadLine();
            Arr.AgregarNombre(Nombre);

            int UltimaPos = Arr.Cantidad() - 1;
            Console.WriteLine($"El nombre guardado en la posición {UltimaPos} es: {Arr.ObtenerNombre(UltimaPos)}");

            Console.Write("Desea continuar? (S/N): ");
            Continuar = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

        } while (Continuar == 'S');
    }
}