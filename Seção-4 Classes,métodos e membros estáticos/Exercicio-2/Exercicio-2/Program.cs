using Exercicio_2;
using System;
using System.Globalization;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Entre com os dados do primeiro Funcionario");
            Console.WriteLine("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.WriteLine("Salario: ");
            funcionario1.Salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados do segundo funcionario");
            Console.WriteLine("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.WriteLine("Salario: ");
            funcionario2.Salario = int.Parse(Console.ReadLine());

            double Total = (funcionario1.Salario + funcionario2.Salario) / 2;

            Console.WriteLine("Salario medio: " + Total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}