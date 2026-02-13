using System;

namespace TareasCSharp.Tareas
{
    public class Calculadora
    {
        private double resultadoActual = 0;

        // Menú principal
        public void MostrarMenu()
        {
            int opcion;

            do
            {
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("Resultado actual: " + resultadoActual);
                Console.WriteLine("---------------------------");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raíz cuadrada");
                Console.WriteLine("7. Porcentaje");
                Console.WriteLine("8. Reiniciar resultado");
                Console.WriteLine("9. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Sumar(); break;
                    case 2: Restar(); break;
                    case 3: Multiplicar(); break;
                    case 4: Dividir(); break;
                    case 5: Potencia(); break;
                    case 6: RaizCuadrada(); break;
                    case 7: Porcentaje(); break;
                    case 8:
                        resultadoActual = 0;
                        Console.WriteLine("Resultado reiniciado a 0.");
                        break;
                    case 9:
                        Console.WriteLine("Saliendo de la calculadora...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 9)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 9);
        }

        // Métodos de operaciones
        private void Sumar()
        {
            double numero = PedirNumero();
            resultadoActual += numero;
        }

        private void Restar()
        {
            double numero = PedirNumero();
            resultadoActual -= numero;
        }

        private void Multiplicar()
        {
            double numero = PedirNumero();
            resultadoActual *= numero;
        }

        private void Dividir()
        {
            double numero;
            do
            {
                numero = PedirNumero();
                if (numero == 0)
                    Console.WriteLine("No se puede dividir entre cero.");
            } while (numero == 0);

            resultadoActual /= numero;
        }

        private void Potencia()
        {
            double exponente = PedirNumero();
            resultadoActual = Math.Pow(resultadoActual, exponente);
        }

        private void RaizCuadrada()
        {
            if (resultadoActual < 0)
                Console.WriteLine("No se puede sacar raíz de un número negativo.");
            else
                resultadoActual = Math.Sqrt(resultadoActual);
        }

        private void Porcentaje()
        {
            double porcentaje = PedirNumero();
            resultadoActual = resultadoActual * porcentaje / 100;
        }

        // Pedir número
        private double PedirNumero()
        {
            Console.Write("Ingrese un número: ");
            return double.Parse(Console.ReadLine());
        }
    }
}
