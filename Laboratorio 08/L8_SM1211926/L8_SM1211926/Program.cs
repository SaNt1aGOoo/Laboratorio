using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_SM1211926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1 Promedio de notas
            int nota, contador, contadorAprobado, contadorReprobado;
            int suma = 0;
            contadorReprobado = 0;
            contadorAprobado = 0;
            contador = 1;
            while (contador <=10)
            {
                contador++;
                Console.WriteLine("Ingrese su nota: ");
                nota = int.Parse(Console.ReadLine());
                suma = suma + nota;
                if (nota < 61)
                {
                    contadorReprobado++;
                }
                else
                {
                    contadorAprobado++;
                }
            }
            Console.WriteLine("La cantidad de clases reprobadas son: " + contadorReprobado);
            Console.WriteLine("La cantidad de clases aprobadas son: " + contadorAprobado);
            Console.WriteLine("Su promedio de notas es: " + suma / 10);

            //Ejercicio 2 Solicita número
            int numEntero, contador2, contPar, contImpar, sum;
            Console.WriteLine("Ingrese un número entero: ");
            numEntero = int.Parse(Console.ReadLine());
            contador2 = 1;
            sum = 0;
            contPar = 0;
            contImpar = 0;
            while (numEntero >= contador2)
            {
                sum = sum + contador2;
                contador2++;
            if (sum % 2 == 0)
                {
                    contPar++;
                }
                else
                {
                    contImpar++;
                }
            }
            Console.WriteLine("La suma de todos los números es:" + sum);
            Console.WriteLine("Existen " + contPar + " números pares.");
            Console.WriteLine("Existen " + contImpar + " números impares");

            //Ejercicio 3

            int opcion;
            double totalVentas = 0;
            int clientes = 0;

            do
            {
                Console.WriteLine("\nMENÚ");
                Console.WriteLine("1) Registrar compra");
                Console.WriteLine("2) Mostrar total de ventas");
                Console.WriteLine("3) Mostrar cantidad de clientes atendidos");
                Console.WriteLine("4) Salir");

                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el monto de la compra: ");
                        double compra = Convert.ToDouble(Console.ReadLine());
                        totalVentas += compra;
                        clientes++;
                        break;

                    case 2:
                        Console.WriteLine("Total de ventas del día: " + totalVentas);
                        break;

                    case 3:
                        Console.WriteLine("Cantidad de clientes atendidos: " + clientes);
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }

            } while (opcion != 4);


            Console.WriteLine("\n===== EJERCICIO 4 =====");

            int contador3 = 0;
            int positivos = 0;
            int negativos = 0;
            int sumaTotal = 0;
            int num;

            do
            {
                Console.Write("Ingrese un número (0 para terminar): ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num != 0)
                {
                    contador3++;
                    sumaTotal += num;

                    if (num > 0)
                    {
                        positivos++;
                    }
                    else
                    {
                        negativos++;
                    }
                }

            } while (num != 0);

            Console.WriteLine("Total de números ingresados: " + contador3);
            Console.WriteLine("Cantidad de positivos: " + positivos);
            Console.WriteLine("Cantidad de negativos: " + negativos);
            Console.WriteLine("Suma total: " + sumaTotal);


            //Ejercicio 5

            Console.Write("Ingrese un número N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
