using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            Console.WriteLine($"MEDIA = {((A*2 + B*3 + C*5) / 10).ToString("N1")}");
            Console.ReadKey();
        }
    }
}
