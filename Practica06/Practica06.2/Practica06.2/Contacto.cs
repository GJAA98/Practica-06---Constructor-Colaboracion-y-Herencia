using System;
using System.Collections.Generic;
using System.Text;

namespace Practica06._2
{
    public class Contacto
    {
        private string nombre;
        private string apellido;
        private string telefono;
        private string direccion;
        public void SetContacto(
            string nombre, 
            string apellido, 
            string telefono, 
            string direccion 
            )
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola soy " + nombre + " " + apellido);
            Console.WriteLine("Mi telefono es: " + telefono);
            Console.WriteLine("Mi dirección es: " + direccion);

        }
    }
}
