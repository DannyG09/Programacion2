namespace PracticaHerencia
{
    public abstract class Persona
    {
        public string Nombre { get; set; }

        protected Persona(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}";
        }
    }
}
