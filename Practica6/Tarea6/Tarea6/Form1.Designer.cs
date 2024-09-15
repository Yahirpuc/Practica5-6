namespace TorresDeHanoiApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNumeroDiscos = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lstMovimientos = new System.Windows.Forms.ListBox();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumeroDiscos
            // 
            this.txtNumeroDiscos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNumeroDiscos.Location = new System.Drawing.Point(20, 50);
            this.txtNumeroDiscos.Margin = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.txtNumeroDiscos.Name = "txtNumeroDiscos";
            this.txtNumeroDiscos.Size = new System.Drawing.Size(200, 38);
            this.txtNumeroDiscos.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Teal;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(230, 50);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(10);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(180, 38);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lstMovimientos
            // 
            this.lstMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lstMovimientos.FormattingEnabled = true;
            this.lstMovimientos.ItemHeight = 31;
            this.lstMovimientos.Location = new System.Drawing.Point(20, 100);
            this.lstMovimientos.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.lstMovimientos.Name = "lstMovimientos";
            this.lstMovimientos.Size = new System.Drawing.Size(390, 220);
            this.lstMovimientos.TabIndex = 2;
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblInstrucciones.Location = new System.Drawing.Point(20, 10);
            this.lblInstrucciones.Margin = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(310, 39);
            this.lblInstrucciones.TabIndex = 3;
            this.lblInstrucciones.Text = "Ingrese el número de discos:";
            this.lblInstrucciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.lstMovimientos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumeroDiscos);
            this.Name = "Form1";
            this.Text = "Torres de Hanoi";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNumeroDiscos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lstMovimientos;
        private System.Windows.Forms.Label lblInstrucciones;
    }
}
