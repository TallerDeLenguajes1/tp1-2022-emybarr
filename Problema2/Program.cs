// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Problema2 
{
   class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                Console.WriteLine("\nIngresar el dividendo");
                int dividendo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nIngresar el divisor");
                int divisor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nLa división de {dividendo} en {divisor} es: {dividendo / divisor}");
            }
            catch (DivideByZeroException x)
            {
                Console.WriteLine($"\n{x}\nError division en 0");
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