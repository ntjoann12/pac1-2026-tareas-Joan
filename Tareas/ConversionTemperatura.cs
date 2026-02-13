using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class ConversionTemperatura
    {
        private float n1;
        private float F, C, K;
        public float Celsius_a_Fahrenheit (float N1)
        {
             F = (n1 * 1.8f) + 32f;
            return F;
        }
        public float Fahrenheit_a_Celsius (float N1)
        {
             C = (n1 - 32) / 1.8f;
            return C;
        }
        public float Celsius_a_Kelvin (float N1)
        {
             K = n1 + 273.15f;
            return K;
        }
        public float Kelvin_a_Celsius (float N1)
        {
             C = n1 - 273.15f;
            return C;
        }
        public float Fahrenheit_a_Kelvin (float N1)
        {
             K = (((n1 - 32) * 5) / 9) + 273.15f ;
            return K;
        }
    }
}