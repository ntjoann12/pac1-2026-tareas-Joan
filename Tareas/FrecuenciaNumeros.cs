namespace TareasCSharp.Tareas
{
    public class FrecuenciaNumeros
    {
        private int[] numeros = new int[20];
        private int[] frecuencias = new int[10]; // índice 0 = número 1, índice 9 = número 10
        private int semilla = 0; // para pseudo-random básico

        // Generar números aleatorios entre 1 y 10
        public void GenerarNumeros()
        {
            Console.Clear();
            Console.WriteLine("Números generados aleatoriamente:");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = NumeroAleatorio(1, 10);
                Console.Write(numeros[i] + " ");
            }

            Console.WriteLine("\n");
        }

        // Calcular frecuencias
        public void CalcularFrecuencias()
        {
            for (int i = 0; i < frecuencias.Length; i++)
                frecuencias[i] = 0;

            for (int i = 0; i < numeros.Length; i++)
                frecuencias[numeros[i] - 1]++;
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
                Console.WriteLine("Número " + (i + 1) + ": " + frecuencias[i] + " veces");

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

            Console.WriteLine("\nNúmero más frecuente: " + numMax + " (" + maxFreq + " veces)");
            Console.WriteLine("Número menos frecuente: " + numMin + " (" + minFreq + " veces)");
        }

        // ===== FUNCIÓN BÁSICA DE NÚMERO ALEATORIO =====
        private int NumeroAleatorio(int min, int max)
        {
            // Generador pseudo-aleatorio simple
            semilla = (semilla * 9301 + 49297) % 233280;
            double rnd = semilla / 233280.0;
            return min + (int)(rnd * (max - min + 1));
        }
    }
}
