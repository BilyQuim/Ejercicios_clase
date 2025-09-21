using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Verificar votación");
        Console.WriteLine("2. Verificar día de semana");
        Console.WriteLine("3. Tabla del 7");
        Console.Write("Seleccione opción: ");
        
        switch (Console.ReadLine())
        {
            case "1":
                Console.Write("Ingrese su edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(edad >= 18 ? "Puede votar ✅" : "No puede votar ❌");
                break;
                
            case "2":
                Console.Write("Ingrese el día (1-7 donde 1=Lunes): ");
                int dia = Convert.ToInt32(Console.ReadLine());
                string resultado = dia switch
                {
                    1 or 2 => "Inicio de Semana",
                    3 or 4 or 5 => "Mediados de Semana",
                    6 or 7 => "Fin de semana",
                    _ => "Día no válido"
                };
                Console.WriteLine(resultado);
                break;
                
            case "3":
                for (int i = 1; i <= 10; i++)
                    Console.WriteLine($"7 × {i} = {7 * i}");
                break;
        }
    }
}