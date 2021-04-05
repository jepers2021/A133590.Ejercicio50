using System;
using System.IO;

namespace A133590.Ejercicio50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 50");
            Console.WriteLine("Programa dada una ruta, muestra el contenido del archivo.");

            Console.Write("Por favor, ingrese una ruta: ");
            string ruta = Console.ReadLine();
            if(File.Exists(ruta))
            {
                using (StreamReader sr = File.OpenText(ruta))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            else
            {
                Console.WriteLine("El archivo no existe.");
            }    
            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();

        }
    }
}
