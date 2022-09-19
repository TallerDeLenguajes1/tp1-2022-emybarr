// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Problema1 
{
   class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nIngresar un número ");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"El cuadrado de {n} es: {n * n}");
            }
            catch (FormatException x)
            {
                Console.WriteLine($"\n{x}\nError el valor ingresado no es un número");
            }
            catch (OverflowException x)
            {
                Console.WriteLine($"\n{x}\nError el número ingresado es muy grande");
            }

        }
    }
}
