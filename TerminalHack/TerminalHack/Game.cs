using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalHack
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }
        string answer;
        string difficulty;
        int incorrectGuesses = 0;
        public string _cmbdiffi
        {
            set { difficulty = value; }
        }
        
        private void btnBegin2_Click(object sender, EventArgs e)
        {
            
            label3.Visible = true;
            label4.Visible = true;
            btnBegin2.Text = "New Game";
            label1.Visible = true;
            label2.Visible = true;
            lblIncorrect.Visible = true;
            GameState newGame = new GameState(difficulty);
            List<String> newList;
            newList = newGame.SelectWordList();
            incorrectGuesses = 0;
            label4.Text = "0";
            lblLastGuess.Text = "";
            lblIncorrect.Text = "0";
            string myString = String.Join(",", newList.ToArray());
            Random myRand = new Random();
            int index = myRand.Next(10);
            btnWord1.Visible = true;
            btnWord2.Visible = true;
            btnWord3.Visible = true;
            btnWord4.Visible = true;
            btnWord5.Visible = true;
            btnWord6.Visible = true;
            btnWord7.Visible = true;
            btnWord8.Visible = true;
            btnWord9.Visible = true;
            btnWord10.Visible = true;
            answer = newList[index];
            btnWord1.Text = newList[0];
            btnWord2.Text = newList[1];
            btnWord3.Text = newList[2];
            btnWord4.Text = newList[3];
            btnWord5.Text = newList[4];
            btnWord6.Text = newList[5];
            btnWord7.Text = newList[6];
            btnWord8.Text = newList[7];
            btnWord9.Text = newList[8];
            btnWord10.Text = newList[9];
           
        }

        private void btnWord1_Click(object sender, EventArgs e)
        {
            char[] answerArr = answer.ToCharArray();
            char[] choiceArr = btnWord1.Text.ToCharArray();
            int numMatch = 0;
            for (int i = 0; i < 4; i++)
            {
                if (answerArr[i] == choiceArr[i])
                {
                    numMatch++;
                }
            }
            if (numMatch == 4)
            {
                MessageBox.Show("You Got it Correct!");
            }
            else
            {
                incorrectGuesses++;
                lblIncorrect.Text = incorrectGuesses.ToString();
                lblLastGuess.Text = btnWord1.Text;
                label4.Text = numMatch.ToString();
            }
            
        }

        private void btnWord2_Click(object sender, EventArgs e)
        {
            char[] answerArr = answer.ToCharArray();
            char[] choiceArr = btnWord2.Text.ToCharArray();
            int numMatch = 0;
            for (int i = 0; i < 4; i++)
            {
                if (answerArr[i] == choiceArr[i])
                {
                    numMatch++;
                }
            }
            if (numMatch == 4)
            {
                MessageBox.Show("You Got it Correct!");
            }
            else
            {
                incorrectGuesses++;
                lblIncorrect.Text = incorrectGuesses.ToString();
                lblLastGuess.Text = btnWord2.Text;
                label4.Text = numMatch.ToString();
            }
        
        }

        private void btnWord3_Click(object sender, EventArgs e)
        {
            char[] answerArr = answer.ToCharArray();
            char[] choiceArr = btnWord3.Text.ToCharArray();
            int numMatch = 0;
            for (int i = 0; i < 4; i++)
            {
                if (answerArr[i] == choiceArr[i])
                {
                    numMatch++;
                }
            }
            if (numMatch == 4)
            {
                MessageBox.Show("You Got it Correct!");
            }
            else
            {
                incorrectGuesses++;
                lblIncorrect.Text = incorrectGuesses.ToString();
                lblLastGuess.Text = btnWord3.Text;
                label4.Text = numMatch.ToString();
            }
         
        }

        private void btnWord4_Click(object sender, EventArgs e)
        {
            char[] answerArr = answer.ToCharArray();
            char[] choiceArr = btnWord4.Text.ToCharArray();
            int numMatch = 0;
            for (int i = 0; i < 4; i++)
            {
                if (answerArr[i] == choiceArr[i])
                {
                    numMatch++;
                }
            }
            if (numMatch == 4)
            {
                MessageBox.Show("You Got it Correct!");
                
            }
            else
            {
                incorrectGuesses++;
                lblIncorrect.Text = incorrectGuesses.ToString();
                lblLastGuess.Text = btnWord4.Text;
                label4.Text = numMatch.ToString();
            }
           
        }

        private void btnWord5_Click(object sender, EventArgs e)
        {
            char[] answerArr = answer.ToCharArray();
            char[] choiceArr = btnWord5.Text.ToCharArray();
            int numMatch = 0;
            for (int i = 0; i < 4; i++)
            {
                if (answerArr[i] == choiceArr[i])
                {
                    numMatch++;
                }
            }
            if (numMatch == 4)
            {
                MessageBox.Show("You Got it Correct!");
                
            }
            else
            {
                incorrectGuesses++;
                lblIncorrect.Text = incorrectGuesses.ToString();
                lblLastGuess.Text = btnWord5.Text;
                label4.Text = numMatch.ToString();
            }
            
        }

        private void btnWord6_Click(object sender, EventArgs e)
        {
            char[] answerArr = answer.ToCharArray();
            char[] choiceArr = btnWord6.Text.ToCharArray();
            int numMatch = 0;
            for (int i = 0; i < 4; i++)
            {
                if (answerArr[i] == choiceArr[i])
                {
                    numMatch++;
                    lblIncorrect.Text = incorrectGuesses.ToString();
                }
            }
            if (numMatch == 4)
            {
                MessageBox.Show("You Got it Correct!");
            }
            else
            {
                incorrectGuesses++;
                lblIncorrect.Text = incorrectGuesses.ToString();
                lblLastGuess.Text = btnWord5.Text;
                label4.Text = numMatch.ToString();
            }
           
        }

        private void btnWord7_Click(object sender, EventArgs e)
        {
            char[] answerArr = answer.ToCharArray();
            char[] choiceArr = btnWord7.Text.ToCharArray();
            int numMatch = 0;
            for (int i = 0; i < 4; i++)
            {
                if (answerArr[i] == choiceArr[i])
                {
                    numMatch++;
                }
            }
            if (numMatch == 4)
            {
                MessageBox.Show("You Got it Correct!");
            }
            else
            {
                incorrectGuesses++;
                lblIncorrect.Text = incorrectGuesses.ToString();
                lblLastGuess.Text = btnWord7.Text;
                label4.Text = numMatch.ToString();
            }
           
        }

        private void btnWord8_Click(object sender, EventArgs e)
        {
            char[] answerArr = answer.ToCharArray();
            char[] choiceArr = btnWord8.Text.ToCharArray();
            int numMatch = 0;
            for (int i = 0; i < 4; i++)
            {
                if (answerArr[i] == choiceArr[i])
                {
                    numMatch++;
                }
            }
            if (numMatch == 4)
            {
                MessageBox.Show("You Got it Correct!");
            }
            else
            {
                incorrectGuesses++;
                lblIncorrect.Text = incorrectGuesses.ToString();
                lblLastGuess.Text = btnWord8.Text;
                label4.Text = numMatch.ToString();
            }
           
        }

        private void btnWord9_Click(object sender, EventArgs e)
        {
            char[] answerArr = answer.ToCharArray();
            char[] choiceArr = btnWord9.Text.ToCharArray();
            int numMatch = 0;
            for (int i = 0; i < 4; i++)
            {
                if (answerArr[i] == choiceArr[i])
                {
                    numMatch++;
                }
            }
            if (numMatch == 4)
            {
                MessageBox.Show("You Got it Correct!");
            }
            else
            {
                incorrectGuesses++;
                lblIncorrect.Text = incorrectGuesses.ToString();
                lblLastGuess.Text = btnWord9.Text;
                label4.Text = numMatch.ToString();
            }
            
        }

        private void btnWord10_Click(object sender, EventArgs e)
        {
            char[] answerArr = answer.ToCharArray();
            char[] choiceArr = btnWord10.Text.ToCharArray();
            int numMatch = 0;
            for (int i = 0; i < 4; i++)
            {
                if (answerArr[i] == choiceArr[i])
                {
                    numMatch++;
                }
            }
            if (numMatch == 4)
            {
                MessageBox.Show("You Got it Correct!");
            }
            else
            {
                incorrectGuesses++;
                lblIncorrect.Text = incorrectGuesses.ToString();
                lblLastGuess.Text = btnWord10.Text;
                label4.Text = numMatch.ToString();
            }
           
        }
    }
}
