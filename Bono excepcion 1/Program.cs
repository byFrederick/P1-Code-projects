using System;

/* Escribir un programa que controle al menos 2 tipos de excepciones y contenga la sentencia 
  finally (el programa debe ser diferente a los ejemplos realizados en clase).*/

class BiberonesMes 
{
    int hijos;
    int biberoneDiario;
    int resultado;
    public BiberonesMes()
    {
        while(hijos < 1)
        {
            try
            {
                Console.WriteLine("Introduzca el numero de hijos");
                hijos = int.Parse(Console.ReadLine());
                if(hijos < 1)
                {
                    throw new ArgumentException("El numero de hijos no puede ser menor a 1");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        while (biberoneDiario < 1)
        {
            try
            {
                Console.WriteLine("Introduzca el numero de biberones diarios (Si no digitas un numero valido, se colocara 1 por defecto)");
                biberoneDiario = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(biberoneDiario < 1)
                {
                    biberoneDiario = 1;
                }
            }
        }
        
        resultado = 0;
    }
    public void CalcularBiberonesMes()
    {
        resultado = hijos * biberoneDiario;
        Console.WriteLine($"El numero de biberones al mes que consume(n) su(s) hijo(s) es {resultado*30}");
    }
}
class Program
{
    static void Main()
    {
        BiberonesMes biberonesMesobj = new BiberonesMes();
        biberonesMesobj.CalcularBiberonesMes();
    }
}