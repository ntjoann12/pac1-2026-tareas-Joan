using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class TablaDeMultiplicar
    {
        private int numero_user;
        public void PedirNumero()
        {
            Console.WriteLine("Ingrese el numero a realizar operacion : ");
             numero_user = int.Parse(Console.ReadLine());
        }
        public void MostrarTabla()
        {
            int  i;
            for(i = 1; i <= 12; i++)
            {
              int multiplicacion = numero_user * i;
              Console.WriteLine("TABLA DEL : " + numero_user + " || " + multiplicacion);
            }
        }

    }
}