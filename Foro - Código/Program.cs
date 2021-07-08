using System;

abstract class split
{
    public string inputNum;
    public string[] arrayString;
    string[] checkArray;
    int check;
    bool seguir = false;
    public split()
    {
        while (seguir == false){
            try
            {
                Console.WriteLine("Digite una secuencia de numeros separados por un espacio");
                inputNum = Console.ReadLine();

                //Validación de secuencia introducida

                checkArray = inputNum.Split(" ");
                foreach (string checkNumbers in checkArray)
                {
                    check += int.Parse(checkNumbers);
                }
                seguir = true;
            }
            catch
            {
                Console.WriteLine("Digita una secuencia válida");
            }
        }
    }
    public void splitString()
    {
        arrayString = inputNum.Split(" ");
    }
    public virtual void sumItems(){ }
}
sealed class sumArray : split
{
    int sumTotal;
    public override void sumItems()
    {
        foreach (string number in arrayString)
        {
            sumTotal += int.Parse(number);
        }
        Console.WriteLine("La suma de la secuencia de número es: {0}", sumTotal);
    }
}
class program
{
    static void Main()
    {
        sumArray sumArrayObj = new sumArray();
        sumArrayObj.splitString();
        sumArrayObj.sumItems();
    }
}