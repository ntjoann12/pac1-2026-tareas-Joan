using System;

namespace TareasCSharp.Tareas
{
    public class RotacionArreglo
    {
        private int[] arreglo;

        // ===== Inicializar arreglo =====
        // Pedir tamaño del arreglo y llenar los elementos
        public void InicializarArreglo()
        {
            int n;
            do
            {
                Console.Write("Ingrese la cantidad de elementos del arreglo (mayor que 0): ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            arreglo = new int[n];

            Console.Clear();
            Console.WriteLine("Ingrese los elementos del arreglo:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento #{i + 1}: ");
                arreglo[i] = int.Parse(Console.ReadLine());
            }
        }

        // ===== Menú principal =====
        // Permite al usuario seleccionar qué operación realizar sobre el arreglo
        public void MostrarMenu()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("ROTACIÓN DE ARREGLO");
                MostrarArreglo();

                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Rotar K posiciones a la izquierda");
                Console.WriteLine("2. Rotar K posiciones a la derecha");
                Console.WriteLine("3. Invertir arreglo");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RotarIzquierda();
                        break;
                    case 2:
                        RotarDerecha();
                        break;
                    case 3:
                        InvertirArreglo();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 4);
        }

        // ===== Mostrar arreglo =====
        // Muestra el arreglo actual en consola
        private void MostrarArreglo()
        {
            Console.WriteLine("\nArreglo actual:");
            foreach (int num in arreglo)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // ===== Rotar a la izquierda =====
        // Desplaza todos los elementos k posiciones hacia la izquierda
        private void RotarIzquierda()
        {
            Console.Write("Ingrese K posiciones para rotar a la izquierda: ");
            int k = int.Parse(Console.ReadLine());
            k = k % arreglo.Length; // Evitar rotaciones completas innecesarias

            int[] temp = new int[arreglo.Length];

            // Cada elemento se mueve k posiciones hacia la izquierda
            for (int i = 0; i < arreglo.Length; i++)
            {
                temp[i] = arreglo[(i + k) % arreglo.Length];
            }

            arreglo = temp;
        }

        // ===== Rotar a la derecha =====
        // Desplaza todos los elementos k posiciones hacia la derecha
        private void RotarDerecha()
        {
            Console.Write("Ingrese K posiciones para rotar a la derecha: ");
            int k = int.Parse(Console.ReadLine());
            k = k % arreglo.Length; // Evitar rotaciones completas innecesarias

            int[] temp = new int[arreglo.Length];

            // Cada elemento se mueve k posiciones hacia la derecha
            for (int i = 0; i < arreglo.Length; i++)
            {
                temp[i] = arreglo[(i - k + arreglo.Length) % arreglo.Length];
            }

            arreglo = temp;
        }

        // ===== Invertir arreglo =====
        // Invierte el orden de todos los elementos del arreglo
        private void InvertirArreglo()
        {
            int izquierda = 0;
            int derecha = arreglo.Length - 1;

            // Intercambiar elementos desde los extremos hacia el centro
            while (izquierda < derecha)
            {
                int temp = arreglo[izquierda];
                arreglo[izquierda] = arreglo[derecha];
                arreglo[derecha] = temp;
                izquierda++;
                derecha--;
            }
        }
    }
}
