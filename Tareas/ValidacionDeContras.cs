using System;

namespace TareasCSharp.Tareas
{
    public class ValidacionDeContras
    {
        // ===== ATRIBUTOS =====
        private string contrasenaIngresada;
        private int cantidadMayusculas;
        private int cantidadMinusculas;
        private int cantidadDigitos;
        private int cantidadOtros;

        // ===== PEDIR Y VALIDAR CONTRASEÑA =====
        public void SolicitarContrasenaSegura()
        {
            bool contrasenaValida = false;

            while (!contrasenaValida)
            {
                Console.WriteLine("Ingrese una contraseña segura:");
                contrasenaIngresada = Console.ReadLine();

                // Reiniciar contadores
                cantidadMayusculas = 0;
                cantidadMinusculas = 0;
                cantidadDigitos = 0;
                cantidadOtros = 0;

                foreach (char c in contrasenaIngresada)
                {
                    if (Char.IsUpper(c)) cantidadMayusculas++;
                    else if (Char.IsLower(c)) cantidadMinusculas++;
                    else if (Char.IsDigit(c)) cantidadDigitos++;
                    else cantidadOtros++;
                }

                // Verificar cada condición
                bool tieneLongitud = contrasenaIngresada.Length >= 8;
                bool tieneMayuscula = cantidadMayusculas > 0;
                bool tieneMinuscula = cantidadMinusculas > 0;
                bool tieneDigito = cantidadDigitos > 0;
                bool tieneEspecial = cantidadOtros > 0;

                // Mostrar resultado o indicaciones
                if (tieneLongitud && tieneMayuscula && tieneMinuscula && tieneDigito && tieneEspecial)
                {
                    contrasenaValida = true;
                    Console.WriteLine("Contraseña válida y segura.");
                }
                else
                {
                    Console.WriteLine("Contraseña inválida. Faltan:");
                    if (!tieneLongitud) Console.WriteLine("- Mínimo 8 caracteres");
                    if (!tieneMayuscula) Console.WriteLine("- Al menos una letra mayúscula");
                    if (!tieneMinuscula) Console.WriteLine("- Al menos una letra minúscula");
                    if (!tieneDigito) Console.WriteLine("- Al menos un número");
                    if (!tieneEspecial) Console.WriteLine("- Al menos un carácter especial");
                    Console.WriteLine();
                }
            }
        }
    }
}
