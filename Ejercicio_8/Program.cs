using System;

class Producto {
    public string Nombre;
    public double Precio;
    public int Cantidad;
    
    // Constructor
    public Producto(string n, double p, int c) {
        Nombre = n; Precio = p; Cantidad = c;
    }
}

class Estudiante {
    public string Nombre;
    public int Nota;
    
    // Métodos sobrecargados
    public void MostrarInfo() {
        Console.WriteLine($"Nombre: {Nombre}");
    }
    
    public void MostrarInfo(int nota) {
        Console.WriteLine($"Nombre: {Nombre}, Nota: {nota}");
    }
}

class Vehiculo {
    public string Marca;
    public string Modelo;
    public int Año;
    
    // Constructores sobrecargados
    public Vehiculo(string marca, string modelo) {
        Marca = marca; Modelo = modelo; Año = 0;
    }
    
    public Vehiculo(string marca, string modelo, int año) {
        Marca = marca; Modelo = modelo; Año = año;
    }
    
    // Método para mostrar información
    public void MostrarInfo() {
        if (Año == 0)
            Console.WriteLine($"Vehículo: {Marca} {Modelo}");
        else
            Console.WriteLine($"Vehículo: {Marca} {Modelo} ({Año})");
    }
}

class Program {
    static void Main() {
        Console.WriteLine("1. Producto con constructor");
        Console.WriteLine("2. Estudiante con métodos sobrecargados");
        Console.WriteLine("3. Vehículo con constructores sobrecargados");
        Console.Write("Seleccione opción: ");
        
        switch (Console.ReadLine()) {
            case "1":
                Producto p = new Producto("Laptop", 1500, 5);
                Console.WriteLine($"Producto: {p.Nombre}, Precio: Q{p.Precio}, Cantidad: {p.Cantidad}");
                break;
                
            case "2":
                Estudiante e = new Estudiante();
                e.Nombre = "Ana";
                e.MostrarInfo(); // Solo nombre
                e.MostrarInfo(85); // Nombre y nota
                break;
                
            case "3":
                Vehiculo v1 = new Vehiculo("Toyota", "Corolla");
                Vehiculo v2 = new Vehiculo("Honda", "Civic", 2023);
                v1.MostrarInfo();
                v2.MostrarInfo();
                break;
        }
    }
}