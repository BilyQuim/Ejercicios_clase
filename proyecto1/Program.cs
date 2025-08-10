using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar) // bucle para mostrar el menu 
        { // se llama al menu 
            MostrarMenu();
            // se solicita ingresar el valor a usar al usuario 
            string opcion = Console.ReadLine();
            // case de donde se ralizan las operaciones 
            switch (opcion)
            {
                case "1":
                    RealizarOperacion("Suma", (a, b) => a + b);
                    break;
                case "2":
                    RealizarOperacion("Resta", (a, b) => a - b);
                    break;
                case "3":
                    RealizarOperacion("Multiplicación", (a, b) => a * b);
                    break;
                case "4":
                    RealizarOperacion("División", Dividir);
                    break;
                case "5":
                    continuar = false;
                    Console.WriteLine("\nGracias por usar la calculadora. ¡Hasta pronto!");
                    break;
                case "6":
                    CalcularFactorial();
                    break;
                default:
                    Console.WriteLine("\nOpción no válida. Por favor, seleccione 1-6.");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    static void MostrarMenu() // creacion de menu de metodo 
    {
        Console.WriteLine("=== CALCULADORA BÁSICA ===");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Salir");
        Console.WriteLine("6. Factorial");
        Console.Write("Seleccione una opción (1-6): ");
    }
    // metodo para el ingreso de valores para los calculos 
    static void RealizarOperacion(string nombreOperacion, Func<double, double, double> operacion)
    {
        Console.WriteLine($"\n** {nombreOperacion} **");

        try
        {
            double num1 = ObtenerNumero("Ingrese el primer número: ");
            double num2 = ObtenerNumero("Ingrese el segundo número: ");

            double resultado = operacion(num1, num2);

            if (!double.IsNaN(resultado))
            {
                Console.WriteLine($"\nResultado: {resultado.ToString("0.##")}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Por favor ingrese números válidos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
    }

    static double ObtenerNumero(string mensaje)
    {
        Console.Write(mensaje);
        return Convert.ToDouble(Console.ReadLine());
    }
    // verificacion del error en entre 0
    static double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
            return double.NaN;
        }
        return a / b;
    }

    // metodo para calcular factorial
    static void CalcularFactorial()
    {
        Console.WriteLine("\n** Factorial **");
        try
        {
            int numero = (int)ObtenerNumero("Ingrese un número entero no negativo: ");
            if (numero < 0)
            {
                Console.WriteLine("Error: El número debe ser no negativo.");
                return;
            }

            long resultado = 1;
            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }

            Console.WriteLine($"\nEl factorial de {numero} es: {resultado}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Por favor ingrese un número entero válido.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
    }
}