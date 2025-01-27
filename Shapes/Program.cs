class Program
{
    static void Main(string[] args)
    {
        // Creamos un arreglo de diferentes formas
        Shape[] shapes = new Shape[]
        {
            new Rectangle(5, 10),   
            new Triangle(6, 8),     
            new Circle(7)          
        };

        // Creaamos una matriz para almacenar los resultados del área
        double[] areas = new double[shapes.Length];

        // Aplicamos el metodo para Calcular el área de cada forma y almacenar en el arreglo de áreas
        for (int i = 0; i < shapes.Length; i++)
        {
            areas[i] = shapes[i].CalculateSurface();
        }

        // Imprimir las áreas con el nombre de cada forma
        for (int i = 0; i < areas.Length; i++)
        {
            // Imprime el nombre de la forma junto con su área
            Console.WriteLine($"Área del {shapes[i].GetName()}: {areas[i]}");
        }
    }
}
