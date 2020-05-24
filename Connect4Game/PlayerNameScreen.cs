using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4Game
{
    public partial class PlayerNameScreen : Form
    {
        public PlayerNameScreen()
        {
            InitializeComponent();
        }

        // function used to submit a new name for a player 
        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            // check for an empty text box 
            if (!PlayerNameEntryTxtBox.Text.Equals(""))
            {
                // sets playername depending on whether player 1 or player 2 being active
                if (Connect4MainForm.p1active == true)
                {
                    Connect4MainForm.player1Name = PlayerNameEntryTxtBox.Text;
                    
                    

                }
                else
                {
                    Connect4MainForm.player2Name = PlayerNameEntryTxtBox.Text;
                }
            }
            // close this instance 
            this.Close();
        }
    }
}
