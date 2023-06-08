using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
    ///mensagem explicativa, conforme exemplos.
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}