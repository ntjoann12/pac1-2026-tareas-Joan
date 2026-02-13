namespace TareasCSharp.Tareas
{
    public class JuegoTicTacToe
    {
        private char[,] tablero = new char[3, 3]; // Matriz 3x3 que representa el tablero
        private char jugadorActual = 'X'; // Jugador que inicia el turno

        // ===== Inicializar el tablero con espacios vacíos =====
        public void InicializarTablero()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    tablero[i, j] = ' '; // Cada casilla comienza vacía
        }

        // ===== Mostrar el tablero en consola =====
        public void MostrarTablero()
        {
            Console.WriteLine("JUEGO DE GATO");
            Console.WriteLine("  0   1   2"); // Encabezado de columnas
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " "); // Número de fila
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tablero[i, j]); // Mostrar valor de la casilla
                    if (j < 2) Console.Write(" | "); // Separador de columnas
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("  ---------"); // Separador de filas
            }
        }

        // ===== Hacer un movimiento del jugador actual =====
        public bool HacerMovimiento()
        {
            int fila = -1, columna = -1;
            bool valido;

            do
            {
                // Pedir fila y validar que esté entre 0 y 2
                Console.WriteLine("Jugador " + jugadorActual + ", ingrese fila (0-2): ");
                valido = int.TryParse(Console.ReadLine(), out fila) && fila >= 0 && fila <= 2;
                if (!valido)
                {
                    Console.WriteLine("Fila inválida. Intente de nuevo.");
                    continue;
                }

                // Pedir columna y validar que esté entre 0 y 2
                Console.WriteLine("Jugador " + jugadorActual + ", ingrese columna (0-2): ");
                valido = int.TryParse(Console.ReadLine(), out columna) && columna >= 0 && columna <= 2;
                if (!valido)
                {
                    Console.WriteLine("Columna inválida. Intente de nuevo.");
                    continue;
                }

                // Verificar que la casilla no esté ocupada
                if (tablero[fila, columna] != ' ')
                {
                    Console.WriteLine("Casilla ocupada. Intente otra posición.");
                    valido = false;
                }

            } while (!valido); // Repetir hasta que el jugador ingrese un movimiento válido

            tablero[fila, columna] = jugadorActual; // Asignar la jugada al tablero

            // Retorna true si el movimiento genera un ganador
            return VerificarGanador(fila, columna);
        }

        // ===== Verificar si el jugador actual ha ganado =====
        private bool VerificarGanador(int fila, int columna)
        {
            // Verificar fila completa
            if (tablero[fila, 0] == jugadorActual && tablero[fila, 1] == jugadorActual && tablero[fila, 2] == jugadorActual)
                return true;

            // Verificar columna completa
            if (tablero[0, columna] == jugadorActual && tablero[1, columna] == jugadorActual && tablero[2, columna] == jugadorActual)
                return true;

            // Verificar diagonal principal
            if (tablero[0, 0] == jugadorActual && tablero[1, 1] == jugadorActual && tablero[2, 2] == jugadorActual)
                return true;

            // Verificar diagonal secundaria
            if (tablero[0, 2] == jugadorActual && tablero[1, 1] == jugadorActual && tablero[2, 0] == jugadorActual)
                return true;

            return false; // No hay ganador
        }

        // ===== Verificar si el juego terminó en empate =====
        public bool VerificarEmpate()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (tablero[i, j] == ' ') // Si hay al menos un espacio vacío, no hay empate
                        return false;
            return true; // Todas las casillas ocupadas y sin ganador → empate
        }

        // ===== Cambiar el jugador actual =====
        public void CambiarJugador()
        {
            if (jugadorActual == 'X')
                jugadorActual = 'O';
            else
                jugadorActual = 'X';
        }

        // ===== Obtener el jugador actual =====
        public char JugadorActual()
        {
            return jugadorActual;
        }
    }
}
