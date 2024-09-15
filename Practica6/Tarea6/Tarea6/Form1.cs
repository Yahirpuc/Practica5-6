using Practica6;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TorresDeHanoiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Limpiar la lista de movimientos y el ListBox
            TorresDeHanoi.Movimientos.Clear();
            lstMovimientos.Items.Clear();

            // Validar la entrada del usuario
            if (int.TryParse(txtNumeroDiscos.Text, out int numeroDeDiscos) && numeroDeDiscos > 0)
            {
                // Resolver Torres de Hanoi y mostrar los movimientos
                TorresDeHanoi.ResolverTorresDeHanoi(numeroDeDiscos, 'A', 'C', 'B');
                foreach (string movimiento in TorresDeHanoi.Movimientos)
                {
                    lstMovimientos.Items.Add(movimiento);
                }
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("N�mero inv�lido. Por favor ingrese un n�mero entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
