namespace TareasCSharp.Tareas
{
    public class NotasEstudiantes
    {
        private int cantidadEstudiantes;
        private float[,] notas; // Matriz: filas = estudiantes, columnas = parciales
        private string[] nombresEstudiantes;

        // ===== INGRESO DE ESTUDIANTES Y NOTAS =====
        public void PedirDatosEstudiantes()
        {
            Console.Clear();

            // Pedir cantidad de estudiantes y validar que sea mayor a 0
            do
            {
                Console.Write("Ingrese la cantidad de estudiantes: ");
                cantidadEstudiantes = int.Parse(Console.ReadLine());
            } while (cantidadEstudiantes <= 0);

            // Inicializar matriz de notas y arreglo de nombres
            notas = new float[cantidadEstudiantes, 3];
            nombresEstudiantes = new string[cantidadEstudiantes];

            // Ciclo para ingresar nombre y notas de cada estudiante
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.Write("Ingrese el nombre del estudiante #" + (i + 1) + ": ");
                nombresEstudiantes[i] = Console.ReadLine();

                // Ciclo para ingresar las 3 notas de cada estudiante
                for (int j = 0; j < 3; j++)
                {
                    float nota;
                    bool notaValida;
                    do
                    {
                        Console.Write("Ingrese nota del parcial #" + (j + 1) + " (0-100): ");
                        notaValida = float.TryParse(Console.ReadLine(), out nota);

                        // Validar que la nota sea un número entre 0 y 100
                        if (!notaValida || nota < 0 || nota > 100)
                            Console.WriteLine("Nota inválida. Debe estar entre 0 y 100.");

                    } while (!notaValida || nota < 0 || nota > 100);

                    notas[i, j] = nota; // Guardar nota en la matriz
                }
            }
        }

        // ===== PROMEDIO POR ESTUDIANTE =====
        public float[] CalcularPromedioPorEstudiante()
        {
            float[] promedios = new float[cantidadEstudiantes];

            // Calcular promedio de cada estudiante sumando sus 3 notas
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                float sumaNotas = 0;
                for (int j = 0; j < 3; j++)
                    sumaNotas += notas[i, j]; // Sumar las notas del estudiante i

                promedios[i] = sumaNotas / 3; // Dividir entre 3 para obtener promedio
            }

            return promedios; // Devolver arreglo con promedios
        }

        // ===== PROMEDIO POR PARCIAL =====
        public float[] CalcularPromedioPorParcial()
        {
            float[] promediosParciales = new float[3];

            // Calcular promedio de cada parcial sumando las notas de todos los estudiantes
            for (int j = 0; j < 3; j++)
            {
                float suma = 0;
                for (int i = 0; i < cantidadEstudiantes; i++)
                    suma += notas[i, j]; // Sumar nota del parcial j para cada estudiante

                promediosParciales[j] = suma / cantidadEstudiantes; // Dividir entre total de estudiantes
            }

            return promediosParciales; // Devolver arreglo con promedios por parcial
        }

        // ===== ESTUDIANTE CON MEJOR PROMEDIO =====
        public void MostrarEstudianteMejorPromedio()
        {
            float[] promedios = CalcularPromedioPorEstudiante(); // Obtener promedios de estudiantes
            float maxPromedio = promedios[0]; // Inicializar con el primer estudiante
            int indiceMejor = 0;

            // Buscar el estudiante con el promedio más alto
            for (int i = 1; i < cantidadEstudiantes; i++)
            {
                if (promedios[i] > maxPromedio)
                {
                    maxPromedio = promedios[i];
                    indiceMejor = i; // Guardar índice del estudiante con mejor promedio
                }
            }

            Console.WriteLine("\nMejor estudiante: " + nombresEstudiantes[indiceMejor] +
                              " con promedio " + maxPromedio);
        }

        // ===== PARCIAL MÁS DIFÍCIL (PROMEDIO MÁS BAJO) =====
        public void MostrarParcialMasDificil()
        {
            float[] promediosParciales = CalcularPromedioPorParcial(); // Obtener promedio de cada parcial
            float minPromedio = promediosParciales[0]; // Inicializar con el primer parcial
            int parcialMasDificil = 1; // Contador de parcial más difícil

            // Buscar el parcial con promedio más bajo
            for (int j = 1; j < 3; j++)
            {
                if (promediosParciales[j] < minPromedio)
                {
                    minPromedio = promediosParciales[j];
                    parcialMasDificil = j + 1; // Guardar número del parcial más difícil
                }
            }

            Console.WriteLine("Parcial más difícil: Parcial #" + parcialMasDificil +
                              " con promedio " + minPromedio);
        }

        // ===== MOSTRAR TODOS LOS RESULTADOS =====
        public void MostrarTodosResultados()
        {
            Console.Clear();
            Console.WriteLine("NOTAS DE ESTUDIANTES");
            Console.WriteLine("-------------------");

            // Mostrar todas las notas de cada estudiante
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.Write(nombresEstudiantes[i] + ": ");
                for (int j = 0; j < 3; j++)
                    Console.Write(notas[i, j] + " ");
                Console.WriteLine();
            }

            // Mostrar promedio por estudiante
            Console.WriteLine("\nPromedio por estudiante:");
            float[] promediosEstudiantes = CalcularPromedioPorEstudiante();
            for (int i = 0; i < cantidadEstudiantes; i++)
                Console.WriteLine(nombresEstudiantes[i] + ": " + promediosEstudiantes[i]);

            // Mostrar promedio por parcial
            Console.WriteLine("\nPromedio por parcial:");
            float[] promediosParciales = CalcularPromedioPorParcial();
            for (int j = 0; j < 3; j++)
                Console.WriteLine("Parcial #" + (j + 1) + ": " + promediosParciales[j]);

            // Mostrar estudiante con mejor promedio
            MostrarEstudianteMejorPromedio();

            // Mostrar parcial más difícil
            MostrarParcialMasDificil();
        }
    }
}
