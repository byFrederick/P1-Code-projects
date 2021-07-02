//using System;

//namespace Ejercicio_2_Manejo_de_Excepcion
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Bienvenido al consultorio ");
//            Cita paciente = new Cita();
//            paciente.pedir();
//        }
//    }
//    class Cita
//    {
//        public void pedir()
//        {
//            string dia;
//            do
//            {
//                Console.Write("Escriba el día: ");
//                dia = Console.ReadLine();
//                if (string.IsNullOrEmpty(dia))
//                {
//                    Console.WriteLine("Por favor escriba el día.");
//                }
//                else if (int.TryParse(dia, out _))
//                {
//                    Console.WriteLine("Solo se permiten letras, escriba el día");
//                }
//                else if (double.TryParse(dia, out _))
//                {
//                    Console.WriteLine("Solo se permiten letras, escriba el día");
//                }
//            } while (string.IsNullOrEmpty(dia) || int.TryParse(dia, out _) || double.TryParse(dia, out _));

//            string hora;
//            do
//            {
//                Console.Write("Digite la hora de la consulta: ");
//                hora = Console.ReadLine();
//                if (!int.TryParse(hora, out _))
//                {
//                    Console.WriteLine("Por favor, solo números válidos.");
//                }
//                else if (Convert.ToInt32(hora) <= 0 || Convert.ToInt32(hora) > 23)
//                {
//                    Console.WriteLine("Por favor, ingrese la hora");
//                }

//            } while (!int.TryParse(hora, out _) || Convert.ToInt32(hora) <= 0 || Convert.ToInt32(hora) > 23);
//            string minuto;
//            do
//            {
//                Console.Write("Digite los minutos de la consulta: ");
//                minuto = Console.ReadLine();
//                if (!int.TryParse(minuto, out _))
//                {
//                    Console.WriteLine("Por favor, solo números válidos.");
//                }
//                else if (Convert.ToInt32(minuto) <= 0 || Convert.ToInt32(minuto) > 59)
//                {
//                    Console.WriteLine("Por favor, ingrese los minutos");
//                }

//            } while (!int.TryParse(minuto, out _) || Convert.ToInt32(minuto) <= 0 || Convert.ToInt32(minuto) > 23);
//            string descripcion;
//            do
//            {
//                Console.WriteLine("Describa la cita: ");
//                descripcion = Console.ReadLine();
//                if (string.IsNullOrEmpty(descripcion))
//                {
//                    Console.WriteLine("Por favor describa la cita.");
//                }
//                else if (int.TryParse(descripcion, out _))
//                {
//                    Console.WriteLine("Solo se permiten letras.");
//                }
//                else if (double.TryParse(descripcion, out _))
//                {
//                    Console.WriteLine("Solo se permiten letras");
//                }
//            } while (string.IsNullOrEmpty(descripcion) || int.TryParse(descripcion, out _) || double.TryParse(descripcion, out _));
//        }
//        public Cita(string dia, int hora, int minuto, string descripcion)
//        {

//        }

//    }
//}
using System;
class Cita
{
    string dia;
    int hora, minuto;
    string descripcionCita;
    public Cita(string dia, int hora, int minuto, string descripcionCita)
    {
        try
        {
            if (dia == "lunes")
            {
                this.dia = dia;
            }
            else
            {
                throw new ArgumentException("El parámetro ingresado no es válido");
            }
        }
        catch (ArgumentException error)
        {
            Console.WriteLine(error.Message);
        }
        
    }
}
class Program
{
    static void Main()
    {
        Cita citaobj = new Cita("lunes", 13, 22, "..");
        
    }
}