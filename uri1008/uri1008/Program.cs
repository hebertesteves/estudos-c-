using System;
using System.Globalization;

namespace uri1008 {
    internal class Program {
        static void Main(string[] args) {
            int num = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NUMBER = " + num);
            Console.WriteLine("SALARY = U$ " + (salario * horas).ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
