using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgProject
{
    class Map
    {
        List<Collide>[,] stages;
        int currentMapX;
        int currentMapY;

        public Map(double x, double y) {
            stages = new List<Collide>[2, 2];

            for (int i = 0; i < stages.GetLength(0); i++)
                for (int j = 0; j < stages.GetLength(1); j++) {
                    stages[i, j] = new List<Collide> {
                        // Bordes del mapa.
                        new Collide(0, 0, x, 32),       // Lado superior
                        new Collide(0, 0, 32, y),       // Lado izquierdo
                        new Collide(0, y-32, x, y),     // Lado inferior
                        new Collide(x-32, 0, x, y),     // Lado derecho

                        // Extras.
                        new Collide(64,64, 192, 192)
                    };
                }

            currentMapX = 0;
            currentMapY = 0;
        }

        public List<Collide> CurrenStage { get { return stages[currentMapX, currentMapY]; } }
    }
}