using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero = int.Parse(Console.ReadLine());

            if(Numero %2 == 0)
            {
                Console.WriteLine("Numero PAR");
            }
            else
            {
                Console.WriteLine("Numero IMPAR");
            }
        }
    }
}