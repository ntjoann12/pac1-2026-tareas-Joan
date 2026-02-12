using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class ValidacionDeContras
    {
        public void SolicitarContras()
        {
            Console.WriteLine("Ingrese la contrasenia");
            string contra_user =(Console.ReadLine()); 
             int mayusculas = 0;
            int minusculas = 0;
            int digitos = 0;
            int otros = 0;

            foreach (char c in contra_user)
            {
                if (Char.IsUpper(c))
                mayusculas++;
                else if (Char.IsLower(c))
                minusculas++;
                else if (Char.IsDigit(c))
                digitos++;
                else
                otros++;
            }
        }
    }
}