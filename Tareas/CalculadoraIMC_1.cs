using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class CalculadoraIMC_1
    {
        private int peso, imc;
        private float altura;
        public void PedirDatos()
        {
            Console.WriteLine("Ingrese su peso (kg):");
            peso = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su altura (m) en formato 0.00:");
            altura = float.Parse(Console.ReadLine());
        }
       public int calculadoraIMC()
        {
            return imc = (int)(peso / (altura * altura));
            
        }
        public void MostrarResultados()
        {
             if (imc < 18.5f)
            Console.WriteLine("IMC:" + imc ," - Bajo peso");
        else if (imc < 24.9f)
            Console.WriteLine("IMC:" + imc ,"- Peso normal");
        else if (imc < 29.9f)
            Console.WriteLine("IMC:" + imc ,"- Sobrepeso");
        else
            Console.WriteLine("IMC:" + imc ,"- Obesidad");
        }
    }
}