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
using System.Windows.Threading;

namespace RpgProject
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player player;
        Map map;
        
        public MainWindow() {
            InitializeComponent();
            player = new Player(32);
            screen.Children.Add(player.Img);
            map = new Map(screen.Width, screen.Height);
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

        private void TryMove(Collide c) {
            if (Collide.CanMove(c, map.CurrenStage))
                player.Location = c;
        }

        // Movto arriba.
        public void MoveUp() {
            TryMove(player.Location.Move(0, -player.Velocity * 4));
            Canvas.SetTop(player.Img, player.Location.Y1);
        }

        // Movto abajo
        public void MoveDown() {
            TryMove(player.Location.Move(0, player.Velocity * 4));
            Canvas.SetTop(player.Img, player.Location.Y1);
        }

        // Movto izq
        public void MoveLeft() {
            TryMove(player.Location.Move(-player.Velocity * 4, 0));
            Canvas.SetLeft(player.Img, player.Location.X1);
        }

        // Movto der
        public void MoveRight() {
            TryMove(player.Location.Move(player.Velocity * 4, 0));
            Canvas.SetLeft(player.Img, player.Location.X1);
        }
    }
}
