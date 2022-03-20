using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Fish
{
    public partial class FlappyFish : Form
    {
        int pipeSpeed = 5; //sets speed at which pipes move
        int gravity = 13;  // makes bird fall
        int score = 0;     //keeps track of how many points you get, may turn to coins
        public FlappyFish()
        {
            InitializeComponent();
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void FlappyFish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) //when the space bar is pushed down
            {
                gravity = -13; //the bird goes up
            }

        }

        private void FlappyFish_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) //when the space bar is let go
            {
                gravity = 13; //the bird goes down
            }
        }
        private void endGame()
        {
            timer1.Stop(); 
            score1.Text += " Game over!!!"; //score text box says messge
            Restart.Visible = true; //button to restart game shows
            ExitButton.Visible = true;  //button to exit game shows



        }
        private void GameTimerEvent(object sender, EventArgs e)
        {
            Fish.Top += gravity; //links bird with gravity so it falls/rises
            PipeBottom.Left -= pipeSpeed; //links pipeSpeed with the pipes so they move
            PipeTop.Left -= pipeSpeed; //top and bottom
             score1.Text = "Score: " + score;  //keeps track of score

            if (PipeBottom.Left < -150)
            {
                PipeBottom.Left = 800;
                score++;   //once the pipes go past the bird they reset and score is added
            }
            if (PipeTop.Left < -150) //-180
            {
                PipeTop.Left = 800; //950
                score++;
            }
            if (Fish.Bounds.IntersectsWith(PipeBottom.Bounds) ||
                Fish.Bounds.IntersectsWith(PipeTop.Bounds) ||
                Fish.Bounds.IntersectsWith(Ground.Bounds) || Fish.Top < -25
                )  //if the bird hits the pipes or ground game ends
            {
                endGame(); //runs function 
            }
 

           // if (score % 5 == 0 && score > 0) //testing to see if pipes should move faster as you play
           // {
           //    pipeSpeed = pipeSpeed + 1;
           // }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Application.Restart(); //restarts game
        }
    }
}
