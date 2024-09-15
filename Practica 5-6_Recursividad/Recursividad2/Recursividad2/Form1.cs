using System;
using System.Drawing;
using System.Windows.Forms;
using CambioMonedasForm;

namespace Recursividad2
{
    public partial class Form1 : Form
    {
        private TextBox txtMontoProducto;
        private TextBox txtMontoEntregado;
        private Button btnCalcular;
        private Label lblCambioTotal;
        private ListBox lstDesgloseCambio;
        private Label lblTitulo;
        private Label lblMontoProducto;
        private Label lblMontoEntregado;

        public Form1()
        {
            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            // Inicializar controles
            this.txtMontoProducto = new TextBox();
            this.txtMontoEntregado = new TextBox();
            this.btnCalcular = new Button();
            this.lblCambioTotal = new Label();
            this.lstDesgloseCambio = new ListBox();
            this.lblTitulo = new Label();
            this.lblMontoProducto = new Label();
            this.lblMontoEntregado = new Label();

            // Configuración del Label para el título
            this.lblTitulo.Text = "Maquina de Cambio";
            this.lblTitulo.Font = new Font("Arial", 24, FontStyle.Bold);
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitulo.Location = new Point(50, 10); // Centra el título
            this.lblTitulo.ForeColor = Color.Teal; // Color del texto

            // Configuración del Label para el monto del producto
            this.lblMontoProducto.Text = "Ingresa el precio del producto:";
            this.lblMontoProducto.Font = new Font("Arial", 12, FontStyle.Bold);
            this.lblMontoProducto.AutoSize = true;
            this.lblMontoProducto.TextAlign = ContentAlignment.MiddleCenter;
            this.lblMontoProducto.Location = new Point(90, 60); // Ubicación del label
            this.lblMontoProducto.ForeColor = Color.Black; // Color del texto

            // Configuración del Label para el monto entregado
            this.lblMontoEntregado.Text = "Ingresa el monto entregado:";
            this.lblMontoEntregado.Font = new Font("Arial", 12, FontStyle.Bold);
            this.lblMontoEntregado.AutoSize = true;
            this.lblMontoEntregado.TextAlign = ContentAlignment.MiddleCenter;
            this.lblMontoEntregado.Location = new Point(90, 120); // Ubicación del label
            this.lblMontoEntregado.ForeColor = Color.Black; // Color del texto

            // Configuración del TextBox para el monto del producto
            this.txtMontoProducto.Location = new Point(90, 90);
            this.txtMontoProducto.Size = new Size(300, 50); // Tamaño aumentado
            this.txtMontoProducto.Font = new Font("Arial", 16);
            this.txtMontoProducto.PlaceholderText = "Monto del producto";
            this.txtMontoProducto.TextAlign = HorizontalAlignment.Center; // Centra el texto

            // Configuración del TextBox para el monto entregado
            this.txtMontoEntregado.Location = new Point(90, 150);
            this.txtMontoEntregado.Size = new Size(300, 50); // Tamaño aumentado
            this.txtMontoEntregado.Font = new Font("Arial", 16);
            this.txtMontoEntregado.PlaceholderText = "Monto entregado";
            this.txtMontoEntregado.TextAlign = HorizontalAlignment.Center; // Centra el texto

            // Configuración del Button
            this.btnCalcular.Location = new Point(90, 210);
            this.btnCalcular.Size = new Size(300, 60); // Tamaño aumentado
            this.btnCalcular.Font = new Font("Arial", 18, FontStyle.Bold);
            this.btnCalcular.Text = "Calcular Cambio";
            this.btnCalcular.BackColor = Color.Teal; // Color de fondo del botón
            this.btnCalcular.ForeColor = Color.White; // Color del texto del botón
            this.btnCalcular.FlatStyle = FlatStyle.Flat;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.Click += new EventHandler(this.BtnCalcular_Click);

            // Configuración del Label para el cambio total
            this.lblCambioTotal.Location = new Point(90, 280);
            this.lblCambioTotal.Size = new Size(300, 50);
            this.lblCambioTotal.Font = new Font("Arial", 18);
            this.lblCambioTotal.TextAlign = ContentAlignment.MiddleCenter;

            // Configuración del ListBox para el desglose del cambio
            this.lstDesgloseCambio.Location = new Point(90, 340);
            this.lstDesgloseCambio.Size = new Size(300, 180); // Tamaño aumentado
            this.lstDesgloseCambio.Font = new Font("Arial", 16);
            this.lstDesgloseCambio.BorderStyle = BorderStyle.FixedSingle;

            // Agregar controles al formulario
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblMontoProducto);
            this.Controls.Add(this.txtMontoProducto);
            this.Controls.Add(this.lblMontoEntregado);
            this.Controls.Add(this.txtMontoEntregado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCambioTotal);
            this.Controls.Add(this.lstDesgloseCambio);

            // Configuración del formulario
            this.Text = "Máquina para Cobrar";
            this.Size = new Size(500, 550); // Tamaño más grande del formulario
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario
            this.BackColor = Color.LightGray; // Color de fondo del formulario
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            // Lógica para calcular el cambio
            if (double.TryParse(txtMontoProducto.Text, out double montoProducto) &&
                double.TryParse(txtMontoEntregado.Text, out double montoEntregado))
            {
                CalculadorDeCambio.CalculaTuCambio(montoProducto, montoEntregado);
                double cambio = montoEntregado - montoProducto;
                lblCambioTotal.Text = $"Cambio total: ${cambio:F2}";

                lstDesgloseCambio.Items.Clear();
                lstDesgloseCambio.Items.Add($"Cantidad de 100 pesos: {CalculadorDeCambio.cantidad100}");
                lstDesgloseCambio.Items.Add($"Cantidad de 50 pesos: {CalculadorDeCambio.cantidad50}");
                lstDesgloseCambio.Items.Add($"Cantidad de 20 pesos: {CalculadorDeCambio.cantidad20}");
                lstDesgloseCambio.Items.Add($"Cantidad de 10 pesos: {CalculadorDeCambio.cantidad10}");
                lstDesgloseCambio.Items.Add($"Cantidad de 5 pesos: {CalculadorDeCambio.cantidad5}");
                lstDesgloseCambio.Items.Add($"Cantidad de 1 peso: {CalculadorDeCambio.cantidad1}");
                lstDesgloseCambio.Items.Add($"Cantidad de 50 centavos: {CalculadorDeCambio.cantidad50Centavos}");
                lstDesgloseCambio.Items.Add($"Cantidad de 20 centavos: {CalculadorDeCambio.cantidad20Centavos}");
                lstDesgloseCambio.Items.Add($"Cantidad de 1 centavo: {CalculadorDeCambio.cantidad1Centavo}");
            }
            else
            {
                MessageBox.Show("Por favor ingrese montos válidos.");
            }
        }
    }
}
