using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class ArregloNumeros
    {
        private int[] numeros = new int[10];

    // Llenar arreglo con validación
    public void LlenarArreglo()
    {
        Console.Clear();
        Console.WriteLine("INGRESO DE 10 NÚMEROS ENTEROS");
        for (int i = 0; i < numeros.Length; i++)
        {
            int valor;
            bool valido;
            do
            {
                Console.Write($"Ingrese el número #{i + 1}: ");
                valido = int.TryParse(Console.ReadLine(), out valor);
                if (!valido)
                    Console.WriteLine("Entrada inválida. Debe ser un número entero.");
            } while (!valido);

            numeros[i] = valor;
        }
    }

    // Búsqueda lineal
    public void BuscarNumero()
    {
        Console.Write("Ingrese el número a buscar: ");
        int numBuscar = int.Parse(Console.ReadLine());

        int posicion = -1;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numBuscar)
            {
                posicion = i;
                break;
            }
        }

        if (posicion != -1)
            Console.WriteLine($"Número encontrado en la posición {posicion} (0 basado).");
        else
            Console.WriteLine("Número no encontrado.");
    }

    // Encontrar segundo mayor
    public int SegundoMayor()
    {
        int mayor = int.MinValue;
        int segundo = int.MinValue;

        foreach (int n in numeros)
        {
            if (n > mayor)
            {
                segundo = mayor;
                mayor = n;
            }
            else if (n > segundo && n < mayor)
            {
                segundo = n;
            }
        }

        return segundo;
    }

    // Ordenar ascendente (burbuja)
    public void OrdenarBurbuja()
    {
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = 0; j < numeros.Length - 1 - i; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }
    }

    // Mostrar arreglo
    public void MostrarArreglo()
    {
        Console.WriteLine("Arreglo completo:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine();
    }

    // Mostrar posiciones pares
    public void MostrarPosicionesPares()
    {
        Console.WriteLine("Elementos en posiciones pares:");
        for (int i = 0; i < numeros.Length; i += 2)
        {
            Console.WriteLine($"Posición {i}: {numeros[i]}");
        }
    }
    }
}