using System;
using System.Collections.Generic;

/// <summary>
/// The abstract Component class
/// </summary>
abstract class RestaurantDish
{
    public abstract void Display();
}

/// <summary>
/// A ConcreteComponent class
/// </summary>
class FreshSalad : RestaurantDish
{
    private string _greens;
    private string _cheese; //I am going to use this pun everywhere I can
    private string _dressing;

    public FreshSalad(string greens, string cheese, string dressing)
    {
        _greens = greens;
        _cheese = cheese;
        _dressing = dressing;
    }

    public override void Display()
    {
        Console.WriteLine("\nFresh Salad:");
        Console.WriteLine(" Greens: {0}", _greens);
        Console.WriteLine(" Cheese: {0}", _cheese);
        Console.WriteLine(" Dressing: {0}", _dressing);
    }
}

/// <summary>
/// A ConcreteComponent class
/// </summary>
class Pasta : RestaurantDish
{
    private string _pastaType;
    private string _sauce;

    public Pasta(string pastaType, string sauce)
    {
        _pastaType = pastaType;
        _sauce = sauce;
    }

    public override void Display()
    {
        Console.WriteLine("\nClassic Pasta:");
        Console.WriteLine(" Pasta: {0}", _pastaType);
        Console.WriteLine(" Sauce: {0}", _sauce);
    }
}

/// <summary>
/// The abstract Decorator class.  
/// </summary>
abstract class Decorator : RestaurantDish
{
    protected RestaurantDish _dish;

    public Decorator(RestaurantDish dish)
    {
        _dish = dish;
    }

    public override void Display()
    {
        _dish.Display();
    }
}

/// <summary>
/// A ConcreteDecorator. This class will impart "responsibilities" onto the dishes 
/// (e.g. whether or not those dishes have enough ingredients left to order them)
/// </summary>
class Available : Decorator
{
    public int NumAvailable { get; set; } //How many can we make?
    protected List<string> customers = new List<string>();
    public Available(RestaurantDish dish, int numAvailable) : base(dish)
    {
        NumAvailable = numAvailable;
    }

    public void OrderItem(string name)
    {
        if (NumAvailable > 0)
        {
            customers.Add(name);
            NumAvailable--;
        }
        else
        {
            Console.WriteLine("\nNot enough ingredients for " + name + "'s order!");
        }
    }

    public override void Display()
    {
        base.Display();

        foreach (var customer in customers)
        {
            Console.WriteLine("Ordered by " + customer);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        //Step 1: Define some dishes, and how many of each we can make
        FreshSalad caesarSalad = new FreshSalad("Crisp romaine lettuce", "Freshly-grated Parmesan cheese", "House-made Caesar dressing");
        caesarSalad.Display();

        Pasta fettuccineAlfredo = new Pasta("Fresh-made daily pasta", "Creamly garlic alfredo sauce");
        fettuccineAlfredo.Display();

        Console.WriteLine("\nMaking these dishes available.");

        //Step 2: Decorate the dishes; now if we attempt to order them once we're out of ingredients, we can notify the customer
        Available caesarAvailable = new Available(caesarSalad, 3);
        Available alfredoAvailable = new Available(fettuccineAlfredo, 4);

        //Step 3: Order a bunch of dishes
        caesarAvailable.OrderItem("John");
        caesarAvailable.OrderItem("Sally");
        caesarAvailable.OrderItem("Manush");

        alfredoAvailable.OrderItem("Sally");
        alfredoAvailable.OrderItem("Francis");
        alfredoAvailable.OrderItem("Venkat");
        alfredoAvailable.OrderItem("Diana");
        alfredoAvailable.OrderItem("Dennis"); //There won't be enough for this order.

        caesarAvailable.Display();
        alfredoAvailable.Display();

        Console.ReadKey();
    }
}