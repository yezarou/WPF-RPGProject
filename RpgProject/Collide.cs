using System.Collections.Generic;

namespace RpgProject
{
    public class Collide {
        //Ctor
        public Collide(double x1, double y1, double x2, double y2) {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
        }

        // Propiedades
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }

        // Métodos
        public Collide Move(double x, double y) {
            return new Collide(X1 + x, Y1 + y, X2 + x, Y2 + y);
        }

        public Collide Copy() {
            Collide copy = (Collide)this.MemberwiseClone();
            return copy;
        }

        // Estático.
        public static bool CanMove(Collide l, List<Collide> map) {
            bool result = true;
            int pos = 0;
            while (pos < map.Count && result) {
                // Comprueba si hay intersección entre dos cuadrados.
                result = !((map[pos].X2 > l.X1 && map[pos].X1 < l.X2) && (map[pos].Y2 > l.Y1 && map[pos].Y1 < l.Y2));

                // Si no hay intersección entre dos cuadrados, comprueba si está dentro de otro.
                if (result)
                    result = !(l.X1 >= map[pos].X1 && l.Y1 >= map[pos].Y1 && l.X2 <= map[pos].X2 && l.Y2 <= map[pos].Y2);
                pos++;
            }
            return result;
        }
    }
}
