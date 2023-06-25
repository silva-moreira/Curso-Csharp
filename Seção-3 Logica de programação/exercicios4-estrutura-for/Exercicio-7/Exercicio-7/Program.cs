using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumeroLinha = int.Parse(Console.ReadLine());

            for (int i = 1; i <= NumeroLinha; i++)
            {

                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
        }
    }
}