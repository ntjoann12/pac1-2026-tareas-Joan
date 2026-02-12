using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class Inventario
    {
        private int[] codigos = new int[5];
    private string[] nombres = new string[5];
    private int[] cantidades = new int[5];
    private float[] precios = new float[5];

    // Inicializar inventario
    public void InicializarInventario()
    {
        Console.Clear();
        Console.WriteLine("INICIALIZACIÓN DE INVENTARIO");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"\nProducto #{i + 1}:");

            int codigo;
            bool valido;
            do
            {
                Console.Write("Ingrese código (entero positivo): ");
                valido = int.TryParse(Console.ReadLine(), out codigo) && codigo > 0;
                if (!valido) Console.WriteLine("Código inválido.");
            } while (!valido);
            codigos[i] = codigo;

            Console.Write("Ingrese nombre del producto: ");
            nombres[i] = Console.ReadLine();

            int cantidad;
            do
            {
                Console.Write("Ingrese cantidad (>=0): ");
                valido = int.TryParse(Console.ReadLine(), out cantidad) && cantidad >= 0;
                if (!valido) Console.WriteLine("Cantidad inválida.");
            } while (!valido);
            cantidades[i] = cantidad;

            float precio;
            do
            {
                Console.Write("Ingrese precio (>=0): ");
                valido = float.TryParse(Console.ReadLine(), out precio) && precio >= 0;
                if (!valido) Console.WriteLine("Precio inválido.");
            } while (!valido);
            precios[i] = precio;
        }
    }

    // Mostrar inventario
    public void MostrarInventario()
    {
        Console.Clear();
        Console.WriteLine("INVENTARIO DE PRODUCTOS");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Código\tNombre\tCantidad\tPrecio");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{codigos[i]}\t{nombres[i]}\t{cantidades[i]}\t\tL.{precios[i]:0.00}");
        }
    }

    // Buscar producto por código
    public void BuscarProducto()
    {
        Console.Write("\nIngrese código a buscar: ");
        int codigoBuscar = int.Parse(Console.ReadLine());
        bool encontrado = false;

        for (int i = 0; i < 5; i++)
        {
            if (codigos[i] == codigoBuscar)
            {
                Console.WriteLine($"Producto encontrado: {nombres[i]}, Cantidad: {cantidades[i]}, Precio: L.{precios[i]:0.00}");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
            Console.WriteLine("Producto no encontrado.");
    }

    // Actualizar cantidad
    public void ActualizarCantidad()
    {
        Console.Write("\nIngrese código del producto a actualizar: ");
        int codigoActualizar = int.Parse(Console.ReadLine());
        bool encontrado = false;

        for (int i = 0; i < 5; i++)
        {
            if (codigos[i] == codigoActualizar)
            {
                int nuevaCantidad;
                bool valido;
                do
                {
                    Console.Write($"Ingrese nueva cantidad para {nombres[i]}: ");
                    valido = int.TryParse(Console.ReadLine(), out nuevaCantidad) && nuevaCantidad >= 0;
                    if (!valido) Console.WriteLine("Cantidad inválida.");
                } while (!valido);

                cantidades[i] = nuevaCantidad;
                Console.WriteLine("Cantidad actualizada correctamente.");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
            Console.WriteLine("Producto no encontrado.");
    }

    // Calcular valor total del inventario
    public void ValorTotalInventario()
    {
        float total = 0;
        for (int i = 0; i < 5; i++)
            total += cantidades[i] * precios[i];

        Console.WriteLine($"\nValor total del inventario: L.{total:0.00}");
    }
    }
}