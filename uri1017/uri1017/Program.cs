using System;
using System.Globalization;

namespace uri1017 {
    internal class Program {
        static void Main(string[] args) {
            double horas = double.Parse(Console.ReadLine());
            double velMedia = double.Parse(Console.ReadLine());
            double litros = (horas * velMedia) / 12;
            Console.WriteLine(litros.ToString("F3"), CultureInfo.InvariantCulture);
        }
    }
}
