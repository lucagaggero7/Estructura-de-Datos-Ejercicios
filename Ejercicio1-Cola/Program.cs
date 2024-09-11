using System;
using System.Collections.Generic;

class Ejercicio1
{
    static void Main()
    {
        Queue<string> cola = new Queue<string>();
        string input;

        Console.WriteLine("Introduce cadenas (deja vacío y presiona Enter para finalizar):");

        do
        {
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                cola.Enqueue(input);
            }
        } while (!string.IsNullOrEmpty(input));

        Console.WriteLine("Cadenas introducidas:");
        while (cola.Count > 0)
        {
            string dato = cola.Dequeue();
            Console.WriteLine(dato);
        }
    }
}