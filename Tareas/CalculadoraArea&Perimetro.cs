using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class CalculadoraAreaPerimetro
    {
        public float CirculoPerimetro (float radio)
        {
           float perimetro = (float)(2 * 3.1416 * radio);
           return perimetro;
        }
        public float CirculoArea(float radio)
        {
              float area = (float) 3.1416 * radio * radio;
              return area;
        }
        public float TrianguloPerimetro(float lado_a, float lado_b, float lado_c)
        {
            float perimetro = (float) lado_a + lado_b + lado_c;
            return perimetro;
        }
        public float TrianguloArea(float base_t, float altura)
        {
            float area = (float)(base_t * altura)/2;
            return area;
        }
        public float RectanguloPerimetro(float base_r, float altura)
        {
            return 2 * (base_r + altura);
        }
        public float RectanguloArea (float base_r, float altura)
        {
            return base_r * altura;
        }
        public float TrapecioPerimetro(float lado1, float lado2, float lado3, float lado4)
        {
            return lado1 + lado2 + lado3 + lado4;
        }
        public float TrapecioArea(float base_mayor, float base_menor, float altura)
        {
            return ((base_mayor + base_menor) * altura) / 2;
        }
    }
}