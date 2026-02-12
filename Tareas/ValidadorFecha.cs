using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;

namespace TareasCSharp.Tareas
{
class ValidadorFecha
{
    private int dia;
    private int mes;
    private int anio;

    public void PedirDatos()
    {
        Console.Write("Ingrese el día: ");
        dia = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el mes: ");
        mes = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el año: ");
        anio = int.Parse(Console.ReadLine());
    }

    public bool EsBisiesto()
    {
        if ((anio % 400 == 0) || (anio % 4 == 0 && anio % 100 != 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int DiasDelMes()
    {
        int dias = 0;

        if (mes == 1 || mes == 3 || mes == 5 || mes == 7 ||
            mes == 8 || mes == 10 || mes == 12)
        {
            dias = 31;
        }
        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
        {
            dias = 30;
        }
        else if (mes == 2)
        {
            if (EsBisiesto())
            {
                dias = 29;
            }
            else
            {
                dias = 28;
            }
        }

        return dias;
    }

    public bool FechaValida()
    {
        if (anio <= 0)
        {
            return false;
        }

        if (mes < 1 || mes > 12)
        {
            return false;
        }

        if (dia < 1 || dia > DiasDelMes())
        {
            return false;
        }

        return true;
    }

    public void MostrarResultado()
    {
        if (FechaValida())
        {
            Console.WriteLine("La fecha ingresada es válida.");
        }
        else
        {
            Console.WriteLine("La fecha ingresada NO es válida.");
        }
    }
}
}