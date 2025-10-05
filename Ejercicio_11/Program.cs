using System;
using System.Collections.Generic;

namespace EjemplosUML
{
    // ===== SISTEMA COMPUTADORA =====
    
    // Clases componentes para Computadora
    public class Monitor
    {
        public string Marca { get; set; }
        public string Resolucion { get; set; }
        
        public Monitor(string marca, string resolucion)
        {
            Marca = marca;
            Resolucion = resolucion;
        }
    }

    public class Teclado
    {
        public string Tipo { get; set; }
        public bool EsMecanico { get; set; }
        
        public Teclado(string tipo, bool esMecanico)
        {
            Tipo = tipo;
            EsMecanico = esMecanico;
        }
    }

    public class Mouse
    {
        public string Marca { get; set; }
        public int DPI { get; set; }
        
        public Mouse(string marca, int dpi)
        {
            Marca = marca;
            DPI = dpi;
        }
    }

    // Clase principal que usa composición
    public class Computadora
    {
        // COMPOSICIÓN: La computadora está compuesta por estos componentes
        public Monitor Monitor { get; set; }
        public Teclado Teclado { get; set; }
        public Mouse Mouse { get; set; }
        
        public Computadora(string marcaMonitor, string resolucion, 
                          string tipoTeclado, bool tecladoMecanico,
                          string marcaMouse, int dpiMouse)
        {
            // Creación de las instancias dentro del constructor (composición)
            Monitor = new Monitor(marcaMonitor, resolucion);
            Teclado = new Teclado(tipoTeclado, tecladoMecanico);
            Mouse = new Mouse(marcaMouse, dpiMouse);
        }
        
        public void MostrarEspecificaciones()
        {
            Console.WriteLine("=== ESPECIFICACIONES DE LA COMPUTADORA ===");
            Console.WriteLine($"Monitor: {Monitor.Marca} - {Monitor.Resolucion}");
            Console.WriteLine($"Teclado: {Teclado.Tipo} - Mecánico: {Teclado.EsMecanico}");
            Console.WriteLine($"Mouse: {Mouse.Marca} - {Mouse.DPI} DPI");
            Console.WriteLine();
        }
    }

    // ===== SISTEMA BIBLIOTECA =====

    // Clase Libro
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        
        public Libro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
    }

    // Clase Estante con COMPOSICIÓN de Libros
    public class Estante
    {
        public int Numero { get; set; }
        private List<Libro> libros;
        
        // COMPOSICIÓN: El estante crea y contiene libros
        // Cuando el estante se destruye, los libros también
        public Estante(int numero)
        {
            Numero = numero;
            libros = new List<Libro>();
        }
        
        public void AgregarLibro(string titulo, string autor)
        {
            // Composición: creamos el libro dentro del estante
            libros.Add(new Libro(titulo, autor));
        }
        
        public void MostrarLibros()
        {
            Console.WriteLine($"=== LIBROS EN EL ESTANTE {Numero} ===");
            foreach (var libro in libros)
            {
                Console.WriteLine($"- {libro.Titulo} por {libro.Autor}");
            }
            Console.WriteLine();
        }
        
        public int CantidadLibros()
        {
            return libros.Count;
        }
    }

    // Clase Bibliotecario con AGREGACIÓN de Estantes
    public class Bibliotecario
    {
        public string Nombre { get; set; }
        private List<Estante> estantes;
        
        // AGREGACIÓN: El bibliotecario usa estantes que existen independientemente
        public Bibliotecario(string nombre)
        {
            Nombre = nombre;
            estantes = new List<Estante>();
        }
        
        public void AgregarEstante(Estante estante)
        {
            // Agregación: recibimos un estante que ya existe
            estantes.Add(estante);
        }
        
        public void MostrarEstantes()
        {
            Console.WriteLine($"=== ESTANTES ADMINISTRADOS POR {Nombre} ===");
            foreach (var estante in estantes)
            {
                Console.WriteLine($"Estante {estante.Numero}: {estante.CantidadLibros()} libros");
            }
            Console.WriteLine();
        }
    }

    // ===== SISTEMA CASA =====

    // Clases para el sistema de Casa
    public class Habitacion
    {
        public string Nombre { get; set; }
        public double MetrosCuadrados { get; set; }
        
        public Habitacion(string nombre, double metrosCuadrados)
        {
            Nombre = nombre;
            MetrosCuadrados = metrosCuadrados;
        }
    }

    public class Mueble
    {
        public string Tipo { get; set; }
        public string Material { get; set; }
        
        public Mueble(string tipo, string material)
        {
            Tipo = tipo;
            Material = material;
        }
    }

    public class Casa
    {
        // COMPOSICIÓN: Las habitaciones son parte integral de la casa
        private List<Habitacion> habitaciones;
        
        // AGREGACIÓN: Los muebles existen independientemente de la casa
        private List<Mueble> muebles;
        
        public string Direccion { get; set; }
        
        public Casa(string direccion)
        {
            Direccion = direccion;
            habitaciones = new List<Habitacion>();
            muebles = new List<Mueble>();
            
            // COMPOSICIÓN: Creamos las habitaciones al crear la casa
            AgregarHabitacion("Sala", 20.5);
            AgregarHabitacion("Cocina", 15.0);
            AgregarHabitacion("Dormitorio Principal", 18.0);
        }
        
        // Método para composición
        private void AgregarHabitacion(string nombre, double metros)
        {
            habitaciones.Add(new Habitacion(nombre, metros));
        }
        
        // Método para agregación
        public void AgregarMueble(Mueble mueble)
        {
            muebles.Add(mueble);
        }
        
        public void MostrarInformacion()
        {
            Console.WriteLine($"=== CASA EN {Direccion} ===");
            
            Console.WriteLine("Habitaciones (Composición):");
            foreach (var habitacion in habitaciones)
            {
                Console.WriteLine($"- {habitacion.Nombre}: {habitacion.MetrosCuadrados}m²");
            }
            
            Console.WriteLine("Muebles (Agregación):");
            foreach (var mueble in muebles)
            {
                Console.WriteLine($"- {mueble.Tipo} de {mueble.Material}");
            }
            Console.WriteLine();
        }
    }

    // ===== PROGRAMA PRINCIPAL =====
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DEMOSTRACIÓN DE COMPOSICIÓN Y AGREGACIÓN\n");
            
            // 1. DEMOSTRACIÓN COMPUTADORA (Composición)
            Computadora miPc = new Computadora(
                "Samsung", "1920x1080", 
                "Membrana", false, 
                "Logitech", 1600
            );
            miPc.MostrarEspecificaciones();
            
            // 2. DEMOSTRACIÓN BIBLIOTECA (Composición y Agregación)
            // Crear estantes (composición con libros)
            Estante estante1 = new Estante(1);
            estante1.AgregarLibro("Cien años de soledad", "Gabriel García Márquez");
            estante1.AgregarLibro("1984", "George Orwell");
            
            Estante estante2 = new Estante(2);
            estante2.AgregarLibro("El Quijote", "Miguel de Cervantes");
            
            // Crear bibliotecario (agregación con estantes)
            Bibliotecario bibliotecario = new Bibliotecario("Ana García");
            bibliotecario.AgregarEstante(estante1);
            bibliotecario.AgregarEstante(estante2);
            
            estante1.MostrarLibros();
            estante2.MostrarLibros();
            bibliotecario.MostrarEstantes();
            
            // 3. DEMOSTRACIÓN CASA (Composición y Agregación)
            Casa miCasa = new Casa("Calle Principal 123");
            
            // Agregar muebles (agregación)
            miCasa.AgregarMueble(new Mueble("Sofá", "Cuero"));
            miCasa.AgregarMueble(new Mueble("Mesa", "Madera de roble"));
            miCasa.AgregarMueble(new Mueble("Silla", "Madera"));
            
            miCasa.MostrarInformacion();
            
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}