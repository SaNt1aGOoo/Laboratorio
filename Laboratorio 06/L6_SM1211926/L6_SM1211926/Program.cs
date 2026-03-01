using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_SM1211926
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            // Ejercicio#1 Tipos de vehiculos
            int opción;
            Console.WriteLine("Escriba su tipo de vehículo: Bicicleta, 2: Motocicleta, 3: Auto, 4: Camión, 5: Autobús");
            opción = int.Parse(Console.ReadLine());
            switch (opción)
            {
                case 1:
                    Console.WriteLine("Vehiculo no motorizado");
                    break;
                case 2:
                    Console.WriteLine("Vehiculo ligero");
                    break;
                case 3:
                    Console.WriteLine("Vehiculo Mediano");
                    break;
                case 4:
                    Console.WriteLine("Vehiculo Pesado");
                    break;
                case 5:
                    Console.WriteLine("Transporte Público");
                    break;
                case 6:
                    Console.WriteLine("Número ingresado no válido.");
                    break;
            }
            // Ejercicio#2 Banco Industrial
            int tipoTarjeta;
            double limiteActual, nuevoLimite, aumentoPorcentaje;


            Console.WriteLine("Ingrese su límite de crédito actual:");
            limiteActual = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tipo de tarjeta (1, 2, 3 o cualquier otro número para otro tipo):");
            tipoTarjeta = int.Parse(Console.ReadLine());

            switch (tipoTarjeta)
            {
                case 1:
                    aumentoPorcentaje = 0.25; 
                    break;
                case 2:
                    aumentoPorcentaje = 0.35; 
                    break;
                case 3:
                    aumentoPorcentaje = 0.40; 
                    break;
                default:
                    aumentoPorcentaje = 0.50; 
                    break;
            }

            // Cálculo del nuevo límite
            nuevoLimite = limiteActual + (limiteActual * aumentoPorcentaje);

            // Resultado $ para no tener que cortar las comillas y corchetes para expresar la variable
            Console.WriteLine($"Su aumento es del {aumentoPorcentaje * 100}%.");
            Console.WriteLine($"Su nuevo límite de crédito es: Q{nuevoLimite:0.00}");

            // Ejercicio#3 Empleados
            double puntuacion, beneficio;
            // ("")Para poder colocar info sin que sea error
            string nivelRendimiento = "";

            Console.WriteLine("Ingrese su puntuación (0.0, 0.4, o 0.6 en adelante):");
            puntuacion = double.Parse(Console.ReadLine());

            // Validación correcta de puntuaciones permitidas y uso de condiciones compuestas
            if (puntuacion == 0.0 || puntuacion == 0.4 || puntuacion >= 0.6)
            {
                // Clasificación correcta del nivel
                if (puntuacion == 0.0)
                {
                    nivelRendimiento = "Inaceptable";
                }
                else if (puntuacion == 0.4)
                {
                    nivelRendimiento = "Aceptable";
                }
                else if (puntuacion >= 0.6)
                {
                    nivelRendimiento = "Meritorio";
                }

                // Cálculo correcto del incentivo
                beneficio = 2400.0 * puntuacion;

                // Presentación clara del nivel y monto
                Console.WriteLine($"Su nivel de rendimiento es: {nivelRendimiento}");
                Console.WriteLine($"Cantidad de dinero a recibir: {beneficio}€");
            }
            else
            {
                Console.WriteLine("Error: La puntuación ingresada no es válida. No se permiten valores intermedios como 0.1, 0.2, 0.3 o 0.5.");
            }

            //Ejercicio 4 Pizzería 

            int tipoPizza, opcionIngrediente;
            string ingredienteElegido = "";
            bool seleccionValida = true;
            string tipoPizzaTexto = "";

            Console.WriteLine("¿Qué tipo de pizza desea? \n1: Vegetariana \n2: No Vegetariana");
            tipoPizza = int.Parse(Console.ReadLine());

            if (tipoPizza == 1)
            {
                tipoPizzaTexto = "Vegetariana";
                Console.WriteLine("Ha elegido pizza Vegetariana. Elija UN ingrediente adicional:");
                Console.WriteLine("1: Pimiento");
                Console.WriteLine("2: Tofu");
                opcionIngrediente = int.Parse(Console.ReadLine());

                if (opcionIngrediente == 1) ingredienteElegido = "Pimiento";
                else if (opcionIngrediente == 2) ingredienteElegido = "Tofu";
                else
                {
                    Console.WriteLine("Opción de ingrediente inválida.");
                    seleccionValida = false;
                }
            }
            else if (tipoPizza == 2)
            {
                tipoPizzaTexto = "No Vegetariana";
                Console.WriteLine("Ha elegido pizza No Vegetariana. Elija UN ingrediente adicional:");
                Console.WriteLine("1: Peperoni");
                Console.WriteLine("2: Jamón");
                Console.WriteLine("3: Salmón");
                opcionIngrediente = int.Parse(Console.ReadLine());

                if (opcionIngrediente == 1) ingredienteElegido = "Peperoni";
                else if (opcionIngrediente == 2) ingredienteElegido = "Jamón";
                else if (opcionIngrediente == 3) ingredienteElegido = "Salmón";
                else
                {
                    Console.WriteLine("Opción de ingrediente inválida.");
                    seleccionValida = false;
                }
            }
            else
            {
                Console.WriteLine("Tipo de pizza no válido.");
                seleccionValida = false;
            }
            if (seleccionValida)
            {
                Console.WriteLine("Resumen de su pedido");
                Console.WriteLine($"Tipo de pizza: {tipoPizzaTexto}");
                Console.WriteLine($"Ingredientes: Mozzarella, Tomate y {ingredienteElegido}.");
            }
        }
    }
}
