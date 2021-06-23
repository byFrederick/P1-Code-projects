using System;

/*
    Escriba una clase Cita para controlar la agenda de un médico. La clase tendrá los
    siguientes atributos y sus respectivas propiedades:
    a) Día de la semana (ejemplo: lunes).
    b) Hora (Entero entre 0 y 23)
    c) Minuto (Entero entre 0 y 59)
    d) Descripción de la cita (cadena)

    Agregue un constructor que reciba como parámetros todos los datos de la cita. Si el 
    día, hora ó minuto no son válidos, entonces el constructor provocará una excepción de 
    tipo ArgumentException.
*/

class Cita
{
    string diaSemana;
    int hora;
    int minuto;
    string descripcionCita;
    public Cita(string diaS, int hor, int min, string descrip)
    {
        if(diaS != "lunes" || diaS != "martes" || diaS != "miercoles" || diaS != "jueves" || diaS != "viernes" ||
            diaSemana != "sabado")
        {
            try
            {
                diaSemana = diaS;
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
        }
        if(hora < 0 || hora > 23)
        {
            try
            {
                hora = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Debe digitar un numero válido");
            }
        }
         if(minuto < 1 || minuto > 58)
        {
            try
            {
                Console.WriteLine("Digite la hora (Debe estar dentro de 0 y 59)");
                hora = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Debe digitar un numero válido");
            }
        }
        while (string.IsNullOrEmpty(descripcionCita))
        {
            Console.WriteLine("Digite una descripcion para la cita");
            descripcionCita = Console.ReadLine();
        }
    }
}