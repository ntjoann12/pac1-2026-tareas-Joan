using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class TiempoTranscurrido 
    {
        private int hora1, hora2, minuto1, minuto2, segundo1, segundo2;
        private int _diferenciaH, _diferenciaM, _diferencia_s;
        public void PedirInstanciasTiempo()
    {
      Console.WriteLine("Ingrese hora 1: ");
      hora1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese hora 2: ");
      hora2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese minutos 1: ");
      minuto1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese minutos 2: ");
      minuto2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese segundos 1: ");
      segundo1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese segundos 2: ");
      segundo2 = int.Parse(Console.ReadLine());
    }
        public int tiempoTranscurridoH()
        {
           return _diferenciaH = hora1 - hora2;
             
        }
        public int tiempoTranscurridoM()
        {
          return _diferenciaM = minuto1 - minuto2;
          
        }public int tiempoTranscurridoS()
        {
          
           return _diferencia_s = segundo1 - segundo2;
           
        }
        public void MostrasDiferenciasTiempo()
    {
      Console.WriteLine("La diferencias de tiempo son: ");
      Console.WriteLine("Horas: " + _diferenciaH,"\nMinutos: " + _diferenciaM ,"\nSegundos: " + _diferencia_s);
    }
    }
}