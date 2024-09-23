using System;
using System.Globalization;

namespace uri1051 {
    internal class Program {
        static void Main(string[] args) {

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0;

            if (salario >= 0.00 && salario <= 2000.00) {
                Console.WriteLine("Isento");
            } else if (salario <= 3000.00) {
                imposto = (salario - 2000.00) * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2"), CultureInfo.InvariantCulture);
            } else if (salario <= 4500.00) {
                imposto = (1000.00 * 0.08) + ((salario - 2000) - 1000) * 0.18;
                Console.WriteLine("R$ " + imposto.ToString("F2"), CultureInfo.InvariantCulture);
            } else {
                imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + ((salario - 4500) * 0.28);
                Console.WriteLine("R$ " + imposto.ToString("F2"), CultureInfo.InvariantCulture);
            }
            
        }
    }
}
