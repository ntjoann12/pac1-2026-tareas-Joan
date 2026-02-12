using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class JuegoTicTacToe
    {
        private char[,] tablero = new char[3, 3]; // Tablero 3x3
    private char jugadorActual = 'X';

    // Inicializar tablero vacío
    public void InicializarTablero()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                tablero[i, j] = ' ';
    }

    // Mostrar tablero
    public void MostrarTablero()
    {
        Console.Clear();
        Console.WriteLine("JUEGO DE GATO\n");
        Console.WriteLine("  0   1   2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tablero[i, j]);
                if (j < 2) Console.Write(" | ");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("  ---------");
        }
    }

    // Hacer movimiento
    public bool HacerMovimiento()
    {
        int fila = -1, columna = -1;
        bool valido;

        do
        {
            Console.WriteLine($"\nJugador {jugadorActual}, ingrese fila (0-2): ");
            valido = int.TryParse(Console.ReadLine(), out fila) && fila >= 0 && fila <= 2;

            if (!valido)
            {
                Console.WriteLine("Fila inválida. Intente de nuevo.");
                continue;
            }

            Console.WriteLine($"Jugador {jugadorActual}, ingrese columna (0-2): ");
            valido = int.TryParse(Console.ReadLine(), out columna) && columna >= 0 && columna <= 2;

            if (!valido)
            {
                Console.WriteLine("Columna inválida. Intente de nuevo.");
                continue;
            }

            if (tablero[fila, columna] != ' ')
            {
                Console.WriteLine("Casilla ocupada. Intente otra posición.");
                valido = false;
            }

        } while (!valido);

        tablero[fila, columna] = jugadorActual;

        return VerificarGanador(fila, columna);
    }

    // Verificar ganador
    private bool VerificarGanador(int fila, int columna)
    {
        // Verificar fila
        if (tablero[fila, 0] == jugadorActual && tablero[fila, 1] == jugadorActual && tablero[fila, 2] == jugadorActual)
            return true;

        // Verificar columna
        if (tablero[0, columna] == jugadorActual && tablero[1, columna] == jugadorActual && tablero[2, columna] == jugadorActual)
            return true;

        // Verificar diagonales
        if (tablero[0, 0] == jugadorActual && tablero[1, 1] == jugadorActual && tablero[2, 2] == jugadorActual)
            return true;

        if (tablero[0, 2] == jugadorActual && tablero[1, 1] == jugadorActual && tablero[2, 0] == jugadorActual)
            return true;

        return false;
    }

    // Verificar empate
    public bool VerificarEmpate()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                if (tablero[i, j] == ' ')
                    return false;
        return true;
    }

    // Cambiar jugador
    public void CambiarJugador()
    {
        jugadorActual = (jugadorActual == 'X') ? 'O' : 'X';
    }

    // Obtener jugador actual
    public char JugadorActual()
    {
        return jugadorActual;
    }
    }
}