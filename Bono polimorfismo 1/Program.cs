using System;

abstract class CuentaCliente
{
    public int numCuenta;
    public string nombreCliente;
    public double saldo;
    public CuentaCliente()
    {
        Console.WriteLine("Ingresar los datos de la cuenta\n");
        while(numCuenta < 99999 || numCuenta > 9999999)
        {
            try
            {
                Console.WriteLine("Ingrese número de la cuenta (Debe ser de 6 digitos e iniciar con un digito mayor que cero)");
                numCuenta = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("El numero de cuenta digitado no es válido");
            }
        }
        while(string.IsNullOrEmpty(nombreCliente) == true)
        {
            Console.WriteLine("Digite el nombre del cliente");
            nombreCliente = Console.ReadLine();
        }
        while(saldo < 1)
        {
            try
            {
                Console.WriteLine("Digita el saldo de la cuenta");
                saldo = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite un saldo válido");
            }
        }
    }
    public virtual void ConsultarDatos() { }
    public void Depositar()
    {
        double deposito = 0;
        while(deposito < 1)
        {
            try
            {
                Console.WriteLine("Digite la cantidad que desea depositar en la cuenta\n");
                deposito = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite una cantidad de deposito válida\n");
            }
        }
        saldo += deposito;
        Console.WriteLine("Su deposito fue de RD${0:f2}\nEl nuevo saldo de su cuenta es de RD${1:f2}", deposito, saldo);
    }
    public void Retirar()
    {
        double retiro = 0;
        while (retiro < 1)
        {
            try
            {
                Console.WriteLine("Digite el saldo a retirar");
                retiro = double.Parse(Console.ReadLine());
                if(retiro > saldo)
                {
                    Console.WriteLine("El saldo que se desea retirar supera el saldo disponible\n");
                }
            }
            catch
            {
                Console.WriteLine("Digite una cantidad válida a retirar\n");
            }
        }
        saldo -= retiro;
        Console.WriteLine("Su retiro fue de RD${0:f2}\nEl nuevo saldo de su cuenta es de RD${1:f2}", retiro, saldo);
    }
}
sealed class Ahorro : CuentaCliente
{
    public int[] fecha = new int[2];
    float interes;

    public Ahorro()
    {
        while(fecha[0] < 1 || fecha[0] > 12 || fecha[1] < 2021 || fecha[1] > 2030)
        {
            try
            {
                Console.WriteLine("Introduzca el mes de vencimiento (Si digitas un mes no válida tendrás que introducir la fecha otra vez)");
                fecha[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el año de vencimiento (Si digitas un año no válido tendrás que introducir la fecha otra vez)");
                fecha[1] = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Introduzca una fecha de vencimiento válida");
            }
        }
        while(interes < 1 || interes > 50)
        {
            try
            {
                Console.WriteLine("Digite el porcentaje de interés mensual");
                interes = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Introduzca un porcentaje de interes válido");
            }
        }
        interes = interes / 100;
    }
    public void DepositarIntereses()
    {
        double deposito;
        deposito = saldo * interes;
        saldo += deposito;
        Console.WriteLine("Su deposito por intereses fue de RD${0:f2}\nEl nuevo saldo de su cuenta es de RD${1:f2}", deposito, saldo);
    }
    public override void ConsultarDatos()
    {
        Console.WriteLine("Número de cuenta: {0}\nNombre del cliente: {1}\nSaldo: RD${2:f2}\nFecha de vencimiento: {3}/{4}\n" +
            "Porcentaje de interés mensual: {5}%", numCuenta, nombreCliente, saldo, fecha[0], fecha[1], interes * 100);
    }
}
sealed class Cheques : CuentaCliente
{
    float comisionUso, comisionCheques;
    public Cheques()
    {
        while(comisionUso < 1 || comisionCheques < 1)
        {
            try
            {
                Console.WriteLine("Digita la comision por uso de chequera");
                comisionUso = float.Parse(Console.ReadLine());
                Console.WriteLine("Digita la comision por emisión de cheques sin saldo");
                comisionCheques = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("El monto digitado no es válido");
            }
        }
    }
    public override void ConsultarDatos()
    {
        Console.WriteLine("Número de cuenta: {0}\nNombre del cliente: {1}\nSaldo: RD${2:f2}\nComisión por uso de chequera: {3:f2}\n" +
            "Comisión por emisión de cheques sin saldo: {4:f2}", numCuenta, nombreCliente, saldo, comisionUso, comisionCheques);
    }
}                           
class Program
{
    static void Main()
    {
        int opcion = 0;
        int opcionAhorro = 0;
        int opcionChequera = 0;
        int dia = 0, mes = 0, anno = 0;
        while(opcion < 1 || opcion > 2)
        {
            try
            {
                Console.WriteLine("1 - Para registrar una cuenta de ahorro\n2 - Para registrar una cuenta de cheques\n");
                opcion = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite una opción válida");
            }
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    Ahorro cuentaAhorro = new Ahorro();
                        while (opcionAhorro < 1 || opcionAhorro > 4)
                        {
                            try
                            {
                                Console.WriteLine("1 - Para depositar\n2 - Para retirar\n3 - Para depositar intereses\n4 - Para consultar datos");
                                opcionAhorro = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Digite una opción válida");
                            }
                        }
                        switch (opcionAhorro)
                        {
                            case 1:
                                Console.Clear();
                                cuentaAhorro.Depositar();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                                Console.Clear();
                                while (mes < 1 || mes > 30 || anno < 2021 || anno > 2030)
                                {
                                    try
                                    {
                                        Console.WriteLine("Digita el mes de vencimiento");
                                        mes = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digita el año de vecimiento");
                                        anno = int.Parse(Console.ReadLine());
                                        if (mes < 1 || mes > 30 || anno < 2021 || anno > 2030)
                                        {
                                            throw new ArgumentException("La fecha no es válida");
                                        }
                                    }
                                    catch(Exception e)
                                    {
                                        Console.WriteLine(e.Message);

                                    }
                                }
                                if(mes == cuentaAhorro.fecha[0] && anno == cuentaAhorro.fecha[1])
                                {
                                    cuentaAhorro.Retirar();
                                }
                                else
                                {
                                    Console.WriteLine("No se puede retirar ya que la fecha introducida no coincide con la de vencimiento." +
                                        "El programa se finalizará por motivos de seguridad");
                                }
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 3:
                                while(dia < 1 || dia > 30)
                                {
                                    try
                                    {
                                        Console.WriteLine("Digite el día");
                                        dia = int.Parse(Console.ReadLine());
                                        if (dia < 1 || dia > 30)
                                        {
                                            throw new ArgumentException("Digita un dia válido");
                                        }
                                    }
                                    catch(Exception e)
                                    {
                                        Console.WriteLine(e.Message);
                                    }
                                }
                                if(dia == 1)
                                {
                                    cuentaAhorro.DepositarIntereses();
                                    Console.ReadKey();
                                    Console.Clear();
                                } else
                                {
                                    Console.WriteLine("El dia digitado no es el válido para depositar los intereses");
                                }
                                break;
                            case 4:
                                Console.Clear();
                                cuentaAhorro.ConsultarDatos();
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                    
                    break;
                case 2:
                    Cheques cuentaCheques = new Cheques();
                    while(opcionChequera < 1 || opcionChequera > 3)
                    {
                        try
                        {
                            Console.WriteLine("1 - Para depositar\n2 - Para retirar\n3 - Para consultar datos");
                            opcionChequera = int.Parse(Console.ReadLine());
                            if(opcionChequera < 1 || opcionChequera > 3)
                            {
                                throw new ArgumentException("Digite una opción válida");
                            }
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    switch (opcionChequera)
                    {
                        case 1:
                            Console.Clear();
                            cuentaCheques.Depositar();
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            cuentaCheques.Retirar();
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            cuentaCheques.ConsultarDatos();
                            Console.ReadKey();
                            break;
                    }
                    Console.ReadKey();
                    break;
            }
        }
    }
}