using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class Combinatoria
    {
        private int N;
        private int R;
        public void PedirNyR()
        {
            Console.WriteLine("Ingrese valor de N a sacar factorial y combinatoria");
            N = int.Parse(Console.ReadLine());
             Console.Write("Ingrese el valor de r: ");
            R = int.Parse(Console.ReadLine());
        }
        public int SacarFactorial(int numero)
        {
            int i = 0, factorial = 1;
            
            for (i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
       
        public void SacarCombinatoria()
        {
        int factorialN = SacarFactorial(N);
        int factorialR = SacarFactorial(R);
        int factorialNR = SacarFactorial(N - R);

        int combinacion = factorialN / (factorialR * factorialNR);

        Console.WriteLine("Factorial de n (" + N + ") = " + factorialN);
        Console.WriteLine("C(" + N + ", " + R + ") = " + combinacion);
    }
}
}