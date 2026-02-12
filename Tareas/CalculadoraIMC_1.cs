using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class CalculadoraIMC_1
    {
       public int calculadoraIMC(int peso, float altura)
        {
            int imc = (int)(peso / (altura * altura));
            return imc;
        }
    }
}