namespace SimulacionOptimizacion
{
    partial class SimOT
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimOT));
            this.button_iniciar_simulacion = new System.Windows.Forms.Button();
            this.numericUpDown_infectados_por_millon_supuesto = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_numero_de_simulaciones = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.numericUpDown_primera_etapa = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_segunda_etapa = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1_resultado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_multiplicacion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_infectados_por_millon_supuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numero_de_simulaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_primera_etapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_segunda_etapa)).BeginInit();
            this.SuspendLayout();
            // 
            // button_iniciar_simulacion
            // 
            this.button_iniciar_simulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iniciar_simulacion.Location = new System.Drawing.Point(7, 419);
            this.button_iniciar_simulacion.Name = "button_iniciar_simulacion";
            this.button_iniciar_simulacion.Size = new System.Drawing.Size(835, 64);
            this.button_iniciar_simulacion.TabIndex = 0;
            this.button_iniciar_simulacion.Text = "Iniciar simulación";
            this.button_iniciar_simulacion.UseVisualStyleBackColor = true;
            this.button_iniciar_simulacion.Click += new System.EventHandler(this.button_iniciar_simulacion_Click);
            // 
            // numericUpDown_infectados_por_millon_supuesto
            // 
            this.numericUpDown_infectados_por_millon_supuesto.DecimalPlaces = 2;
            this.numericUpDown_infectados_por_millon_supuesto.Location = new System.Drawing.Point(11, 224);
            this.numericUpDown_infectados_por_millon_supuesto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_infectados_por_millon_supuesto.Name = "numericUpDown_infectados_por_millon_supuesto";
            this.numericUpDown_infectados_por_millon_supuesto.Size = new System.Drawing.Size(188, 20);
            this.numericUpDown_infectados_por_millon_supuesto.TabIndex = 1;
            this.numericUpDown_infectados_por_millon_supuesto.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de infectados por millón de habitantes que se supone (ésta cifra irá cam" +
    "biando a lo largo de los días)";
            // 
            // numericUpDown_numero_de_simulaciones
            // 
            this.numericUpDown_numero_de_simulaciones.Location = new System.Drawing.Point(11, 288);
            this.numericUpDown_numero_de_simulaciones.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_numero_de_simulaciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_numero_de_simulaciones.Name = "numericUpDown_numero_de_simulaciones";
            this.numericUpDown_numero_de_simulaciones.Size = new System.Drawing.Size(188, 20);
            this.numericUpDown_numero_de_simulaciones.TabIndex = 3;
            this.numericUpDown_numero_de_simulaciones.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de simulaciones (poner un número grande puede afectar el rendimiento)";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 499);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(571, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(602, 499);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 6;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Visible = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // numericUpDown_primera_etapa
            // 
            this.numericUpDown_primera_etapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_primera_etapa.Location = new System.Drawing.Point(11, 364);
            this.numericUpDown_primera_etapa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_primera_etapa.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_primera_etapa.Name = "numericUpDown_primera_etapa";
            this.numericUpDown_primera_etapa.Size = new System.Drawing.Size(185, 31);
            this.numericUpDown_primera_etapa.TabIndex = 7;
            this.numericUpDown_primera_etapa.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_primera_etapa.ValueChanged += new System.EventHandler(this.numericUpDown_primera_etapa_ValueChanged);
            // 
            // numericUpDown_segunda_etapa
            // 
            this.numericUpDown_segunda_etapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_segunda_etapa.Location = new System.Drawing.Point(253, 364);
            this.numericUpDown_segunda_etapa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_segunda_etapa.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_segunda_etapa.Name = "numericUpDown_segunda_etapa";
            this.numericUpDown_segunda_etapa.Size = new System.Drawing.Size(188, 31);
            this.numericUpDown_segunda_etapa.TabIndex = 8;
            this.numericUpDown_segunda_etapa.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_segunda_etapa.ValueChanged += new System.EventHandler(this.numericUpDown_segunda_etapa_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Primera etapa de multiplicación de test";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Segunda etapa de multiplicación de test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(755, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Resultado, que es la cantidad de test promedio que fueron necesarios para descubr" +
    "ir todos los infectados";
            // 
            // textBox1_resultado
            // 
            this.textBox1_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_resultado.ForeColor = System.Drawing.Color.Blue;
            this.textBox1_resultado.Location = new System.Drawing.Point(7, 571);
            this.textBox1_resultado.Multiline = true;
            this.textBox1_resultado.Name = "textBox1_resultado";
            this.textBox1_resultado.ReadOnly = true;
            this.textBox1_resultado.Size = new System.Drawing.Size(831, 125);
            this.textBox1_resultado.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(462, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "=";
            // 
            // label_multiplicacion
            // 
            this.label_multiplicacion.AutoSize = true;
            this.label_multiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_multiplicacion.Location = new System.Drawing.Point(508, 367);
            this.label_multiplicacion.Name = "label_multiplicacion";
            this.label_multiplicacion.Size = new System.Drawing.Size(43, 24);
            this.label_multiplicacion.TabIndex = 15;
            this.label_multiplicacion.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Ivory;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(793, 52);
            this.label8.TabIndex = 16;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Ivory;
            this.label9.Location = new System.Drawing.Point(579, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "Es la muestra elegida, que depende \r\nde las etapas de multiplicación";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Azure;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(826, 80);
            this.label10.TabIndex = 18;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // SimOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 719);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_multiplicacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1_resultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_segunda_etapa);
            this.Controls.Add(this.numericUpDown_primera_etapa);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_numero_de_simulaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_infectados_por_millon_supuesto);
            this.Controls.Add(this.button_iniciar_simulacion);
            this.MaximizeBox = false;
            this.Name = "SimOT";
            this.Text = "Simulación para la optimización de test para el Covid-19";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_infectados_por_millon_supuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numero_de_simulaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_primera_etapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_segunda_etapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_iniciar_simulacion;
        private System.Windows.Forms.NumericUpDown numericUpDown_infectados_por_millon_supuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_numero_de_simulaciones;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.NumericUpDown numericUpDown_primera_etapa;
        private System.Windows.Forms.NumericUpDown numericUpDown_segunda_etapa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1_resultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_multiplicacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

