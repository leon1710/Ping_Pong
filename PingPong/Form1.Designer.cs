namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playground = new System.Windows.Forms.Panel();
            this.gameover_label = new System.Windows.Forms.Label();
            this.points_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.gameover_label);
            this.playground.Controls.Add(this.points_label);
            this.playground.Controls.Add(this.score_label);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(670, 482);
            this.playground.TabIndex = 0;
            // 
            // gameover_label
            // 
            this.gameover_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameover_label.AutoSize = true;
            this.gameover_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover_label.Location = new System.Drawing.Point(203, 89);
            this.gameover_label.Name = "gameover_label";
            this.gameover_label.Size = new System.Drawing.Size(277, 220);
            this.gameover_label.TabIndex = 4;
            this.gameover_label.Text = "Game over\r\n\r\nF1 - Restart\r\nESC - Quit";
            // 
            // points_label
            // 
            this.points_label.AutoSize = true;
            this.points_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points_label.Location = new System.Drawing.Point(115, 12);
            this.points_label.Name = "points_label";
            this.points_label.Size = new System.Drawing.Size(26, 29);
            this.points_label.TabIndex = 3;
            this.points_label.Text = "0";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label.Location = new System.Drawing.Point(12, 9);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(97, 32);
            this.score_label.TabIndex = 2;
            this.score_label.Text = "Score:";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Lime;
            this.ball.Location = new System.Drawing.Point(144, 80);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(213, 252);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 30);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 482);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label points_label;
        private System.Windows.Forms.Label gameover_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

