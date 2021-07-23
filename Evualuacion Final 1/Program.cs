using System;
using System.Text.RegularExpressions;
//Component Class
abstract class BurguerKing
{
    public abstract void Desplegar();
}

//ConcreteComponent class
class Hamburguesa : BurguerKing
{
    private string hamburguesa;
    public Hamburguesa()
    {
        try
        {
            Console.WriteLine("Digite la hamburguesa que desea pedir");
            hamburguesa = Console.ReadLine();
            if(string.IsNullOrEmpty(hamburguesa) == true || Regex.IsMatch(hamburguesa, @"[\p{L} ]+$") == false)
            {
                throw new ArgumentException();
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    } 
    public override void Desplegar()
    {
        Console.WriteLine("Hamburguesa: {0}", hamburguesa);
    }
}

//Abstract Decorator class
abstract class IngredientesExtras : BurguerKing
{
    protected BurguerKing hamburguesa;
    public IngredientesExtras(BurguerKing hamburguesa)
    {
        this.hamburguesa = hamburguesa;
    }
    public override void Desplegar()
    {
        hamburguesa.Desplegar();
    }
}

//ConcretDecorator class. This class will impart "responsibilities" onto the dishes
class Extras : IngredientesExtras
{
    string ingrExtra1, ingrExtra2;
    public Extras(BurguerKing hamburguesa) : base(hamburguesa)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Digite el primer ingrediente extra");
                ingrExtra1 = Console.ReadLine();
                if (string.IsNullOrEmpty(ingrExtra1) == true || Regex.IsMatch(ingrExtra1, @"[\p{L} ]+$") == false)
                {
                    throw new ArgumentException();
                }
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        while (true)
        {
            try
            {
                Console.WriteLine("Digite el segundo ingrediente extra");
                ingrExtra2 = Console.ReadLine();
                if (string.IsNullOrEmpty(ingrExtra2) == true || Regex.IsMatch(ingrExtra2, @"[\p{L} ]+$") == false)
                {
                    throw new ArgumentException();
                }
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    private void addIngr(BurguerKing hamburguesa)
    {
        Console.WriteLine("Primer ingrediente extra: {0}\nSegundo ingrediente extra: {1}", ingrExtra1, ingrExtra2);
    }
    public override void Desplegar()
    {
        base.Desplegar();
        addIngr(hamburguesa);
    }
}
class Program
{
    static void Main()
    {
        Hamburguesa hamburguesa = new Hamburguesa();
        Extras ingrExtras = new Extras(hamburguesa);
        Console.Clear();
        ingrExtras.Desplegar();
    }
}

