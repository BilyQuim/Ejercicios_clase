using System; 
using System.Collections.Generic; 
using System.Linq; 

class ProgramaNotasEstudiantes 
{
    static void Main() 
    {
        
        List<double> notas = new List<double>();
        Console.WriteLine("Ingrese las notas de al menos 10 cursos:");

         
        while (notas.Count < 10)
        {
            Console.Write($"Nota #{notas.Count + 1}: ");
            string entrada = Console.ReadLine(); 

            
            if (double.TryParse(entrada, out double nota))
            {
                
                if (nota >= 0 && nota <= 100)
                {
                    notas.Add(nota);
                }
                else
                {  
                    Console.WriteLine("La nota debe estar entre 0 y 100.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Ingrese un número válido.");
            }
        }

        try // para manejar errores 
        {
            if (!notas.Any()) // verifica si la lista tiene elmentos si no lanza una excepcion personalizafa con throw
            {
                throw new InvalidOperationException("No se puede calcular el promedio: la lista está vacía.");
            }

            double promedio = notas.Average();// calcula el promedio Average()
            Console.WriteLine($"\nEl promedio de las notas es: {promedio:F2}");// muestra el resultado con 2 decimales F2
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

