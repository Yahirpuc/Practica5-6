using System;
using System.Windows.Forms;

namespace CambioMonedasForm
{
    public class CalculadorDeCambio
    {
        // Variables para almacenar la cantidad de cada denominación
        public static int cantidad100, cantidad50, cantidad20, cantidad10, cantidad5, cantidad1, cantidad50Centavos, cantidad20Centavos, cantidad1Centavo;

        // Método principal para calcular el cambio
        public static void CalculaTuCambio(double montoTotal, double montoEntregado)
        {
            // Calculamos el cambio a devolver
            double cambio = montoEntregado - montoTotal;

            // Reiniciamos las variables de cantidad
            cantidad100 = cantidad50 = cantidad20 = cantidad10 = cantidad5 = cantidad1 = 0;
            cantidad50Centavos = cantidad20Centavos = cantidad1Centavo = 0;

            // Verificamos si el monto entregado es suficiente
            if (cambio < 0)
            {
                MessageBox.Show("Monto entregado insuficiente.");
                return;
            }
            else if (cambio == 0)
            {
                MessageBox.Show("No hay cambio.");
                return;
            }

            // Llamamos al método recursivo para calcular el cambio
            CalcularCambio(cambio, 0); // El 0 indica que comenzamos desde la primera denominación en el arreglo
        }

        private static void CalcularCambio(double cambioRestante, int indice)
        {
            // Arreglo con las denominaciones de monedas y billetes
            double[] denominacionesDeMonedas = { 100.0, 50.0, 20.0, 10.0, 5.0, 1.0, 0.50, 0.20, 0.01 };

            // Si el cambio restante es menor que 0.01 o ya procesamos todas las denominaciones, salimos
            if (cambioRestante < 0.01 || indice >= denominacionesDeMonedas.Length)
                return;

            // Calculamos la cantidad de monedas/billetes para la denominación actual
            int cantidad = (int)(cambioRestante / denominacionesDeMonedas[indice]);
            cambioRestante -= cantidad * denominacionesDeMonedas[indice];

            // Guardamos la cantidad correspondiente en la variable correcta
            switch (indice)
            {
                case 0: cantidad100 = cantidad; 
                    break;
                case 1: cantidad50 = cantidad; 
                    break;
                case 2: cantidad20 = cantidad; 
                    break;
                case 3: cantidad10 = cantidad; 
                    break;
                case 4: cantidad5 = cantidad; 
                    break;
                case 5: cantidad1 = cantidad; 
                    break;
                case 6: cantidad50Centavos = cantidad; 
                    break;
                case 7: cantidad20Centavos = cantidad; 
                    break;
                case 8: cantidad1Centavo = cantidad; break;
            }

            // Continuamos con la siguiente denominación
            CalcularCambio(cambioRestante, indice + 1);
        }
    }
}
