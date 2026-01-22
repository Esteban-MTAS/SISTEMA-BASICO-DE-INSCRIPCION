using System;

namespace sistemaDeinscripciones
{
    internal class Estudiante
    
    {
        public string Matricula {  get; set; }
        public string Nombre { get; set; }
        public int Edad {  get; set; }

        public Estudiante (string matricula, string nombre, int edad)
        {
            Matricula = matricula;
            Nombre = nombre;
            Edad = edad;
        }

        public void Mostrar ()
        {
            Console.WriteLine($"Maticula: {Matricula} | Nombre: { Nombre } | Edad: { Edad}");
            
        }
    }


}
