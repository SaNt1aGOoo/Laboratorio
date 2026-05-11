using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14_SM_1211926
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("¿Cómo te llamas? ");
            string nombreUsuario = Console.ReadLine();
            Console.WriteLine("Hola, " + nombreUsuario + " ¡Bienvenido a C#!\n");

            
            // EJERCICIO 1 - LIBROS
           
            Console.WriteLine("EJERCICIO 1 – LIBROS DE LA BIBLIOTECA");

            // Atributos del libro 1
            string titulo1 = "Cien años de soledad";
            string autor1 = "Gabriel García Márquez";
            int anio1 = 1967;
            bool disponible1 = true;

            // Atributos del libro 2
            string titulo2 = "1984";
            string autor2 = "George Orwell";
            int anio2 = 1949;
            bool disponible2 = false;

            // Mostrar información
            Console.WriteLine("Información del libro 1");
            Console.WriteLine("Título: " + titulo1);
            Console.WriteLine("Autor: " + autor1);
            Console.WriteLine("Año de publicación: " + anio1);
            Console.WriteLine("Disponible: " + (disponible1 ? "Sí" : "No"));
            Console.WriteLine();

            Console.WriteLine("Información del libro 2");
            Console.WriteLine("Título: " + titulo2);
            Console.WriteLine("Autor: " + autor2);
            Console.WriteLine("Año de publicación: " + anio2);
            Console.WriteLine("Disponible: " + (disponible2 ? "Sí" : "No"));
            Console.WriteLine();

            // Probar préstamo (libro1)
            Console.WriteLine("Probando préstamo...");
            Console.WriteLine("Estado antes: " + (disponible1 ? "Disponible" : "No disponible"));
            if (disponible1)
            {
                disponible1 = false;
                Console.WriteLine("Libro prestado.");
            }
            else
            {
                Console.WriteLine("Ya está prestado.");
            }
            Console.WriteLine("Estado después: " + (disponible1 ? "Disponible" : "No disponible"));
            Console.WriteLine();

            // Probar devolución (libro2)
            Console.WriteLine("Probando devolución...");
            Console.WriteLine("Estado antes: " + (disponible2 ? "Disponible" : "No disponible"));
            if (!disponible2)
            {
                disponible2 = true;
                Console.WriteLine("Libro devuelto.");
            }
            else
            {
                Console.WriteLine("Ya está disponible.");
            }
            Console.WriteLine("Estado después: " + (disponible2 ? "Disponible" : "No disponible"));
            Console.WriteLine();

            
            // EJERCICIO 2 - MASCOTAS
            Console.WriteLine("   EJERCICIO 2 – MASCOTAS DE LA VETERINARIA");

            // Atributos mascota 1
            string nombreM1 = "Max";
            string especieM1 = "Perro";
            int edadM1 = 3;
            bool vacunadoM1 = false;

            // Atributos mascota 2
            string nombreM2 = "Luna";
            string especieM2 = "Gato";
            int edadM2 = 2;
            bool vacunadoM2 = true;

            // Mostrar información
            Console.WriteLine("Datos de la mascota 1");
            Console.WriteLine("Nombre: " + nombreM1);
            Console.WriteLine("Especie: " + especieM1);
            Console.WriteLine("Edad: " + edadM1);
            Console.WriteLine("Vacunado: " + (vacunadoM1 ? "Sí" : "No"));
            Console.WriteLine();

            Console.WriteLine(" Datos de la mascota 2");
            Console.WriteLine("Nombre: " + nombreM2);
            Console.WriteLine("Especie: " + especieM2);
            Console.WriteLine("Edad: " + edadM2);
            Console.WriteLine("Vacunado: " + (vacunadoM2 ? "Sí" : "No"));
            Console.WriteLine();

            // Vacunar mascota 1
            Console.WriteLine("Vacunando a " + nombreM1 );
            Console.WriteLine("Vacunado antes: " + (vacunadoM1 ? "Sí" : "No"));
            if (!vacunadoM1)
            {
                vacunadoM1 = true;
                Console.WriteLine(nombreM1 + " ha sido vacunado/a.");
            }
            else
            {
                Console.WriteLine(nombreM1 + " ya está vacunado/a.");
            }
            Console.WriteLine("Vacunado después: " + (vacunadoM1 ? "Sí" : "No"));
            Console.WriteLine();

            // Cumpleaños mascota 2
            Console.WriteLine("--- Cumpleaños de " + nombreM2);
            Console.WriteLine("Edad antes: " + edadM2);
            edadM2++;
            Console.WriteLine(nombreM2 + " cumplió años. Ahora tiene " + edadM2 + " años.");
            Console.WriteLine("Edad después: " + edadM2);
            Console.WriteLine();

            
            // EJERCICIO 3 - ESTUDIANTES
            Console.WriteLine("   EJERCICIO 3 – ESTUDIANTES DE LA ESCUELA");
        

            // Estudiante 1
            string nombreE1 = "Ana";
            int edadE1 = 16;
            string gradoE1 = "10mo";
            double[] notasE1 = { 70.5, 80.0, 65.0 };

            // Estudiante 2
            string nombreE2 = "Pedro";
            int edadE2 = 15;
            string gradoE2 = "9no";
            double[] notasE2 = { 55.0, 60.0, 58.0, 70.0 };

            // Calcular promedio (función local)
            double CalcularPromedio(double[] arr)
            {
                if (arr.Length == 0) return 0;
                double suma = 0;
                for (int i = 0; i < arr.Length; i++)
                    suma += arr[i];
                return suma / arr.Length;
            }

            // Mostrar información estudiante 1
            Console.WriteLine("Información del estudiante 1");
            Console.WriteLine("Nombre: " + nombreE1);
            Console.WriteLine("Edad: " + edadE1);
            Console.WriteLine("Grado: " + gradoE1);
            Console.Write("Notas: ");
            for (int i = 0; i < notasE1.Length; i++)
                Console.Write(notasE1[i] + (i < notasE1.Length - 1 ? ", " : ""));
            Console.WriteLine();
            double promedioE1 = CalcularPromedio(notasE1);
            Console.WriteLine("Promedio: " + promedioE1.ToString("F2"));
            Console.WriteLine();

            // Mostrar información estudiante 2
            Console.WriteLine("Información del estudiante 2");
            Console.WriteLine("Nombre: " + nombreE2);
            Console.WriteLine("Edad: " + edadE2);
            Console.WriteLine("Grado: " + gradoE2);
            Console.Write("Notas: ");
            for (int i = 0; i < notasE2.Length; i++)
                Console.Write(notasE2[i] + (i < notasE2.Length - 1 ? ", " : ""));
            Console.WriteLine();
            double promedioE2 = CalcularPromedio(notasE2);
            Console.WriteLine("Promedio: " + promedioE2.ToString("F2"));
            Console.WriteLine();

            // Verificar aprobación
            Console.WriteLine("Aprobación");
            Console.WriteLine(nombreE1 + " aprobó: " + (promedioE1 >= 61 ? "Sí" : "No"));
            Console.WriteLine(nombreE2 + " aprobó: " + (promedioE2 >= 61 ? "Sí" : "No"));
            Console.WriteLine();

            // Agregar nueva nota a estudiante 2
            Console.WriteLine("Agregando nueva nota a " + nombreE2 );
            Console.Write("Notas antes: ");
            for (int i = 0; i < notasE2.Length; i++)
                Console.Write(notasE2[i] + " ");
            Console.WriteLine();
            Console.WriteLine("Promedio antes: " + promedioE2.ToString("F2"));

            // Agregar nota
            double[] nuevasNotasE2 = new double[notasE2.Length + 1];
            for (int i = 0; i < notasE2.Length; i++)
                nuevasNotasE2[i] = notasE2[i];
            nuevasNotasE2[nuevasNotasE2.Length - 1] = 90.0;
            notasE2 = nuevasNotasE2;
            promedioE2 = CalcularPromedio(notasE2);

            Console.Write("Notas después: ");
            for (int i = 0; i < notasE2.Length; i++)
                Console.Write(notasE2[i] + " ");
            Console.WriteLine();
            Console.WriteLine("Promedio después: " + promedioE2.ToString("F2"));
            Console.WriteLine();

            // Mostrar información actualizada
            Console.WriteLine("Información actualizada de " + nombreE2 + ":");
            Console.WriteLine("Información del estudiante 2");
            Console.WriteLine("Nombre: " + nombreE2);
            Console.WriteLine("Edad: " + edadE2);
            Console.WriteLine("Grado: " + gradoE2);
            Console.Write("Notas: ");
            for (int i = 0; i < notasE2.Length; i++)
                Console.Write(notasE2[i] + (i < notasE2.Length - 1 ? ", " : ""));
            Console.WriteLine();
            Console.WriteLine("Promedio: " + promedioE2.ToString("F2"));

            Console.WriteLine("\n¡Fin del laboratorio!");
        
    }
    }
}
