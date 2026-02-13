namespace TareasCSharp.Tareas
{
    public class ConversionesUnidadesAlm
    {
        // ===== ATRIBUTOS =====
        private int opcionConversion;      // Opción elegida por el usuario
        private float valorIngresado;      // Valor que se desea convertir
        private float resultadoConversion; // Resultado de la conversión

        // ===== PEDIR DATOS =====
        public void PedirDatos()
        {
            Console.WriteLine("Seleccione la conversión:");
            Console.WriteLine("1. Bytes a KB");
            Console.WriteLine("2. Bytes a MB");
            Console.WriteLine("3. Bytes a GB");
            Console.WriteLine("4. Bytes a TB");
            Console.WriteLine("5. KB a Bytes");
            Console.WriteLine("6. MB a Bytes");
            Console.WriteLine("7. GB a Bytes");
            Console.WriteLine("8. TB a Bytes");

            // Leer opción del usuario
            opcionConversion = int.Parse(Console.ReadLine());

            // Leer valor a convertir
            Console.WriteLine("Ingrese el valor a convertir:");
            valorIngresado = float.Parse(Console.ReadLine());
        }

        // ===== CALCULAR CONVERSIÓN =====
        public void Calcular()
        {
            // Usamos switch para manejar cada opción de conversión
            switch (opcionConversion)
            {
                case 1: // Bytes a KB
                    resultadoConversion = valorIngresado / 1024;
                    break;
                case 2: // Bytes a MB
                    resultadoConversion = valorIngresado / (1024 * 1024);
                    break;
                case 3: // Bytes a GB
                    resultadoConversion = valorIngresado / (1024 * 1024 * 1024);
                    break;
                case 4: // Bytes a TB
                    resultadoConversion = valorIngresado / (1024f * 1024 * 1024 * 1024);
                    break;
                case 5: // KB a Bytes
                    resultadoConversion = valorIngresado * 1024;
                    break;
                case 6: // MB a Bytes
                    resultadoConversion = valorIngresado * 1024 * 1024;
                    break;
                case 7: // GB a Bytes
                    resultadoConversion = valorIngresado * 1024 * 1024 * 1024;
                    break;
                case 8: // TB a Bytes
                    resultadoConversion = valorIngresado * 1024 * 1024 * 1024 * 1024;
                    break;
                default: // Opción inválida
                    Console.WriteLine("Opción de conversión no válida.");
                    resultadoConversion = 0;
                    break;
            }
        }

        // ===== MOSTRAR RESULTADO =====
        public void MostrarResultado()
        {
            Console.WriteLine("Resultado de la conversión: " + resultadoConversion);
        }
    }
}
