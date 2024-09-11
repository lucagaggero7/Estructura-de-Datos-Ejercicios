using System;
using System.Collections;

class Ejercicio5
{
    static void Main()
    {
        Hashtable diccionario = new Hashtable();  //tabla hash ;)

        diccionario.Add("hello", "hola");
        diccionario.Add("goodbye", "adios");
        diccionario.Add("please", "por favor");
        diccionario.Add("thank", "gracias");
        diccionario.Add("you", "tú");
        diccionario.Add("yes", "sí");
        diccionario.Add("no", "no");
        diccionario.Add("later", "luego");

        string frase = "";

        while (true)
        {
            Console.WriteLine("\nIntroducí una palabra en inglés (o escribí 'salir' para terminar):");
            frase = Console.ReadLine();

            if (frase.ToLower() == "salir")
            {
                Console.WriteLine("Nos vemos! (>_<) ");
                break;
            }

            if (string.IsNullOrEmpty(frase))
            {
                Console.WriteLine("Por favor, usa la cabeza.");
                continue; // Volver a pedir
            }

            // Separar la frase en palabras usando Split
            string[] palabras = frase.ToLower().Split(' '); // Todo en minúsculas 

            Console.WriteLine("\nTraducción de la palabra:");
            foreach (string palabra in palabras)
            {
                if (diccionario.ContainsKey(palabra))
                {
                    Console.Write(diccionario[palabra] + " ");
                }
                else
                {
                    Console.Write($"La palabra [{palabra}] no se encuentra en el diccionario ");
                }
            }

            Console.WriteLine();
        }
    }
}
