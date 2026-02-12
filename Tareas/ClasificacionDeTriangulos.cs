using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class ClasificacionDeTriangulos
    {
        public string ClasificarTriangulo(int lado1, int lado2, int lado3, int angulo)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                if (angulo < 90)
                    return "Triángulo Equilátero Acutángulo";
                else
                    return "Triángulo Equilátero";
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                if (angulo == 90)
                    return "Triángulo Isósceles Rectángulo";
                else if (angulo > 90)
                    return "Triángulo Isósceles Obtusángulo";
                else
                    return "Triángulo Isósceles Acutángulo";
            }
            else
            {
                if (angulo == 90)
                    return "Triángulo Escaleno Rectángulo";
                else if (angulo > 90)
                    return "Triángulo Escaleno Obtusángulo";
                else
                    return "Triángulo Escaleno Acutángulo";
            }
        }
    }
}
