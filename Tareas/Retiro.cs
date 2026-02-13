namespace TareasCSharp.Tareas
{
    class Retiro
    {
        private int saldo = 5000; // Saldo inicial de la cuenta
        private int monto; // Monto que el usuario desea retirar

        // ===== Pedir monto de retiro =====
        public void PedirMonto()
        {
            Console.Write("Ingrese el monto a retirar: ");
            monto = int.Parse(Console.ReadLine()); // Leer monto ingresado por el usuario
        }

        // ===== Validar retiro =====
        // Comprueba si el retiro cumple las condiciones:
        // 1. Mayor que cero
        // 2. Menor o igual al saldo
        // 3. Múltiplo de 20
        public bool RetiroValido()
        {
            if (monto <= 0)
                return false;

            if (monto > saldo)
                return false;

            if (monto % 20 != 0)
                return false;

            return true;
        }

        // ===== Mostrar desglose de billetes =====
        // Calcula cuántos billetes de cada denominación se entregan
        public void MostrarDesglose()
        {
            // Verifica si el retiro es válido
            if (!RetiroValido())
            {
                Console.WriteLine("Retiro no válido.");
                return;
            }

            int restante = monto; // Variable para ir descontando los billetes

            // Calcular billetes de 500
            int billetes500 = restante / 500;
            restante = restante % 500;

            // Calcular billetes de 200
            int billetes200 = restante / 200;
            restante = restante % 200;

            // Calcular billetes de 100
            int billetes100 = restante / 100;
            restante = restante % 100;

            // Calcular billetes de 20
            int billetes20 = restante / 20;

            // Mostrar información al usuario
            Console.WriteLine("Retiro aprobado.");
            Console.WriteLine("Billetes entregados:");
            Console.WriteLine("L500: " + billetes500);
            Console.WriteLine("L200: " + billetes200);
            Console.WriteLine("L100: " + billetes100);
            Console.WriteLine("L20 : " + billetes20);

            // Actualizar saldo
            saldo = saldo - monto;
            Console.WriteLine("Saldo restante: L" + saldo);
        }
    }
}
