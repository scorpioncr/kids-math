using System.Drawing;
using kids_math_ui;

namespace Graficador
{
    public partial class frmGraficador : Form
    {
        public frmGraficador()
        {
            InitializeComponent();


            _graphic = picCanvas.CreateGraphics();
            //DefinirPlanoCartesiano();
        }
        private Graphics _graphic;

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            Graficar();
        }

        private void Graficar()
        {
            if (_graphic != null)
            {
                _graphic.Dispose();
            }

            _graphic = picCanvas.CreateGraphics();

            DefinirPlanoCartesiano();

            Recta recta1 = new Recta(2, 0, new Tuple<int, int>(-100, 100));
            Recta recta2 = new Recta(1, 0, new Tuple<int, int>(-100, 100));
            Recta recta3 = new Recta(-2, 50, new Tuple<int, int>(-20, 30));
            Recta recta4 = new Recta(15, 56, new Tuple<int, int>(-10, 10));

            _graphic.DrawCurve(Pens.Red, recta1.Puntos);
            _graphic.DrawCurve(Pens.Blue, recta2.Puntos);
            _graphic.DrawCurve(Pens.Orange, recta3.Puntos);
            _graphic.DrawCurve(Pens.Purple, recta4.Puntos);
        }

        private void DefinirPlanoCartesiano()
        {
            _graphic.Clear(Color.White);
            _graphic.ResetTransform();

            float dx = _graphic.VisibleClipBounds.Width / 2;
            float dy = _graphic.VisibleClipBounds.Height / 2;
            _graphic.TranslateTransform(dx, dy);

            var matrix = new System.Drawing.Drawing2D.Matrix(1, 0, 0, -1, 1, 1);
            _graphic.MultiplyTransform(matrix);
            //_graphic.ScaleTransform(100, 100);

            _graphic.DrawLine(Pens.Green, (int)(-1 * dx), 0, (int)dx, 0);
            _graphic.DrawLine(Pens.Green, 0, (int)dy, 0, (int)(-1 * dy));
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _graphic.Clear(Color.White);
        }

        private void picCanvas_Resize(object sender, EventArgs e)
        {
            Graficar();
        }

        private void picCanvas_SizeChanged(object sender, EventArgs e)
        {
            Graficar();
        }

        private void picCanvas_RegionChanged(object sender, EventArgs e)
        {
            Graficar();
        }

        private void frmGraficador_SizeChanged(object sender, EventArgs e)
        {
            Graficar();
        }
    }
}
