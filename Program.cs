
using System;
using System.Diagnostics;

namespace ComparacionAlgoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("       ANALISIS DE ALGORITMOS DE BUSQUEDA");
            Console.WriteLine("==============================================");

            // Cantidades de elementos para las pruebas
            int[] tamanos = { 100, 1000, 10000 };

            // Repeticiones para medir el tiempo
            int repeticiones = 1000;

            foreach (int cantidad in tamanos)
            {
                Console.WriteLine("\n----------------------------------------------");
                Console.WriteLine($"PRUEBA CON {cantidad} ELEMENTOS");
                Console.WriteLine("----------------------------------------------");

                // Crear arreglo ordenado
                int[] numeros = CrearArreglo(cantidad);

                // Buscar el ultimo elemento
                int objetivo = cantidad;

                Console.WriteLine($"Numero buscado: {objetivo}");

                // Ejecutar busqueda lineal
                int comparacionesLineal = 0;

                int resultadoLineal = BusquedaLineal(
                    numeros,
                    objetivo,
                    ref comparacionesLineal
                );

                // Medir tiempo de busqueda lineal
                Stopwatch cronometroLineal = Stopwatch.StartNew();

                for (int i = 0; i < repeticiones; i++)
                {
                    int resultado = BusquedaLineal(
                        numeros, objetivo, ref comparacionesLinealDummy
                    );

                    GC.KeepAlive(resultado);
                }

                cronometroLineal.Stop();

                // Ejecutar busqueda binaria
                int comparacionesBinaria = 0;

                int resultadoBinaria = BusquedaBinaria(
                    numeros,
                    objetivo,
                    ref comparacionesBinaria
                );

                // Medir tiempo de busqueda binaria
                Stopwatch cronometroBinaria = Stopwatch.StartNew();

                for (int i = 0; i < repeticiones; i++)
                {
                    int resultado = BusquedaBinaria(
                        numeros, objetivo, ref comparacionesBinariaDummy
                    );

                    GC.KeepAlive(resultado);
                }

                cronometroBinaria.Stop();

                // Mostrar resultados
                Console.WriteLine("\nBUSQUEDA LINEAL");
                MostrarResultado(resultadoLineal);
                Console.WriteLine("Comparaciones: " + comparacionesLineal);
                Console.WriteLine(
                    "Tiempo total: " +
                    cronometroLineal.Elapsed.TotalMilliseconds.ToString("F4") +
                    " ms"
                );

                Console.WriteLine("\nBUSQUEDA BINARIA");
                MostrarResultado(resultadoBinaria);
                Console.WriteLine("Comparaciones: " + comparacionesBinaria);
                Console.WriteLine(
                    "Tiempo total: " +
                    cronometroBinaria.Elapsed.TotalMilliseconds.ToString("F4") +
                    " ms"
                );

                Console.WriteLine("\nDIFERENCIA DE COMPLEJIDAD");
                Console.WriteLine("Lineal: O(n)");
                Console.WriteLine("Binaria: O(log n)");
                Console.WriteLine("Espacio adicional de ambas: O(1)");
            }

            Console.WriteLine("\n==============================================");
            Console.WriteLine("       PRUEBAS FINALIZADAS");
            Console.WriteLine("==============================================");

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }

        // Contadores auxiliares para las pruebas de tiempo
        static int comparacionesLinealDummy;
        static int comparacionesBinariaDummy;

        // Crear un arreglo ordenado
        static int[] CrearArreglo(int cantidad)
        {
            int[] arreglo = new int[cantidad];

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = i + 1;
            }

            return arreglo;
        }

        // Algoritmo de busqueda lineal
        static int BusquedaLineal(
            int[] arreglo,
            int objetivo,
            ref int comparaciones)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                comparaciones++;

                if (arreglo[i] == objetivo)
                {
                    return i;
                }
            }

            return -1;
        }

        // Algoritmo de busqueda binaria
        static int BusquedaBinaria(
            int[] arreglo,
            int objetivo,
            ref int comparaciones)
        {
            int inicio = 0;
            int final = arreglo.Length - 1;

            while (inicio <= final)
            {
                int medio = inicio + (final - inicio) / 2;

                comparaciones++;

                if (arreglo[medio] == objetivo)
                {
                    return medio;
                }

                if (arreglo[medio] < objetivo)
                {
                    inicio = medio + 1;
                }
                else
                {
                    final = medio - 1;
                }
            }

            return -1;
        }

        // Mostrar resultado de la busqueda
        static void MostrarResultado(int posicion)
        {
            if (posicion != -1)
            {
                Console.WriteLine(
                    "Numero encontrado en la posicion: " + posicion
                );
            }
            else
            {
                Console.WriteLine("Numero no encontrado.");
            }
        }
    }
}
