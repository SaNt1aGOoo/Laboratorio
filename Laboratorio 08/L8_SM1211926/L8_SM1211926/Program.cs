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

        }
    }
}
