using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            fibonacci fib = new fibonacci();
            System.Console.WriteLine("digite o numero de vezes que aparecera a sequencia fibonacci");
            fib.GerarFibonacci(0,1, int.Parse(Console.ReadLine()) );

        }
    }
}
