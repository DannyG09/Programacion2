using System.Collections.Generic;

namespace PracticaHerencia
{
    public class Profesor : Persona
    {
        public List<Curso> Cursos { get; set; }

        public Profesor(string nombre) : base(nombre)
        {
            Cursos = new List<Curso>();
        }

        public void AgregarCurso(Curso curso)
        {
            Cursos.Add(curso);
        }

        public override string ToString()
        {
            return base.ToString() + $", Cursos: {Cursos.Count}";
        }
    }
}
