using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Maze : Form
    {
        int Score;
        
        // This SoundPlayer plays a sound whenever the player hits a wall.
        System.Media.SoundPlayer startSoundPlayer = new
          System.Media.SoundPlayer(@"C:\Users\l.finke\Downloads\death.wav");

        // This SoundPlayer plays a sound when the player finishes the game.
        System.Media.SoundPlayer finishSoundPlayer = new
       System.Media.SoundPlayer(@"C:\Users\l.finke\Downloads\cassette_get.wav");

        // This SoundPlayer plays a sound when the player collects a strawberry
        System.Media.SoundPlayer collectSoundPlayer = new
        System.Media.SoundPlayer(@"C:\Users\l.finke\Downloads\strawberry_red_get_1000.wav");

       

        public Maze()
        {
            InitializeComponent();
            MessageBox.Show("Scores     " + "Death: -100" + "   Strawberry: +1000");
            MoveToStart();
            ScoreBoard.Text = ("Score: " + (Convert.ToString(Score)));
        }
                
        private void label80_MouseEnter(object sender, EventArgs e)
        {
            // Show a congratulatory MessageBox, then close the form.
            finishSoundPlayer.Play();
            MessageBox.Show("Congratulations!");
            MessageBox.Show("Your total Score was:  " + (Convert.ToString(Score)) + "/5000");
            Close();
        }

        /// <summary>
        /// Move the pointer to a point 10 pixels down and to the right
        /// of the starting point in the upper-left corner of the maze.
        /// </summary>
        private void MoveToStart()
        {
            startSoundPlayer.Play();
            Point startingPoint = panel1.Location;
            startingPoint.Offset(55, 55);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void Wall_MouseEnter(object sender, EventArgs e)
        {
            // When the mouse pointer hits a wall or enters the panel,
            // call the MoveToStart() method.
            Score -= 100;
            ScoreBoard.Text = ("Score: " + (Convert.ToString(Score)));
            MoveToStart();
            

        }

        
        
        private void Strawberry_MouseEnter(object sender, EventArgs e)
        {
            collectSoundPlayer.Play();
        }

       private void Strawberry1_MouseLeave(object sender, EventArgs e)
        {
            Strawberry1.ForeColor = Color.Gray;
            Score += 1000;
            ScoreBoard.Text = ("Score: " + (Convert.ToString(Score)));
        }

        private void Strawberry3_MouseLeave(object sender, EventArgs e)
        {
            Strawberry3.ForeColor = Color.Gray;
            Score += 1000;
            ScoreBoard.Text = ("Score: " + (Convert.ToString(Score)));
        }

        private void Strawberry2_MouseLeave(object sender, EventArgs e)
        {
            Strawberry2.ForeColor = Color.Gray;
            Score += 1000;
            ScoreBoard.Text = ("Score: " + (Convert.ToString(Score)));
        }

        private void Strawberry4_MouseLeave(object sender, EventArgs e)
        {
            Strawberry4.ForeColor = Color.Gray;
            Score += 1000;
            ScoreBoard.Text = ("Score: " + (Convert.ToString(Score)));
        }

        private void Strawberry5_MouseLeave(object sender, EventArgs e)
        {
            Strawberry5.ForeColor = Color.Gray;
            Score += 1000;
            ScoreBoard.Text = ("Score: " + (Convert.ToString(Score)));
        }

        private void ScoreBoard_Click(object sender, EventArgs e)
        {

        }
    }
}

