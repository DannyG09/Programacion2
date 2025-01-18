using System;
using PracticaHerencia;

class Program
{
    static void Main()
    {

          // Título de la aplicación
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("       Sistema de Gestión de Clases y Cursos      ");
        Console.WriteLine("--------------------------------------------------\n");
        Console.ResetColor();

        // Crear Clase
        Clase ProgramacionII = new Clase("Instituto Tecnologico");

        // Agregar Estudiantes
        ProgramacionII.AgregarEstudiante(new Estudiante("Danny Guerrero", 2024-0092));
        ProgramacionII.AgregarEstudiante(new Estudiante("Amada Victoria", 0000-0000));
        ProgramacionII.AgregarEstudiante(new Estudiante("Eduardo Rodriguez", 0000-0001));
        ProgramacionII.AgregarEstudiante(new Estudiante("Sebastian Tineo", 0000-0002));

        // Agregar Profesores
        Profesor profesorGarcia = new Profesor("Lic.Francis Ramirez");
        profesorGarcia.AgregarCurso(new Curso("ProgramacionII", 10, 20));
        

        ProgramacionII.AgregarProfesor(profesorGarcia);

        // Mostrar Información de la Clase
        Console.WriteLine(ProgramacionII);

        Console.WriteLine("\nEstudiantes:");
        foreach (var estudiante in ProgramacionII.Estudiantes)
        {
            Console.WriteLine(estudiante);
        }

        Console.WriteLine("\nProfesores:");
        foreach (var profesor in ProgramacionII.Profesores)
        {
            Console.WriteLine(profesor);
            foreach (var curso in profesor.Cursos)
            {
                Console.WriteLine($"  {curso}");
            }
        }

        // Separador final
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n--------------------------------------------------");
        Console.ResetColor();
    }

    
}

