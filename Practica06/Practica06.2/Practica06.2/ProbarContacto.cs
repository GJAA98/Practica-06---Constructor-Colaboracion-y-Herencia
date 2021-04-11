using System;

namespace Practica06._2
{
    class ProbarContacto
    {
        static void Main(string[] args)
        {
            Contacto c = new Contacto();
            c.SetContacto("Junior", "Acero", "809-555-44444", "Mi direccion especial");
            c.Saludar();
        }
    }
}
