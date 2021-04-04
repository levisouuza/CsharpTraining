
using System;
using System.Globalization;


namespace MetodosEstaticos
{
    class Metodos
    {

        static double Pi = 3.14;

        static void (string[] args )
        {
            Console.Write("Entre com o raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor do PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {

            return 4.0 / 3.0 * Pi * Math.Pow(r,3);
        }


    }



}