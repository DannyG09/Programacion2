using System.Collections.Generic;

namespace PracticaHerencia
{
    public class Clase
    {
        public string Identificador { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
        public List<Profesor> Profesores { get; set; }

        public Clase(string identificador)
        {
            Identificador = identificador;
            Estudiantes = new List<Estudiante>();
            Profesores = new List<Profesor>();
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public void AgregarProfesor(Profesor profesor)
        {
            Profesores.Add(profesor);
        }

        public override string ToString()
        {
            return $"Clase: {Identificador}, Estudiantes: {Estudiantes.Count}, Profesores: {Profesores.Count}";
        }
    }
}
