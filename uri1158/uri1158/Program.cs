using System;

namespace uri1158 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] numeros = Console.ReadLine().Split(' ');
                int x = int.Parse(numeros[0]);
                int y = int.Parse(numeros[1]);

                int soma = 0;

                if (x % 2 != 0) {
                    for (int ini = 0; ini < y; ini++) {
                        soma += x;
                        x += 2;
                    }
                } else {
                    x++;
                    for (int ini = 0; ini < y; ini++) {
                        soma += x;
                        x += 2;
                    }
                }
                
                Console.WriteLine(soma);
            }

        }
    }
}
