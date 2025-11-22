using System;
using BibliotecaDescuentos;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE FACTURACIÓN ===");
        Console.Write("Ingrese el total de la compra: Q. ");
        decimal total = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("\nTipo de cliente:");
        Console.WriteLine("1. Regular");
        Console.WriteLine("2. VIP");
        Console.WriteLine("3. Empleado");
        Console.Write("Seleccione opción: ");
        int tipo = Convert.ToInt32(Console.ReadLine());

        IDescuento descuento;

        switch (tipo)
        {
            case 1: descuento = new DescuentoRegular(); break;
            case 2: descuento = new DescuentoVIP(); break;
            case 3: descuento = new DescuentoEmpleado(); break;
            default:
                Console.WriteLine("Opción no válida.");
                return;
        }

        decimal totalFinal = descuento.AplicarDescuento(total);
        Console.WriteLine($"\nTotal a pagar con descuento: Q. {totalFinal}");
    }
}
