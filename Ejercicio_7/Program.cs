using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. División con validación");
        Console.WriteLine("2. Validar precio numérico");
        Console.Write("Seleccione opción: ");
        
        switch (Console.ReadLine())
        {
            case "1":
                Division();
                break;
                
            case "2":
                ValidarPrecio();
                break;
        }
    }
    
    static void Division()
    {
        try
        {
            Console.Write("Número 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Número 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            if (num2 == 0) throw new DivideByZeroException();
            
            Console.WriteLine($"Resultado: {num1 / num2}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("❌ Error: No se puede dividir por cero");
        }
        catch (FormatException)
        {
            Console.WriteLine("❌ Error: Ingrese números válidos");
        }
    }
    
    static void ValidarPrecio()
    {
        try
        {
            Console.Write("Ingrese el precio: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            
            if (precio <= 0) throw new ArgumentException();
            
            Console.WriteLine($"✅ Precio válido: Q{precio}");
        }
        catch (FormatException)
        {
            Console.WriteLine("❌ Error: Debe ingresar un número");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("❌ Error: El precio debe ser positivo");
        }
    }
}