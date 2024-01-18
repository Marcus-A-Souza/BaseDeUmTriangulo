
using BaseDeUmTriangulo;
using System;
using System.Formats.Asn1;
using System.Globalization;
namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre Com As Medidias do Triangulo X ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areax = x.area();
            double areay = y.area();


            Console.WriteLine("Entre Com as Medidias do Trinagulo y ");
            y.A = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);
            y.B = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("a area de x " + areax.ToString("F4"));
            Console.WriteLine("a area de y " + areay.ToString("F4"));

            if (areax > areay)
            {
                Console.WriteLine("a maior area é x");
            }
            else
            {
                Console.WriteLine("a maior área é y");
            }



        }
    }
}
