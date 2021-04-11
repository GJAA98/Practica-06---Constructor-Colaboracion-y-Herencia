using System;
using System.Collections.Generic;
using System.Text;

namespace Practica06
{
    public class Profesor : Persona
    {
        private int sueldo;
        public int Sueldo { 
            get {
                return sueldo;
            } 
            set {
                sueldo = value;
            }
        }

        public void ImprimirSueldo()
        {
            Console.WriteLine("Sueldo:" + sueldo);
        }
    }
}
