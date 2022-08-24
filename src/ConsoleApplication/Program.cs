//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            // Va destruyendo a medida que se queda sin memoria para guardar más trenes

            /*
            for (int i = 0; i < 10000000; i++)
            {
                var train = new Train("Thomas");
                
            }
            Console.WriteLine(Train.Count); 
            */

            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");

            // Falso las dos. Son instancias distintas aunq compartan nombre
            Console.WriteLine(t1 == t2);
            Console.WriteLine(t2 == t3);
        }
    }
}