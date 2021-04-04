
//Para os casos em que o resultado do método independe do objeto trabalhamos com métodos estáticos
//Nao e necessario instaciar a classe em um objeto

namespace MetodosEstaticos
{
    class Calculadora 
    {
        public static double Pi = 3.14;
        
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;

        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }

    }
}


///////////////////////////////////////////////////////////////////

using System;
using System.Globalization;

namespace MetodosEstaticos
{
    class Metodos
    {
        static void (string[] args )
        {
            Console.WriteLine("Entre com o valor do raio: ")
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI" + Calculadora.PI.ToString("F2", CultureInfo.InvariantCulture));

        }



    }
}