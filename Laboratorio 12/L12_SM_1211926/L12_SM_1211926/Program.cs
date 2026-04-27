using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_SM_1211926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIOS DE MATRICES");
            Console.WriteLine("Seleccione el ejercicio a ejecutar:");
            Console.WriteLine("1 - Ejercicio 1 (Matriz 4x4, suma fila y columna)");
            Console.WriteLine("2 - Ejercicio 2 (Matriz 3x5 float, número mayor)");
            Console.WriteLine("3 - Ejercicio 3 (Multiplicación de matrices A 2x3 y B 3x2)");
            Console.WriteLine("4 - Ejercicio 4 (Matriz 5x5, diagonales principal y secundaria)");
            Console.Write("\nOpción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Ejercicio1();
                    break;
                case "2":
                    Ejercicio2();
                    break;
                case "3":
                    Ejercicio3();
                    break;
                case "4":
                    Ejercicio4();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Ejercicio 1: Matriz 4x4, suma de fila y columna
        static void Ejercicio1()
        {
            int[,] matriz = new int[4, 4];
            LlenarMatriz4x4(matriz);

            Console.Write("Ingrese el índice de la fila a sumar (0-3): ");
            int fila = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el índice de la columna a sumar (0-3): ");
            int col = int.Parse(Console.ReadLine());

            int sumaF = SumaFila(matriz, fila);
            int sumaC = SumaColumna(matriz, col);

            Console.WriteLine($"\nSuma de la fila {fila} = {sumaF}");
            Console.WriteLine($"Suma de la columna {col} = {sumaC}");
        }

        static void LlenarMatriz4x4(int[,] m)
        {
            Console.WriteLine("Llene la matriz 4x4 con números enteros:");
            for (int fila = 0; fila < 4; fila++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.Write($"Elemento [{fila},{col}]: ");
                    m[fila, col] = int.Parse(Console.ReadLine());
                }
            }
        }

        static int SumaFila(int[,] m, int fila)
        {
            int suma = 0;
            for (int col = 0; col < 4; col++)
                suma += m[fila, col];
            return suma;
        }

        static int SumaColumna(int[,] m, int col)
        {
            int suma = 0;
            for (int fila = 0; fila < 4; fila++)
                suma += m[fila, col];
            return suma;
        }

        
        // Ejercicio 2: Matriz 3x5 float, número mayor
        
        static void Ejercicio2()
        {
            float[,] matriz = new float[3, 5];
            CargarMatriz3x5(matriz);
            float mayor = MayorMatriz(matriz);
            Console.WriteLine($"\nEl valor mayor de la matriz es: {mayor}");
        }

        static void CargarMatriz3x5(float[,] m)
        {
            Console.WriteLine("Llene la matriz 3x5 con números reales:");
            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write($"Elemento [{fila},{col}]: ");
                    m[fila, col] = float.Parse(Console.ReadLine());
                }
            }
        }

        static float MayorMatriz(float[,] m)
        {
            float mayor = m[0, 0];
            for (int fila = 0; fila < 3; fila++)
                for (int col = 0; col < 5; col++)
                    if (m[fila, col] > mayor)
                        mayor = m[fila, col];
            return mayor;
        }

        
        // Ejercicio 3: Multiplicación de matrices A(2x3) y B(3x2)
        static void Ejercicio3()
        {
            int[,] A = new int[2, 3];
            int[,] B = new int[3, 2];
            int[,] R = new int[2, 2];

            Console.WriteLine("Llenado de matriz A (2x3):");
            LlenarMatrizA(A);
            Console.WriteLine("Llenado de matriz B (3x2):");
            LlenarMatrizB(B);

            MultiplicarMatrices(A, B, R);

            Console.WriteLine("\nMatriz resultante (2x2):");
            MostrarMatriz2x2(R);
        }

        static void LlenarMatrizA(int[,] m)
        {
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"A[{i},{j}]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
        }

        static void LlenarMatrizB(int[,] m)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"B[{i},{j}]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
        }

        static void MultiplicarMatrices(int[,] A, int[,] B, int[,] R)
        {
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    R[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                        R[i, j] += A[i, k] * B[k, j];
                }
        }

        static void MostrarMatriz2x2(int[,] m)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write($"{m[i, j]} ");
                Console.WriteLine();
            }
        }

        // Ejercicio 4: Matriz 5x5, diagonales principal y secundaria
      
        static void Ejercicio4()
        {
            int[,] matriz = new int[5, 5];
            LlenarMatriz5x5(matriz);
            int sumaP = SumaDiagonalPrincipal(matriz);
            int sumaS = SumaDiagonalSecundaria(matriz);
            Console.WriteLine($"\nSuma diagonal principal = {sumaP}");
            Console.WriteLine($"Suma diagonal secundaria = {sumaS}");
        }

        static void LlenarMatriz5x5(int[,] m)
        {
            Console.WriteLine("Llene la matriz 5x5 con números enteros:");
            for (int fila = 0; fila < 5; fila++)
                for (int col = 0; col < 5; col++)
                {
                    Console.Write($"Elemento [{fila},{col}]: ");
                    m[fila, col] = int.Parse(Console.ReadLine());
                }
        }

        static int SumaDiagonalPrincipal(int[,] m)
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
                suma += m[i, i];
            return suma;
        }

        static int SumaDiagonalSecundaria(int[,] m)
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
                suma += m[i, 4 - i];
            return suma;
        }
    }
    }

