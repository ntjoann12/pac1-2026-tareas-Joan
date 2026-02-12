using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class CalculadoraDePrestamoSimple
    {
        public float CuotaMensualFija (float monto_solicitado, float tasa_interes)
        {
            float cuota_mensual;
            cuota_mensual = monto_solicitado *  tasa_interes / (1 - (1 + tasa_interes));
            return cuota_mensual;
        }

        public float InteresTotal ( float capitalInicial, float plazo_en_meses, float cuota_mensual)
        {
            CalculadoraDePrestamoSimple calculadoraDePrestamoSimple1 = new CalculadoraDePrestamoSimple();
            float I_total = cuota_mensual * plazo_en_meses / capitalInicial;
            return I_total;
        }
    }
}