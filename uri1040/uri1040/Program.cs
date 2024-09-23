using System;
using System.Globalization;

namespace uri1040 {
    internal class Program {
        static void Main(string[] args) {

            string[] notas = Console.ReadLine().Split(' ');
            double n1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
            double n4 = double.Parse(notas[3], CultureInfo.InvariantCulture);
            double exame;

            double media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10.0;
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0) {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 5.0 && media <= 6.9) {
                Console.WriteLine("Aluno em exame.");
                exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));

                media = (media + exame) / 2.0;

                if (media >= 5.0) {
                    Console.WriteLine("Aluno aprovado.");
                }
                else {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
            else {
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}
