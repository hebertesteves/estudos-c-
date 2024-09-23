using System;
using System.Globalization;

namespace uri1010 {
    internal class Program {
        static void Main(string[] args) {
            string[] valores1 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(valores1[0]);
            int peca1 = int.Parse(valores1[1]);
            double preco1 = double.Parse(valores1[2], CultureInfo.InvariantCulture);

            string[] valores2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(valores2[0]);
            int peca2 = int.Parse(valores2[1]);
            double preco2 = double.Parse(valores2[2], CultureInfo.InvariantCulture);

            double valor = (peca1 * preco1) + (peca2 * preco2);
            Console.WriteLine("VALOR A PAGAR: R$ " + valor.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
