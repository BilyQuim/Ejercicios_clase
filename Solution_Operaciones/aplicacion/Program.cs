using Operacion_Biblio;

Calculadora calc = new Calculadora();
bool continuar = true;

Console.WriteLine("🚀 CALCULADORA AVANZADA - SISTEMA DE OPERACIONES");
Console.WriteLine("=================================================\n");

while (continuar)
{
    try
    {
        MostrarMenu();
        string opcion = Console.ReadLine();
        
        switch (opcion)
        {
            case "1": RealizarSuma(calc); break;
            case "2": RealizarResta(calc); break;
            case "3": RealizarMultiplicacion(calc); break;
            case "4": RealizarDivision(calc); break;
            case "5": RealizarPotencia(calc); break;
            case "6": RealizarRaizCuadrada(calc); break;
            case "7": RealizarPorcentaje(calc); break;
            case "8": 
                continuar = false; 
                Console.WriteLine("👋 ¡Gracias por usar la calculadora!");
                break;
            default:
                Console.WriteLine("❌ Opción no válida. Intente nuevamente.\n");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"💥 Error: {ex.Message}\n");
    }
}

void MostrarMenu()
{
    Console.WriteLine("📋 MENU DE OPERACIONES:");
    Console.WriteLine("1. ➕ Sumar");
    Console.WriteLine("2. ➖ Restar");
    Console.WriteLine("3. ✖️ Multiplicar");
    Console.WriteLine("4. ➗ Dividir");
    Console.WriteLine("5. 🔢 Potencia");
    Console.WriteLine("6. √ Raíz Cuadrada");
    Console.WriteLine("7. % Porcentaje");
    Console.WriteLine("8. 🚪 Salir");
    Console.Write("Seleccione una opción: ");
}

void RealizarSuma(Calculadora calc)
{
    Console.Write("Ingrese el primer número: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingrese el segundo número: ");
    double num2 = Convert.ToDouble(Console.ReadLine());
    double resultado = calc.Sumar(num1, num2);
    Console.WriteLine($"✅ Resultado: {num1} + {num2} = {resultado}\n");
}

void RealizarResta(Calculadora calc)
{
    Console.Write("Ingrese el primer número: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingrese el segundo número: ");
    double num2 = Convert.ToDouble(Console.ReadLine());
    double resultado = calc.Restar(num1, num2);
    Console.WriteLine($"✅ Resultado: {num1} - {num2} = {resultado}\n");
}

void RealizarMultiplicacion(Calculadora calc)
{
    Console.Write("Ingrese el primer número: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingrese el segundo número: ");
    double num2 = Convert.ToDouble(Console.ReadLine());
    double resultado = calc.Multiplicar(num1, num2);
    Console.WriteLine($"✅ Resultado: {num1} × {num2} = {resultado}\n");
}

void RealizarDivision(Calculadora calc)
{
    Console.Write("Ingrese el dividendo: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingrese el divisor: ");
    double num2 = Convert.ToDouble(Console.ReadLine());
    
    if (num2 == 0)
    {
        Console.WriteLine("❌ No se puede dividir por cero\n");
        return;
    }
    
    double resultado = calc.Dividir(num1, num2);
    Console.WriteLine($"✅ Resultado: {num1} ÷ {num2} = {resultado}\n");
}

void RealizarPotencia(Calculadora calc)
{
    Console.Write("Ingrese la base: ");
    double baseNum = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingrese el exponente: ");
    double exponente = Convert.ToDouble(Console.ReadLine());
    double resultado = calc.Potencia(baseNum, exponente);
    Console.WriteLine($"✅ Resultado: {baseNum} ^ {exponente} = {resultado}\n");
}

void RealizarRaizCuadrada(Calculadora calc)
{
    Console.Write("Ingrese el número: ");
    double numero = Convert.ToDouble(Console.ReadLine());
    
    if (numero < 0)
    {
        Console.WriteLine("❌ No se puede calcular la raíz de un número negativo\n");
        return;
    }
    
    double resultado = calc.RaizCuadrada(numero);
    Console.WriteLine($"✅ Resultado: √{numero} = {resultado}\n");
}

void RealizarPorcentaje(Calculadora calc)
{
    Console.Write("Ingrese el número: ");
    double numero = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingrese el porcentaje: ");
    double porcentaje = Convert.ToDouble(Console.ReadLine());
    double resultado = calc.Porcentaje(numero, porcentaje);
    Console.WriteLine($"✅ Resultado: {porcentaje}% de {numero} = {resultado}\n");
}