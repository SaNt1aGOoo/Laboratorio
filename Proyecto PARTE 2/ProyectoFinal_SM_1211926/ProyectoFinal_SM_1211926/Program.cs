using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProyectoFinal_SM_1211926
{
    internal class Program
    {
        // Clase Parcela
        class Parcela
        {
            public string siembra;
            public int crecimientoActual;
            public int mesesCrecimiento;
            public double ingresos;
            public bool regadaEsteMes;

            public void sembrar(string cultivo)
            {
                siembra = cultivo;
                switch (cultivo.ToLower())
                {
                    case "papa":
                        mesesCrecimiento = 2;
                        crecimientoActual = 0;
                        ingresos = 650;
                        regadaEsteMes = false;
                        break;
                    case "fresa":
                        mesesCrecimiento = 4;
                        crecimientoActual = 0;
                        ingresos = 900;
                        regadaEsteMes = false;
                        break;
                    case "tomate":
                        mesesCrecimiento = 3;
                        crecimientoActual = 0;
                        ingresos = 650;
                        regadaEsteMes = false;
                        break;
                    default:
                        siembra = "vacia";
                        mesesCrecimiento = 0;
                        ingresos = 0;
                        regadaEsteMes = false;
                        break;
                }
            }
        }

        // Menú principal
        static void EjecutarMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=== MENÚ ===");
            Console.WriteLine("1. Sembrar");
            Console.WriteLine("2. Regar parcela");
            Console.WriteLine("3. Consultar parcela");
            Console.WriteLine("4. Avanzar mes");
            Console.WriteLine("5. Ver reporte Actual");
            Console.WriteLine("6. Salir");
            Console.ResetColor();
        }

        // Distribuidor de opciones
        static void EjecutarOpcion(int opcion, Parcela[,] parcelas, ref double dineroInicial, ref double totalEgresos, ref double dineroTotal, ref double totalIngresos, ref int riegosRealizados, ref int mesesSimulados, ref int cantidadParcelacosechada, ref int cantidadParcelasembrada, ref int empleados, ref double sueldoXempleado, ref int parcelasVacias, ref int mesesTotales)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Sembrar");
                    Sembrar(parcelas, ref parcelasVacias, ref cantidadParcelacosechada, ref cantidadParcelasembrada);
                    break;
                case 2:
                    Console.WriteLine("Regar parcela");
                    regar(parcelas, ref dineroInicial, ref totalEgresos, ref riegosRealizados, ref dineroTotal);
                    break;
                case 3:
                    Console.WriteLine("Consultar parcela");
                    consultarParcela(parcelas);
                    break;
                case 4:
                    Console.WriteLine("Avanzar mes");
                    avanzarMes(parcelas, ref empleados, ref mesesSimulados, ref sueldoXempleado, ref dineroTotal, ref dineroInicial, ref cantidadParcelacosechada, ref parcelasVacias, ref totalIngresos, ref totalEgresos, ref mesesTotales);
                    break;
                case 5:
                    Console.WriteLine("Reporte (Estado actual de la granja)");
                    datosFinales(dineroTotal, totalIngresos, totalEgresos, mesesSimulados,
                        cantidadParcelasembrada, cantidadParcelacosechada, parcelasVacias, riegosRealizados);
                    break;
                case 6:
                    Console.WriteLine("Salir");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción inválida");
                    Console.ResetColor();
                    break;
            }
        }

        // Siembra
        static void Sembrar(Parcela[,] parcelas, ref int parcelasVacias, ref int cantidadParcelacosechada, ref int cantidadParcelasembrada)
        {
            Console.WriteLine("Ingrese fila:");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese columna:");
            int c = int.Parse(Console.ReadLine());

            if (f >= 0 && f < parcelas.GetLength(0) && c >= 0 && c < parcelas.GetLength(1))
            {
                if (parcelas[f, c].siembra == "vacia")
                {
                    Console.WriteLine("Ingrese tipo de producto a sembrar (papa, tomate, fresa):");
                    string cultivo = Console.ReadLine().ToLower();
                    if (cultivo == "papa" || cultivo == "fresa" || cultivo == "tomate")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        parcelas[f, c].sembrar(cultivo);
                        Console.WriteLine("Siembra realizada correctamente.");
                        cantidadParcelasembrada++;
                        parcelasVacias--;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Cultivo no encontrado. Ingrese de nuevo la posicion de su cultivo");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Esa parcela ya tiene siembra. Coloque una nueva posicion");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Posición fuera del rango.");
                Console.ResetColor();
            }
        }

        // Riego
        static void regar(Parcela[,] parcelas, ref double dineroInicial, ref double totalEgresos, ref int riegosRealizados, ref double dineroTotal)
        {
            Console.WriteLine("Ingrese la fila que desea regar:");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la columna que desea regar:");
            int c = int.Parse(Console.ReadLine());

            if (f >= 0 && f < parcelas.GetLength(0) && c >= 0 && c < parcelas.GetLength(1))
            {
                if (parcelas[f, c].siembra == "vacia")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡No se puede regar una parcela vacía!");
                    Console.ResetColor();
                }
                else
                {
                    if (parcelas[f, c].regadaEsteMes)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Esta parcela ya fue regada este mes!");
                        Console.ResetColor();
                    }
                    else if (dineroTotal < 40)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Dinero insuficiente para regar (cuesta Q40).");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("La parcela sí tiene siembra, se puede regar.");
                        parcelas[f, c].regadaEsteMes = true;
                        dineroTotal -= 40;
                        totalEgresos += 40;
                        Console.WriteLine("Se descontaron Q40.");
                        riegosRealizados++;
                        Console.ResetColor();
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡Sus datos estan fuera del limite!");
                Console.ResetColor();
            }
        }

        // Consulta
        static void consultarParcela(Parcela[,] parcelas)
        {
            Console.WriteLine("Ingrese la fila de la parcela que desea consultar");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la columna que desea revisar");
            int c = int.Parse(Console.ReadLine());

            if (parcelas[f, c].siembra == "vacia")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("la parcela esta disponible para sembrar");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Tipo de cultivo: " + parcelas[f, c].siembra);
                Console.WriteLine("Crecimiento: " + parcelas[f, c].crecimientoActual + " / " + parcelas[f, c].mesesCrecimiento + " meses");
            }
        }

        // Avanzar mes (corregido)
        static void avanzarMes(Parcela[,] parcelas, ref int empleados, ref int mesesSimulados, ref double sueldoXempleado, ref double dineroTotal, ref double dineroInicial, ref int cantidadParcelacosechada, ref int parcelasVacias, ref double totalIngresos, ref double totalEgresos, ref int mesesTotales)
        {
            // Procesar crecimiento y cosecha
            for (int f = 0; f < parcelas.GetLength(0); f++)
            {
                for (int c = 0; c < parcelas.GetLength(1); c++)
                {
                    if (parcelas[f, c].siembra != "vacia")
                    {
                        if (parcelas[f, c].regadaEsteMes)
                            parcelas[f, c].crecimientoActual += 2;
                        else
                            parcelas[f, c].crecimientoActual += 1;

                        if (parcelas[f, c].crecimientoActual >= parcelas[f, c].mesesCrecimiento)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("¡ALERTA! Parcela (" + f + "," + c + ") con " + parcelas[f, c].siembra + " lista para cosechar.");
                            Console.ResetColor();

                            dineroTotal += parcelas[f, c].ingresos;
                            totalIngresos += parcelas[f, c].ingresos;
                            cantidadParcelacosechada++;

                            parcelas[f, c].sembrar("vacia");
                            parcelasVacias++;
                        }
                    }
                    // Reiniciar el estado de riego para TODAS las parcelas cada mes
                    parcelas[f, c].regadaEsteMes = false;
                }
            }

            // Avanzar el mes (solo una vez)
            mesesSimulados++;
            mesesTotales--;

            // Pagar empleados
            double pagoEmpleados = empleados * sueldoXempleado;
            Console.WriteLine("El pago de los empleados sera de: Q" + pagoEmpleados);
            dineroTotal -= pagoEmpleados;
            totalEgresos += pagoEmpleados;

            Console.WriteLine("Fin de mes. Meses restantes: " + mesesTotales + ". Dinero actual: Q" + dineroTotal);
        }

        // Reporte final
        static void datosFinales(double dineroTotal, double totalIngresos, double totalEgresos, int mesesSimulados, int cantidadParcelsem, int cantidadParcelcos, int parcelasVacias, int riegosRealizados)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("===== REPORTE FINAL =====");
            Console.WriteLine("Dinero final: Q" + dineroTotal);
            Console.WriteLine("Total de ingresos: Q" + totalIngresos);
            Console.WriteLine("Total de egresos: Q" + totalEgresos);
            Console.WriteLine("Meses simulados: " + mesesSimulados);
            Console.WriteLine("Cantidad de parcelas sembradas: " + cantidadParcelsem);
            Console.WriteLine("Cantidad de cosechas realizadas: " + cantidadParcelcos);
            Console.WriteLine("Cantidad total de riegos realizados: " + riegosRealizados);
            Console.WriteLine("Cantidad de parcelas vacías al finalizar: " + parcelasVacias);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("¡GRACIAS POR CONFIAR EN NUESTRO SISTEMA!");
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("¡Bienvenido a su granja virtual!");
            Console.ResetColor();

            double dineroInicial, sueldoXempleado;
            double dineroTotal = 0, totalIngresos = 0, totalEgresos = 0;

            int empleados, mesesTotales;
            int mesesSimulados = 0, cantidadParcelasembrada = 0, cantidadParcelacosechada = 0, riegosRealizados = 0;

            Console.WriteLine("Ingrese el dinero inicial para arrancar con su granja:");
            dineroInicial = double.Parse(Console.ReadLine());

            while (dineroInicial <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error");
                Console.ResetColor();
                Console.WriteLine("Ingrese un número mayor a 0: ");
                dineroInicial = double.Parse(Console.ReadLine());
            }
            dineroTotal = dineroInicial;

            Console.WriteLine("Ingrese el número de empleados para iniciar operaciones:");
            empleados = int.Parse(Console.ReadLine());

            while (empleados <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error");
                Console.ResetColor();
                Console.WriteLine("No cuenta con empleados, vuelva a ingresar su número de empleados: ");
                empleados = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese el sueldo de los empleados. ");
            sueldoXempleado = double.Parse(Console.ReadLine());

            while (sueldoXempleado <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error");
                Console.ResetColor();
                Console.WriteLine("El sueldo debe ser mayor a 0. Ingrese de nuevo: ");
                sueldoXempleado = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese la cantidad de meses a cultivar: ");
            mesesTotales = int.Parse(Console.ReadLine());

            while (mesesTotales <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error");
                Console.ResetColor();
                Console.WriteLine("No se puede inicializar su granja, el número debe ser mayor a 0");
                mesesTotales = int.Parse(Console.ReadLine());
            }

            // Dimensiones de la granja
            Console.WriteLine("Ingrese número de filas:");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número de columnas:");
            int columnas = int.Parse(Console.ReadLine());

            // Inicializar la matriz y el contador de parcelas vacías
            Parcela[,] parcelas = new Parcela[filas, columnas];
            int parcelaVacia = filas * columnas;   // CORREGIDO: ahora se calcula correctamente

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    parcelas[i, j] = new Parcela();
                    parcelas[i, j].sembrar("vacia");
                }
            }

            // Bucle principal CORREGIDO: se detiene automáticamente cuando dinero o meses llegan a 0
            while (mesesTotales > 0 && dineroTotal > 0)
            {
                EjecutarMenu();
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 6)
                    break;   // Salir voluntario

                EjecutarOpcion(opcion, parcelas, ref dineroInicial, ref totalEgresos, ref dineroTotal, ref totalIngresos,
                    ref riegosRealizados, ref mesesSimulados, ref cantidadParcelacosechada, ref cantidadParcelasembrada,
                    ref empleados, ref sueldoXempleado, ref parcelaVacia, ref mesesTotales);
            }

            // Reporte final
            datosFinales(dineroTotal, totalIngresos, totalEgresos, mesesSimulados,
                cantidadParcelasembrada, cantidadParcelacosechada, parcelaVacia, riegosRealizados);
        }
    }
}