using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class FrecuenciaNumeros
    {
        private int[] numeros = new int[20];
    private int[] frecuencias = new int[10]; // índice 0 = número 1, índice 9 = número 10
    private Random random = new Random();

    // Generar números aleatorios
    public void GenerarNumeros()
    {
        Console.Clear();
        Console.WriteLine("Números generados aleatoriamente:");

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = random.Next(1, 11); // 1 a 10
            Console.Write(numeros[i] + " ");
        }

        Console.WriteLine("\n");
    }

    // Calcular frecuencias
    public void CalcularFrecuencias()
    {
        // Inicializar frecuencias
        for (int i = 0; i < frecuencias.Length; i++)
            frecuencias[i] = 0;

        // Contar frecuencia de cada número
        foreach (int num in numeros)
        {
            frecuencias[num - 1]++; // num 1 → índice 0
        }
    }

    // Mostrar resultados
    public void MostrarFrecuencias()
    {
        int maxFreq = frecuencias[0];
        int minFreq = frecuencias[0];
        int numMax = 1;
        int numMin = 1;

        Console.WriteLine("Frecuencia de cada número:");

        for (int i = 0; i < frecuencias.Length; i++)
        {
            Console.WriteLine($"Número {i + 1}: {frecuencias[i]} veces");

            if (frecuencias[i] > maxFreq)
            {
                maxFreq = frecuencias[i];
                numMax = i + 1;
            }

            if (frecuencias[i] < minFreq)
            {
                minFreq = frecuencias[i];
                numMin = i + 1;
            }
        }

        Console.WriteLine($"\nNúmero más frecuente: {numMax} ({maxFreq} veces)");
        Console.WriteLine($"Número menos frecuente: {numMin} ({minFreq} veces)");
    }
    }
}