using System;


/*class clasebase
{
    public int a;
    public clasebase()
    {
        a = 10;
    }
}
class clasederivada1 : clasebase
{
    public int b;
    public clasederivada1()
    {
        b = 20;
    }
}
class clasederivada2 : clasederivada1
{
    public int c;
    public clasederivada2()
    {
        c = 30;
    }
    public int calculasuma(int c)
    {
        return a + b + c;
    }
    public float calculasuma(float c)
    {
        return a + b + c;
    }
}
class ejemplo
{
    static void main()
    {
        clasederivada2 objderivada2 = new clasederivada2();
        Console.Write("Suma = " + objderivada2.calculasuma(5));
        Console.Write("Suma = " + objderivada2.calculasuma(5));
    }
}*/
public abstract class clasebase
{
    public int calculasuma(int x, int y)
    {
        return (x + y);
    }
    public abstract int calcularesta(int x, int y);
    public virtual int calculamultiplicacion(int x, int y)
    {
        int res = x * y;
        return res;
    }
}
public class clasederivada1 : clasebase
{
    public override int calcularesta(int x, int y)
    {
        int res = x - y - 2;
        return res;
    }
    public override int calculamultiplicacion(int x, int y)
    {
        int res = (x / y) * 2;
        return res;
    }
}
public class ejemplo
{
    public static void Main()
    {
        clasederivada1 objderivado1 = new clasederivada1();
        Console.WriteLine("Calcula suma " + objderivado1.calculasuma(10, 5));
        Console.WriteLine("calcula rest " + objderivado1.calcularesta(10, 5));
        Console.WriteLine("calcula multiplicacon " + objderivado1.calculamultiplicacion(10, 5));
    }
}