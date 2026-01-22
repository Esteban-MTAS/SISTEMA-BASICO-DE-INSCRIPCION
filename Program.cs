using sistemaDeinscripciones;
using System;

class Program

{
    static void Main()

    {
        Escuela escuela = new Escuela();
        string opcion;

        do
        {
            Console.WriteLine("\n=== SISTEMA BASICO DE INSCRIPCION ===");
            Console.WriteLine("1) Inscribir estudiante");
            Console.WriteLine("2) Listar estudiantes");
            Console.WriteLine("3) Buscar estudiante");
            Console.WriteLine("0) Salir");
            Console.Write("Opcion: ");

            opcion = Console.ReadLine();

            switch (opcion) {

                case "1":
                    escuela.InscribirEstudiantes();
                    break;
                case "2":
                    escuela.ListarEstudiantes();
                    break;
                case "3":
                    escuela.BuscarEstudiante();
                    break;
                case "0":
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opcion invalida.");
                    break;

            }
        

        } while (opcion != "0");

        }
}

    