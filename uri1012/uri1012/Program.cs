using System;
using System.Globalization;

namespace uri1012 {
    internal class Program {
        static void Main(string[] args) {
            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double areaTriangulo = (a * c) / 2;
            double areaCirculo = 3.14159 * Math.Pow(c, 2);
            double areaTrapezio = ((a + b) * c) / 2;
            double areaQuadrado = b * b;
            double areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3"), CultureInfo.InvariantCulture);
        }
    }
}
