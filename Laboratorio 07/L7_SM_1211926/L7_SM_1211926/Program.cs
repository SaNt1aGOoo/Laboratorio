using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_SM_1211926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            Console.Write("Ingrese cuantos valores quiere sumar --> ");
            int valores = int.Parse(Console.ReadLine());
            int contador = 1;
            int suma = 0;
            while (valores <= 0)
            {
                Console.WriteLine("Ingresa un valor mayor a 0: ");
                valores = int.Parse(Console.ReadLine());
            }

            while (contador <= valores)
            {
                suma += contador;
                contador++;
            }
            double promedio = ((double)suma / valores);
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Promedio " + promedio);

            //Ejercicio 2

            int opción;
            do
            {
                Console.WriteLine("1. Celsius a Fahrenheit, 2. Fahrenheit a Celsius, 3. Kilómetros a Millas, 4. Salir");
                opción = int.Parse(Console.ReadLine());
                switch (opción)
                {
                    case 1:
                        Console.Write("Ingrese grados en celsius: ");
                        double celsius = double.Parse(Console.ReadLine());
                        double fahrenheit = (celsius * 1.8) + 32;
                        Console.WriteLine($"Grados Fahrenheit --> {fahrenheit:F2}");
                        break;

                    case 2:
                        Console.Write("Ingrese grados en Fahrenheit: ");
                        double f = double.Parse(Console.ReadLine());
                        double c = (f - 32) / 1.8;
                        Console.WriteLine($"Grados Celsius --> {c:F2}");
                        break;

                    case 3:
                        Console.Write("Ingrese Kilómetros: ");
                        double km = double.Parse(Console.ReadLine());
                        double mi = (km / 1.609);
                        Console.WriteLine($"Millas --> {mi:F2}");
                        break;
                    case 4:
                        Console.WriteLine("Salir");
                        break;
                    default:
                        Console.WriteLine("Opción invalida");
                        break;
                }
            } while (opción != 4);

            //Ejercicio 3
            Random random = new Random();
            int num = random.Next(1, 101);
            int intento = 0;
            int numeroElegido = 0;

            while (numeroElegido != num)
            {
                Console.Write("Ingrese un numero entre 1 y 100 ");
                numeroElegido = int.Parse(Console.ReadLine());

                if (numeroElegido < 1 || numeroElegido > 100)
                {
                    Console.WriteLine("Numero fuera de rango");
                    continue;
                }

                intento++;

                if (numeroElegido < num)
                {
                    Console.WriteLine("Mas alto");
                }
                else if (numeroElegido > num)
                {
                    Console.WriteLine("Mas bajo");
                }
                else
                {
                    Console.WriteLine("Correcto");
                    Console.WriteLine("Intentos: " + intento);
                }
            }

            //Ejercicio 4
            int codigo = 1234;
            int intentos = 0;
            int códigoUsuario = 0;
            do
            {
                Console.Write("Ingrese el codigo de 4 digitos: ");
                códigoUsuario = int.Parse(Console.ReadLine());

                if (códigoUsuario != codigo)
                {
                    Console.WriteLine("Codigo incorrecto");
                    intentos++;
                }
                else
                {
                    Console.WriteLine("Acceso concedido");
                }
            } while (códigoUsuario != codigo && intentos < 3);

            if (códigoUsuario != codigo)
            {
                Console.WriteLine("Cuenta bloqueada");
            }

        
        }
    }
}
