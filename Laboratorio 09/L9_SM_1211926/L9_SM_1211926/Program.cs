using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_SM_1211926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Saludo(nombre);
            Curso();

            //Ejercicio 2
            Console.Write("Ingrese la figura que desea calcular: 1)Cuadrado 2)Rectángulo 3)Triángulo .");
            int opción = int.Parse(Console.ReadLine());
            int ladoCuadrado, baseRectangulo, ladoRectangulo;
            switch(opción)
            {
                case 1:
                    Console.Write("Ingrese cuanto mide el lado del cuadrado: ");
                    ladoCuadrado = int.Parse(Console.ReadLine());
                    areaCuadrado(ladoCuadrado);
                    break;
                case 2:
                    Console.Write("Ingrese cuanto mide la base del rectangulo: ");
                    baseRectangulo = int.Parse(Console.ReadLine());
                    break;

                    Console.Write("Ingrese cuanto mide el lado del rectangulo: ");
                    ladoRectangulo = int.Parse(Console.ReadLine());
                    break;
            }
        }
        //Procedimientos Ejercicio 1
        static void Saludo(string nombre) 
        {
            Console.WriteLine(" Hola " +nombre + " Como estás? ");
        }
        static void Curso() 
        {
            Console.WriteLine("Bienvenido a PENSAMIENTO COMPUTACIONAL");
        }
        //Procedimiento Ejercicio 2
        static void areaCuadrado(int ladoCuadrado)
        {
            int resultado = ladoCuadrado * ladoCuadrado;
            Console.Write("El área del cuadrado es: " + resultado);
        }
        static void areaRectangulo(int ladoRectangulo)
        {
            int 
        }
    }
}
