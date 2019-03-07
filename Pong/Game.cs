namespace Pong
{
    class Game
    {
        string gameID = null;
        Paddle leftPaddle = null;
        Paddle rightPaddle = null;
        Ball gameBall = null;
        int score = 0;
        public Game(string gameID,string player1ID, string player2ID)
        {
            this.gameID = gameID;
            this.leftPaddle = new Paddle(player1ID,20,0,27,127);
            this.rightPaddle = new Paddle(player2ID,20,899,27,127);
            this.gameBall = new Ball(10,10,435,239,27,26);
        }
        public string updateGame()
        {
            gameBall.YLoc -= gameBall.XSpeed;
            gameBall.XLoc -= gameBall.YSpeed;

            if (ball.Left < 0)
            {
                ball.Left = 434;
                ballx = -ballx;
                p2score++;
                player2Score.Text = "" + p2score;
            }
            if (ball.Right > ClientSize.Width)
            {
                ball.Left = 434;
                ballx = -ballx;
                score++;
                player1Score.Text = "" + score;
            }
            if (ball.Top < 0 || ball.Bottom > ClientSize.Height)
            {
                bally = -bally;
            }
            if (ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(player2.Bounds))
            {
                ballx = -ballx;
            }
            if (goup && player1.Top > 0)
            {
                player1.Top -= 20;
            }
            if (godown && player1.Bottom < 455)
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
            if (score > 9)
            {
                gameTimer.Stop();
                MessageBox.Show("Player1 wins");
            }
            if (p2score > 9)
            {
                gameTimer.Stop();
                MessageBox.Show("Player2 wins");
            }
            return "";
        }
    }
}