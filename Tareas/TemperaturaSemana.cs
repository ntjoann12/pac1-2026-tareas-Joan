using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class TemperaturaSemana
    {
        private float[] temperaturas = new float[7];
    private string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

    // Ingresar temperaturas
    public void IngresarTemperaturas()
    {
        Console.Clear();
        Console.WriteLine("INGRESO DE TEMPERATURAS SEMANALES");

        for (int i = 0; i < temperaturas.Length; i++)
        {
            float temp;
            bool valido;
            do
            {
                Console.Write($"Ingrese la temperatura del {dias[i]}: ");
                valido = float.TryParse(Console.ReadLine(), out temp);

                if (!valido)
                    Console.WriteLine("Entrada inválida. Ingrese un número válido.");

            } while (!valido);

            temperaturas[i] = temp;
        }
    }

    // Calcular promedio
    public float CalcularPromedio()
    {
        float suma = 0;
        foreach (float temp in temperaturas)
        {
            suma += temp;
        }
        return suma / temperaturas.Length;
    }

    // Mostrar días sobre el promedio
    public void MostrarDiasSobrePromedio()
    {
        float promedio = CalcularPromedio();
        Console.WriteLine("\nDías con temperatura sobre el promedio:");

        bool hay = false;
        for (int i = 0; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] > promedio)
            {
                Console.WriteLine($"{dias[i]}: {temperaturas[i]}°");
                hay = true;
            }
        }

        if (!hay)
            Console.WriteLine("Ningún día superó el promedio.");
    }

    // Día más caluroso
    public void MostrarDiaMasCaluroso()
    {
        float max = temperaturas[0];
        int indice = 0;
        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] > max)
            {
                max = temperaturas[i];
                indice = i;
            }
        }
        Console.WriteLine($"\nDía más caluroso: {dias[indice]} ({max}°)");
    }

    // Día más frío
    public void MostrarDiaMasFrio()
    {
        float min = temperaturas[0];
        int indice = 0;
        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] < min)
            {
                min = temperaturas[i];
                indice = i;
            }
        }
        Console.WriteLine($"Día más frío: {dias[indice]} ({min}°)");
    }

    // Variación entre días consecutivos
    public void MostrarVariacionConsecutiva()
    {
        Console.WriteLine("\nVariación entre días consecutivos:");
        for (int i = 0; i < temperaturas.Length - 1; i++)
        {
            float variacion = temperaturas[i + 1] - temperaturas[i];
            Console.WriteLine($"{dias[i]} → {dias[i + 1]}: {variacion:+0.00;-0.00;0}°");
        }
    }

    // Mostrar resumen
    public void MostrarResumen()
    {
        Console.Clear();
        float promedio = CalcularPromedio();
        Console.WriteLine("RESUMEN DE TEMPERATURAS SEMANALES");
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Promedio semanal: {promedio:0.00}°");

        MostrarDiasSobrePromedio();
        MostrarDiaMasCaluroso();
        MostrarDiaMasFrio();
        MostrarVariacionConsecutiva();
    }
    }
}