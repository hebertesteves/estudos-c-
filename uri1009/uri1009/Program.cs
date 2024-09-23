using System;
using System.Globalization;

namespace uri1009 {
    internal class Program {
        static void Main(string[] args) {
            string nome = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double comissao = (vendas * 15) / 100;
            Console.WriteLine("TOTAL = R$ " + (salarioFixo + comissao).ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
