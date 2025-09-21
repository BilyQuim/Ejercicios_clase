using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SUMA DE DOS NÚMEROS ===");
        
        // Solicitar el primer número
        Console.Write("Ingrese el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        
        // Solicitar el segundo número
        Console.Write("Ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());
        
        // Realizar la suma
        double resultado = numero1 + numero2;
        
        // Mostrar el resultado
        Console.WriteLine($"\nEl resultado de {numero1} + {numero2} = {resultado}");
        Console.ReadKey();
    }
}