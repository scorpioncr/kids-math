using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kids_math_ui
{
    /// <summary>
    /// Esta clase representa la ecuación de una recta, la cual es de la forma:
    /// y = mx + b
    /// donde:
    /// 'm' es la pendiente de la recta
    /// 'b' es la intersección con el eje Y
    /// 
    /// </summary>
    public class Recta
    {
        // Variables
        private float _m;
        private float _b;
        private Tuple<int, int> _intervalo;
        private PointF[] _arregloDePuntos;

        // Propiedades
        public float Pendiente { get { return _m; } }

        public float InterseccionConEjeY { get { return _b; } }

        public PointF[] Puntos { get { return ObtenerPuntos(); } }

        // Constructor
        public Recta(float pendiente, float interseccionConEjeY)
        {
            _m = pendiente;
            _b = interseccionConEjeY;
            _intervalo = new Tuple<int, int>(-100, 100);
        }

        // Métodos
        private PointF ObtenerPunto(float x)
        {
            return new PointF(x, _m * x + _b);
        }

        private PointF[] ObtenerPuntos()
        {
            int indexArreglo = 0;
            _arregloDePuntos = new PointF[_intervalo.Item2 - _intervalo.Item1];

            for (int x = _intervalo.Item1; x < _intervalo.Item2; x++)
            {
                var puntoRecta = ObtenerPunto(x);
                puntoRecta.Y *= -1;

                _arregloDePuntos[indexArreglo] = puntoRecta;

                indexArreglo++;
            }

            return _arregloDePuntos;
        }
    }
}
