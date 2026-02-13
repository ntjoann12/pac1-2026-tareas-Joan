namespace TareasCSharp.Tareas
{
    public class DesgloseDeBilletes
    {
        private int _monto; // Monto total que se desea desglosar

        // ===== Pedir al usuario la cantidad de dinero =====
        public void PedirCantidadADesglosar()
        {
            Console.WriteLine("Ingrese cantidad de dinero para desglose:");
            _monto = int.Parse(Console.ReadLine()); // Guardar monto ingresado
        }

        // ===== Desglosar el monto en billetes =====
        public int Desglose_de_Billetes()
        {
            int N = _monto; // Variable temporal para ir reduciendo el monto

            // Arreglo de billetes disponibles, de mayor a menor
            int[] billetes = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            // Iterar sobre cada billete para calcular cuántos se necesitan
            for (int i = 0; i < billetes.Length; i++)
            {
                int cantidad = N / billetes[i]; // Número de billetes de este tipo

                if (cantidad > 0)
                {
                    // Mostrar cuántos billetes de cada tipo se entregan
                    Console.WriteLine("Billetes de " + billetes[i] + ": " + cantidad);

                    // Restar del monto la cantidad entregada en estos billetes
                    N = N - (cantidad * billetes[i]);
                }
            }

            return 0; // El método devuelve 0 como indicador (no usado)
        }
    }
}
