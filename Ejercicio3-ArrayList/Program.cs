using System;
using System.Collections;

class Ejercicio3
{
    static void Main()
    {
        ArrayList lista = new ArrayList();
        string input;

        // Recoger cadenas de texto del usuario
        Console.WriteLine("Introduce cadenas de texto (deja vacío para terminar):");
        while (true)
        {
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                break;
            lista.Add(input);
        }

        // Modo de consulta
        Console.WriteLine("Introduce un número para obtener la cadena en esa posición (0 para salir):");
        while (true)
        {
            input = Console.ReadLine();
            if (int.TryParse(input, out int index))
            {
                if (index == 0)
                    break;
                if (index > 0 && index <= lista.Count)
                    Console.WriteLine(lista[index - 1]);
                else
                    Console.WriteLine("Índice fuera de rango.");
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }
    }
}