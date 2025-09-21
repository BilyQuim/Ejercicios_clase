using System;
using System.Collections.Generic;
using System.Linq;

class Estudiante {
    public string Nombre;
    public int Nota;
    public int Edad;
    public double Estatura;
    
    public Estudiante(string n, int nota, int e = 0, double est = 0) {
        Nombre = n; Nota = nota; Edad = e; Estatura = est;
    }
}

class Program {
    static void Main() {
        Console.WriteLine("1. Estudiantes aprobados (nota ≥ 61)");
        Console.WriteLine("2. Estudiantes mayores de edad y >1.65m");
        Console.Write("Seleccione opción: ");
        
        switch (Console.ReadLine()) {
            case "1":
                List<Estudiante> estudiantes1 = new List<Estudiante> {
                    new Estudiante("Ana", 85), new Estudiante("Luis", 45),
                    new Estudiante("Maria", 92), new Estudiante("Carlos", 61),
                    new Estudiante("Pedro", 58)
                };
                
                var aprobados = from e in estudiantes1 
                               where e.Nota >= 61 
                               select e;
                               
                Console.WriteLine("Estudiantes aprobados:");
                foreach (var e in aprobados)
                    Console.WriteLine($"{e.Nombre} - Nota: {e.Nota}");
                break;
                
            case "2":
                List<Estudiante> estudiantes2 = new List<Estudiante> {
                    new Estudiante("Juan", 70, 17, 1.70),
                    new Estudiante("Sofia", 80, 19, 1.60),
                    new Estudiante("Diego", 65, 20, 1.75),
                    new Estudiante("Laura", 75, 16, 1.68),
                    new Estudiante("Miguel", 85, 18, 1.72)
                };
                
                var filtrados = from e in estudiantes2 
                               where e.Edad >= 18 && e.Estatura > 1.65 
                               select e;
                               
                Console.WriteLine("Mayores de edad y >1.65m:");
                foreach (var e in filtrados)
                    Console.WriteLine($"{e.Nombre} - Edad: {e.Edad}, Estatura: {e.Estatura}m");
                break;
        }
    }
}