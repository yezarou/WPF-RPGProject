using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace RpgProject
{
    public class Player  
    {
        // Campos
        const double SIZE = 50;

        // Ctor
        public Player() {
            Velocity = 10;
            Img = new Rectangle {
                Width = SIZE,
                Height = SIZE,
                Fill = Brushes.Yellow
            };
            Location = new Location(0, 0, SIZE, SIZE);
            CheckLocation = new Location(0, 0, SIZE, SIZE);
            Canvas.SetTop(Img, Location.Y1);
            Canvas.SetLeft(Img, Location.X1);
        }

        // Propiedades
        public double Velocity { get; set; }
        public Rectangle Img { get; set; }
        public Location Location { get; set; }
        public Location CheckLocation { get; set; }
    }
}
