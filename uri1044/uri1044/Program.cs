using System;

namespace uri1044 {
    internal class Program {
        static void Main(string[] args) {
            string[] numeros = Console.ReadLine().Split(' ');
            int a = int.Parse(numeros[0]);
            int b = int.Parse(numeros[1]);
            int troca;

           if (b > a) {
                troca = b;
                b = a;
                a = troca;
            }

           if (a % b == 0) {
                Console.WriteLine("Sao Multiplos");
            } else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
