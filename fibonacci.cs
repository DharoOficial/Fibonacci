using System;

namespace fibonacci
{
    public class fibonacci
    {
        public void GerarFibonacci(int n1, int n2, int vezes)
        {
            if(vezes > 0){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(n1);
                GerarFibonacci(n2, n1 + n2, vezes -1);
                Console.ResetColor();
            }
        }
    }
    
}