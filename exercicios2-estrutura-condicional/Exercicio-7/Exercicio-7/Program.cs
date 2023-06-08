using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double EixoX = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double EixoY = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (EixoX == 0.0 && EixoY == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (EixoX == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (EixoY == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (EixoX > 0.0 && EixoY > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (EixoX < 0.0 && EixoY > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (EixoX < 0.0 && EixoY < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}