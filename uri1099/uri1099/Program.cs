using System;

namespace uri1099 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            int troca;
            

            for (int i = 0; i < n; i++) {
                string[] numeros = Console.ReadLine().Split(' ');
                int x = int.Parse(numeros[0]);
                int y = int.Parse(numeros[1]);

                int soma = 0;

                if (x > y) {
                    troca = x;
                    x = y;
                    y = troca;
                }

                for (int j = x + 1; j < y; j++) {
                    if (j % 2 != 0) soma += j;
                }

                Console.WriteLine(soma);

            }

        }
    }
}
