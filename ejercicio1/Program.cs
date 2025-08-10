using System;

class Program
{
    static void Main()
    {
        // Pedir al usuario que ingrese el primer número
        Console.Write("Ingrese el primer numero: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        
        // Pedir al usuario que ingrese el segundo número
        Console.Write("Ingrese el segundo numero: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());
        
        // Calcular la suma
        double suma = numero1 + numero2;
        
        // Mostrar el resultado
        Console.WriteLine($"La suma de {numero1} y {numero2} es: {suma}");
        
        // Esperar a que el usuario presione una tecla para salir
        Console.ReadKey();
    }
}