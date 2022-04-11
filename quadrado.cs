using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var numeros = $"{i} {i * i} {i * i * i}";

                Console.WriteLine(numeros);
            }
           
        }
    }
}
