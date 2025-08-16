using System;

class ProgramaVotar
{
    static void Main()
    {
        Console.WriteLine("Verificador de edad para votar");
        Console.Write("Ingrese su edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());
        
        if (edad >= 18)
        {
            Console.WriteLine("¡Felicidades! Ya puedes votar.");
        }
        else
        {
            Console.WriteLine("Lo siento, aún no puedes votar.");
        }
    }
}