using System;

// INTERFAZ PARA EL SISTEMA DE PAGOS
public interface IMetodoPago
{
    bool ProcesarPago(decimal monto);
    string ObtenerNombreMetodo();
}

// Implementaciones de métodos de pago
public class TarjetaCredito : IMetodoPago
{
    public bool ProcesarPago(decimal monto)
    {
        Console.WriteLine($"Procesando pago de {monto:C} con tarjeta de crédito");
        return true;
    }

    public string ObtenerNombreMetodo() => "Tarjeta de Crédito";
}

public class PayPal : IMetodoPago
{
    public bool ProcesarPago(decimal monto)
    {
        Console.WriteLine($"Procesando pago de {monto:C} con PayPal");
        return true;
    }

    public string ObtenerNombreMetodo() => "PayPal";
}

public class TransferenciaBancaria : IMetodoPago
{
    public bool ProcesarPago(decimal monto)
    {
        Console.WriteLine($"Procesando pago de {monto:C} con transferencia bancaria");
        return true;
    }

    public string ObtenerNombreMetodo() => "Transferencia Bancaria";
}

// INTERFAZ PARA IMPRESIÓN DE REPORTES
public interface IImprimible
{
    void Imprimir();
}

// Implementaciones de clases imprimibles
public class Factura : IImprimible
{
    public void Imprimir()
    {
        Console.WriteLine("Imprimiendo factura con detalles de compra...");
    }
}

public class Reporte : IImprimible
{
    public void Imprimir()
    {
        Console.WriteLine("Imprimiendo reporte con estadísticas y gráficos...");
    }
}

public class Etiqueta : IImprimible
{
    public void Imprimir()
    {
        Console.WriteLine("Imprimiendo etiqueta con código de barras...");
    }
}

// INTERFAZ PARA AUTENTICACIÓN
public interface IAutenticable
{
    bool Autenticar();
}

// Implementaciones de clases de autenticación
public class UsuarioWeb : IAutenticable
{
    private string _username;
    private string _password;

    public UsuarioWeb(string username, string password)
    {
        _username = username;
        _password = password;
    }

    public bool Autenticar()
    {
        Console.WriteLine($"Autenticando usuario web: {_username}");
        return !string.IsNullOrEmpty(_username) && !string.IsNullOrEmpty(_password);
    }
}

public class Administrador : IAutenticable
{
    private string _adminKey;

    public Administrador(string adminKey)
    {
        _adminKey = adminKey;
    }

    public bool Autenticar()
    {
        Console.WriteLine("Autenticando administrador con clave especial");
        return _adminKey == "ADMIN123";
    }
}

public class Invitado : IAutenticable
{
    public bool Autenticar()
    {
        Console.WriteLine("Autenticando invitado con acceso limitado");
        return true; // Los invitados siempre tienen acceso
    }
}

// Clase principal para probar la implementación
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Pagos ===");
        IMetodoPago[] metodosPago = new IMetodoPago[]
        {
            new TarjetaCredito(),
            new PayPal(),
            new TransferenciaBancaria()
        };

        foreach (var metodo in metodosPago)
        {
            Console.WriteLine($"Usando: {metodo.ObtenerNombreMetodo()}");
            metodo.ProcesarPago(100.00m);
        }

        Console.WriteLine("\n=== Sistema de Impresión ===");
        IImprimible[] imprimibles = new IImprimible[]
        {
            new Factura(),
            new Reporte(),
            new Etiqueta()
        };

        foreach (var item in imprimibles)
        {
            item.Imprimir();
        }

        Console.WriteLine("\n=== Sistema de Autenticación ===");
        IAutenticable[] usuarios = new IAutenticable[]
        {
            new UsuarioWeb("john_doe", "pass123"),
            new Administrador("ADMIN123"),
            new Invitado()
        };

        foreach (var usuario in usuarios)
        {
            bool autenticado = usuario.Autenticar();
            Console.WriteLine($"Autenticación {(autenticado ? "exitosa" : "fallida")}\n");
        }
    }
}