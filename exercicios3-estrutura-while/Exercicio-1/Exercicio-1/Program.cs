using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Senha = 1000;

            int Tentativas = int.Parse(Console.ReadLine());

            while(Senha != Tentativas)
            {
                Console.WriteLine("Senha Invalida");
                Tentativas = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}