using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class SistemaCalificacionesUNAH
    {
        public string ObtenerLetra(int nota)
        {
            if (nota >= 90) return "A";
            else if (nota >= 80) return "B";
            else if (nota >= 70) return "C";
            else if (nota >= 60) return "D";
            else return "F";
        }

        public string ObtenerDescripcion(int nota)
        {
            if (nota >= 90) return "Excelente";
            else if (nota >= 80) return "Muy bueno";
            else if (nota >= 70) return "Bueno";
            else if (nota >= 60) return "Regular";
            else return "Reprobado";
        }

        public string ObtenerEstado(int nota)
        {
            if (nota >= 60)
                return "APROBADO";
            else
                return "REPROBADO";
        }

        public bool NotaValida(int nota)
        {
            if (nota >= 0 && nota <= 100)
                return true;
            else
                return false;
        }
    }
}
