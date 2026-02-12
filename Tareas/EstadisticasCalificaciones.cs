using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class EstadisticasCalificaciones
    {
        private double[] calificaciones;
    private int cantidad;

    // Constructor
    public EstadisticasCalificaciones(int cantidad)
    {
        this.cantidad = cantidad;
        calificaciones = new double[cantidad];
    }

    // Ingresar calificaciones con validación
    public void IngresarCalificaciones()
    {
        for (int i = 0; i < cantidad; i++)
        {
            double nota;
            do
            {
                Console.Write($"Ingrese la calificación #{i + 1} (0 - 100): ");
                nota = double.Parse(Console.ReadLine());

                if (nota < 0 || nota > 100)
                {
                    Console.WriteLine("Nota inválida. Debe estar entre 0 y 100.");
                }

            } while (nota < 0 || nota > 100);

            calificaciones[i] = nota;
        }
    }

    // Calcular promedio
    public double CalcularPromedio()
    {
        double suma = 0;

        foreach (double nota in calificaciones)
        {
            suma += nota;
        }

        return suma / cantidad;
    }

    public double ObtenerMaxima()
    {
        double max = calificaciones[0];

        foreach (double nota in calificaciones)
        {
            if (nota > max)
                max = nota;
        }

        return max;
    }

    public double ObtenerMinima()
    {
        double min = calificaciones[0];

        foreach (double nota in calificaciones)
        {
            if (nota < min)
                min = nota;
        }

        return min;
    }

    public int ContarAprobados()
    {
        int aprobados = 0;

        foreach (double nota in calificaciones)
        {
            if (nota >= 60)
                aprobados++;
        }

        return aprobados;
    }

    public int ContarReprobados()
    {
        return cantidad - ContarAprobados();
    }

    // Desviación estándar
    public double CalcularDesviacionEstandar()
    {
        double promedio = CalcularPromedio();
        double suma = 0;

        foreach (double nota in calificaciones)
        {
            suma += Math.Pow(nota - promedio, 2);
        }

        return Math.Sqrt(suma / cantidad);
    }

    // Mostrar resultados
    public void MostrarResultados()
    {
        Console.Clear();
        Console.WriteLine("ESTADÍSTICAS DE CALIFICACIONES");
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Promedio: {CalcularPromedio():0.00}");
        Console.WriteLine($"Nota máxima: {ObtenerMaxima()}");
        Console.WriteLine($"Nota mínima: {ObtenerMinima()}");
        Console.WriteLine($"Aprobados: {ContarAprobados()}");
        Console.WriteLine($"Reprobados: {ContarReprobados()}");
        Console.WriteLine($"Desviación estándar: {CalcularDesviacionEstandar():0.00}");
    }
    }
}