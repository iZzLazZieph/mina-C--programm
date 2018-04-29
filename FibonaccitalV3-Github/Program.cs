using System;

namespace FibonaccitalV3_Github
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till min Fibonaccital generator!");
            Console.WriteLine();
            int x, y, z, v;

        Start:

            Console.WriteLine("Ange maxtal:");
            Console.WriteLine();
            try
            {
                v = int.Parse(Console.ReadLine());
                Console.WriteLine();

            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Felaktig input:");
                goto Start;
            }
            x = 0;
            y = 1;
            while (x <= v)
            {
                Console.WriteLine(x);
                z = x + y;
                x = y;
                y = z;
            }
            Console.WriteLine();
            goto Start;
        }
    }
}
