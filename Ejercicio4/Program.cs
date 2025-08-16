using System;

class ProgramaUnificado
{
    // Método para multiplicar dos números
    static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    // Método para calcular área de rectángulo
    static double CalcularAreaRectangulo(double ancho, double alto)
    {
        return ancho * alto;
    }

    // Método para determinar si un número es par o impar
    static string DeterminarParImpar(int numero)
    {
        return (numero % 2 == 0) ? "par" : "impar";
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Multiplicar dos números");
            Console.WriteLine("2. Calcular área de un rectángulo");
            Console.WriteLine("3. Determinar si un número es par o impar");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            int opcionPrincipal = Convert.ToInt32(Console.ReadLine());

            switch (opcionPrincipal)
            {
                case 1: // Multiplicación
                    Console.Write("\nIngrese el primer número: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    
                    double producto = Multiplicar(num1, num2);
                    Console.WriteLine($"\nEl producto es: {producto}");
                    break;

                case 2: // Área de rectángulo
                    Console.Write("\nIngrese el ancho del rectángulo: ");
                    double ancho = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el alto del rectángulo: ");
                    double alto = Convert.ToDouble(Console.ReadLine());
                    
                    double area = CalcularAreaRectangulo(ancho, alto);
                    
                    Console.WriteLine("\nSeleccione formato de salida:");
                    Console.WriteLine("1 - Metros cuadrados");
                    Console.WriteLine("2 - Centímetros cuadrados");
                    Console.Write("Elija una opción: ");
                    
                    int opcionArea = Convert.ToInt32(Console.ReadLine());
                    
                    switch(opcionArea)
                    {
                        case 1:
                            Console.WriteLine($"\nEl área es: {area} m²");
                            break;
                        case 2:
                            Console.WriteLine($"\nEl área es: {area * 10000} cm²");
                            break;
                        default:
                            Console.WriteLine("\nOpción no válida. Mostrando en metros cuadrados...");
                            Console.WriteLine($"El área es: {area} m²");
                            break;
                    }
                    break;

                case 3: // Par o impar
                    Console.Write("\nIngrese un número entero: ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    
                    string resultado = DeterminarParImpar(numero);
                    Console.WriteLine($"\nEl número {numero} es {resultado}");
                    break;

                case 4: // Salir
                    Console.WriteLine("\nSaliendo del programa...");
                    return;

                default:
                    Console.WriteLine("\nOpción no válida. Intente nuevamente.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}