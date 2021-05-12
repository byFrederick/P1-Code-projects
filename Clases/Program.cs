using System;

//Ejemplo 1
/*namespace Clases
{
    class casa 
    {
        public string color;

        public casa()//Constructor por default. No obtiene ninguno valor de variables externas.
        {
            color = "morao";
        }
        static void Main()
        {
            casa playa = new casa(); //Crea el objeto para llamar al constructor
            Console.WriteLine(playa.color);
        }
    }
}*/
//Ejemplo 2 
/*class casa
{
    public string color;
    public casa()
    {
        color = "morao";
    }
    public void desplegarmsg()//Creacion de un metodo sin retorno
    {
        Console.WriteLine("La casa esta cerca del mar");
    }
    static void Main()
    {
        casa playa = new casa();
        playa.desplegarmsg();
        Console.WriteLine(playa.color);

    }
}*/
//Ejemplo 3
class potencia
{
    public int x, y;
    public potencia (int x, int y)
    {
        Console.WriteLine("Instancia creada");
        this.x = x;
        this.y = y;
        double c = Math.Pow(this.x, this.y);
        Console.WriteLine("Resultado = " + c);
    }
    ~potencia()
    {
        Console.WriteLine("Instancia eliminana");
    }
}
class program
{
    static void Main()
    {
        metodovalores();
        GC.Collect();//Metodo para recoger la basura y limpiarla
    }
    public static void metodovalores()
    {
        potencia objpotencia = new potencia(2, 3);
    }
}