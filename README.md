# Comparación de Algoritmos de Búsqueda

## Descripción
Este proyecto consiste en una aplicación de consola desarrollada en C# que implementa dos algoritmos de búsqueda: búsqueda lineal y búsqueda binaria. El programa compara su eficiencia mediante el número de comparaciones realizadas y el tiempo de ejecución.

## Objetivo
Analizar y comparar dos algoritmos que resuelven el mismo problema, considerando su complejidad temporal y espacial, así como su comportamiento al trabajar con diferentes cantidades de datos.

## Tecnologías utilizadas
- Lenguaje de programación: C#.
- Plataforma: .NET.
- Entorno de desarrollo: Visual Studio 2022.
- Tipo de aplicación: Consola.

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
- Crear arreglos ordenados automáticamente.
- Realizar pruebas con 100, 1,000 y 10,000 elementos.
- Buscar un número dentro del arreglo.
- Ejecutar la búsqueda lineal y la búsqueda binaria.
- Contabilizar las comparaciones de cada algoritmo.
- Medir el tiempo de ejecución utilizando `Stopwatch`.
- Mostrar la posición del elemento encontrado.
- Mostrar la complejidad temporal y espacial de ambos algoritmos.

## Pruebas de ejecución
El programa realiza tres pruebas con diferentes cantidades de elementos:

- Prueba 1: 100 elementos.
- Prueba 2: 1,000 elementos.
- Prueba 3: 10,000 elementos.

En cada prueba se busca el último elemento del arreglo para observar el comportamiento de los algoritmos en un escenario desfavorable para la búsqueda lineal.

El tiempo se mide realizando 1,000 búsquedas repetidas por algoritmo.

## Análisis de complejidad

| Característica | Búsqueda lineal | Búsqueda binaria |
|---|---|---|
| Complejidad temporal | O(n) | O(log n) |
| Complejidad espacial | O(1) | O(1) |
| Requiere datos ordenados | No | Sí |

## Conceptos aplicados
- Arreglos.
- Algoritmos de búsqueda.
- Ciclos e instrucciones condicionales.
- Métodos.
- Contadores de operaciones.
- Medición del tiempo de ejecución.
- Complejidad temporal.
- Complejidad espacial.
- Análisis de eficiencia algorítmica.

## Ejecución del proyecto
1. Abrir el proyecto en Visual Studio 2022.
2. Ejecutar la aplicación.
3. El programa genera automáticamente los arreglos de prueba.
4. Se ejecutan ambos algoritmos para cada cantidad de elementos.
5. Se muestran las comparaciones, los tiempos y las complejidades.

## Conclusión
La búsqueda binaria presenta una mayor eficiencia temporal cuando se trabaja con datos ordenados, ya que reduce el rango de búsqueda a la mitad en cada iteración. Por otro lado, la búsqueda lineal es más sencilla y puede utilizarse cuando los datos no están ordenados.

## Autor
Cristofer

## Actividad
Tarea 1.3: Análisis comparativo de eficiencia y complejidad algorítmica.
