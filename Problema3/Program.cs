// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Problema3 
{
   class Program
    {
        static void Main(string[] args)
        { 
             try
            {
                Console.WriteLine("\nIngrese los kilómetros ");
                double kms = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nIngrese los litros ");
                double litros = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nLos kms/l gastados son: {kms * litros}");
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


