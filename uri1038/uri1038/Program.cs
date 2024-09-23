using System;
using System.Globalization;

namespace uri1038 {
    internal class Program {
        static void Main(string[] args) {
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int qnd = int.Parse(valores[1]);
            double valor = 0;

            switch(codigo) {
                case 1:
                    valor = 4.00 * qnd;
                    break;

                case 2:
                    valor = 4.50 * qnd;
                    break;

                case 3:
                    valor = 5.00 * qnd;
                    break;

                case 4:
                    valor = 2.00 * qnd;
                    break;

                case 5:
                    valor = 1.50 * qnd;
                    break;
            }
            Console.WriteLine("Total: R$ " + valor.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
