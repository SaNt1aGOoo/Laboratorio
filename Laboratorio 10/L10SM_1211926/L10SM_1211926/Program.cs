using System;

namespace L10SM_1211926
{
    internal class Program
    {
        
        // EJERCICIO 1:
        
        static int ContarVocales(string texto)
        {
            int contador = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                char c = texto[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    contador++;
                }
            }
            return contador;
        }

        // ================================================================
        // EJERCICIO 2: Elevar al cuadrado (por referencia) (20 puntos)
        // ================================================================
        static string ElevarAlCuadrado(ref int numero)
        {
            numero *= numero;
            return "Operacion realizada con exito.";
        }

        
        // EJERCICIO 3: Descuento (valor + referencia) 
        static double AplicarDescuento(double porcentajeDescuento, ref double precio)
        {
            double montoDescontado = precio * porcentajeDescuento;
            precio -= montoDescontado;
            return montoDescontado;
        }

        // EJERCICIO 4: Sistema de energía del jugador 
         
        // 4.1 Consumir energía
        static int ConsumirEnergia(ref int energia)
        {
            energia -= 4;
            if (energia < 0)
                energia = 0;
            return energia;
        }

        // 4.2 Recargar energía
        static int RecargarEnergia(ref int energia)
        {
            energia += 6;
            if (energia > 20)
                energia = 20;
            return energia;
        }

        // 4.3 Obtener estado
        static string ObtenerEstado(int energia)
        {
            if (energia >= 15)
                return "Alta";
            else if (energia >= 8)
                return "Media";
            else
                return "Baja";
        }

        // 4.4 Calcular rendimiento
        static string CalcularRendimiento(int energia)
        {
            if (energia == 20)
                return "S";
            else if (energia >= 15)
                return "A";
            else if (energia >= 8)
                return "B";
            else
                return "C";
        }

        // MÉTODO PRINCIPAL INTERACTIVO
        static void Main(string[] args)
        {
            Console.WriteLine("=== EVALUACIÓN PARCIAL - PROGRAMACIÓN (MODO INTERACTIVO) ===\n");

            // ----------------- EJERCICIO 1 -----------------
            Console.WriteLine("1. CONTEO DE VOCALES");
            Console.Write("Ingrese una frase o palabra: ");
            string fraseUsuario = Console.ReadLine();
            int totalVocales = ContarVocales(fraseUsuario);
            Console.WriteLine($"La frase \"{fraseUsuario}\" contiene {totalVocales} vocal(es).\n");

            // ----------------- EJERCICIO 2 -----------------
            Console.WriteLine("2. ELEVAR AL CUADRADO (POR REFERENCIA)");
            int numeroUsuario = LeerEntero("Ingrese un número entero: ");
            int numeroOriginal = numeroUsuario; // Guardamos copia para mostrar
            string mensaje = ElevarAlCuadrado(ref numeroUsuario);
            Console.WriteLine($"Número original: {numeroOriginal}");
            Console.WriteLine($"Número elevado al cuadrado: {numeroUsuario}");
            Console.WriteLine($"Mensaje del sistema: {mensaje}\n");

            // ----------------- EJERCICIO 3 -----------------
            Console.WriteLine("3. DESCUENTO EN TIENDA");
            double precioUsuario = LeerDouble("Ingrese el precio del producto: ");
            double porcentajeUsuario = LeerDouble("Ingrese el porcentaje de descuento (ej. 0.25 para 25%): ");
            double precioOriginal = precioUsuario;
            double montoDescontado = AplicarDescuento(porcentajeUsuario, ref precioUsuario);
            Console.WriteLine($"Precio original: {precioOriginal:C}");
            Console.WriteLine($"Descuento aplicado: {porcentajeUsuario:P0}");
            Console.WriteLine($"Monto descontado: {montoDescontado:C}");
            Console.WriteLine($"Precio final: {precioUsuario:C}\n");

            // ----------------- EJERCICIO 4 -----------------
            Console.WriteLine("4. SISTEMA DE ENERGÍA DEL JUGADOR");
            int energiaInicial = LeerEntero("Ingrese la energía inicial del jugador (0-20): ");
            // Validar rango
            if (energiaInicial < 0) energiaInicial = 0;
            if (energiaInicial > 20) energiaInicial = 20;

            int energiaJugador = energiaInicial;
            Console.WriteLine($"\nEnergía inicial: {energiaJugador}");

            // Consumir energía
            int restante = ConsumirEnergia(ref energiaJugador);
            Console.WriteLine($"Después de consumir 4 unidades: {restante}");

            // Recargar energía
            int actual = RecargarEnergia(ref energiaJugador);
            Console.WriteLine($"Después de recargar 6 unidades: {actual}");

            // Estado y rendimiento
            string estado = ObtenerEstado(energiaJugador);
            string rendimiento = CalcularRendimiento(energiaJugador);
            Console.WriteLine($"Estado actual: {estado}");
            Console.WriteLine($"Calificación de rendimiento: {rendimiento}");

            
            
        }

        // FUNCIONES AUXILIARES PARA LA LECTURA DE DATOS
        
        static int LeerEntero(string mensaje)
        {
            int valor;
            bool esValido;
            do
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();
                esValido = int.TryParse(entrada, out valor);
                if (!esValido)
                {
                    Console.WriteLine("Error: Debe ingresar un número entero válido.");
                }
            } while (!esValido);
            return valor;
        }

        static double LeerDouble(string mensaje)
        {
            double valor;
            bool esValido;
            do
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();
                esValido = double.TryParse(entrada, out valor);
                if (!esValido)
                {
                    Console.WriteLine("Error: Debe ingresar un número decimal válido (use punto o coma según su configuración regional).");
                }
            } while (!esValido);
            return valor;
        }
    }
}