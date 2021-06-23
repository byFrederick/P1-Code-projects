using System;

class excepcion
{
    public void div()
    {
        try
        {
            Console.WriteLine("Ingrese el primer numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Resulado = " + (num1 / num2));
        }
        catch (DivideByZeroException) {
            Console.WriteLine("Divido entre cero");
        }
        catch (Exception err)
        {
            Console.WriteLine("Excepcion " + err.Message);
        }
        finally
        {
            Console.WriteLine("Fin del programa");
        }
    }
}

class Program
{
    static void Main()
    {
        excepcion objexcepcion = new excepcion();
        objexcepcion.div();
    }
}
}