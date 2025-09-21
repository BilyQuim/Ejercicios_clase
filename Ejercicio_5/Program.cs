// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;

class Producto {
    public string Nombre;
    public double Precio;
    public Producto(string n, double p) { Nombre = n; Precio = p; }
}

class Estudiante {
    public string Nombre;
    public int Nota;
    public Estudiante(string n, int nota) { Nombre = n; Nota = nota; }
}

class Program {
    static void Main() {
        Console.WriteLine("1. Buscar producto");
        Console.WriteLine("2. Productos > Q100");
        Console.WriteLine("3. Estudiantes aprobados y promedio");
        Console.Write("Seleccione opción: ");
        
        switch (Console.ReadLine()) {
            case "1":
                List<string> productos = new List<string> { "laptop", "mouse", "teclado", "monitor" };
                Console.Write("Producto a buscar: ");
                string busqueda = Console.ReadLine().ToLower();
                string encontrado = productos.Find(p => p == busqueda);
                Console.WriteLine(encontrado != null ? "✅ Disponible" : "❌ No disponible");
                break;
                
            case "2":
                List<Producto> listaProductos = new List<Producto> {
                    new Producto("Tablet", 80), new Producto("Smartphone", 150),
                    new Producto("Auriculares", 50), new Producto("Smartwatch", 200)
                };
                var caros = listaProductos.Where(p => p.Precio > 100).ToList();
                Console.WriteLine("Productos > Q100:");
                caros.ForEach(p => Console.WriteLine($"{p.Nombre} - Q{p.Precio}"));
                break;
                
            case "3":
                List<Estudiante> estudiantes = new List<Estudiante> {
                    new Estudiante("Ana", 85), new Estudiante("Luis", 45),
                    new Estudiante("Maria", 92), new Estudiante("Carlos", 61)
                };
                var aprobados = estudiantes.Where(e => e.Nota >= 61).ToList();
                double promedio = estudiantes.Average(e => e.Nota);
                
                Console.WriteLine("Aprobados:");
                aprobados.ForEach(e => Console.WriteLine($"{e.Nombre} - {e.Nota}"));
                Console.WriteLine($"Promedio general: {promedio:F1}");
                break;
        }
    }
}