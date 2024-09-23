using System;

namespace uri1165 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
        
            for (int i = 0; i < n; i++) {
                bool ePrimo = true;
                int x = int.Parse(Console.ReadLine());
                for (int j = 2; j <= Math.Sqrt(x); j++) {
                    if (x % j == 0) ePrimo = false; 
                }
                if (ePrimo == true) {
                    Console.WriteLine(x + " eh primo");
                } else {
                    Console.WriteLine(x + " nao eh primo");
                }
            }

        }
    }
}
