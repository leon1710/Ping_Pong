using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public int speed_left = 4;      //speed of ball
        public int speed_top = 4;

        public int point = 0;           //scored points

        public Form1()
        {
            InitializeComponent();

            timer.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;    //no border
            this.TopMost = true;                            //form in front
            this.Bounds = Screen.PrimaryScreen.Bounds;      //fullscreen

            racket.Top = playground.Bottom - (playground.Bottom / 10);

            gameover_label.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);   //set position of racket

            ball.Left += speed_left;        //move the ball
            ball.Top += speed_top;

            if(ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)     //ball collision
            {
                speed_top += 1;
                speed_left +=1;
                speed_top = -speed_top;     //change direction
                point += 1;                 //score + 1

                points_label.Text = point.ToString();   //cast int point to string for text
            }


            if(ball.Left <= playground.Left)
            {
                speed_left = -speed_left;   //change direction of ball 
            }

            if(ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }

            if(ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }

            if(ball.Bottom >= playground.Bottom)
            {
                timer.Enabled = false;          //ball is out
                gameover_label.Visible = true;  //show gamoverlabel
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Klick Escape to Quit game
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }// end of escape

            // Restart
            if(e.KeyCode == Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                point = 0;
                points_label.Text = "0";
                timer.Enabled = true;
                gameover_label.Visible = false;

            }

            //test comment

        }
    }
}
