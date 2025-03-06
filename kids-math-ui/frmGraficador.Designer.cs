namespace Graficador
{
    partial class frmGraficador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picCanvas = new PictureBox();
            btnGraficar = new Button();
            btnLimpiar = new Button();
            numDX = new NumericUpDown();
            numDY = new NumericUpDown();
            groupBox1 = new GroupBox();
            btnAgregarRecta = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            numHasta = new NumericUpDown();
            label3 = new Label();
            numDesde = new NumericUpDown();
            Rango = new Label();
            numInterseccion = new NumericUpDown();
            numPendiente = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDY).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHasta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDesde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numInterseccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPendiente).BeginInit();
            SuspendLayout();
            // 
            // picCanvas
            // 
            picCanvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picCanvas.BackColor = Color.White;
            picCanvas.BorderStyle = BorderStyle.FixedSingle;
            picCanvas.Location = new Point(17, 20);
            picCanvas.Margin = new Padding(4, 5, 4, 5);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(1123, 959);
            picCanvas.TabIndex = 0;
            picCanvas.TabStop = false;
            picCanvas.RegionChanged += picCanvas_RegionChanged;
            picCanvas.SizeChanged += picCanvas_SizeChanged;
            picCanvas.Resize += picCanvas_Resize;
            // 
            // btnGraficar
            // 
            btnGraficar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGraficar.Location = new Point(1266, 1005);
            btnGraficar.Margin = new Padding(4, 5, 4, 5);
            btnGraficar.Name = "btnGraficar";
            btnGraficar.Size = new Size(107, 38);
            btnGraficar.TabIndex = 1;
            btnGraficar.Text = "&Graficar";
            btnGraficar.UseVisualStyleBackColor = true;
            btnGraficar.Click += btnGraficar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimpiar.Location = new Point(1150, 1007);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(107, 38);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // numDX
            // 
            numDX.DecimalPlaces = 1;
            numDX.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numDX.Location = new Point(273, 1005);
            numDX.Margin = new Padding(4, 5, 4, 5);
            numDX.Name = "numDX";
            numDX.Size = new Size(99, 31);
            numDX.TabIndex = 4;
            numDX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numDY
            // 
            numDY.DecimalPlaces = 1;
            numDY.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numDY.Location = new Point(456, 1005);
            numDY.Margin = new Padding(4, 5, 4, 5);
            numDY.Name = "numDY";
            numDY.Size = new Size(97, 31);
            numDY.TabIndex = 5;
            numDY.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(btnAgregarRecta);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numHasta);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numDesde);
            groupBox1.Controls.Add(Rango);
            groupBox1.Controls.Add(numInterseccion);
            groupBox1.Controls.Add(numPendiente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(1150, 87);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(234, 477);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulador de rectas";
            // 
            // btnAgregarRecta
            // 
            btnAgregarRecta.Location = new Point(73, 388);
            btnAgregarRecta.Margin = new Padding(4, 5, 4, 5);
            btnAgregarRecta.Name = "btnAgregarRecta";
            btnAgregarRecta.Size = new Size(107, 38);
            btnAgregarRecta.TabIndex = 10;
            btnAgregarRecta.Text = "&Agregar";
            btnAgregarRecta.UseVisualStyleBackColor = true;
            btnAgregarRecta.Click += btnAgregarRecta_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1. Azul", "2. Rojo", "3. Amarillo", "4. Morado" });
            comboBox1.Location = new Point(73, 285);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 33);
            comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 290);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 8;
            label4.Text = "Color";
            // 
            // numHasta
            // 
            numHasta.Location = new Point(156, 207);
            numHasta.Margin = new Padding(4, 5, 4, 5);
            numHasta.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numHasta.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numHasta.Name = "numHasta";
            numHasta.Size = new Size(70, 31);
            numHasta.TabIndex = 7;
            numHasta.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 210);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(21, 25);
            label3.TabIndex = 6;
            label3.Text = "a";
            // 
            // numDesde
            // 
            numDesde.Location = new Point(9, 207);
            numDesde.Margin = new Padding(4, 5, 4, 5);
            numDesde.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDesde.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numDesde.Name = "numDesde";
            numDesde.Size = new Size(82, 31);
            numDesde.TabIndex = 5;
            numDesde.Value = new decimal(new int[] { 200, 0, 0, int.MinValue });
            // 
            // Rango
            // 
            Rango.AutoSize = true;
            Rango.Location = new Point(13, 162);
            Rango.Margin = new Padding(4, 0, 4, 0);
            Rango.Name = "Rango";
            Rango.Size = new Size(64, 25);
            Rango.TabIndex = 4;
            Rango.Text = "Rango";
            // 
            // numInterseccion
            // 
            numInterseccion.DecimalPlaces = 2;
            numInterseccion.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numInterseccion.Location = new Point(144, 98);
            numInterseccion.Margin = new Padding(4, 5, 4, 5);
            numInterseccion.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numInterseccion.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numInterseccion.Name = "numInterseccion";
            numInterseccion.Size = new Size(77, 31);
            numInterseccion.TabIndex = 3;
            // 
            // numPendiente
            // 
            numPendiente.DecimalPlaces = 2;
            numPendiente.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numPendiente.Location = new Point(144, 48);
            numPendiente.Margin = new Padding(4, 5, 4, 5);
            numPendiente.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPendiente.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numPendiente.Name = "numPendiente";
            numPendiente.Size = new Size(79, 31);
            numPendiente.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 102);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 1;
            label2.Text = "Interseccion (b)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "Pendiente (m)";
            // 
            // frmGraficador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 1050);
            Controls.Add(groupBox1);
            Controls.Add(numDY);
            Controls.Add(numDX);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGraficar);
            Controls.Add(picCanvas);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmGraficador";
            Text = "Form1";
            SizeChanged += frmGraficador_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDY).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHasta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDesde).EndInit();
            ((System.ComponentModel.ISupportInitialize)numInterseccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPendiente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picCanvas;
        private Button btnGraficar;
        private Button btnLimpiar;
        private NumericUpDown numDX;
        private NumericUpDown numDY;
        private GroupBox groupBox1;
        private NumericUpDown numPendiente;
        private Label label2;
        private Label label1;
        private NumericUpDown numHasta;
        private Label label3;
        private NumericUpDown numDesde;
        private Label Rango;
        private NumericUpDown numInterseccion;
        private Label label4;
        private ComboBox comboBox1;
        private Button btnAgregarRecta;
    }
}
