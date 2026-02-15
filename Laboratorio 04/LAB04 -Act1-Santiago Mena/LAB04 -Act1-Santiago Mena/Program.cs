using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04__Act1_Santiago_Mena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1
            string modelo = "Dinoco";
            int carga = 750;
            float nivelcombustible = 10.5f;
            Boolean saltoactivo = true;
            Console.WriteLine("modelo:"+ modelo);
            Console.WriteLine("carga:"+ carga);
            Console.WriteLine("nivelcombustible:"+ nivelcombustible);
            Console.WriteLine("saltoactivo:"+saltoactivo);

            //Ejercicio2
            short sensoresActivos = 128;
            int registroProcesador = Convert.ToInt32(sensoresActivos);
            double precisionTotal = Convert.ToDouble(sensoresActivos);
            Console.WriteLine("precisionTotal:" + precisionTotal);

            //Ejercicio3
            double energiaGenerada = 987.65;
            int energiaLimitada = (int)energiaGenerada;
            Console.WriteLine("Energía Generada:"+ energiaGenerada);
            Console.WriteLine("Energía Limitada:"+energiaLimitada);

            //Ejercicio4
            Console.WriteLine();
            string planetaMasCercano = 
            Console.WriteLine();
            string entradaRadar;
            Console.WriteLine("Ingrese la distancia al planeta más cercano");
            entradaRadar= Console.ReadLine();

            int entradaRadar = int.Parse(planetaMasCercano);
            int distanciaFinal = entradaRadar + 100;
            Console WriteLine("La distancia final es: " + distanciaFinal=;)
        }
    }
}
