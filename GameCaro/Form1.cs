using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardMannergeer ChessBoard;
        #endregion
        public Form1()
        {
            InitializeComponent();
            ChessBoard = new ChessBoardMannergeer(pncheckboard,txtNameplayer,picAvatar);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMark += ChessBoard_PlayerMark;
            prcbarCoolDown.Step = Cons.Steps;
            prcbarCoolDown.Maximum = Cons.Steps_Times;
            prcbarCoolDown.Value = 0;
            timerCoolDown.Interval = Cons.Steps_Interval;
            ChessBoard.DrawCheckBoard();
           
        }
        void NewGame()
        {
            timerCoolDown.Stop();
            prcbarCoolDown.Value = 0;
            undoToolStripMenuItem.Enabled = true;
            ChessBoard.DrawCheckBoard();
            
        }
        void Quit()
        {
            Application.Exit();
        }
        void Undo()
        {
            ChessBoard.Undo();
        }
        void EndeGame()
        {
            pncheckboard.Enabled = false;
            timerCoolDown.Stop();
            undoToolStripMenuItem.Enabled = false;
            
            MessageBox.Show("Hết Game Nhé");
        }
        private void ChessBoard_PlayerMark(object sender, EventArgs e)
        {
            timerCoolDown.Start();
            prcbarCoolDown.Value = 0;
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndeGame();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNameplayer_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void prcbarCoolDown_Click(object sender, EventArgs e)
        {

        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLAN_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pncheckboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerCoolDown_Tick(object sender, EventArgs e)
        {
            prcbarCoolDown.PerformStep();
            if (prcbarCoolDown.Value >= prcbarCoolDown.Maximum)
            {
                
                EndeGame();
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ptcavatar_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void quitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            e.Cancel = true;
        }
    }
}
