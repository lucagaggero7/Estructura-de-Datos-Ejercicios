using System;
using System.Collections.Generic;

class Ejercicio6
{
    static void Main()
    {
        HashSet<string> frasesIntroducidas = new HashSet<string>(); //hash set :D

        string frase = "";

        while (true)
        {
            Console.WriteLine("\nIntroducí una palabra (o presiona Enter sin escribir nada para terminar):");
            frase = Console.ReadLine();

            if (string.IsNullOrEmpty(frase))
            {
                Console.WriteLine("Nos vemos! (>_<) ");
                break;
            }

            if (frasesIntroducidas.Contains(frase.ToLower()))
            {
                Console.WriteLine("Esta palabra ya ha sido introducida.");
            }
            else
            {
                frasesIntroducidas.Add(frase.ToLower());
                Console.WriteLine("Nueva palabra introducida.");
            }
        }
    }
}
