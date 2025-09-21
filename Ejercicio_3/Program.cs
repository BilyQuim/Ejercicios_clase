using System;

class Libro {
    public string Titulo, Autor, ISBN;
    public int Año, Paginas;
    
    public Libro(string t, string a, string i, int año, int p) {
        Titulo = t; Autor = a; ISBN = i; Año = año; Paginas = p;
    }
    
    public void Mostrar() {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Año: {Año}");
        Console.WriteLine($"Páginas: {Paginas}");
    }
}

class Program {
    static void Main() {
        Console.Write("Título: "); string t = Console.ReadLine();
        Console.Write("Autor: "); string a = Console.ReadLine();
        Console.Write("ISBN: "); string i = Console.ReadLine();
        Console.Write("Año: "); int año = int.Parse(Console.ReadLine());
        Console.Write("Páginas: "); int p = int.Parse(Console.ReadLine());
        
        Libro libro = new Libro(t, a, i, año, p);
        libro.Mostrar();
    }
}