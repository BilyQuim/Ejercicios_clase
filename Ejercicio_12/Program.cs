using System;

// ============================================
// SISTEMA 1: GESTIÓN DE FIGURAS GEOMÉTRICAS
// ============================================

public abstract class Figura
{
    public abstract double CalcularArea();
    public abstract string ObtenerNombre();
}

public class Triangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double baseTri, double altura)
    {
        Base = baseTri;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }

    public override string ObtenerNombre()
    {
        return "Triángulo";
    }
}

public class Rectangulo : Figura
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public override double CalcularArea()
    {
        return Ancho * Alto;
    }

    public override string ObtenerNombre()
    {
        return "Rectángulo";
    }
}

public class Circulo : Figura
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }

    public override string ObtenerNombre()
    {
        return "Círculo";
    }
}

// ============================================
// SISTEMA 2: CATÁLOGO DE PRODUCTOS
// ============================================

public abstract class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Producto(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }

    public abstract void MostrarDescripcion();
}

public class Electronico : Producto
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Electronico(string nombre, double precio, string marca, string modelo) 
        : base(nombre, precio)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public override void MostrarDescripcion()
    {
        Console.WriteLine($"PRODUCTO ELECTRÓNICO:");
        Console.WriteLine($"- Nombre: {Nombre}");
        Console.WriteLine($"- Precio: ${Precio:F2}");
        Console.WriteLine($"- Marca: {Marca}");
        Console.WriteLine($"- Modelo: {Modelo}");
        Console.WriteLine($"- Garantía: 2 años");
        Console.WriteLine();
    }
}

public class Alimento : Producto
{
    public string Ingredientes { get; set; }
    public DateTime FechaVencimiento { get; set; }

    public Alimento(string nombre, double precio, string ingredientes, DateTime fechaVencimiento) 
        : base(nombre, precio)
    {
        Ingredientes = ingredientes;
        FechaVencimiento = fechaVencimiento;
    }

    public override void MostrarDescripcion()
    {
        Console.WriteLine($"PRODUCTO ALIMENTICIO:");
        Console.WriteLine($"- Nombre: {Nombre}");
        Console.WriteLine($"- Precio: ${Precio:F2}");
        Console.WriteLine($"- Ingredientes: {Ingredientes}");
        Console.WriteLine($"- Vence: {FechaVencimiento:dd/MM/yyyy}");
        Console.WriteLine($"- Conservación: Refrigerar");
        Console.WriteLine();
    }
}

public class Ropa : Producto
{
    public string Talla { get; set; }
    public string Material { get; set; }

    public Ropa(string nombre, double precio, string talla, string material) 
        : base(nombre, precio)
    {
        Talla = talla;
        Material = material;
    }

    public override void MostrarDescripcion()
    {
        Console.WriteLine($"PRODUCTO DE ROPA:");
        Console.WriteLine($"- Nombre: {Nombre}");
        Console.WriteLine($"- Precio: ${Precio:F2}");
        Console.WriteLine($"- Talla: {Talla}");
        Console.WriteLine($"- Material: {Material}");
        Console.WriteLine($"- Lavado: Máquina 30°C");
        Console.WriteLine();
    }
}

// ============================================
// SISTEMA 3: SISTEMA DE PAGOS
// ============================================

public abstract class Pago
{
    public double Monto { get; set; }
    public string TransaccionID { get; set; }

    public Pago(double monto)
    {
        Monto = monto;
        TransaccionID = Guid.NewGuid().ToString().Substring(0, 8);
    }

    public abstract bool Procesar();
    public abstract void MostrarConfirmacion();
}

public class PagoEfectivo : Pago
{
    public PagoEfectivo(double monto) : base(monto) { }

    public override bool Procesar()
    {
        // Validación: Efectivo debe ser exacto o con cambio mínimo
        Console.WriteLine($"\n--- PROCESANDO PAGO EFECTIVO ---");
        Console.WriteLine($"Monto a pagar: ${Monto:F2}");
        Console.WriteLine("Validando billetes recibidos...");
        
        if (Monto > 0)
        {
            Console.WriteLine("✓ Validación exitosa");
            return true;
        }
        Console.WriteLine("✗ Error: Monto inválido");
        return false;
    }

    public override void MostrarConfirmacion()
    {
        Console.WriteLine($"✓ PAGO EFECTIVO CONFIRMADO");
        Console.WriteLine($"ID: {TransaccionID}");
        Console.WriteLine($"Monto: ${Monto:F2}");
        Console.WriteLine("Cambio entregado: $0.00");
        Console.WriteLine("¡Gracias por su compra!");
    }
}

public class PagoTarjeta : Pago
{
    public string NumeroTarjeta { get; set; }
    public int CVV { get; set; }

    public PagoTarjeta(double monto, string numeroTarjeta, int cvv) : base(monto)
    {
        NumeroTarjeta = numeroTarjeta.Substring(numeroTarjeta.Length - 4); // Solo últimos 4 dígitos
        CVV = cvv;
    }

    public override bool Procesar()
    {
        Console.WriteLine($"\n--- PROCESANDO PAGO CON TARJETA ---");
        Console.WriteLine($"Monto: ${Monto:F2}");
        Console.WriteLine($"Tarjeta: **** **** **** {NumeroTarjeta}");
        
        // Simulación de validaciones
        if (Monto > 0 && CVV >= 100 && CVV <= 999)
        {
            Console.WriteLine("✓ Validación de tarjeta exitosa");
            Console.WriteLine("✓ Autorización bancaria aprobada");
            return true;
        }
        Console.WriteLine("✗ Error: Tarjeta rechazada");
        return false;
    }

    public override void MostrarConfirmacion()
    {
        Console.WriteLine($"✓ PAGO CON TARJETA CONFIRMADO");
        Console.WriteLine($"ID: {TransaccionID}");
        Console.WriteLine($"Monto: ${Monto:F2}");
        Console.WriteLine($"Tarjeta: **** **** **** {NumeroTarjeta}");
        Console.WriteLine("¡Pago procesado exitosamente!");
    }
}

public class PagoTransferencia : Pago
{
    public string NumeroCuenta { get; set; }
    public string Banco { get; set; }

    public PagoTransferencia(double monto, string numeroCuenta, string banco) : base(monto)
    {
        NumeroCuenta = numeroCuenta;
        Banco = banco;
    }

    public override bool Procesar()
    {
        Console.WriteLine($"\n--- PROCESANDO PAGO POR TRANSFERENCIA ---");
        Console.WriteLine($"Monto: ${Monto:F2}");
        Console.WriteLine($"Cuenta destino: {NumeroCuenta}");
        Console.WriteLine($"Banco: {Banco}");
        
        // Simulación: Transferencia tarda 2-3 días
        Random rnd = new Random();
        int dias = rnd.Next(2, 4);
        
        if (Monto > 0)
        {
            Console.WriteLine($"✓ Validación de cuenta exitosa");
            Console.WriteLine($"⏳ Transferencia confirmada en {dias} días hábiles");
            return true;
        }
        Console.WriteLine("✗ Error: Datos bancarios inválidos");
        return false;
    }

    public override void MostrarConfirmacion()
    {
        Console.WriteLine($"✓ PAGO POR TRANSFERENCIA CONFIRMADO");
        Console.WriteLine($"ID: {TransaccionID}");
        Console.WriteLine($"Monto: ${Monto:F2}");
        Console.WriteLine($"Cuenta: {NumeroCuenta}");
        Console.WriteLine("Recibirá comprobante por email");
    }
}

// ============================================
// PROGRAMA PRINCIPAL - DEMOSTRACIÓN
// ============================================

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("    DEMOSTRACIÓN DE SISTEMAS");
        Console.WriteLine("================================");

        // SISTEMA 1: FIGURAS GEOMÉTRICAS
        Console.WriteLine("\n1️⃣ GESTIÓN DE FIGURAS GEOMÉTRICAS");
        Console.WriteLine("---------------------------------");
        
        Figura[] figuras = {
            new Triangulo(10, 5),
            new Rectangulo(8, 6),
            new Circulo(7)
        };

        foreach (Figura f in figuras)
        {
            Console.WriteLine($"{f.ObtenerNombre()}: {f.CalcularArea():F2} cm²");
        }

        // SISTEMA 2: CATÁLOGO DE PRODUCTOS
        Console.WriteLine("\n2️⃣ CATÁLOGO DE PRODUCTOS");
        Console.WriteLine("---------------------------------");
        
        Producto[] productos = {
            new Electronico("Smartphone", 599.99, "Samsung", "Galaxy S23"),
            new Alimento("Pizza Margherita", 12.99, "Harina, tomate, mozzarella", new DateTime(2025, 12, 31)),
            new Ropa("Camisa Casual", 29.99, "M", "Algodón 100%")
        };

        foreach (Producto p in productos)
        {
            p.MostrarDescripcion();
        }

        // SISTEMA 3: SISTEMA DE PAGOS
        Console.WriteLine("\n3️⃣ SISTEMA DE PAGOS");
        Console.WriteLine("---------------------------------");
        
        Pago[] pagos = {
            new PagoEfectivo(150.00),
            new PagoTarjeta(299.99, "1234567890123456", 123),
            new PagoTransferencia(450.00, "001-2345678-9", "Banco Nacional")
        };

        foreach (Pago p in pagos)
        {
            if (p.Procesar())
            {
                p.MostrarConfirmacion();
            }
            else
            {
                Console.WriteLine("❌ PAGO RECHAZADO\n");
            }
            Console.WriteLine(new string('-', 40));
        }

        Console.WriteLine("\n🎉 DEMOSTRACIÓN COMPLETADA EXITOSAMENTE!");
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}