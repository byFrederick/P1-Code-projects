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

                Console.WriteLine("Resulado = {0}", num1 / num2);
            }
            catch (Exception err)
            {
                Console.WriteLine("Excepcion {0}", err.Message);
            }
            finally
            {
                Console.WriteLine("Fin del programa");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            excepcion objex = new excepcion();
            objex.div();
        }
    }
