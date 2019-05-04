using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace GameCaro
{
    
    public class ChessBoardMannergeer
    {
        #region Properties
        private Panel chessBoard;
        private List<Player> player;
        private int currentPlayer;
        private TextBox playerName;
        private PictureBox imagePlayer;
        private List<List<Button>> matrix;
        private event EventHandler playerMark;
        public event EventHandler PlayerMark
        {
            add
            {
                playerMark += value;
            }
            remove
            {
                playerMark -= value;
            }
        }
        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox PlayerName { get => playerName; set => playerName = value; }
        public PictureBox ImagePlayer { get => imagePlayer; set => imagePlayer = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        public Stack<PlayerInfo> PlayTimeLine { get => playTimeLine; set => playTimeLine = value; }

        private Stack<PlayerInfo> playTimeLine;
        #endregion
        #region Initialize

        public ChessBoardMannergeer(Panel chessBoard,TextBox playerName, PictureBox imagePlayer)
        {
            
            this.PlayerName = playerName;
            this.ImagePlayer = imagePlayer;
            this.ChessBoard = chessBoard;
            this.Player = new List<Player>()
            {
                new Player("Người chơi 1",Image.FromFile("C:\\Users\\quant\\source\\repos\\GameCaro\\GameCaro\\Resources\\O_vectorized.png")),
                new Player("Người chơi 2",Image.FromFile("C:\\Users\\quant\\source\\repos\\GameCaro\\GameCaro\\Resources\\X.png"))
               
            };
            
        }
        #endregion
        #region Methods

        public void DrawCheckBoard()
        {
            PlayTimeLine = new Stack<PlayerInfo>();
            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear();
            currentPlayer = 0;
            ChangePlayer();
            Matrix = new List<List<Button>>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.Chess_Widht; i++)
            {
                for (int j = 0; j < Cons.Chess_Height; j++)
                {
                    Matrix.Add(new List<Button>());
                    Button btn = new Button()
                    {
                        Width = Cons.Chess_Widht,
                        Height = Cons.Chess_Height,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    btn.Click += Btn_Click;
                    ChessBoard.Controls.Add(btn);
                    oldButton = btn;
                    Matrix[i].Add(btn);
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.Chess_Height);
                oldButton.Width = 0;
                oldButton.Height = 0;

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.BackgroundImage != null)
            {
                return;
            }
            MarkPlayer(btn);
            PlayTimeLine.Push(new PlayerInfo(getCheckPoint(btn),CurrentPlayer));
           
            ChangePlayer();
           if (playerMark != null)
                playerMark(this, new EventArgs());
            if (isEndGame(btn)){
                 EndGame();
              } 
        }
        public bool isEndGame(Button btn)
        {
            return isEndGameHorizontal(btn) || isEndGameVertical(btn) || isEndGamePrimaryMain(btn) || isEndGamePrimaryBase(btn);
        }
        private Point getCheckPoint(Button btn)
        {
            
            int vertical = Convert.ToInt32(btn.Tag);
            int horizotal = Matrix[vertical].IndexOf(btn);
            Point point = new Point(horizotal,vertical);
            return point;

        }
        public bool isEndGameHorizontal(Button btn)
        {
            Point point = getCheckPoint(btn);
            int countLesft = 0;
            for(int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLesft++;
                }
                else
                    break;
            }
            int countRight = 0;
            for (int i = point.X+1; i < Cons.Chess_Board_Widht; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }
            return countLesft + countRight == 5;
        }
        public bool isEndGameVertical(Button btn)
        {
            Point point = getCheckPoint(btn);
            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBot = 0;
            for (int i = point.Y + 1; i < Cons.Chess_Board_Height; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBot++;
                }
                else
                    break;
            }
            return countTop + countBot == 5;
        }
        public bool isEndGamePrimaryMain(Button btn)
        {
            Point point = getCheckPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;
                if (Matrix[point.Y-i][point.X-i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBot = 0;
            for (int i = 1; i <=Cons.Chess_Board_Widht- point.X; i++)
            {
                if (point.Y + i >= Cons.Chess_Board_Height || point.X + i >= Cons.Chess_Board_Widht)
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBot++;
                }
                else
                    break;
            }
            return countTop + countBot == 5;
        }
        public bool isEndGamePrimaryBase(Button btn)
        {
            Point point = getCheckPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i > Cons.Chess_Board_Widht || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBot = 0;
            for (int i = 1; i <= Cons.Chess_Board_Widht - point.X; i++)
            {
                if (point.Y + i >= Cons.Chess_Board_Height || point.X - i < 0)
                    break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBot++;
                }
                else
                    break;
            }
            return countTop + countBot == 5;
        }
        private void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());
            ChessBoard.Enabled = false;
           // MessageBox.Show("Hết Game Nhé");
           
        }
        public bool Undo()
        {
            if (PlayTimeLine.Count <= 0)
                return false;
            PlayerInfo oldPoint = PlayTimeLine.Pop();
            Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];
            btn.BackgroundImage = null;
            
            if (PlayTimeLine.Count <= 0)
            {
                CurrentPlayer = 0;
                
            }
            else
            {
                oldPoint = PlayTimeLine.Peek();
                CurrentPlayer = oldPoint.CurrentPlayer == 1 ? 0 : 1;
            }
            ChangePlayer();
            return false;
        }
        private void MarkPlayer(Button btn)
        {
            if (btn.BackgroundImage != null) { return; }
            btn.BackgroundImage = Player[CurrentPlayer].Mark;
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }
        private void ChangePlayer()
        {
            
            PlayerName.Text = Player[CurrentPlayer].Name;
            ImagePlayer.Image = Player[CurrentPlayer].Mark;
           
        }
        #endregion

    }
}
