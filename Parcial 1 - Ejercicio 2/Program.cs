using System;

class gasolinera
{
    double inputGalones;
    double precioLitro;
    double litros;
    double montoCobro;
    public gasolinera()//Constructor para fijar el precio por litro
    {
        precioLitro = 0.894;
        Console.WriteLine("Digite la cantidad de galones");
        inputGalones = double.Parse(Console.ReadLine());
    }
    public void convertGaL()//Método para convertir de galones a litros 
    {
        litros = inputGalones * 3.78;

    }
    public void monto()//Método para calcular el monto a cobrar 
    {
        montoCobro = Math.Round(litros * precioLitro, 2);
        Console.WriteLine("El monto a cobrar es: " + montoCobro);
    }
}
class program
{
    static void Main()
    {
        gasolinera gasolineraobj = new gasolinera();
        Console.WriteLine("");
        gasolineraobj.convertGaL();
        gasolineraobj.monto();
    }
}
