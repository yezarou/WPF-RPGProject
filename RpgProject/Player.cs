using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace RpgProject
{
    public class Player  
    {
        // Campos
        const double SIZE = 32;

        // Ctor
        public Player(double posIni) {
            Velocity = 4;
            Img = new Rectangle {
                Width = SIZE,
                Height = SIZE,
                Fill = Brushes.Yellow
            };
            Location = new Collide(posIni, posIni, SIZE + posIni, SIZE + posIni);
            Canvas.SetTop(Img, Location.Y1);
            Canvas.SetLeft(Img, Location.X1);
        }

        // Propiedades
        public double Velocity { get; set; }
        public Rectangle Img { get; set; }
        public Collide Location { get; set; }
    }
}
