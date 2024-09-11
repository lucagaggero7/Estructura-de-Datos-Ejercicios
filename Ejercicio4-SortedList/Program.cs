using System;
using System.Collections.Generic;

class Ejercicio4
{
    static void Main()
    {

        SortedList<string, string> diccionario = new SortedList<string, string>(); //sorted list ;)


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

            Console.WriteLine("\nIntroducí una palabra en ingles (o escribí 'salir' para terminar):");
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


            // Separar la frase en palabras usando Split como dice el tipo del video
            string[] palabras = frase.ToLower().Split(' '); // Todo en minusculas 


            Console.WriteLine("\nTraducción de la palabra:");
            foreach (string palabra in palabras)
            {
                if (diccionario.ContainsKey(palabra))
                {

                    Console.Write(diccionario[palabra] + " ");
                }
                else
                {

                    Console.Write($"La palabra [{palabra} no se encuentra en el diccionario] ");
                }
            }

            Console.WriteLine();
        }
    }
}
