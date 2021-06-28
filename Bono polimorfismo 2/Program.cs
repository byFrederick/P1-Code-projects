using System;

abstract class Animal
{
    public int peso;
    public Animal()
    {
        while(peso < 1)
        {
            try
            {
                Console.WriteLine("Digite el peso del animal");
                peso = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite un peso válido\n");
            }
        }
    }
    public virtual void Dice() { }
}
class Vaca : Animal
{
    public override void Dice()
    {
        Console.WriteLine("Muuuuuuu\n\n");
    }
}
class Serpiente : Animal
{
    public override void Dice()
    {
        Console.WriteLine("ssssssssssss\n\n");
    }
}
class Cerdo : Animal
{
    public override void Dice()
    {
        Console.WriteLine("oinc oinc\n\n");
    }
}
class Program
{
    static void Main()
    {
        Vaca vacaobj = new Vaca();
        vacaobj.Dice();
        Console.WriteLine("");
        Serpiente serpienteobj = new Serpiente();
        serpienteobj.Dice();
        Console.WriteLine("");
        Cerdo cerdobj = new Cerdo();
        cerdobj.Dice();

    }
}