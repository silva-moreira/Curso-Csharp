using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Codigo1, Codigo2, qte1, qte2;
            double preco1, preco2, Total;

            string[] valores = Console.ReadLine().Split(' ');
            Codigo1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            Codigo2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Total = preco2 * qte1 + preco2 * qte2;

            Console.WriteLine("Valor a pagar: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
