namespace TareasCSharp.Tareas
{
    public class TemperaturaSemana
    {
        private float[] temperaturas = new float[7];
        private string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

        // ===== INGRESAR TEMPERATURAS =====
        public void PedirTemperaturas()
        {
            Console.Clear();
            Console.WriteLine("INGRESO DE TEMPERATURAS SEMANALES");

            for (int i = 0; i < 7; i++)
            {
                float temp;
                bool valido;
                do
                {
                    Console.Write("Ingrese la temperatura del " + dias[i] + ": ");
                    valido = float.TryParse(Console.ReadLine(), out temp);

                    if (!valido)
                        Console.WriteLine("Entrada inválida. Ingrese un número válido.");

                } while (!valido);

                temperaturas[i] = temp;
            }
        }

        // ===== CALCULAR PROMEDIO =====
        public float CalcularPromedio()
        {
            float suma = 0;
            for (int i = 0; i < 7; i++)
                suma += temperaturas[i];

            return suma / 7;
        }

        // ===== DÍAS SOBRE EL PROMEDIO =====
        public void MostrarDiasSobrePromedio()
        {
            float promedio = CalcularPromedio();
            Console.WriteLine("\nDías con temperatura sobre el promedio:");
            bool hay = false;

            for (int i = 0; i < 7; i++)
            {
                if (temperaturas[i] > promedio)
                {
                    Console.WriteLine(dias[i] + ": " + temperaturas[i] + "°");
                    hay = true;
                }
            }

            if (!hay)
                Console.WriteLine("Ningún día superó el promedio.");
        }

        // ===== DÍA MÁS CALUROSO =====
        public void MostrarDiaMasCaluroso()
        {
            float max = temperaturas[0];
            int indice = 0;

            for (int i = 1; i < 7; i++)
            {
                if (temperaturas[i] > max)
                {
                    max = temperaturas[i];
                    indice = i;
                }
            }

            Console.WriteLine("\nDía más caluroso: " + dias[indice] + " (" + max + "°)");
        }

        // ===== DÍA MÁS FRÍO =====
        public void MostrarDiaMasFrio()
        {
            float min = temperaturas[0];
            int indice = 0;

            for (int i = 1; i < 7; i++)
            {
                if (temperaturas[i] < min)
                {
                    min = temperaturas[i];
                    indice = i;
                }
            }

            Console.WriteLine("Día más frío: " + dias[indice] + " (" + min + "°)");
        }

        // ===== VARIACIÓN ENTRE DÍAS CONSECUTIVOS =====
        public void MostrarVariacionConsecutiva()
        {
            Console.WriteLine("\nVariación entre días consecutivos:");
            for (int i = 0; i < 6; i++)
            {
                float variacion = temperaturas[i + 1] - temperaturas[i];
                string signo = variacion >= 0 ? "+" : "";
                Console.WriteLine(dias[i] + " → " + dias[i + 1] + ": " + signo + variacion + "°");
            }
        }

        // ===== RESUMEN COMPLETO =====
        public void MostrarResumen()
        {
            Console.Clear();
            float promedio = CalcularPromedio();
            Console.WriteLine("RESUMEN DE TEMPERATURAS SEMANALES");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Promedio semanal: " + promedio + "°");

            MostrarDiasSobrePromedio();
            MostrarDiaMasCaluroso();
            MostrarDiaMasFrio();
            MostrarVariacionConsecutiva();
        }
    }
}
