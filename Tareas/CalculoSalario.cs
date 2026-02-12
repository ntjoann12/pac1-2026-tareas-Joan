using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace TareasCSharp.Tareas
{
    public class CalculoSalarioSemanal
    {
        public float CalculoSalario(float horas, float tarifaHoras)
        {
            return horas * tarifaHoras;
        }
        public float CalculoSalarioHorasExtras (float horas, float tarifaHoras, float tarifaHorasExtras)
        {
            return  (float)((44 * tarifaHoras) + (horas - 44 * (tarifaHorasExtras * 1.5))); //Sueldo total sumando sueldo base + horas extras
        }

    }
}