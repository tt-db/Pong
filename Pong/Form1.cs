using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//followed tutorial from this website https://www.mooict.com/c-tutorial-create-a-pong-arcade-game-in-visual-studio/
namespace Pong
{
    public partial class Form1 : Form
    {
        bool goup,p2goUp;
        bool godown,p2goDown;
        bool startGame = false;
        int ballx = 0;
        int bally = 0;
        int score = 0;
        int p2score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timerTick(object sender, EventArgs e)
        {

            ball.Top -= bally;
            ball.Left -= ballx;

            if(ball.Left<0)
            {
                ball.Left = 434;
                ballx = -ballx;
                p2score++;
                player2Score.Text = "" + p2score;
            }
            if (ball.Right>ClientSize.Width)
            {
                ball.Left = 434;
                ballx = -ballx;
                score++;
                player1Score.Text = "" + score;
            }
            if (ball.Top<0||ball.Bottom>ClientSize.Height)
            {
                bally = -bally;
            }
            if(ball.Bounds.IntersectsWith(player1.Bounds)|| ball.Bounds.IntersectsWith(player2.Bounds))
            {
                ballx = -ballx;
            }
            if(goup&&player1.Top>0)
            {
                player1.Top -= 20;
            }
            if(godown&&player1.Bottom<455)
            {
                player1.Top += 20;
            }
            if (p2goUp && player2.Top > 0)
            {
                player2.Top -= 20;
            }
            if (p2goDown && player2.Bottom < 455)
            {
                player2.Top += 20;
            }
            if (score>9)
            {
                gameTimer.Stop();
                MessageBox.Show("Player1 wins");
            }
            if(p2score>9)
            {
                gameTimer.Stop();
                MessageBox.Show("Player2 wins"); 
            }

        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                p2goUp = true;
            if (e.KeyCode == Keys.Down)
                p2goDown = true;
            if (e.KeyCode == Keys.W)
                goup =true;
            if (e.KeyCode == Keys.S)
                godown = true;
            if (e.KeyCode == Keys.Space&&!startGame)
            {
                startGame = true;
                ballx = 10;
                bally = 10;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                p2goUp = false;
            if (e.KeyCode == Keys.Down)
                p2goDown = false;
            if (e.KeyCode == Keys.W)
                goup = false;
            if (e.KeyCode == Keys.S)
                godown = false;
        }
    }
}
