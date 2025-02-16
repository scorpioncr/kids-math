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
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // picCanvas
            // 
            picCanvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picCanvas.BorderStyle = BorderStyle.FixedSingle;
            picCanvas.Location = new Point(12, 12);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(949, 576);
            picCanvas.TabIndex = 0;
            picCanvas.TabStop = false;
            picCanvas.RegionChanged += picCanvas_RegionChanged;
            picCanvas.SizeChanged += picCanvas_SizeChanged;
            picCanvas.Resize += picCanvas_Resize;
            // 
            // btnGraficar
            // 
            btnGraficar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGraficar.Location = new Point(886, 603);
            btnGraficar.Name = "btnGraficar";
            btnGraficar.Size = new Size(75, 23);
            btnGraficar.TabIndex = 1;
            btnGraficar.Text = "&Graficar";
            btnGraficar.UseVisualStyleBackColor = true;
            btnGraficar.Click += btnGraficar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimpiar.Location = new Point(805, 604);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmGraficador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 638);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGraficar);
            Controls.Add(picCanvas);
            Name = "frmGraficador";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picCanvas;
        private Button btnGraficar;
        private Button btnLimpiar;
    }
}
