using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace TareasCSharp.Tareas
{
class Retiro
{
    private int saldo = 5000; // saldo inicial
    private int monto; //Se declaran las variables como privadas para seguridad. 

    public void PedirMonto()
    {
        Console.Write("Ingrese el monto a retirar: ");
        monto = int.Parse(Console.ReadLine());
    }

    public bool RetiroValido()
    {
        if (monto <= 0)
        {
            return false;
        }

        if (monto > saldo)
        {
            return false;
        }

        if (monto % 20 != 0)
        {
            return false;
        }

        return true;
    }

    public void MostrarDesglose()
    {
        if (!RetiroValido())
        {
            Console.WriteLine("Retiro no válido.");
            return;
        }

        int restante = monto;

        int billetes500 = restante / 500;
        restante = restante % 500;

        int billetes200 = restante / 200;
        restante = restante % 200;

        int billetes100 = restante / 100;
        restante = restante % 100;

        int billetes20 = restante / 20;

        Console.WriteLine("Retiro aprobado.");
        Console.WriteLine("Billetes entregados:");
        Console.WriteLine("L500: " + billetes500);
        Console.WriteLine("L200: " + billetes200);
        Console.WriteLine("L100: " + billetes100);
        Console.WriteLine("L20 : " + billetes20);

        saldo = saldo - monto;
        Console.WriteLine("Saldo restante: L" + saldo);
    }
}
}