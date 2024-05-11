namespace Ping_pong_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        int ballspeedx = 3;
        int ballspeedy = 3;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 60;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                racket.Location = new Point(racket.Location.X - 10, racket.Location.Y);
            }
            if (e.KeyCode == Keys.D)
            {
                racket.Location = new Point(racket.Location.X + 10, racket.Location.Y);
            }
        }
        bool isCollided()
        {
            if (ball.Location.Y > 382&& ball.Location.X > racket.Location.X && ball.Location.X < racket.Location.X + 170)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void UpdayteBall()
        {
            ball.Location = new Point(ball.Location.X + ballspeedx, ball.Location.Y + ballspeedy);
            //ball.Location = new Point(ball.Location.X, ball.Location.Y + ballspeedy);

            if (ball.Location.X < 0 || ball.Location.X + 40 > this.Width)
            {
                ballspeedx = -ballspeedx;
            }
            if(ball.Location.Y < 0)
            {
                ballspeedy = -ballspeedy;
            }
            if (isCollided())
            {
                ballspeedy = -ballspeedy;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdayteBall();
        }
    }
}
