using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace toh
{
    public partial class GameForm : Form
    {
        private PictureBox _base;
        private List<Pole> poles = GameState.Poles;
        public GameForm()
        {
            InitializeComponent();
            this.AllowDrop = true;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            RestartGame();
            HideGameBox();
        }

        private void HideGameBox()
        {
            _base.Hide();
            foreach (Pole pole in GameState.Poles)
            {
                pole.Hide();
                foreach (Disk disk in pole.Disks.Values)
                {
                    disk.Hide();
                }
            }
        }

        private void ShowGameBox()
        {
            _base.Show();
            foreach (Pole pole in GameState.Poles)
            {
                pole.Show();
                foreach (Disk disk in pole.Disks.Values)
                {
                    disk.Show();
                }
            }
        }

        void thisBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        void thisBox_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            Disk disk = (Disk)sender;
            disk.Location = new Point(Cursor.Position.X - this.Location.X - (disk.Size.Height / 2),
                                             Cursor.Position.Y - this.Location.Y - (disk.Size.Width / 2));

            if (e.Action == DragAction.Drop)
            {
                int destinationPoleNumber = DeterminePoleFromCursorPosition();
                Pole currentPole = GameState.FindDisk(disk);
                Move move = new Move(currentPole, GameState.Poles[destinationPoleNumber]);

                if (move.IsValid())
                {
                    MakeMove(move);
                }
                else
                {
                    Move moveBack = new Move(currentPole, currentPole);
                    GameState.MakeMove(moveBack);
                }
            }
        }

        private void MakeMove(Move move)
        {
            int moveCount = GameState.MakeMove(move);
            moveCounter.Text = moveCount.ToString();
            if (GameState.IsSolved())
            {   
                possibleToSolve.Text = "Solved :) ";
            }
        }

        private void disk_MouseDown(object sender, MouseEventArgs e)
        {
            Disk disk = (Disk)sender;
            Pole pole = GameState.FindDisk(disk);

            //Check if the disk is the top one
            if (!pole.GetTopDisk().Equals(disk))
            {
                return;
            }
            disk.DoDragDrop(disk, DragDropEffects.All);
        }

        private Point GetMousePosition()  {
            return new Point(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y);
        }

        //Determine at which pole the cursor is
        private int DeterminePoleFromCursorPosition()
        {
            Point MousePosition = GetMousePosition();
            if (MousePosition.X < GameState.Poles[0].Location.X)
                return 0;
            if (MousePosition.X > GameState.Poles[1].Location.X - 60 && MousePosition.X < GameState.Poles[2].Location.X - 60)
                return 1;
            if (MousePosition.X > GameState.Poles[2].Location.X - 60 && MousePosition.X < GameState.Poles[2].Location.X + GameConstants.SpaceBetweenPoles)
                return 2;
            //Use pole 0 as default
            return 0;
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripDropDownItem Item = sender as ToolStripDropDownItem;
            RestartGame(Convert.ToInt16(Item.Text));
        }

        private void Form2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void showMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartGame();
            SolveGame();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void SolveGame()
        {
            this.Enabled = false;
            List<Move> moves = MoveCalculator.GetMoves(GameState.NumberOfDisks);
            hints.Visible = true;
            hints.Text = string.Empty;
            hints.Text = Properties.Resources.HintCaption;
            int movesLength = moves.Count();
            foreach (Move move in moves)
            {
                hints.Text += move.ToString();
                MakeMove(move);
                Application.DoEvents();
                Thread.Sleep(20000/(movesLength+1));
            }
            this.Enabled = true;
        }

        private void RestartGame(int numberOfDisks)
        {
            GameState.NumberOfDisks = numberOfDisks;
            RestartGame();
        }

        private void RestartGame()
        {
            RemoveAllDisks();
            GameState.RestartGame();
            AddComponents();
            hints.Text = "";
            hints.Visible = false;
            moveCounter.Text = GameState.MoveCount.ToString();
            possibleToSolve.Text = "It is possible to solve this puzzle in " + MoveCalculator.GetMoveCount(GameState.NumberOfDisks).ToString() + " moves.";
        }

        private void RemoveAllDisks()
        {
            foreach (Pole pole in GameState.Poles)
            {
                foreach (Disk disk in pole.Disks.Values)
                {
                    this.Controls.Remove(disk);
                }
            }
        }

        private void AddComponents()
        {
            if(_base == null)
            _base = new PictureBox();
            _base.Image = toh.Properties.Resources._base;
            _base.Size = toh.Properties.Resources._base.Size;
            _base.BackColor = SystemColors.ControlDarkDark;
            _base.Location = new Point(GameConstants.BaseStartPositionX, GameConstants.BaseStartPositionY);

            this.Controls.Add(_base);
            
            moveCounter.Text = GameState.MoveCount.ToString();
            
            foreach (Pole pole in GameState.Poles)
            {
                InitPole(pole);
                foreach (Disk disk in pole.Disks.Values)
                {
                    InitDisk(disk);
                }
            }
        }

        private void InitPole(Pole pole)
        {
            if (!this.Controls.Contains(pole))
            {
                this.Controls.Add(pole);
            }
        }

        private void InitDisk(Disk disk)
        {
            if (!this.Controls.Contains(disk))
            {
                disk.MouseDown += new MouseEventHandler(disk_MouseDown);
                disk.QueryContinueDrag += new QueryContinueDragEventHandler(thisBox_QueryContinueDrag);
                disk.DragOver += new DragEventHandler(thisBox_DragOver);
                this.Controls.Add(disk);
                this.Controls.SetChildIndex(disk, 0);
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            usernameTextbox.Text = "";
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            RestartGame();
            SolveGame();
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void HideControls(int diskNo)
        {
            ShowGameBox();
            RestartGame(diskNo);
            label1.Hide();
            startBtn3.Hide();
            startBtn4.Hide();
            startBtn5.Hide();
            startBtn6.Hide();
            helpBtn.Show();
            restartBtn.Show();
            button1.Show();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            HideControls(3);
        }

        private void startBtn4_Click(object sender, EventArgs e)
        {
            HideControls(4);
        }

        private void startBtn5_Click(object sender, EventArgs e)
        {
            HideControls(5);
        }

        private void startButton6_Click(object sender, EventArgs e)
        {
            HideControls(6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideGameBox();
            label1.Show();
            startBtn3.Show();
            startBtn4.Show();
            startBtn5.Show();
            startBtn6.Show();
            helpBtn.Hide();
            restartBtn.Hide();
            button1.Hide();
        }
    }
}