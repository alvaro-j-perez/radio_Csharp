using System;

namespace capsulas
{
    class Program
    {
        static void Main(string[] args)
        {
           const double PI = 3.1416;
           Console.WriteLine("INTRODUCE EL NUMERO DEL RADIO QUE DESEAS: ");

           double radio = double.Parse(Console.ReadLine());

           double area = Math.Pow(radio, 2) * PI;

           Console.WriteLine($"EL AREA DEL CIRCULO ES: {area}");
           
        }
    }
}
