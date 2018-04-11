using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace RpgProject
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player player;
        List<Location> map;

        public MainWindow() {
            InitializeComponent();
            player = new Player();
            screen.Children.Add(player.Img);
            map = new List<Location> {
                // Bordes del mapa.
                new Location(0, 0, screen.Width, 0),
                new Location(0, 0, 0, screen.Height),
                new Location(0, screen.Height, screen.Width, screen.Height),
                new Location(screen.Width, 0, screen.Width, screen.Height),

                // Extras.
                new Location(100,100, 200, 200)
            };
        }

        // Pulsar una tecla.
        private void Window_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.W)
                MoveUp();
            else if (e.Key == Key.S)
                MoveDown();
            if (e.Key == Key.A)
                MoveLeft();
            else if (e.Key == Key.D)
                MoveRight();
        }

        // Movto arriba.
        public void MoveUp() {
            player.CheckLocation.Move(0, -player.Velocity);
            if (Location.CanMove(player.CheckLocation, map))
                player.Location = player.CheckLocation.Copy();
            else
                player.CheckLocation = player.Location.Copy();
            Canvas.SetTop(player.Img, player.Location.Y1);
        }

        // Movto abajo
        public void MoveDown() {
            player.CheckLocation.Move(0, player.Velocity);
            if (Location.CanMove(player.CheckLocation, map))
                player.Location = player.CheckLocation.Copy();
            else
                player.CheckLocation = player.Location.Copy();
            Canvas.SetTop(player.Img, player.Location.Y1);
        }

        // Movto izq
        public void MoveLeft() {
            player.CheckLocation.Move(-player.Velocity, 0);
            if (Location.CanMove(player.CheckLocation, map))
                player.Location = player.CheckLocation.Copy();
            else
                player.CheckLocation = player.Location.Copy();
            Canvas.SetLeft(player.Img, player.Location.X1);
        }

        // Movto der
        public void MoveRight() {
            player.CheckLocation.Move(player.Velocity, 0);
            if (Location.CanMove(player.CheckLocation, map))
                player.Location = player.CheckLocation.Copy();
            else
                player.CheckLocation = player.Location.Copy();
            Canvas.SetLeft(player.Img, player.Location.X1);
        }
    }
}
