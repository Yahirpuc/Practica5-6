using System;
using System.Collections.Generic;

namespace Practica6
{
    internal static class TorresDeHanoi
    {
        // Variable estática para almacenar los movimientos
        public static List<string> Movimientos { get; private set; } = new List<string>();

        // Método principal para resolver el problema de las Torres de Hanoi
        public static void ResolverTorresDeHanoi(int n, char origen, char destino, char auxiliar)
        {
            if (n == 1) //N se refiere a el numero de discos para cada caso
            {
                // Caso base: Mueve un solo disco directamente de la varilla de origen a la varilla de destino
                MoverDisco(n, origen, destino);
                return;
            }

            // Paso 1: Mueve n-1 discos de la varilla de origen a la varilla auxiliar usando la varilla de destino como auxiliar
            ResolverTorresDeHanoi(n - 1, origen, auxiliar, destino);

            // Paso 2: Mueve el disco n (el más grande) de la varilla de origen a la varilla de destino
            MoverDisco(n, origen, destino);

            // Paso 3: Mueve los n-1 discos de la varilla auxiliar a la varilla de destino usando la varilla de origen como auxiliar
            ResolverTorresDeHanoi(n - 1, auxiliar, destino, origen);
        }

        // Método para registrar el movimiento de un disco
        public static void MoverDisco(int disco, char origen, char destino)
        {
            // Agrega un movimiento a la lista de movimientos
            string movimiento = $"Mover disco {disco} de {origen} a {destino}";
            Movimientos.Add(movimiento);
        }

   
        
    }
}
