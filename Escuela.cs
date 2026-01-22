using System;
using System.Collections.Generic;

namespace sistemaDeinscripciones
{
    internal class Escuela
    {
        private List<Estudiante> estudies = new List<Estudiante>();

        public void InscribirEstudiantes()
        {
            Console.Write("Matricula: ");
            string matricula = Console.ReadLine();

            if (ExisteMatricula(matricula))
            {
                Console.WriteLine("Ya existe un estudiante con esa matricula.");
                return;
            }

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Estudiante nuevo = new Estudiante(matricula, nombre, edad);
            estudies.Add(nuevo);

            Console.WriteLine("Estudiante inscrito correctamente");
        }

        public void ListarEstudiantes()
        {
            if (estudies.Count == 0)
            {
                Console.WriteLine("No hay estudiantes inscritos.");
                return;
            }

            Console.WriteLine("\n--- LISTA DE ESTUDIANTES ---");

            foreach (var e in estudies)
            {
                e.Mostrar();
            }
        }

        public void BuscarEstudiante()
        {
            Console.Write("Matricula a buscar: ");
            string matricula = Console.ReadLine();

            foreach (Estudiante e in estudies) 
            {
                if (e.Matricula == matricula)
                {
                    Console.WriteLine("Estudiante encontrado:");
                    e.Mostrar();
                    return;
                }
            }

            Console.WriteLine("No se encontro el estudiante.");
        }

        private bool ExisteMatricula(string matricula)
        {
            foreach (var estudiante in estudies)
            {
                if (estudiante.Matricula == matricula) 
                    return true;
            }
            return false;
        }
    }
}
