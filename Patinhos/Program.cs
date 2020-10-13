using System;

namespace Patinhos
{
    class Program
    {
        static void Main(string[] args)
        {
            int pato;

            Console.Write("Digite o número de patinhos? ");
            pato = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = pato; i > 0; i -= 1)
            {
                Console.WriteLine(i + " Patinhos foram passear");
                Console.WriteLine("Além das montanhas");
                Console.WriteLine("Para brincar");
                Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá");
                Console.WriteLine("Mas só " + (i - 1) + " patinhos voltaram de lá.\n");

            }

            Console.WriteLine("A mamãe patinha foi procurar");
            Console.WriteLine("Além das montanhas");
            Console.WriteLine("Na beira do mar");
            Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá");
            Console.WriteLine("E os " + pato + " patinhos voltaram de lá.");
        }
    }
}
