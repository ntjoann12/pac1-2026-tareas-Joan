using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
class Fibonacci
{
    private int n;

    public void PedirN()
    {
        Console.Write("Ingrese la cantidad de términos: ");
        n = int.Parse(Console.ReadLine());
    }

    public void GenerarSerie()
    {
        int a = 0;
        int b = 1;
        int suma = 0;

        Console.WriteLine("Serie de Fibonacci:");

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(a);
            suma += a;

            int siguiente = a + b;
            a = b;
            b = siguiente;
        }

        double promedio = 0;

        if (n > 0)
        {
            promedio = (double)suma / n;
        }

        Console.WriteLine("Suma total: " + suma);
        Console.WriteLine("Promedio: " + promedio);
    }
}

}