<<<<<<< HEAD
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
=======
﻿using System;
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
>>>>>>> de6b5ab0326211d55eaf246002fccf9c83ce537e
