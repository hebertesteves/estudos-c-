using System;

namespace uri1101 {
    internal class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            int m = int.Parse(valores[0]);
            int n = int.Parse(valores[1]);
            int troca;
            

            while (m > 0 && n > 0) {
                if (m > n) {
                    troca = m;
                    m = n;
                    n = troca;
                }

                int soma = 0;

                for (int i = m; i <= n; i++) {
                    Console.Write(i + " ");
                    soma += i;
                }
                Console.WriteLine("Sum=" + soma);

                string[] valores1 = Console.ReadLine().Split(' ');
                m = int.Parse(valores1[0]);
                n = int.Parse(valores1[1]);
            }

        }
    }
}
