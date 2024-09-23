using System;
using System.Globalization;

namespace uri1015 {
    internal class Program {
        static void Main(string[] args) {
            string[] eixos1 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(eixos1[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(eixos1[1], CultureInfo.InvariantCulture);

            string[] eixos2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(eixos2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(eixos2[1], CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
            Console.WriteLine(distancia.ToString("F4"), CultureInfo.InvariantCulture);
        }
    }
}
