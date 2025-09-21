using System;

class CalculadoraAvanzada
{
    static void Main()
    {
        bool continuar = true;
        
        while (continuar)
        {
            Console.Clear();
            MostrarMenuAvanzado();
            
            Console.Write("Seleccione una opción (1-9): ");
            string opcion = Console.ReadLine();
            
            switch (opcion)
            {
                case "1": Suma(); break;
                case "2": Resta(); break;
                case "3": Multiplicacion(); break;
                case "4": Division(); break;
                case "5": Potencia(); break;
                case "6": RaizCuadrada(); break;
                case "7": Porcentaje(); break;
                case "8": Modulo(); break;
                case "9": continuar = false; break;
                default:
                    Console.WriteLine("Opción no válida. Presione cualquier tecla...");
                    Console.ReadKey();
                    break;
            }
            
            if (opcion != "9" && opcion != "0")
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
        
        Console.WriteLine("¡Hasta pronto!");
    }
    
    static void MostrarMenuAvanzado()
    {
        Console.WriteLine("=== CALCULADORA AVANZADA ===");
        Console.WriteLine("1.  Suma (+)");
        Console.WriteLine("2.  Resta (-)");
        Console.WriteLine("3.  Multiplicación (*)");
        Console.WriteLine("4.  División (/)");
        Console.WriteLine("5.  Potencia (x^y)");
        Console.WriteLine("6.  Raíz Cuadrada (√)");
        Console.WriteLine("7.  Porcentaje (%)");
        Console.WriteLine("8.  Módulo (mod)");
        Console.WriteLine("9.  Salir");
        Console.WriteLine("============================");
    }
    
    static double SolicitarNumero(string mensaje)
    {
        double numero;
        while (true)
        {
            Console.Write($"Ingrese {mensaje}: ");
            if (double.TryParse(Console.ReadLine(), out numero))
                return numero;
            Console.WriteLine("Error: Ingrese un número válido.");
        }
    }
    
    static void Suma()
    {
        Console.WriteLine("\n--- SUMA ---");
        double a = SolicitarNumero("el primer número");
        double b = SolicitarNumero("el segundo número");
        Console.WriteLine($"Resultado: {a} + {b} = {a + b}");
    }
    
    static void Resta()
    {
        Console.WriteLine("\n--- RESTA ---");
        double a = SolicitarNumero("el primer número");
        double b = SolicitarNumero("el segundo número");
        Console.WriteLine($"Resultado: {a} - {b} = {a - b}");
    }
    
    static void Multiplicacion()
    {
        Console.WriteLine("\n--- MULTIPLICACIÓN ---");
        double a = SolicitarNumero("el primer número");
        double b = SolicitarNumero("el segundo número");
        Console.WriteLine($"Resultado: {a} × {b} = {a * b}");
    }
    
    static void Division()
    {
        Console.WriteLine("\n--- DIVISIÓN ---");
        double a = SolicitarNumero("el dividendo");
        double b;
        do
        {
            b = SolicitarNumero("el divisor");
            if (b == 0) Console.WriteLine("Error: No se puede dividir por cero.");
        } while (b == 0);
        
        Console.WriteLine($"Resultado: {a} ÷ {b} = {a / b}");
    }
    
    static void Potencia()
    {
        Console.WriteLine("\n--- POTENCIA ---");
        double baseNum = SolicitarNumero("la base");
        double exponente = SolicitarNumero("el exponente");
        Console.WriteLine($"Resultado: {baseNum} ^ {exponente} = {Math.Pow(baseNum, exponente)}");
    }
    
    static void RaizCuadrada()
    {
        Console.WriteLine("\n--- RAÍZ CUADRADA ---");
        double numero;
        do
        {
            numero = SolicitarNumero("el número");
            if (numero < 0) Console.WriteLine("Error: No se puede calcular raíz de número negativo.");
        } while (numero < 0);
        
        Console.WriteLine($"Resultado: √{numero} = {Math.Sqrt(numero)}");
    }
    
    static void Porcentaje()
    {
        Console.WriteLine("\n--- PORCENTAJE ---");
        double numero = SolicitarNumero("el número");
        double porcentaje = SolicitarNumero("el porcentaje");
        double resultado = (numero * porcentaje) / 100;
        Console.WriteLine($"Resultado: {porcentaje}% de {numero} = {resultado}");
    }
    
    static void Modulo()
    {
        Console.WriteLine("\n--- MÓDULO ---");
        double a = SolicitarNumero("el primer número");
        double b = SolicitarNumero("el segundo número");
        if (b == 0)
        {
            Console.WriteLine("Error: División por cero en módulo.");
            return;
        }
        Console.WriteLine($"Resultado: {a} mod {b} = {a % b}");
    }
}