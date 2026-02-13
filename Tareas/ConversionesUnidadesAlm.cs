using System;

namespace TareasCSharp.Tareas
{
    public class ConversionesUnidadesAlm
    {
        // ===== ATRIBUTOS =====
        private int opcionConversion;
        private float valorIngresado;
        private float resultadoConversion;

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

            opcionConversion = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor a convertir:");
            valorIngresado = float.Parse(Console.ReadLine());
        }

        // ===== CALCULAR =====
        public void Calcular()
        {
            if (opcionConversion == 1)
                resultadoConversion = valorIngresado / 1024;
            else if (opcionConversion == 2)
                resultadoConversion = valorIngresado / (1024 * 1024);
            else if (opcionConversion == 3)
                resultadoConversion = valorIngresado / (1024 * 1024 * 1024);
            else if (opcionConversion == 4)
                resultadoConversion = valorIngresado / (1024f * 1024 * 1024 * 1024);
            else if (opcionConversion == 5)
                resultadoConversion = valorIngresado * 1024;
            else if (opcionConversion == 6)
                resultadoConversion = valorIngresado * 1024 * 1024;
            else if (opcionConversion == 7)
                resultadoConversion = valorIngresado * 1024 * 1024 * 1024;
            else if (opcionConversion == 8)
                resultadoConversion = valorIngresado * 1024 * 1024 * 1024 * 1024;
        }

        // ===== MOSTRAR RESULTADO =====
        public void MostrarResultado()
        {
            Console.WriteLine("Resultado de la conversión: " + resultadoConversion);
        }
    }
}
