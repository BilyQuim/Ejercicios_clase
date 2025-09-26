using System;
using System.Collections.Generic;

namespace Ejercicio10Polimorfismo
{
    // ===== EJERCICIO 1: CLASE ABSTRACTA FIGURA =====
    
    // Clase abstracta Figura
    public abstract class Figura
    {
        public abstract double CalcularArea();
        
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Área: {CalcularArea():F2}");
        }
    }
    
    // Clase Circulo que implementa Figura
    public class Circulo : Figura
    {
        public double Radio { get; set; }
        
        public Circulo(double radio)
        {
            Radio = radio;
        }
        
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
        
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Círculo - Radio: {Radio:F2}");
            base.MostrarInformacion();
        }
    }
    
    // Clase Rectangulo que implementa Figura
    public class Rectangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        
        public Rectangulo(double baseRect, double altura)
        {
            Base = baseRect;
            Altura = altura;
        }
        
        public override double CalcularArea()
        {
            return Base * Altura;
        }
        
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Rectángulo - Base: {Base:F2}, Altura: {Altura:F2}");
            base.MostrarInformacion();
        }
    }
    
    // ===== EJERCICIO 2: CLASE BASE CON MÉTODO VIRTUAL =====
    
    // Clase base con método virtual
    public class Animal
    {
        public string Nombre { get; set; }
        
        public Animal(string nombre)
        {
            Nombre = nombre;
        }
        
        // Método virtual que puede ser sobrescrito
        public virtual void HacerSonido()
        {
            Console.WriteLine($"{Nombre} hace un sonido genérico");
        }
        
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Animal: {Nombre}");
        }
    }
    
    // Primera clase derivada que sobrescribe el método
    public class Perro : Animal
    {
        public string Raza { get; set; }
        
        public Perro(string nombre, string raza) : base(nombre)
        {
            Raza = raza;
        }
        
        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} ({Raza}) dice: ¡Guau Guau!");
        }
        
        public override void MostrarInfo()
        {
            Console.WriteLine($"Perro: {Nombre} - Raza: {Raza}");
        }
    }
    
    // Segunda clase derivada que sobrescribe el método
    public class Gato : Animal
    {
        public int Vidas { get; set; }
        
        public Gato(string nombre, int vidas = 7) : base(nombre)
        {
            Vidas = vidas;
        }
        
        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} ({Vidas} vidas) dice: ¡Miau Miau!");
        }
        
        public override void MostrarInfo()
        {
            Console.WriteLine($"Gato: {Nombre} - Vidas: {Vidas}");
        }
    }
    
    // ===== CLASE PRINCIPAL CON MÉTODO MAIN =====
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO #10 - POLIMORFISMO ===\n");
            
            // ===== DEMOSTRACIÓN EJERCICIO 1: FIGURAS ABSTRACTAS =====
            Console.WriteLine("=== EJERCICIO 1: FIGURAS ABSTRACTAS ===\n");
            
            // Crear diferentes figuras (usando la clase base Figura)
            Figura circulo = new Circulo(5.0);
            Figura rectangulo = new Rectangulo(4.0, 6.0);
            Figura circulo2 = new Circulo(3.5);
            Figura rectangulo2 = new Rectangulo(8.0, 2.5);
            
            // Lista de figuras que demuestra polimorfismo
            List<Figura> figuras = new List<Figura> { circulo, rectangulo, circulo2, rectangulo2 };
            
            foreach (var figura in figuras)
            {
                figura.MostrarInformacion();
                Console.WriteLine();
            }
            
            // ===== DEMOSTRACIÓN EJERCICIO 2: MÉTODO VIRTUAL =====
            Console.WriteLine("=== EJERCICIO 2: MÉTODO VIRTUAL Y SOBRESCRITURA ===\n");
            
            // Crear diferentes animales
            Animal animalGenerico = new Animal("Animal Genérico");
            Animal perro = new Perro("Max", "Labrador");
            Animal gato = new Gato("Luna", 6);
            Animal perro2 = new Perro("Buddy", "Pastor Alemán");
            Animal gato2 = new Gato("Simba");
            
            // Lista de animales que demuestra polimorfismo
            List<Animal> animales = new List<Animal> { animalGenerico, perro, gato, perro2, gato2 };
            
            Console.WriteLine("=== Información de los Animales ===");
            foreach (var animal in animales)
            {
                animal.MostrarInfo();
            }
            
            Console.WriteLine("\n=== Sonidos de los Animales (Polimorfismo) ===");
            foreach (var animal in animales)
            {
                animal.HacerSonido();
            }
            
            // ===== DEMOSTRACIÓN ADICIONAL: USO DIRECTO =====
            Console.WriteLine("\n=== DEMOSTRACIÓN ADICIONAL ===");
            
            // Uso directo de las clases específicas
            Console.WriteLine("\n--- Uso directo de Círculo ---");
            Circulo miCirculo = new Circulo(10.0);
            miCirculo.MostrarInformacion();
            
            Console.WriteLine("\n--- Uso directo de Perro ---");
            Perro miPerro = new Perro("Rex", "Bulldog");
            miPerro.HacerSonido();
            
            // Cálculo de áreas específico
            Console.WriteLine("\n=== CÁLCULOS DE ÁREA ESPECÍFICOS ===");
            Console.WriteLine($"Área del círculo (radio 5): {circulo.CalcularArea():F2}");
            Console.WriteLine($"Área del rectángulo (4x6): {rectangulo.CalcularArea():F2}");
            
            Console.WriteLine("\n=== DEMOSTRACIÓN COMPLETADA ===");
            Console.ReadLine();
        }
    }
}