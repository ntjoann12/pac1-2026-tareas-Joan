using System;

namespace TareasCSharp.Tareas
{
    public class CalculoSalarioSemanal
    {
        // ===== ATRIBUTOS =====
        private float horasTrabajadas;
        private float tarifaPorHora;
        private float salarioTotal;

        // ===== PEDIR DATOS =====
        public void PedirDatos()
        {
            Console.WriteLine("Ingrese la cantidad de horas trabajadas en la semana:");
            horasTrabajadas = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tarifa por hora:");
            tarifaPorHora = float.Parse(Console.ReadLine());
        }

        // ===== CALCULAR =====
        public void CalcularSalario()
        {
            float horasBase = Math.Min(horasTrabajadas, 44); // hasta 44 horas normales
            float horasExtras = Math.Max(horasTrabajadas - 44, 0); // si pasa de 44 horas

            salarioTotal = (horasBase * tarifaPorHora) + (horasExtras * tarifaPorHora * 1.5f);
        }

        // ===== MOSTRAR RESULTADOS =====
        public void MostrarSalario()
        {
            Console.WriteLine("Salario semanal total: L. " + salarioTotal);
        }
    }
}
