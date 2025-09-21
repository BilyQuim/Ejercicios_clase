using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Producto de dos números");
        Console.WriteLine("2. Área de rectángulo");
        Console.WriteLine("3. Par o Impar");
        Console.WriteLine("4. Valor total de producto");
        Console.Write("Seleccione opción: ");
        
        switch (Console.ReadLine())
        {
            case "1":
                Console.Write("Número 1: "); double a = double.Parse(Console.ReadLine());
                Console.Write("Número 2: "); double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"Producto: {Producto(a, b)}");
                break;
                
            case "2":
                Console.Write("Ancho: "); double ancho = double.Parse(Console.ReadLine());
                Console.Write("Alto: "); double alto = double.Parse(Console.ReadLine());
                Console.WriteLine($"Área: {AreaRectangulo(ancho, alto)}");
                break;
                
            case "3":
                Console.Write("Número: "); int num = int.Parse(Console.ReadLine());
                Console.WriteLine(ParImpar(num));
                break;
                
            case "4":
                Console.Write("Descripción: "); string desc = Console.ReadLine();
                Console.Write("Precio: "); double precio = double.Parse(Console.ReadLine());
                Console.Write("Cantidad: "); int cant = int.Parse(Console.ReadLine());
                Console.WriteLine($"Total: {ValorTotal(desc, precio, cant):C}");
                break;
        }
    }
    
    static double Producto(double x, double y) => x * y;
    
    static double AreaRectangulo(double a, double b) => a * b;
    
    static string ParImpar(int n) => n % 2 == 0 ? "Par" : "Impar";
    
    static double ValorTotal(string desc, double precio, int cant)
    {
        Console.WriteLine($"Producto: {desc}");
        return precio * cant;
    }
}