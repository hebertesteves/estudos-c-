using System;
using System.Globalization;

namespace uri1041 {
    internal class Program {
        static void Main(string[] args) {

            string[] eixos = Console.ReadLine().Split(' ');
            double x = double.Parse(eixos[0], CultureInfo.InvariantCulture);
            double y = double.Parse(eixos[1], CultureInfo.InvariantCulture);
            
            if (x > 0 && y > 0) {
                Console.WriteLine("Q1");
            } else if (x < 0 && y > 0) {
                Console.WriteLine("Q2");
            } else if (x < 0 && y < 0) {
                Console.WriteLine("Q3");
            } else if (x > 0 && y < 0) {
                Console.WriteLine("Q4");
            } else if (x == 0 && y != 0) {
                Console.WriteLine("Eixo Y");
            } else if (x != 0 && y == 0) {
                Console.WriteLine("Eixo X");
            } else {
                Console.WriteLine("Origem");
            }

        }
    }
}
