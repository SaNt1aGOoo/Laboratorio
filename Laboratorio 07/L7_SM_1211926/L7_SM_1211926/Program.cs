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
            // Entrada
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            // Proceso + Salida
            Console.WriteLine("Hola, " + nombre + ". ¡Bienvenido/a al Laboratorio7!");

            // Ejercicio 1 Suma controlada por contador (WHILE)

            //Entrada
            int numero;
            int contador = 1;
            int suma = 0;

            Console.WriteLine("Ingrese el primer número: ");
            numero = int.Parse(Console.ReadLine());
            while (numero <= 0)
            {
                Console.WriteLine("Ingrese el siguiente número: ");
                numero = int.Parse(Console.ReadLine());
            }

            //Proceso
            while (contador <= numero)
            {
                suma = suma + contador;
                contador++;
            }
            float promedio = suma / numero;
            //Salida
            Console.WriteLine("El promedio es: " + promedio);
            Console.WriteLine("La suma es: " + suma);

            //Ejercicio 2 Menú repetitivo de conversión de unidades (DO-WHILE)

            //entrada
            int Celcius;
            int Fahrenheit;
            int Kilómetros;
            int Millas;
            int Opción;

            Console.WriteLine("Opciones sugeridas:");
            do
            {
                Console.WriteLine("Para convertir Celcius a Fahrenheit coloque 1");
                Console.WriteLine("Para convertir Fahrenheit a Celcius coloque 2");
                Console.WriteLine("Para convertir Kilómetros a Millas coloque 3");
                Console.WriteLine("Para salir coloque 4");

            }
        }
    }
}
