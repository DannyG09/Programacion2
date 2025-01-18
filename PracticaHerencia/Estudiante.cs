namespace PracticaHerencia
{
    public class Estudiante : Persona
    {
        public int NumeroUnico { get; set; }

        public Estudiante(string nombre, int numeroUnico) : base(nombre)
        {
            NumeroUnico = numeroUnico;
        }

        public override string ToString()
        {
            return base.ToString() + $", Número Único: {NumeroUnico}";
        }
    }
}
