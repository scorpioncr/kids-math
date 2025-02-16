using System.Drawing;

namespace Graficador
{
    public partial class frmGraficador : Form
    {
        public frmGraficador()
        {
            InitializeComponent();


            _graphic = picCanvas.CreateGraphics();
        }
        private Graphics _graphic;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            //int inicio = -100;
            //int final = 100;
            //int totalPuntos = final - inicio;
            //var puntosRecta = new PointF[totalPuntos];
            //int indexArreglo = 0;
            //for (int x = inicio; x < final; x++)
            //{
            //    var puntoRecta = Recta(2, 100, x);
            //    puntoRecta.Y *= -1;

            //    puntosRecta[indexArreglo] = puntoRecta;
            //    indexArreglo++;
            //}

            //if (_graphic != null)
            //{
            //    _graphic.Dispose();
            //}

            //_graphic = picCanvas.CreateGraphics();
            //_graphic.ResetTransform();
            //_graphic.TranslateTransform(800, 500);
            //_graphic.DrawLine(Pens.Green, -1000, 0, 2000, 0);
            //_graphic.DrawLine(Pens.Green, 0, 800, 0, -800);
            //_graphic.DrawCurve(Pens.Red, puntosRecta);

            Graficar();
        }

        private Point Recta(int m, int b, int x)
        {
            return new Point(x, m * x + b);
        }

        private Point Parabola(int a, int b, int c, int x)
        {
            return new Point(x, a * (x * x) + b * x + c);
        }

        private void Graficar()
        {
            //_graphic = picCanvas.CreateGraphics();
            _graphic.ResetTransform();

            float dx = _graphic.VisibleClipBounds.Width / 2; //800
            float dy = _graphic.VisibleClipBounds.Height / 2; // 500
            _graphic.TranslateTransform(dx, dy);

            //_graphic.DrawLine(Pens.Green, -1000, 0, 2000, 0);
            //_graphic.DrawLine(Pens.Green, 0, 800, 0, -800);
            _graphic.DrawLine(Pens.Green, (int)(-1 * dx), 0, (int)dx, 0);
            _graphic.DrawLine(Pens.Green, 0, (int)dy, 0, (int)(-1 * dy));


            int inicio = -100;
            int final = 100;
            int totalPuntos = final - inicio;
            var puntosRecta1 = new PointF[totalPuntos];
            var puntosRecta2 = new PointF[totalPuntos];
            var puntosRecta3 = new PointF[totalPuntos];
            int indexArreglo = 0;
            for (int x = inicio; x < final; x++)
            {
                var puntoRecta1 = Recta(2, 0, x);
                puntoRecta1.Y *= -1;

                var puntoRecta2 = Recta(1, 0, x);
                puntoRecta2.Y *= -1;

                var puntoRecta3 = Recta(-2, 50, x);
                puntoRecta3.Y *= -1;

                puntosRecta1[indexArreglo] = puntoRecta1;
                puntosRecta2[indexArreglo] = puntoRecta2;
                puntosRecta3[indexArreglo] = puntoRecta3;
                indexArreglo++;
            }

            _graphic.DrawCurve(Pens.Red, puntosRecta1);
            _graphic.DrawCurve(Pens.Blue, puntosRecta2);
            _graphic.DrawCurve(Pens.Orange, puntosRecta3);
        }

        private void DefinirEjes()
        {
            //_graphic = picCanvas.CreateGraphics();
            _graphic.ResetTransform();
            float dx = _graphic.VisibleClipBounds.Width / 2; //800
            float dy = _graphic.VisibleClipBounds.Height / 2; // 500
            _graphic.TranslateTransform(dx, dy);
            //_graphic.DrawLine(Pens.Green, -1000, 0, 2000, 0);
            //_graphic.DrawLine(Pens.Green, 0, 800, 0, -800);
            _graphic.DrawLine(Pens.Green, (int)(-1 * dx), 0, (int)dx, 0);
            _graphic.DrawLine(Pens.Green, 0, (int)dy, 0, (int)(-1 * dy));
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _graphic.Clear(Color.White);
        }

        private void picCanvas_Resize(object sender, EventArgs e)
        {
            if (_graphic != null)
            {
                _graphic.Dispose();
            }

            _graphic = picCanvas.CreateGraphics();
            _graphic.Clear(Color.White);
            Graficar();
        }

        private void picCanvas_SizeChanged(object sender, EventArgs e)
        {
            if (_graphic != null)
            {
                _graphic.Dispose();
            }

            _graphic = picCanvas.CreateGraphics();
            _graphic.Clear(Color.White);
            Graficar();
        }

        private void picCanvas_RegionChanged(object sender, EventArgs e)
        {
            if (_graphic != null)
            {
                _graphic.Dispose();
            }

            _graphic = picCanvas.CreateGraphics();
            _graphic.Clear(Color.White);
            Graficar();
        }
    }
}
