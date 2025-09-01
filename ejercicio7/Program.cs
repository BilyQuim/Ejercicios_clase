using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== EJERCICIOS DE MANEJO DE EXCEPCIONES ===");
        Console.WriteLine("1. División de números");
        Console.WriteLine("2. Validación de precio");
        Console.WriteLine("3. Salir");
        
        bool continuar = true;
        
        while (continuar)
        {
            Console.Write("\nSeleccione una opción (1-3): ");
            string opcion = Console.ReadLine();
            
            switch (opcion)
            {
                case "1":
                    EjercicioDivision();
                    break;
                case "2":
                    EjercicioPrecio();
                    break;
                case "3":
                    continuar = false;
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }
    
    // Ejercicio 1: División de números con manejo de excepciones
    static void EjercicioDivision()
    {
        Console.WriteLine("\n" + new string('=', 50));
        Console.WriteLine("EJERCICIO 1: DIVISIÓN DE NÚMEROS");
        Console.WriteLine(new string('=', 50));
        
        try
        {
            Console.Write("Ingrese el primer número (dividendo): ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Ingrese el segundo número (divisor): ");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            
            // Validar explícitamente que el divisor no sea cero
            if (numero2 == 0)
            {
                throw new DivideByZeroException("Error: No se puede dividir entre cero.");
            }
            
            double resultado = numero1 / numero2;
            Console.WriteLine($"✅ Resultado: {numero1} / {numero2} = {resultado:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("❌ Error: Debe ingresar números válidos.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"❌ {ex.Message}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("❌ Error: El número ingresado es demasiado grande o pequeño.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error inesperado: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Operación de división finalizada.");
        }
    }
    
    // Ejercicio 2: Validación de precio con manejo de excepciones
    static void EjercicioPrecio()
    {
        Console.WriteLine("\n" + new string('=', 50));
        Console.WriteLine("EJERCICIO 2: VALIDACIÓN DE PRECIO");
        Console.WriteLine(new string('=', 50));
        
        bool precioValido = false;
        double precio = 0;
        
        while (!precioValido)
        {
            try
            {
                Console.Write("Ingrese el precio del producto: ");
                string input = Console.ReadLine();
                
                // Intentar convertir el input a número
                precio = Convert.ToDouble(input);
                
                // Validar que el precio sea positivo
                if (precio <= 0)
                {
                    throw new ArgumentOutOfRangeException("precio", "El precio debe ser mayor que cero.");
                }
                
                // Si llegamos aquí, el precio es válido
                precioValido = true;
                Console.WriteLine($"✅ Precio válido: Q{precio:F2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("❌ Error: Debe ingresar un valor numérico válido.");
                Console.WriteLine("   Ejemplos válidos: 100, 50.50, 25.75");
            }
            catch (OverflowException)
            {
                Console.WriteLine("❌ Error: El precio ingresado es demasiado grande.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error inesperado: {ex.Message}");
            }
        }
        
        // Mostrar información adicional basada en el precio
        Console.WriteLine("\n📋 Información del precio:");
        Console.WriteLine($"Precio base: Q{precio:F2}");
        
        if (precio > 1000)
        {
            double descuento = precio * 0.10;
            double precioFinal = precio - descuento;
            Console.WriteLine($"Descuento (10%): Q{descuento:F2}");
            Console.WriteLine($"Precio final: Q{precioFinal:F2}");
        }
        else if (precio > 500)
        {
            double descuento = precio * 0.05;
            double precioFinal = precio - descuento;
            Console.WriteLine($"Descuento (5%): Q{descuento:F2}");
            Console.WriteLine($"Precio final: Q{precioFinal:F2}");
        }
        else
        {
            Console.WriteLine("No aplica descuento.");
        }
    }
}