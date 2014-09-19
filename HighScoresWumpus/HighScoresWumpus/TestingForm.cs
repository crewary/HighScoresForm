using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WumpusTest2010
{
    public partial class TestingForm : Form
    {
        private HighScore _HighScore = new HighScore();

        public TestingForm()
        {
            InitializeComponent();
            //_HighScore = new HighScore();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ScoresTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //calculates player score using arrows, coins, and turns
        //displays player score in scorebox
        private void CalculateScoreButton_Click(object sender, EventArgs e)
        {
            int arrows = Int32.Parse(tboxArrows.Text);
            int coins = Int32.Parse(tboxCoins.Text);
            int turns = Int32.Parse(tboxTurns.Text);
            String name = tboxName.Text;

            /*          //uncomment to see if string is parted to int in console
            int fivetest = int.Parse(tboxScore.Text);
            Console.WriteLine(int.Parse(tboxArrows.Text));
            Console.WriteLine(fivetest + " string parted to integer");
            //Console.WriteLine(str);
            //returnScoreBox.Text = "Hello";
            */

            //String str = ""+arrows+coins+turns+score;
            String str = "" + _HighScore.CalculateScore(coins, arrows, turns);
            returnScoreBox.Text = str;
        }

        //updates HighScores.txt with arrows, coins, turns, score, and player name from form
        //MUST CALCULATE SCORE FIRST OR INPUT FAKE SCORE
        //all data should be supplied by game control and player name is required for every instance of game
        private void UpdateHighScores_Click(object sender, EventArgs e)
        {
            int arrows = Int32.Parse(tboxArrows.Text);
            int coins = Int32.Parse(tboxCoins.Text);
            int turns = Int32.Parse(tboxTurns.Text);
            /*
            String str = "" + _HighScore.CalculateScore(coins, arrows, turns);
            returnScoreBox.Text = str;
            */
            int score = Int32.Parse(returnScoreBox.Text);
            String name = tboxName.Text;
            _HighScore.UpdateHighScores(name, score, coins, arrows, turns);
        }

        //opens up form to display highscores formatted from HighScores.txt
        private void DisplayHighScoresButton_Click(object sender, EventArgs e)
        {
            _HighScore.openHighScoreForm();
        }

    }
}