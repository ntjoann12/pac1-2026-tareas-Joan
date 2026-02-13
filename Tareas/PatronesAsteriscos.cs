namespace TareasCSharp.Tareas
{
    public class PatronesAsteriscos
    {
        private int tamaño; // Tamaño de los patrones a dibujar

        // ===== Pedir y validar tamaño del patrón =====
        public void PedirTamaño()
        {
            do
            {
                Console.Write("Ingrese el tamaño del patrón (mayor que 0): ");
                tamaño = int.Parse(Console.ReadLine()); // Leer tamaño desde consola
            } while (tamaño <= 0); // Validar que sea mayor que 0
        }

        // ===== Menú principal =====
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

                // Elegir opción según la selección del usuario
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

        // ===== Triángulo normal =====
        public void Triangulo()
        {
            for (int i = 1; i <= tamaño; i++)
            {
                // Dibujar i asteriscos en la fila i
                for (int j = 1; j <= i; j++)
                    Console.Write("*");

                Console.WriteLine(); // Nueva línea para siguiente fila
            }
        }

        // ===== Triángulo invertido =====
        public void TrianguloInvertido()
        {
            for (int i = tamaño; i >= 1; i--)
            {
                // Dibujar i asteriscos en la fila i
                for (int j = 1; j <= i; j++)
                    Console.Write("*");

                Console.WriteLine(); // Nueva línea para siguiente fila
            }
        }

        // ===== Rombo =====
        public void Rombo()
        {
            // Parte superior del rombo
            for (int i = 1; i <= tamaño; i++)
            {
                // Espacios antes de los asteriscos
                for (int j = tamaño; j > i; j--)
                    Console.Write(" ");

                // Asteriscos de la fila
                for (int k = 1; k <= (2 * i - 1); k++)
                    Console.Write("*");

                Console.WriteLine();
            }

            // Parte inferior del rombo
            for (int i = tamaño - 1; i >= 1; i--)
            {
                // Espacios antes de los asteriscos
                for (int j = tamaño; j > i; j--)
                    Console.Write(" ");

                // Asteriscos de la fila
                for (int k = 1; k <= (2 * i - 1); k++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        // ===== Cuadrado hueco =====
        private void CuadradoHueco()
        {
            for (int i = 1; i <= tamaño; i++)
            {
                for (int j = 1; j <= tamaño; j++)
                {
                    // Dibujar asteriscos en los bordes y espacios dentro
                    if (i == 1 || i == tamaño || j == 1 || j == tamaño)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine(); // Nueva línea para siguiente fila
            }
        }
    }
}
