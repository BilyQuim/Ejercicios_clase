using System;
using System.Collections.Generic;

namespace Ejercicio9Herencia
{
    // ===== JERARQUÍA DE VEHÍCULOS =====
    
    // Clase base: Vehículo
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        
        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Vehículo: {Marca} {Modelo}");
        }
    }
    
    // Clase derivada: Motocicleta
    public class Motocicleta : Vehiculo
    {
        public int Cilindraje { get; set; }
        
        public Motocicleta(string marca, string modelo, int cilindraje) 
            : base(marca, modelo)
        {
            Cilindraje = cilindraje;
        }
        
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Motocicleta: {Marca} {Modelo} - {Cilindraje}cc");
        }
    }
    
    // Clase derivada: Camion
    public class Camion : Vehiculo
    {
        public double CapacidadCarga { get; set; } // en toneladas
        
        public Camion(string marca, string modelo, double capacidadCarga) 
            : base(marca, modelo)
        {
            CapacidadCarga = capacidadCarga;
        }
        
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Camión: {Marca} {Modelo} - Capacidad: {CapacidadCarga} toneladas");
        }
    }
    
    // ===== JERARQUÍA DE EMPLEADOS =====
    
    // Clase base: Empleado
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public List<string> Certificaciones { get; set; }
        
        public Empleado(string nombre, string puesto)
        {
            Nombre = nombre;
            Puesto = puesto;
            Certificaciones = new List<string>();
        }
        
        public void AgregarCertificacion(string certificacion)
        {
            Certificaciones.Add(certificacion);
        }
        
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"\nEmpleado: {Nombre}");
            Console.WriteLine($"Puesto: {Puesto}");
            Console.WriteLine("Certificaciones: " + (Certificaciones.Count > 0 ? string.Join(", ", Certificaciones) : "Ninguna"));
        }
    }
    
    // Clase hija: Gerente
    public class Gerente : Empleado
    {
        public int NumeroEquipos { get; set; }
        public double PresupuestoAnual { get; set; }
        
        public Gerente(string nombre, int numeroEquipos, double presupuestoAnual) 
            : base(nombre, "Gerente")
        {
            NumeroEquipos = numeroEquipos;
            PresupuestoAnual = presupuestoAnual;
        }
        
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de equipos: {NumeroEquipos}");
            Console.WriteLine($"Presupuesto anual: ${PresupuestoAnual:N2}");
        }
    }
    
    // Clase hija: Programador
    public class Programador : Empleado
    {
        public string LenguajePrincipal { get; set; }
        public int AniosExperiencia { get; set; }
        public bool TrabajoRemoto { get; set; }
        
        public Programador(string nombre, string lenguajePrincipal, int aniosExperiencia, bool trabajoRemoto) 
            : base(nombre, "Programador")
        {
            LenguajePrincipal = lenguajePrincipal;
            AniosExperiencia = aniosExperiencia;
            TrabajoRemoto = trabajoRemoto;
        }
        
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Lenguaje principal: {LenguajePrincipal}");
            Console.WriteLine($"Años de experiencia: {AniosExperiencia}");
            Console.WriteLine($"Trabajo remoto: {(TrabajoRemoto ? "Sí" : "No")}");
        }
    }
    
    // ===== CLASE PRINCIPAL CON MÉTODO MAIN =====
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO #9 - HERENCIA ===\n");
            
            // Demostración de la jerarquía de vehículos
            Console.WriteLine("=== JERARQUÍA DE VEHÍCULOS ===");
            
            Vehiculo vehiculoGeneral = new Vehiculo("Toyota", "Genérico");
            Motocicleta moto = new Motocicleta("Yamaha", "MT-07", 689);
            Camion camion = new Camion("Volvo", "FH16", 25.5);
            
            vehiculoGeneral.MostrarInformacion();
            moto.MostrarInformacion();
            camion.MostrarInformacion();
            
            // Demostración de la jerarquía de empleados
            Console.WriteLine("\n=== JERARQUÍA DE EMPLEADOS ===");
            
            Empleado empleadoGeneral = new Empleado("Carlos López", "Asistente");
            empleadoGeneral.AgregarCertificacion("Office Avanzado");
            empleadoGeneral.AgregarCertificacion("Atención al Cliente");
            
            Gerente gerente = new Gerente("Ana García", 3, 500000);
            gerente.AgregarCertificacion("PMP");
            gerente.AgregarCertificacion("Scrum Master");
            
            Programador programador = new Programador("Miguel Torres", "C#", 5, true);
            programador.AgregarCertificacion("Microsoft Certified");
            programador.AgregarCertificacion("Azure Fundamentals");
            
            empleadoGeneral.MostrarInformacion();
            gerente.MostrarInformacion();
            programador.MostrarInformacion();
            
            // Demostración de polimorfismo usando lista base
            Console.WriteLine("\n=== POLIMORFISMO CON LISTA DE EMPLEADOS ===");
            List<Empleado> empleados = new List<Empleado> { empleadoGeneral, gerente, programador };
            
            foreach (var emp in empleados)
            {
                emp.MostrarInformacion();
                Console.WriteLine("---");
            }
            
            Console.WriteLine("\n=== DEMOSTRACIÓN COMPLETADA ===");
            Console.ReadLine();
        }
    }
}