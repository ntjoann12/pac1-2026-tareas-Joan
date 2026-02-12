using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class TiempoTranscurrido 
    {
        public int tiempoTranscurridoH( int hora1, int hora2)
        {
           int  diferencia_tiempoH = hora1 - hora2;
             return diferencia_tiempoH;
        }
        public int tiempoTranscurridoM( int minuto1, int minuto2)
        {
           int  diferencia_tiempoM = minuto1 - minuto2;
             return diferencia_tiempoM;
        }public int tiempoTranscurridoS( int segundo1, int segundo2)
        {
           int  diferencia_tiempoS = segundo1 - segundo2;
             return diferencia_tiempoS;
        }
    }
}