using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite as coordenadas X e Y");
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[0]);

            while (x != 0 || y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("Primeiro");
                }
                else if (x > 0 && y < 0) {
                    Console.WriteLine("Quarto");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("Terceiro");
                }
                else if (x < 0 && y > 0) { 
                    Console.WriteLine("Segundo");
                }
                vet = Console.ReadLine().Split(' ');
                    x = int.Parse(vet[0]);
                    y = int.Parse(vet[1]);
            }
        }
    }
}