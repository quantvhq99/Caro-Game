using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    public class PlayerInfo
    {
        private Point point;
        
        public Point Point { get => point; set => point = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }

        private int currentPlayer;
        public PlayerInfo(Point point, int currentPlayer)
        {
            this.Point = point;
            this.CurrentPlayer = currentPlayer;
        }

    }
}
