using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
class NumerosPrimos
{
    private int inicio;
    private int fin;

    public void PedirRango()
    {
        Console.Write("Ingrese el inicio del rango: ");
        inicio = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el fin del rango: ");
        fin = int.Parse(Console.ReadLine());
    }

    public bool EsPrimo(int numero)
    {
        if (numero < 2)
            return false;

        for (int i = 2; i <= numero / 2; i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }

    public void MostrarPrimos()
    {
        int contador = 0;

        Console.WriteLine("Números primos en el rango:");

        for (int i = inicio; i <= fin; i++)
        {
            if (EsPrimo(i))
            {
                Console.WriteLine(i);
                contador++;
            }
        }

        Console.WriteLine("Cantidad de números primos: " + contador);
    }
}
}