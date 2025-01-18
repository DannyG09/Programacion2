namespace PracticaHerencia
{
    public class Curso
    {
        public string Nombre { get; set; }
        public int RecuentoClases { get; set; }
        public int RecuentoEjercicios { get; set; }

        public Curso(string nombre, int recuentoClases, int recuentoEjercicios)
        {
            Nombre = nombre;
            RecuentoClases = recuentoClases;
            RecuentoEjercicios = recuentoEjercicios;
        }

        public override string ToString()
        {
            return $"Curso: {Nombre}, Clases: {RecuentoClases}, Ejercicios: {RecuentoEjercicios}";
        }
    }
}
