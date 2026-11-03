# Comparación de Algoritmos de Búsqueda

## Descripción
Este proyecto consiste en una aplicación de consola desarrollada en C# que implementa dos algoritmos de búsqueda: búsqueda lineal y búsqueda binaria. Ambos algoritmos permiten encontrar un número dentro de un arreglo y comparar la cantidad de operaciones que realizan.

## Objetivo
Analizar y comparar la eficiencia de dos algoritmos que resuelven el mismo problema, considerando su complejidad temporal y espacial.

## Tecnologías utilizadas
- Lenguaje de programación: C#
- Plataforma: .NET
- Entorno de desarrollo: Visual Studio 2022
- Tipo de aplicación: Consola

## Algoritmos implementados

### 1. Búsqueda lineal
Recorre los elementos del arreglo uno por uno hasta encontrar el número solicitado o llegar al final.

- Complejidad temporal: O(n).
- Complejidad espacial: O(1).
- No requiere que los datos estén ordenados.

### 2. Búsqueda binaria
Busca un elemento dividiendo repetidamente el rango de búsqueda en dos mitades.

- Complejidad temporal: O(log n).
- Complejidad espacial: O(1).
- Requiere que los datos estén ordenados.

## Funcionalidades
- Solicitar la cantidad de elementos del arreglo.
- Capturar números enteros en orden ascendente.
- Solicitar el número que se desea buscar.
- Ejecutar la búsqueda lineal.
- Ejecutar la búsqueda binaria.
- Mostrar la posición del elemento encontrado.
- Contabilizar las comparaciones realizadas por cada algoritmo.
- Informar cuando el elemento no se encuentra.

## Ejemplo de ejecución

Arreglo:
`[10, 20, 30, 40, 50, 60, 70, 80]`

Número buscado: `80`

Resultados esperados:
- Búsqueda lineal: 8 comparaciones.
- Búsqueda binaria: 3 comparaciones.

## Conceptos aplicados
- Arreglos.
- Algoritmos de búsqueda.
- Ciclos e instrucciones condicionales.
- Métodos.
- Complejidad temporal.
- Complejidad espacial.
- Análisis de eficiencia algorítmica.

## Ejecución del proyecto
1. Abrir el proyecto en Visual Studio 2022.
2. Ejecutar la aplicación.
3. Introducir la cantidad de números.
4. Ingresar los números en orden ascendente.
5. Introducir el número que se desea buscar.
6. Observar los resultados de ambos algoritmos.

## Conclusión
La búsqueda binaria presenta una mayor eficiencia temporal cuando se trabaja con datos ordenados, ya que reduce el espacio de búsqueda a la mitad en cada iteración. Por otro lado, la búsqueda lineal es más sencilla y puede utilizarse cuando los datos no están ordenados.

## Autor
Cristofer

## Actividad
Tarea 1.3: Análisis comparativo de eficiencia y complejidad algorítmica.
