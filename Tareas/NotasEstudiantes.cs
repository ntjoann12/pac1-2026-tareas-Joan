using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class NotasEstudiantes
    {
         private int cantidadEstudiantes;
    private float[,] notas; // filas = estudiantes, columnas = parciales
    private string[] nombresEstudiantes;

    // Inicializar matriz
    public void InicializarEstudiantes()
    {
        Console.Clear();
        do
        {
            Console.Write("Ingrese la cantidad de estudiantes: ");
            cantidadEstudiantes = int.Parse(Console.ReadLine());
        } while (cantidadEstudiantes <= 0);

        notas = new float[cantidadEstudiantes, 3];
        nombresEstudiantes = new string[cantidadEstudiantes];

        for (int i = 0; i < cantidadEstudiantes; i++)
        {
            Console.Write($"\nIngrese el nombre del estudiante #{i + 1}: ");
            nombresEstudiantes[i] = Console.ReadLine();

            for (int j = 0; j < 3; j++)
            {
                float nota;
                bool valido;
                do
                {
                    Console.Write($"Ingrese nota del parcial #{j + 1} (0-100): ");
                    valido = float.TryParse(Console.ReadLine(), out nota);

                    if (!valido || nota < 0 || nota > 100)
                        Console.WriteLine("Nota inválida. Debe estar entre 0 y 100.");

                } while (!valido || nota < 0 || nota > 100);

                notas[i, j] = nota;
            }
        }
    }

    // Promedio por estudiante
    public float[] PromedioPorEstudiante()
    {
        float[] promedios = new float[cantidadEstudiantes];

        for (int i = 0; i < cantidadEstudiantes; i++)
        {
            float suma = 0;
            for (int j = 0; j < 3; j++)
                suma += notas[i, j];

            promedios[i] = suma / 3;
        }

        return promedios;
    }

    // Promedio por parcial
    public float[] PromedioPorParcial()
    {
        float[] promedios = new float[3];

        for (int j = 0; j < 3; j++)
        {
            float suma = 0;
            for (int i = 0; i < cantidadEstudiantes; i++)
                suma += notas[i, j];

            promedios[j] = suma / cantidadEstudiantes;
        }

        return promedios;
    }

    // Estudiante con mejor promedio
    public void MostrarMejorEstudiante()
    {
        float[] promedios = PromedioPorEstudiante();
        float max = promedios[0];
        int indice = 0;

        for (int i = 1; i < cantidadEstudiantes; i++)
        {
            if (promedios[i] > max)
            {
                max = promedios[i];
                indice = i;
            }
        }

        Console.WriteLine($"\nMejor estudiante: {nombresEstudiantes[indice]} con promedio {max:0.00}");
    }

    // Parcial más difícil (promedio más bajo)
    public void MostrarParcialDificil()
    {
        float[] promediosParcial = PromedioPorParcial();
        float min = promediosParcial[0];
        int parcial = 1;

        for (int j = 1; j < 3; j++)
        {
            if (promediosParcial[j] < min)
            {
                min = promediosParcial[j];
                parcial = j + 1;
            }
        }

        Console.WriteLine($"Parcial más difícil: Parcial #{parcial} con promedio {min:0.00}");
    }

    // Mostrar todos los resultados
    public void MostrarResultados()
    {
        Console.Clear();
        Console.WriteLine("MATRIZ DE NOTAS POR PARCIAL");
        Console.WriteLine("----------------------------");

        for (int i = 0; i < cantidadEstudiantes; i++)
        {
            Console.Write($"{nombresEstudiantes[i]}: ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{notas[i, j]} ");
            }
            Console.WriteLine();
        }

        float[] promediosEst = PromedioPorEstudiante();
        Console.WriteLine("\nPromedio por estudiante:");
        for (int i = 0; i < cantidadEstudiantes; i++)
            Console.WriteLine($"{nombresEstudiantes[i]}: {promediosEst[i]:0.00}");

        float[] promediosParciales = PromedioPorParcial();
        Console.WriteLine("\nPromedio por parcial:");
        for (int j = 0; j < 3; j++)
            Console.WriteLine($"Parcial #{j + 1}: {promediosParciales[j]:0.00}");

        MostrarMejorEstudiante();
        MostrarParcialDificil();
    }
    }
}