using System;
using System.Globalization;

namespace uri1021 {
    internal class Program {
        static void Main(string[] args) {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota100, nota50, nota20, nota10, nota5, nota2;
            double moeda1, moeda050, moeda025, moeda010, moeda005, moeda001;

            nota100 = Math.Floor(valor / 100.00);
            valor %= 100.00;

            nota50 = Math.Floor(valor / 50.00);
            valor %= 50.00;

            nota20 = Math.Floor(valor / 20.00);
            valor %= 20.00;

            nota10 = Math.Floor(valor / 10.00);
            valor %= 10.00;

            nota5 = Math.Floor(valor / 5.00);
            valor %= 5.00;

            nota2 = Math.Floor(valor / 2.00);
            valor %= 2.00;

            moeda1 = Math.Floor(valor / 1.00);
            valor %= 1.00;

            moeda050 = Math.Floor(valor / 0.50);
            valor %= 0.50;

            moeda025 = Math.Floor(valor / 0.25);
            valor %= 0.25;

            moeda010 = Math.Floor(valor / 0.10);
            valor %= 0.10;

            moeda005 = Math.Floor(valor / 0.05);
            valor %= 0.05;

            moeda001 = Math.Round(valor / 0.01);

            Console.WriteLine("NOTAS:");
            Console.WriteLine(nota100 + " nota(s) de R$ 100.00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50.00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20.00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10.00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5.00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moeda1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(moeda050 + " moeda(s) de R$ 0.50");
            Console.WriteLine(moeda025 + " moeda(s) de R$ 0.25");
            Console.WriteLine(moeda010 + " moeda(s) de R$ 0.10");
            Console.WriteLine(moeda005 + " moeda(s) de R$ 0.05");
            Console.WriteLine(moeda001 + " moeda(s) de R$ 0.01");


        }
    }
}
