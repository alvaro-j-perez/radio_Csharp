using System;

namespace capsulas
{
    class Program
    {
        static void Main(string[] args)
        {
         
          Console.WriteLine(x(20, 30));

          Console.WriteLine("============");

          Console.WriteLine(y(20, 30));

        }

        static int x(int numero1, int numero2) => numero1*numero2;

        static int y(int opera1, int opera2)
        {
            return opera1 + opera2;
        }
    }
}
