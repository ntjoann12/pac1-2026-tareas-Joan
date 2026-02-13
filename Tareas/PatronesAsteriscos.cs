using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class PatronesAsteriscos
    {
        private int tamaño;

    // Método para pedir y validar el tamaño
    public void PedirTamaño()
    {
        do
        {
            Console.Write("Ingrese el tamaño del patrón (mayor que 0): ");
            tamaño = int.Parse(Console.ReadLine());
        } while (tamaño <= 0);
    }

    // Menú principal
    public void MostrarMenu()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("PATRONES DE ASTERISCOS");
            Console.WriteLine("1. Triángulo");
            Console.WriteLine("2. Triángulo invertido");
            Console.WriteLine("3. Rombo");
            Console.WriteLine("4. Cuadrado hueco");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcion)
            {
                case 1:
                    PedirTamaño();
                    Triangulo();
                    break;

                case 2:
                    PedirTamaño();
                    TrianguloInvertido();
                    break;

                case 3:
                    PedirTamaño();
                    Rombo();
                    break;

                case 4:
                    PedirTamaño();
                    CuadradoHueco();
                    break;

                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            if (opcion != 5)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 5);
    }

    // Triángulo normal
    public void Triangulo()
    {
        for (int i = 1; i <= tamaño; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    // Triángulo invertido
    public void TrianguloInvertido()
    {
        for (int i = tamaño; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    // Rombo
    public void Rombo()
    {
        // Parte superior
        for (int i = 1; i <= tamaño; i++)
        {
            for (int j = tamaño; j > i; j--)
                Console.Write(" ");

            for (int k = 1; k <= (2 * i - 1); k++)
                Console.Write("*");

            Console.WriteLine();
        }

        // Parte inferior
        for (int i = tamaño - 1; i >= 1; i--)
        {
            for (int j = tamaño; j > i; j--)
                Console.Write(" ");

            for (int k = 1; k <= (2 * i - 1); k++)
                Console.Write("*");

            Console.WriteLine();
        }
    }

    // Cuadrado hueco
    private void CuadradoHueco()
    {
        for (int i = 1; i <= tamaño; i++)
        {
            for (int j = 1; j <= tamaño; j++)
            {
                if (i == 1 || i == tamaño || j == 1 || j == tamaño)
                    Console.Write("* ");
                else
                    Console.Write("  ");
            }
            Console.WriteLine();
        }
    }
    }
}