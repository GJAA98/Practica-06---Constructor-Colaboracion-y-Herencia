using System;

namespace Practica06
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona persona = new Persona();
            persona.Nombre = "Junior";
            persona.Apellido= "Acero";
            persona.Edad= 21;
            persona.Cedula= "405-5656565-9";

            Console.WriteLine("Datos Persona:");
            Console.WriteLine("----------------");
            persona.Imprimir();

            Console.WriteLine();
            Console.WriteLine();

            Profesor profesor = new Profesor();
            profesor.Nombre = "Alan";
            profesor.Apellido = "Ramirez";
            profesor.Edad = 25;
            profesor.Cedula = "405-4444444-9";
            profesor.Sueldo = 50000;
            
            Console.WriteLine("Datos Profesor:");
            Console.WriteLine("----------------");
            profesor.Imprimir();
            profesor.ImprimirSueldo();

        }
    }
}
