using System;
using System.Collections.Generic;
using System.Linq;

// Clase Estudiante para ambos ejercicios
public class Estudiante
{
    public string Nombre { get; set; }
    public int Nota { get; set; }
    public int Edad { get; set; }
    public double Estatura { get; set; } // en metros

    public Estudiante(string nombre, int nota, int edad, double estatura)
    {
        Nombre = nombre;
        Nota = nota;
        Edad = edad;
        Estatura = estatura;
    }
}

class Program
{
    static void Main()
    {
        // Crear lista de estudiantes con datos para ambos ejercicios
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante("Ana García", 85, 20, 1.68),
            new Estudiante("Luis Martínez", 45, 17, 1.72),
            new Estudiante("María López", 92, 22, 1.60),
            new Estudiante("Carlos Rodríguez", 60, 19, 1.75),
            new Estudiante("Sofía Hernández", 78, 16, 1.63),
            new Estudiante("Juan Pérez", 55, 18, 1.80),
            new Estudiante("Laura Díaz", 88, 21, 1.67),
            new Estudiante("Miguel Castro", 61, 20, 1.70),
            new Estudiante("Elena Ruiz", 95, 17, 1.58),
            new Estudiante("Pedro Sánchez", 72, 19, 1.82),
            new Estudiante("Carmen Vargas", 80, 18, 1.66),
            new Estudiante("Jorge Molina", 59, 16, 1.69),
            new Estudiante("Isabel Torres", 90, 21, 1.71),
            new Estudiante("Ricardo Flores", 65, 22, 1.64),
            new Estudiante("Diana Romero", 75, 19, 1.73)
        };

        // Ejercicio 1: Mostrar estudiantes aprobados (nota ≥ 61) usando LINQ
        Console.WriteLine("=== EJERCICIO 1: ESTUDIANTES APROBADOS (NOTA ≥ 61) ===");
        Console.WriteLine("Usando consulta LINQ con sintaxis de método:\n");

        var aprobadosMetodo = estudiantes
            .Where(e => e.Nota >= 61)
            .OrderByDescending(e => e.Nota)
            .ToList();

        Console.WriteLine("Estudiantes aprobados (ordenados por nota descendente):");
        foreach (var estudiante in aprobadosMetodo)
        {
            Console.WriteLine($"- {estudiante.Nombre}: {estudiante.Nota} puntos");
        }

        Console.WriteLine("\n" + new string('-', 60));

        // Ejercicio 1 alternativo: Usando sintaxis de consulta SQL-like
        Console.WriteLine("\nUsando consulta LINQ con sintaxis de consulta:\n");

        var aprobadosConsulta = (from e in estudiantes
                                where e.Nota >= 61
                                orderby e.Nota descending
                                select e).ToList();

        Console.WriteLine("Estudiantes aprobados (sintaxis de consulta):");
        foreach (var estudiante in aprobadosConsulta)
        {
            Console.WriteLine($"- {estudiante.Nombre}: {estudiante.Nota} puntos");
        }

        Console.WriteLine("\n" + new string('=', 60) + "\n");

        // Ejercicio 2: Mostrar estudiantes mayores de edad y estatura > 1.65m usando LINQ
        Console.WriteLine("=== EJERCICIO 2: ESTUDIANTES MAYORES DE EDAD Y ALTURA > 1.65m ===");
        Console.WriteLine("Usando consulta LINQ con sintaxis de método:\n");

        var filtradosMetodo = estudiantes
            .Where(e => e.Edad >= 18 && e.Estatura > 1.65)
            .OrderBy(e => e.Nombre)
            .ToList();

        Console.WriteLine("Estudiantes mayores de edad (≥18) y con estatura > 1.65m:");
        Console.WriteLine("{0,-20} {1,-8} {2,-10} {3,-10}", "Nombre", "Edad", "Estatura", "Nota");
        Console.WriteLine(new string('-', 50));
        
        foreach (var estudiante in filtradosMetodo)
        {
            Console.WriteLine("{0,-20} {1,-8} {2,-10}m {3,-10}", 
                            estudiante.Nombre, 
                            estudiante.Edad, 
                            estudiante.Estatura.ToString("0.00"), 
                            estudiante.Nota);
        }

        Console.WriteLine("\n" + new string('-', 60));

        // Ejercicio 2 alternativo: Usando sintaxis de consulta SQL-like
        Console.WriteLine("\nUsando consulta LINQ con sintaxis de consulta:\n");

        var filtradosConsulta = (from e in estudiantes
                                where e.Edad >= 18 && e.Estatura > 1.65
                                orderby e.Nombre
                                select e).ToList();

        Console.WriteLine("Estudiantes mayores de edad y altos (sintaxis de consulta):");
        Console.WriteLine("{0,-20} {1,-8} {2,-10} {3,-10}", "Nombre", "Edad", "Estatura", "Nota");
        Console.WriteLine(new string('-', 50));
        
        foreach (var estudiante in filtradosConsulta)
        {
            Console.WriteLine("{0,-20} {1,-8} {2,-10}m {3,-10}", 
                            estudiante.Nombre, 
                            estudiante.Edad, 
                            estudiante.Estatura.ToString("0.00"), 
                            estudiante.Nota);
        }

        // Estadísticas adicionales
        Console.WriteLine("\n" + new string('=', 60));
        Console.WriteLine("📊 ESTADÍSTICAS ADICIONALES:");

        var totalAprobados = estudiantes.Count(e => e.Nota >= 61);
        var totalMayoresAltos = estudiantes.Count(e => e.Edad >= 18 && e.Estatura > 1.65);
        var promedioNotas = estudiantes.Average(e => e.Nota);
        var promedioEdad = estudiantes.Average(e => e.Edad);
        var promedioEstatura = estudiantes.Average(e => e.Estatura);

        Console.WriteLine($"Total de estudiantes: {estudiantes.Count}");
        Console.WriteLine($"Estudiantes aprobados: {totalAprobados}");
        Console.WriteLine($"Mayores de edad y altos: {totalMayoresAltos}");
        Console.WriteLine($"Promedio de notas: {promedioNotas:F2}");
        Console.WriteLine($"Promedio de edad: {promedioEdad:F1} años");
        Console.WriteLine($"Promedio de estatura: {promedioEstatura:F2}m");

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}