class Rectangle : Shape
{
    // Constructor que pasa los parámetros al constructor de la clase base (Shape)
    public Rectangle(double width, double height) : base(width, height) { }

    // Implementación del cálculo del área
    public override double CalculateSurface()
    {
        return Width * Height;  // Área del rectángulo
    }


    public override string GetName()
    {
        return "Rectángulo";
    }
}