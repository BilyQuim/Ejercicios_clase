using System;

class Libro
{
    // Atributos de la clase
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnioPublicacion { get; set; }
    public string Genero { get; set; }
    public int Paginas { get; set; }

    // Método para mostrar los datos del libro
    public void MostrarDatos()
    {
        Console.WriteLine("\n=== Información del Libro ===");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Año de publicación: {AnioPublicacion}");
        Console.WriteLine($"Género: {Genero}");
        Console.WriteLine($"Páginas: {Paginas}");
        Console.WriteLine("============================");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear un nuevo objeto Libro
        Libro miLibro = new Libro();

        Console.WriteLine("Ingrese los datos del libro:");

        // Solicitar datos al usuario
        Console.Write("Título: ");
        miLibro.Titulo = Console.ReadLine();

        Console.Write("Autor: ");
        miLibro.Autor = Console.ReadLine();

        Console.Write("Año de publicación: ");
        miLibro.AnioPublicacion = int.Parse(Console.ReadLine());

        Console.Write("Género: ");
        miLibro.Genero = Console.ReadLine();

        Console.Write("Número de páginas: ");
        miLibro.Paginas = int.Parse(Console.ReadLine());

        // Mostrar los datos del libro
        miLibro.MostrarDatos();

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}