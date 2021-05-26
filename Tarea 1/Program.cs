using System;

class convertFaC 
{
    public float input;
    public float output;

    public convertFaC()
    {
        Console.WriteLine("Digite la temperatura en grados Farenheit");
        Console.ReadLine(input);
        output = (input - 32) * 5 / 9;
    }
}
class program
{
    static void Main()
    {
        convertFaC convert = new convertFaC();
        Console.WriteLine("La temperatura en grados celsius es: " + Math.Round(convert.output));
     }
}
