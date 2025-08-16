// See https://aka.ms/new-console-template for more information
Cusing System;

class VerificadorDiaSemana
{
    static void Main()
    {
        Console.WriteLine("Verificador de día de la semana");
        Console.Write("Ingrese un día de la semana (lunes a domingo): ");
        string dia = Console.ReadLine().ToLower();
        
        switch(dia)
        {
            case "lunes":
                Console.WriteLine("Es inicio de semana");
                break;
            case "martes":
            case "miércoles":
            case "jueves":
                Console.WriteLine("Son mediados de semana");
                break;
            case "viernes":
            case "sábado":
            case "domingo":
                Console.WriteLine("Es fin de semana");
                break;
            default:
                Console.WriteLine("Día no válido");
                break;
        }
    }
}