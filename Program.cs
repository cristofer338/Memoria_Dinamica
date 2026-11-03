
using System;

namespace ComparacionAlgoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Console.WriteLine(" COMPARACION DE ALGORITMOS DE BUSQUEDA");
            Console.WriteLine("======================================");

            // Solicitar cantidad de elementos
            int cantidad;

            do
            {
                Console.Write("Ingrese la cantidad de numeros: ");
            }
            while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad < 1);

            int[] numeros = new int[cantidad];

            // Capturar numeros ordenados
            Console.WriteLine("\nIngrese los numeros en orden ascendente:");

            for (int i = 0; i < numeros.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Numero [{i}]: ");

                    if (int.TryParse(Console.ReadLine(), out int valor))
                    {
                        if (i == 0 || valor >= numeros[i - 1])
                        {
                            numeros[i] = valor;
                            break;
                        }
                    }

                    Console.WriteLine("Ingrese un numero valido y en orden ascendente.");
                }
            }

            // Solicitar numero a buscar
            Console.Write("\nIngrese el numero que desea buscar: ");
            int objetivo;

            while (!int.TryParse(Console.ReadLine(), out objetivo))
            {
                Console.Write("Ingrese un numero entero valido: ");
            }

            // Ejecutar busqueda lineal
            int comparacionesLineal = 0;
            int resultadoLineal = BusquedaLineal(
                numeros, objetivo, ref comparacionesLineal);

            // Ejecutar busqueda binaria
            int comparacionesBinaria = 0;
            int resultadoBinaria = BusquedaBinaria(
                numeros, objetivo, ref comparacionesBinaria);

            // Mostrar resultados
            Console.WriteLine("\n========== RESULTADOS ==========");

            Console.WriteLine("\nBusqueda lineal:");
            MostrarResultado(resultadoLineal);
            Console.WriteLine("Comparaciones: " + comparacionesLineal);

            Console.WriteLine("\nBusqueda binaria:");
            MostrarResultado(resultadoBinaria);
            Console.WriteLine("Comparaciones: " + comparacionesBinaria);

            Console.WriteLine("\n================================");
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }

        // Algoritmo de busqueda lineal
        static int BusquedaLineal(
            int[] arreglo, int objetivo, ref int comparaciones)
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
            int[] arreglo, int objetivo, ref int comparaciones)
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

        // Mostrar si se encontro el numero
        static void MostrarResultado(int posicion)
        {
            if (posicion != -1)
            {
                Console.WriteLine("Numero encontrado en la posicion: " + posicion);
            }
            else
            {
                Console.WriteLine("El numero no fue encontrado.");
            }
        }
    }
}
