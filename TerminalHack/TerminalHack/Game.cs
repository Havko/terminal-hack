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

        private void btnBegin2_Click(object sender, EventArgs e)
        {
            GameState newGame = new GameState();
            List<String> newList;
            newList = newGame.SelectWordList();
            string myString = String.Join(",", newList.ToArray());
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

        }
    }
}
