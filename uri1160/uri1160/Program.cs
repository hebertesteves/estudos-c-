using System;
using System.Globalization;

namespace uri1160 {
    internal class Program {
        static void Main(string[] args) {

            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                int pa = int.Parse(valores[0]);
                int pb = int.Parse(valores[1]);
                double g1 = double.Parse(valores[2], CultureInfo.InvariantCulture);
                double g2 = double.Parse(valores[3], CultureInfo.InvariantCulture);

                int anos = 0;

                while (pa <= pb) {
                    pa = (int)(pa * (100 + g1) / 100);
                    pb = (int)(pb * (100 + g2) / 100);
                    anos++;

                if (anos > 100) {
                        Console.WriteLine("Mais de 1 seculo.");
                        break;
                    }
                }

                if (anos <= 100) {
                    Console.WriteLine(anos + " anos.");
                }

            }

            }

        }
    }
