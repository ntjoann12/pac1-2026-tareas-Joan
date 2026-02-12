using System;
using TareasCSharp.Tareas;

class Program
{
    static void Main()
    {
        int bloqueSeleccionado;

        do
        {
            Console.WriteLine("=== MENU PRINCIPAL ===");
            Console.WriteLine("Seleccione un bloque:");
            Console.WriteLine("1. Variables y Operadores");
            Console.WriteLine("2. Estructuras de Control - Condicionales");
            Console.WriteLine("3. Estructuras de Control - Ciclos");
            Console.WriteLine("4. Arreglos Unidimensionales");
            Console.WriteLine("5. Arreglos Bidimensionales");
            Console.WriteLine("6. Salir");
            bloqueSeleccionado = int.Parse(Console.ReadLine());

            switch (bloqueSeleccionado)
            {
                case 1:
                    BloqueVariablesYOperadores();
                    break;
                case 2:
                    BloqueCondicionales();
                    break;
                case 3:
                    BloqueCiclos();
                    break;
                case 4:
                    BloqueArreglosUnidimensionales();
                    break;
                case 5:
                    BloqueArreglosBidimensionales();
                    break;
                case 6:
                    Console.WriteLine("SALIENDO DEL PROGRAMA...");
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }

        } while (bloqueSeleccionado != 6);
    }

    // BLOQUE 1: Variables y Operadores
    static void BloqueVariablesYOperadores()
    {
        Console.WriteLine("=== BLOQUE 1: Variables y Operadores ===");

        // IMC
        CalculadoraIMC_1 imcCalc = new CalculadoraIMC_1();
        Console.WriteLine("Ingrese su peso (kg):");
        int peso = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su altura (m):");
        float altura = float.Parse(Console.ReadLine());
        float imc = imcCalc.calculadoraIMC(peso, altura);

        if (imc < 18.5f)
            Console.WriteLine($"IMC: {imc} - Bajo peso");
        else if (imc < 24.9f)
            Console.WriteLine($"IMC: {imc} - Peso normal");
        else if (imc < 29.9f)
            Console.WriteLine($"IMC: {imc} - Sobrepeso");
        else
            Console.WriteLine($"IMC: {imc} - Obesidad");

        // Conversion de Temperaturas
        ConversionTemperatura convTemp = new ConversionTemperatura();
        Console.WriteLine("Conversión de temperaturas:");
        Console.WriteLine("1.Celsius a Fahrenheit\n2.Fahrenheit a Celsius\n3.Celsius a Kelvin\n4.Kelvin a Celsius\n5.Fahrenheit a Kelvin");
        int op = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la temperatura:");
        float temp = float.Parse(Console.ReadLine());
        float res = 0;

        switch (op)
        {
            case 1: res = convTemp.Celsius_a_Fahrenheit(temp); Console.WriteLine("Fahrenheit: " + res); break;
            case 2: res = convTemp.Fahrenheit_a_Celsius(temp); Console.WriteLine("Celsius: " + res); break;
            case 3: res = convTemp.Celsius_a_Kelvin(temp); Console.WriteLine("Kelvin: " + res); break;
            case 4: res = convTemp.Kelvin_a_Celsius(temp); Console.WriteLine("Celsius: " + res); break;
            case 5: res = convTemp.Fahrenheit_a_Kelvin(temp); Console.WriteLine("Kelvin: " + res); break;
            default: Console.WriteLine("Opción no válida"); break;
        }

        // Desglose de billetes
        DesgloseDeBilletes billetes = new DesgloseDeBilletes();
        Console.WriteLine("Ingrese cantidad de dinero para desglose:");
        int monto = int.Parse(Console.ReadLine());
        billetes.Desglose_de_Billetes(monto);

        // Calculadora de préstamo
        CalculadoraDePrestamoSimple prestamo = new CalculadoraDePrestamoSimple();
        Console.WriteLine("Ingrese monto a solicitar:");
        int monto_solicitado = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese tasa de interés (decimal):");
        float tasa = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese plazo en meses:");
        int plazo = int.Parse(Console.ReadLine());
        float cuota = prestamo.CuotaMensualFija(monto_solicitado, tasa);
        float interes = prestamo.InteresTotal(monto_solicitado, plazo, cuota);
        Console.WriteLine($"Cuota mensual: {cuota}, Interés total: {interes}");
    }

    // BLOQUE 2: Condicionales
    static void BloqueCondicionales()
    {
        Console.WriteLine("=== BLOQUE 2: Condicionales ===");

        // Clasificación de triángulos
        Console.WriteLine("Ingrese tres lados del triángulo:");
        int l1 = int.Parse(Console.ReadLine());
        int l2 = int.Parse(Console.ReadLine());
        int l3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el ángulo del triángulo:");
        int angulo = int.Parse(Console.ReadLine());

        if (l1 == l2 && l2 == l3)
            Console.WriteLine(angulo < 90 ? "Triángulo Equilátero Acutángulo" : "Triángulo Equilátero");
        else if (l1 == l2 || l1 == l3 || l2 == l3)
            Console.WriteLine(angulo == 90 ? "Triángulo Isósceles Rectángulo" : angulo > 90 ? "Triángulo Isósceles Obtusángulo" : "Triángulo Isósceles Acutángulo");
        else
            Console.WriteLine(angulo == 90 ? "Triángulo Escaleno Rectángulo" : angulo > 90 ? "Triángulo Escaleno Obtusángulo" : "Triángulo Escaleno Acutángulo");

        // Sistema de calificaciones
        SistemaCalificacionesUNAH calificaciones = new SistemaCalificacionesUNAH();
        Console.WriteLine("Ingrese nota (0-100):");
        int nota = int.Parse(Console.ReadLine());
        if (calificaciones.NotaValida(nota))
        {
            Console.WriteLine("Letra: " + calificaciones.ObtenerLetra(nota));
            Console.WriteLine("Descripción: " + calificaciones.ObtenerDescripcion(nota));
            Console.WriteLine("Estado: " + calificaciones.ObtenerEstado(nota));
        }
        else Console.WriteLine("Nota inválida");

        // Calculadora de descuentos
        CalculadoraDescuentos descuentos = new CalculadoraDescuentos();
        Console.WriteLine("Ingrese monto de compra:");
        float montoCompra = float.Parse(Console.ReadLine());
        Console.WriteLine("Descuento: " + descuentos.CalcularDescuento(montoCompra));
        Console.WriteLine("Precio final: " + descuentos.CalcularPrecioFinal(montoCompra));
    }

    // BLOQUE 3: Ciclos
    static void BloqueCiclos()
    {
        Console.WriteLine("=== BLOQUE 3: Ciclos ===");

        // Tabla de multiplicar
        TablaDeMultiplicar tabla = new TablaDeMultiplicar();
        tabla.PedirNumero();
        tabla.MostrarTabla();

        // Números primos
        NumerosPrimos primos = new NumerosPrimos();
        primos.PedirRango();
        primos.MostrarPrimos();

        // Fibonacci
        Fibonacci fib = new Fibonacci();
        fib.PedirN();
        fib.GenerarSerie();

        // Combinatoria
        Combinatoria comb = new Combinatoria();
        comb.PedirNyR();
        comb.SacarCombinatoria();

        // Juego de adivinanza
        JuegoDeAdivinanza juego = new JuegoDeAdivinanza();
        juego.GenerarNumero();
        juego.JuegoUsuario();
    }

    // BLOQUE 4: Arreglos Unidimensionales
    static void BloqueArreglosUnidimensionales()
    {
        Console.WriteLine("=== BLOQUE 4: Arreglos Unidimensionales ===");
        Console.WriteLine("Aquí irían las clases que trabajan con vectores/arrays unidimensionales.");
        // Por ejemplo: ValidacionDeContras, Retiro, etc. según tus tareas.
    }

    // BLOQUE 5: Arreglos Bidimensionales
    static void BloqueArreglosBidimensionales()
    {
        Console.WriteLine("=== BLOQUE 5: Arreglos Bidimensionales ===");
        Console.WriteLine("Aquí irían las clases que trabajan con matrices/arreglos 2D.");
    }
}
