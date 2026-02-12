using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace TareasCSharp.Tareas
{
   public class DesgloseDeBilletes
{
    public int Desglose_de_Billetes(int n1)
    {
        int N = n1;

        int[] billetes = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

        for (int i = 0; i < billetes.Length; i++)
        {
            int cantidad = N / billetes[i];

            if (cantidad > 0)
            {
                Console.WriteLine("Billetes de " + billetes[i] + ": " + cantidad);
                N = N - (cantidad * billetes[i]);
            }
        }
        return 0;
    }
}
}