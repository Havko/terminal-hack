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
    
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }
        public string _cmbDiff
        {
            get { return cmbDifficulty.SelectedItem.ToString(); }
        }
        private void btnBegin_Click(object sender, EventArgs e)
        {
            
            GameForm gameForm = new GameForm();
            gameForm._cmbdiffi = _cmbDiff;
            Hide();
            gameForm.ShowDialog();
            Close();
        }
    }
}
