using System;

namespace TareasCSharp.Tareas
{
    public class CalculadoraAreaPerimetro
    {
        // ===== ATRIBUTOS =====
        private int opcionFigura;

        private float radioCirculo;

        private float lado1Triangulo;
        private float lado2Triangulo;
        private float lado3Triangulo;
        private float baseTriangulo;
        private float alturaTriangulo;

        private float baseRectangulo;
        private float alturaRectangulo;

        private float lado1Trapecio;
        private float lado2Trapecio;
        private float lado3Trapecio;
        private float lado4Trapecio;
        private float baseMayorTrapecio;
        private float baseMenorTrapecio;
        private float alturaTrapecio;

        private float areaCalculada;
        private float perimetroCalculado;

        // ===== PEDIR DATOS =====
        public void PedirDatos()
        {
            Console.WriteLine("Seleccione la figura:");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Rectángulo");
            Console.WriteLine("4. Trapecio");

            opcionFigura = int.Parse(Console.ReadLine());

            if (opcionFigura == 1)
            {
                Console.WriteLine("Ingrese el radio del círculo:");
                radioCirculo = float.Parse(Console.ReadLine());
            }
            else if (opcionFigura == 2)
            {
                Console.WriteLine("Ingrese el lado 1 del triángulo:");
                lado1Triangulo = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el lado 2 del triángulo:");
                lado2Triangulo = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el lado 3 del triángulo:");
                lado3Triangulo = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la base del triángulo:");
                baseTriangulo = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la altura del triángulo:");
                alturaTriangulo = float.Parse(Console.ReadLine());
            }
            else if (opcionFigura == 3)
            {
                Console.WriteLine("Ingrese la base del rectángulo:");
                baseRectangulo = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la altura del rectángulo:");
                alturaRectangulo = float.Parse(Console.ReadLine());
            }
            else if (opcionFigura == 4)
            {
                Console.WriteLine("Ingrese el lado 1 del trapecio:");
                lado1Trapecio = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el lado 2 del trapecio:");
                lado2Trapecio = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el lado 3 del trapecio:");
                lado3Trapecio = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el lado 4 del trapecio:");
                lado4Trapecio = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la base mayor del trapecio:");
                baseMayorTrapecio = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la base menor del trapecio:");
                baseMenorTrapecio = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la altura del trapecio:");
                alturaTrapecio = float.Parse(Console.ReadLine());
            }
        }

        // ===== CALCULAR =====
        public void Calcular()
        {
            if (opcionFigura == 1)
            {
                perimetroCalculado = 2 * 3.1416f * radioCirculo;
                areaCalculada = 3.1416f * radioCirculo * radioCirculo;
            }
            else if (opcionFigura == 2)
            {
                perimetroCalculado = lado1Triangulo + lado2Triangulo + lado3Triangulo;
                areaCalculada = (baseTriangulo * alturaTriangulo) / 2;
            }
            else if (opcionFigura == 3)
            {
                perimetroCalculado = 2 * (baseRectangulo + alturaRectangulo);
                areaCalculada = baseRectangulo * alturaRectangulo;
            }
            else if (opcionFigura == 4)
            {
                perimetroCalculado = lado1Trapecio + lado2Trapecio + lado3Trapecio + lado4Trapecio;
                areaCalculada = ((baseMayorTrapecio + baseMenorTrapecio) * alturaTrapecio) / 2;
            }
        }

        // ===== MOSTRAR RESULTADOS =====
        public void MostrarResultados()
        {
            Console.WriteLine("Perímetro: " + perimetroCalculado);
            Console.WriteLine("Área: " + areaCalculada);
        }
    }
}
