using System;
using System.Collections.Generic;
using System.Linq;

// Clase Producto para el segundo ejercicio
public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    public Producto(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

// Clase Estudiante para el tercer ejercicio
public class Estudiante
{
    public string Nombre { get; set; }
    public int Nota { get; set; }

    public Estudiante(string nombre, int nota)
    {
        Nombre = nombre;
        Nota = nota;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== EJERCICIOS CON LISTAS ===");
        
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("\nSeleccione un ejercicio:");
            Console.WriteLine("1. Búsqueda de productos en lista");
            Console.WriteLine("2. Productos con precio mayor a Q100");
            Console.WriteLine("3. Estudiantes aprobados y promedio");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");
            
            string opcion = Console.ReadLine();
            
            switch (opcion)
            {
                case "1":
                    Ejercicio1();
                    break;
                case "2":
                    Ejercicio2();
                    break;
                case "3":
                    Ejercicio3();
                    break;
                case "4":
                    continuar = false;
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }

    // Ejercicio 1: Búsqueda de productos en lista
    static void Ejercicio1()
    {
        Console.WriteLine("\n" + new string('=', 50));
        Console.WriteLine("EJERCICIO 1: BÚSQUEDA DE PRODUCTOS");
        Console.WriteLine(new string('=', 50));
        
        // Crear lista de productos
        List<string> productos = new List<string>
        {
            "laptop", "mouse", "teclado", "monitor", "audifonos",
            "tablet", "impresora", "camara", "altavoz", "router"
        };

        // Mostrar productos disponibles
        Console.WriteLine("📦 Productos disponibles en la tienda:");
        foreach (var producto in productos)
        {
            Console.WriteLine($"- {producto}");
        }

        // Solicitar producto a buscar
        Console.Write("\n🔍 Ingrese el nombre del producto a buscar: ");
        string productoBuscado = Console.ReadLine().ToLower().Trim();

        // Buscar producto usando .Find()
        string productoEncontrado = productos.Find(p => 
            p.Equals(productoBuscado, StringComparison.OrdinalIgnoreCase));

        // Mostrar resultado
        if (productoEncontrado != null)
        {
            Console.WriteLine($"✅ El producto '{productoEncontrado}' SÍ está disponible.");
        }
        else
        {
            Console.WriteLine($"❌ El producto '{productoBuscado}' NO está disponible.");
            Console.WriteLine("💡 Sugerencia: Verifique la ortografía o busque otro producto.");
        }
    }

    // Ejercicio 2: Productos con precio mayor a Q100
    static void Ejercicio2()
    {
        Console.WriteLine("\n" + new string('=', 50));
        Console.WriteLine("EJERCICIO 2: PRODUCTOS CON PRECIO > Q100");
        Console.WriteLine(new string('=', 50));
        
        // Crear lista de objetos Producto
        List<Producto> listaProductos = new List<Producto>
        {
            new Producto("Laptop", 4500.50m),
            new Producto("Mouse", 85.00m),
            new Producto("Teclado", 250.75m),
            new Producto("Monitor", 1200.00m),
            new Producto("Audífonos", 95.00m),
            new Producto("Tablet", 800.00m),
            new Producto("Impresora", 350.25m),
            new Producto("Cámara", 1800.00m),
            new Producto("Altavoz", 75.50m),
            new Producto("Router", 150.00m)
        };

        // Mostrar todos los productos
        Console.WriteLine("🛒 Todos los productos:");
        Console.WriteLine("{0,-15} {1,-10}", "Producto", "Precio");
        Console.WriteLine(new string('-', 25));
        foreach (var producto in listaProductos)
        {
            Console.WriteLine("{0,-15} Q{1,-10:F2}", producto.Nombre, producto.Precio);
        }

        // Filtrar productos con precio mayor a Q100
        var productosCaros = listaProductos.Where(p => p.Precio > 100).ToList();

        Console.WriteLine("\n💰 Productos que cuestan más de Q100:");
        if (productosCaros.Count > 0)
        {
            Console.WriteLine("{0,-15} {1,-10}", "Producto", "Precio");
            Console.WriteLine(new string('-', 25));
            foreach (var producto in productosCaros.OrderByDescending(p => p.Precio))
            {
                Console.WriteLine("{0,-15} Q{1,-10:F2}", producto.Nombre, producto.Precio);
            }
            
            // Estadísticas adicionales
            decimal total = productosCaros.Sum(p => p.Precio);
            decimal promedio = productosCaros.Average(p => p.Precio);
            Console.WriteLine($"\n📊 Total: Q{total:F2}");
            Console.WriteLine($"📊 Promedio: Q{promedio:F2}");
        }
        else
        {
            Console.WriteLine("No hay productos con precio mayor a Q100.");
        }
    }

    // Ejercicio 3: Estudiantes aprobados y promedio
    static void Ejercicio3()
    {
        Console.WriteLine("\n" + new string('=', 50));
        Console.WriteLine("EJERCICIO 3: ESTUDIANTES APROBADOS Y PROMEDIO");
        Console.WriteLine(new string('=', 50));
        
        // Crear lista de estudiantes
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante("Ana García", 85),
            new Estudiante("Luis Martínez", 45),
            new Estudiante("María López", 92),
            new Estudiante("Carlos Rodríguez", 60),
            new Estudiante("Sofía Hernández", 78),
            new Estudiante("Juan Pérez", 55),
            new Estudiante("Laura Díaz", 88),
            new Estudiante("Miguel Castro", 61),
            new Estudiante("Elena Ruiz", 95),
            new Estudiante("Pedro Sánchez", 72)
        };

        // Mostrar todos los estudiantes
        Console.WriteLine("🎓 Lista completa de estudiantes:");
        Console.WriteLine("{0,-20} {1,-5}", "Estudiante", "Nota");
        Console.WriteLine(new string('-', 25));
        foreach (var estudiante in estudiantes)
        {
            string estado = estudiante.Nota >= 61 ? "✅" : "❌";
            Console.WriteLine("{0,-20} {1,-5} {2}", estudiante.Nombre, estudiante.Nota, estado);
        }

        // Filtrar estudiantes aprobados (nota ≥ 61)
        var aprobados = estudiantes.Where(e => e.Nota >= 61).ToList();

        Console.WriteLine("\n🎉 Estudiantes aprobados (nota ≥ 61):");
        if (aprobados.Count > 0)
        {
            Console.WriteLine("{0,-20} {1,-5}", "Estudiante", "Nota");
            Console.WriteLine(new string('-', 25));
            foreach (var estudiante in aprobados.OrderByDescending(e => e.Nota))
            {
                Console.WriteLine("{0,-20} {1,-5}", estudiante.Nombre, estudiante.Nota);
            }
        }
        else
        {
            Console.WriteLine("No hay estudiantes aprobados.");
        }

        // Calcular promedio general
        double promedioGeneral = estudiantes.Average(e => e.Nota);
        int totalEstudiantes = estudiantes.Count;
        int totalAprobados = aprobados.Count;
        int totalReprobados = totalEstudiantes - totalAprobados;

        Console.WriteLine("\n📊 ESTADÍSTICAS:");
        Console.WriteLine($"Total de estudiantes: {totalEstudiantes}");
        Console.WriteLine($"Estudiantes aprobados: {totalAprobados}");
        Console.WriteLine($"Estudiantes reprobados: {totalReprobados}");
        Console.WriteLine($"Promedio general: {promedioGeneral:F2}");

        // Información adicional
        if (promedioGeneral >= 61)
        {
            Console.WriteLine("🎯 El grupo tiene un buen desempeño general.");
        }
        else
        {
            Console.WriteLine("⚠️ El grupo necesita mejorar su desempeño.");
        }
    }
}