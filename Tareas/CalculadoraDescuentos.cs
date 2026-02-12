using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class CalculadoraDescuentos
    {
        public float ObtenerPorcentajeDescuento(float monto)
        {
            if (monto >= 2500)
                return 0.15f;
            else if (monto >= 1000)
                return 0.10f;
            else if (monto >= 500)
                return 0.05f;
            else
                return 0.0f;
        }

        public float CalcularDescuento(float monto)
        {
            float porcentaje = ObtenerPorcentajeDescuento(monto);
            return monto * porcentaje;
        }

        public float CalcularPrecioFinal(float monto)
        {
            float descuento = CalcularDescuento(monto);
            return monto - descuento;
        }
    }
}