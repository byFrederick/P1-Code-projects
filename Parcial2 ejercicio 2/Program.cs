using System;

abstract class Cuadrilatero
{
    public float lado1;
    public float area;
    public Cuadrilatero()
    {
        while(lado1 < 0.01)
        {
            try
            {
                Console.WriteLine("Digite el valor del lado 1");
                lado1 = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite un valor válido\n");
            }
        }
        area = 0;
    }
    public virtual void CalcularArea() { }
}
class Cuadrado : Cuadrilatero
{
    public override void CalcularArea()
    {
        area = lado1 * lado1;
        Console.WriteLine("El área del cuadrado es " + area);
    }
}
class Rectangulo : Cuadrado
{
    public float lado2;
    public Rectangulo()
    {
        while (lado2 < 0.01 || lado1 == lado2)
        {
            try
            {
                Console.WriteLine("Digite el valor del lado 2 (No puede ser igual al lado 1)");
                lado2 = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite un valor válido\n");
            }
        }
    }
    public override void CalcularArea()
    {
        area = lado1 * lado2;
        Console.WriteLine("El área del rectángulo es " + area);
    }
}
class Trapecio : Rectangulo
{
    public float lado3;
    public Trapecio(float lado3)
    {
        if (lado3 < 0.01 )
        {
            {
                while (this.lado3 < 0.01)
                {
                    try
                    {
                        Console.WriteLine("Digite el valor de la altura");
                        this.lado3 = float.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Digite un valor válido\n");
                    }
                }
            }
        } else
        {
            this.lado3 = lado3;
            Console.WriteLine("El valor de la altura de su trapecio es " + this.lado3);
        } 
    }
    public override void CalcularArea()
    {
        area = ((lado1 + lado2) / 2) * lado3;
        Console.WriteLine("El área del trapecio es " + area);
    }
}
class Program
{
    static void Main()
    {
        Cuadrado cuadradobj = new Cuadrado();
        cuadradobj.CalcularArea();
        Console.WriteLine("");
        Rectangulo rectangulobj = new Rectangulo();
        rectangulobj.CalcularArea();
        Console.WriteLine("");
        Trapecio trapeciobj = new Trapecio(0);
        trapeciobj.CalcularArea();
    }
}