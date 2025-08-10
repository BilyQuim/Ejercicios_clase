using System;

class Calculadora
{
    static void Main(string[] args)
    {
        bool salir = false;
        
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("=== CALCULADORA ===");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raíz cuadrada");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");
            
            string opcion = Console.ReadLine();
            
            switch (opcion)
            {
                case "1":
                    Sumar();
                    break;
                case "2":
                    Restar();
                    break;
                case "3":
                    Multiplicar();
                    break;
                case "4":
                    Dividir();
                    break;
                case "5":
                    Potencia();
                    break;
                case "6":
                    RaizCuadrada();
                    break;
                case "7":
                    salir = true;
                    Console.WriteLine("Saliendo de la calculadora...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
            
            if (!salir)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
    
    static void Sumar()
    {
        Console.WriteLine("\n=== SUMA ===");
        double num1 = PedirNumero("Ingrese el primer número: ");
        double num2 = PedirNumero("Ingrese el segundo número: ");
        Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
    }
    
    static void Restar()
    {
        Console.WriteLine("\n=== RESTA ===");
        double num1 = PedirNumero("Ingrese el primer número: ");
        double num2 = PedirNumero("Ingrese el segundo número: ");
        Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
    }
    
    static void Multiplicar()
    {
        Console.WriteLine("\n=== MULTIPLICACIÓN ===");
        double num1 = PedirNumero("Ingrese el primer número: ");
        double num2 = PedirNumero("Ingrese el segundo número: ");
        Console.WriteLine($"Resultado: {num1} × {num2} = {num1 * num2}");
    }
    
    static void Dividir()
    {
        Console.WriteLine("\n=== DIVISIÓN ===");
        double num1 = PedirNumero("Ingrese el numerador: ");
        double num2;
        
        do
        {
            num2 = PedirNumero("Ingrese el denominador (no puede ser cero): ");
            if (num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir por cero. Intente de nuevo.");
            }
        } while (num2 == 0);
        
        Console.WriteLine($"Resultado: {num1} ÷ {num2} = {num1 / num2}");
    }
    
    static void Potencia()
    {
        Console.WriteLine("\n=== POTENCIA ===");
        double baseNum = PedirNumero("Ingrese la base: ");
        double exponente = PedirNumero("Ingrese el exponente: ");
        Console.WriteLine($"Resultado: {baseNum}^{exponente} = {Math.Pow(baseNum, exponente)}");
    }
    
    static void RaizCuadrada()
    {
        Console.WriteLine("\n=== RAÍZ CUADRADA ===");
        double numero;
        
        do
        {
            numero = PedirNumero("Ingrese un número (debe ser positivo): ");
            if (numero < 0)
            {
                Console.WriteLine("Error: No se puede calcular la raíz de un número negativo. Intente de nuevo.");
            }
        } while (numero < 0);
        
        Console.WriteLine($"Resultado: √{numero} = {Math.Sqrt(numero)}");
    }
    
    static double PedirNumero(string mensaje)
    {
        double numero;
        bool esValido;
        
        do
        {
            Console.Write(mensaje);
            esValido = double.TryParse(Console.ReadLine(), out numero);
            
            if (!esValido)
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número.");
            }
        } while (!esValido);
        
        return numero;
    }
}