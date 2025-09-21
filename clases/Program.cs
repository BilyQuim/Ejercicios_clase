/*using System;
class Persona 
{
    public string? Nombre;
    public void Saludar()
    {
        Console.WriteLine($"Hola, soy {Nombre}, mi carnet es {(())}");
    }
}

class Estudiante : Persona 
{
    public string? Carnet; 
}

//USO DE LAS CALSES 

class Program
{
    static void Main(string[]args)
    {
        Estudiante e = new Estudiante();
        e.Nombre = "Lucia";
        e.Carnet = "2025-001";
        e.Saludar(); //Metodo heredado 
    }
}*/

/*using  System;
class Empleado 
{
    public string? Nombre;

    public double Salario;
}

class Gerente : Empleado 
{
    public double Bono;

    public double CalcularTotal()
    {
        return Salario + Bono;
    }
}
// USO DE LAS CLASES 

class Program
{
    static void Main(string[]args)
    {
        Gerente g = new Gerente();
        g.Nombre = "Carlos";
        g.Salario = 3000;
        g.Bono = 500;
        double total = g.CalcularTotal();
        Console.WriteLine($"El gerente {g.Nombre} tiene un salario total de Q.{total}");
    }
}*/

/*using System;
class Animal //Base class (parent)
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal // Derived class (child)
{
    public override void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal // Derived class (child)
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow bow"); 
    }
}

class Program 
{
    static void Main(string[]args)
    {
        Animal myAnimal = new Animal(); // Create a Animal object 
        Animal myPig = new Pig(); // Create a Pig object 
        Animal myDog = new Dog(); // create a Dog object 

        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound(); 
    }
}*/

using System;
class Program
