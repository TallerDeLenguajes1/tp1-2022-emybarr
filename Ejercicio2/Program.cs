// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Ejercicio2 
{
   class Program
    {
        static void Main(string[] args)
        {
           try
            {
                Console.WriteLine("\nIngrese la cantidad de empleados: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                var  listaEmpleados = new List<Empleado>();

                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine($"\n---------Empleado {i + 1}------------");
                    Console.WriteLine("Datos personales:");
                    Console.WriteLine("Apellido: ");
                    string a = Console.ReadLine();
                    Console.WriteLine("Nombre: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Ingrese fecha de nacimiento dd/mm/aaaa :");
                    DateTime fechaNacimiento =  DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese estado civil S-SOLTERO C-CASADO  D-Divorciado: ");
                    char EstadoCivil = Console.ReadLine()[0];
                    Console.WriteLine("Ingrese genero F-FEMENINO M-MASCULINO : ");
                    char Genero = Console.ReadLine()[0];
                  

                    var datosper = new DatosPersonales(a,n,fechaNacimiento,EstadoCivil,Genero);

                    switch(datosper.EstadoCivil)
                    {
                        case 'C':
                            Console.WriteLine("Ingrese la cantidad de hijos que tiene: ");
                            datosper.Hijos = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 'D':
                             Console.WriteLine("Ingrese fecha de divorcio dd/mm/aaaa :");
                             DateTime fechaDivorcio =  DateTime.Parse(Console.ReadLine());
                             break;
                    
                    }

                    Console.WriteLine("Dirección:");
                    Console.WriteLine("Calle: ");
                    string calle = Console.ReadLine();
                    Console.WriteLine("Número: ");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    var direc = new Direccion(calle, numero);

                    Console.WriteLine("Datos Profesionales:");
                    Console.WriteLine("Ingrese fecha de ingreso dd/mm/aaaa : ");
                    DateTime FechaIngreso =  DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Cargo que ocupa en la empresa: ");
                    string cargo = Console.ReadLine();
                    Console.WriteLine("Sueldo básico: ");
                    float sueldo = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("¿Posee título universitario? (Sí: 1, No: 0)");
                    int titulo = Convert.ToInt32(Console.ReadLine());

                    var dprofesional = new DatosProfesionales(cargo,sueldo,FechaIngreso);

                    if (titulo == 1)
                    {
                        Console.WriteLine("Ingrese el título que posee: ");
                        dprofesional.Titulo = Console.ReadLine();
                        Console.WriteLine("Ingrese la universidad a la que asistió");
                        dprofesional.Universidad = Console.ReadLine();
                    }

                    
                    var empleado = new Empleado(datosper,direc,dprofesional);

                    listaEmpleados.Add(empleado);

                }
                int j = 1;
                foreach (var emp in listaEmpleados)
                {
                    Console.WriteLine($"\nEmpleado {j}");
                    Console.WriteLine($"Nombre completo: {emp.Dper.Apellido} {emp.Dper.Nombre}");
                    Console.WriteLine($"Edad: {emp.Dper.calcularEdad()} años");
                    Console.WriteLine($"Antiguedad: {emp.Dprof.antiguedad()}");
                    Console.WriteLine($"Salario: {emp.CalcularSalario()}");
                    j++;
                }
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