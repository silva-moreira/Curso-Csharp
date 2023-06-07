using System;
using System.Globalization;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, horas;
            double valorHora, salario;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine("NUMERO = " + numero);
            Console.WriteLine("Salario = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}