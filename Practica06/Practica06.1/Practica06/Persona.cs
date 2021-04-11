using System;
using System.Collections.Generic;
using System.Text;

namespace Practica06
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private string cedula;
        private int edad;

        public string Nombre
        {
            get {                
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public string Cedula
        {
            get
            {
                return cedula;
            }
            set
            {
                cedula = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad= value;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Cedula: " + cedula);
        }
    }
}
