using System;

namespace CalculoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de cálculo de salarios.");

            while (true)
            {
                Console.WriteLine("\nSeleccione el tipo de trabajador:");
                Console.WriteLine("1. Docente por hora");
                Console.WriteLine("2. Docente de contrato fijo");
                Console.WriteLine("3. Empleado administrativo");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");
                string? opcion = Console.ReadLine();

                if (opcion == "4")
                {
                    Console.WriteLine("Saliendo del programa...");
                    break;
                }

                if (string.IsNullOrEmpty(opcion))
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    continue;
                }

                Console.Write("Ingrese el nombre del trabajador: ");
                string? nombre = Console.ReadLine();

                if (string.IsNullOrEmpty(nombre))
                {
                    Console.WriteLine("El nombre no puede estar vacío. Intente de nuevo.");
                    continue;
                }

                Console.Write("¿Alcanzó la meta? (Sí/No): ");
                string? metaInput = Console.ReadLine();
                bool alcanzoMeta = metaInput?.ToLower() == "sí" || metaInput?.ToLower() == "si";

                Empleado? empleado = null;

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese la cantidad de horas trabajadas: ");
                        string? horasInput = Console.ReadLine();
                        if (int.TryParse(horasInput, out int horasTrabajadas))
                        {
                            empleado = new DocentePorHora(nombre, alcanzoMeta, horasTrabajadas);
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida para horas trabajadas.");
                        }
                        break;

                    case "2":
                        Console.Write("Ingrese el salario base: ");
                        string? salarioBaseDocenteInput = Console.ReadLine();
                        if (double.TryParse(salarioBaseDocenteInput, out double salarioBaseDocente))
                        {
                            empleado = new DocenteContratoFijo(nombre, alcanzoMeta, salarioBaseDocente);
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida para salario base.");
                        }
                        break;

                    case "3":
                        Console.Write("Ingrese el salario base: ");
                        string? salarioBaseAdminInput = Console.ReadLine();
                        if (double.TryParse(salarioBaseAdminInput, out double salarioBaseAdmin))
                        {
                            empleado = new EmpleadoAdministrativo(nombre, alcanzoMeta, salarioBaseAdmin);
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida para salario base.");
                        }
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        continue;
                }

                if (empleado != null)
                {
                    double salario = empleado.CalcularSalario();
                    Console.WriteLine($"\nEl salario de {empleado.Nombre} es: {salario:C}");
                }
            }
        }
    }
}