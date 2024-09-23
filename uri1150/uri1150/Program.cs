using System;

namespace uri1150 {
    internal class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            while (x >= z) {
                z = int.Parse(Console.ReadLine());
            }

            int cont = 1;
            int soma = x;

            while (soma <= z) {
                soma += x + 1;
                x++;
                cont++;
            }

            Console.WriteLine(cont);

        }
    }
}
