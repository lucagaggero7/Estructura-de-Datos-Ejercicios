using System;
using System.Collections.Generic;

class Ejercicio2
{
    static void Main()
    {
        Stack<string> pila = new Stack<string>();
        string input;

        Console.WriteLine("Introduce tantas cadenas como desees. Introduce una cadena vacía para terminar.");

        // Leer cadenas del usuario y almacenarlas en la pila
        while (true)
        {
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }
            pila.Push(input);
        }

        // Mostrar las cadenas en orden inverso
        Console.WriteLine("Cadenas en orden inverso:");
        while (pila.Count > 0)
        {
            Console.WriteLine(pila.Pop());
        }
    }
}
