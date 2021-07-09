using System;
//    2. Una clase abstracta llamada Animal tiene un método constructor, una propiedad
//llamada Peso y un método denominado Dice.
//La propiedad Peso representa el peso del animal, un valor int.
//El método Dice devuelve una cadena, el ruido que hace el animal.
//La clase Animal tiene las subclases Vaca, Serpiente y Cerdo.Estas subclases realizan
//distintas implementaciones de Dice, las cuales devuelven los valores "mu", "sss" y
//"oinc", respectivamente.
//Escriba la clase Animal y las tres subclases.Cree los objetos mascotaVaca,
//mascotaSerpiente y mascotaCerdo a partir de las clases correspondientes, y utilice sus
//propiedades y métodos. Despliegue la información en un cuadro de texto    

class Animal  // Base class (parent) 
{
    public void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal  // Derived class (child) 
{
    public void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal  // Derived class (child) 
{
    public void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();  // Create a Animal object
        Animal myPig = new Pig();  // Create a Pig object
        Animal myDog = new Dog();  // Create a Dog object

        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();
    }
}






