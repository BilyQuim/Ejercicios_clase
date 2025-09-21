using System;

class Calculadora
{
    static void Main()
    {
        bool continuar = true;
        
        while (continuar)
        {
            Console.Clear();
            MostrarMenu();
            
            Console.Write("Seleccione una opción (1-5): ");
            string opcion = Console.ReadLine();
            
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
                    RealizarDivision();
                    break;
                case "5":
                    continuar = false;
                    Console.WriteLine("¡Gracias por usar la calculadora!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }
    
    static void MostrarMenu()
    {
        Console.WriteLine("=== CALCULADORA ===");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.WriteLine("5. Salir");
        Console.WriteLine("===================");
    }
    
    static void RealizarOperacion(string nombreOperacion, Func<double, double, double> operacion)
    {
        Console.WriteLine($"\n--- {nombreOperacion} ---");
        
        double num1 = SolicitarNumero("primer");
        double num2 = SolicitarNumero("segundo");
        
        double resultado = operacion(num1, num2);
        
        Console.WriteLine($"\nResultado: {num1} {GetOperador(nombreOperacion)} {num2} = {resultado}");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }
    
    static void RealizarDivision()
    {
        Console.WriteLine("\n--- División ---");
        
        double num1 = SolicitarNumero("dividendo");
        double num2;
        
        // Validar que el divisor no sea cero
        while (true)
        {
            num2 = SolicitarNumero("divisor");
            if (num2 != 0)
                break;
            Console.WriteLine("Error: No se puede dividir por cero. Intente nuevamente.");
        }
        
        double resultado = num1 / num2;
        
        Console.WriteLine($"\nResultado: {num1} / {num2} = {resultado}");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }
    
    static double SolicitarNumero(string mensaje)
    {
        double numero;
        while (true)
        {
            Console.Write($"Ingrese el {mensaje} número: ");
            if (double.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }
            Console.WriteLine("Error: Por favor ingrese un número válido.");
        }
    }
    
    static string GetOperador(string operacion)
    {
        return operacion switch
        {
            "Suma" => "+",
            "Resta" => "-",
            "Multiplicación" => "*",
            "División" => "/",
            _ => "?"
        };
    }
}