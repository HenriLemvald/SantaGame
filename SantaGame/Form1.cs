using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaGame
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int speed = 5;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Jouluvana.Top += gravity;
            kuu.Left -= speed;
            majake.Left -= speed;
            kuusk.Left -= speed;
            ScoreLabel.Text = $"score: {score}";

            if (kuusk.Left < -100)
            {
                kuusk.Left = 500;
                score++;
            }

            if (Jouluvana.Top < -25)
            {
                gameOver();
            }
            if (majake.Left < -100)
            {
                majake.Left = 500;
                score++;
            }
            if (kuu.Left < -100)
            {
                kuu.Left = 600;
                score++;
            }

            if (Jouluvana.Bounds.IntersectsWith(kuu.Bounds) || Jouluvana.Bounds.IntersectsWith(kuusk.Bounds) || Jouluvana.Bounds.IntersectsWith(majake.Bounds) || Jouluvana.Bounds.IntersectsWith(maa.Bounds))
            {
                gameOver();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void Jouluvana_Click(object sender, EventArgs e)
        {

        }
        public void gameOver()
        {
            timer1.Stop();
            ScoreLabel.Text = $"Game over!";
            button1.Visible = true;
        }
       /*private void nupp_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
       */
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Dispose(false);
        }
        //private void Button1_Click(object sender, EventArgs e)
    }
}
