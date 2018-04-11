using System.Collections.Generic;

namespace RpgProject
{
    public class Location {

        //Ctor
        public Location(double x1, double y1, double x2, double y2) {
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
        public void Move(double x, double y) {
            X1 += x;
            X2 += x;
            Y1 += y;
            Y2 += y;
        }

        public Location Copy() {
            Location copy = (Location)this.MemberwiseClone();
            return copy;
        }

        // Estático.
        public static bool CanMove(Location l, List<Location> map) {
            bool result = true;
            int pos = 0;
            while (pos < map.Count && result) {
                result = !((map[pos].X2 > l.X1 && map[pos].X1 < l.X2) && (map[pos].Y2 > l.Y1 && map[pos].Y1 < l.Y2));
                pos++;
            }
            return result;
        }
    }
}
