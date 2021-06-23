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
            }
            catch
            {
                Console.WriteLine("Digite un numero de hijos valido");
            }
        }
        while (biberoneDiario < 1)
        {
            try
            {
                Console.WriteLine("Introduzca el numero de biberones diarios (Si no digitas un numero valido, se colocara 1 por defecto)");
                biberoneDiario = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Se pondrá 1 como numero de biberones");
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
        Console.WriteLine("El numero de biberones diarios que consume(n) su(s) hijo(s) es " + resultado);
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