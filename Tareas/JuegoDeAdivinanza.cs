using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class JuegoDeAdivinanza
    {
        //Inicializamos la clase para generar numeros aleatorios 
        private Random random = new Random();
        private int _numero;
        public void GenerarNumero()
        {
            _numero = random.Next(1,101);
        }
        public void JuegoUsuario()
        {
            int intentos = 1, intento_usuario;
            bool intento_ganador = false;
            do
            {
                Console.WriteLine("Ingrese su intento ");
                intento_usuario = int.Parse(Console.ReadLine());
                if(intento_usuario == _numero )
                {
                    Console.WriteLine("FELICIDADES! Logro adivinar el numero.");
                    intento_ganador = true;
                    

                }
                else if (intento_usuario < _numero)
                {
                    Console.WriteLine("Ingrese num mayor");
                }
                else
                {
                    Console.WriteLine("Ingrese num menor");
                }
                intentos++;
            } while (intentos <= 7);

            Console.WriteLine("--ESTADISTICAS--");
            if(intento_ganador == true )
            {
                Console.WriteLine("Se realizo el juego en " + intentos ," " + "intentos");
            }
            else
            {
                Console.WriteLine("Intentos : " + intentos);
            }
        }
    }
}