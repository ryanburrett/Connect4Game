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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();

        }

        // function to launch the main form after the start button is clicked. creates an instance of it
        private void StartGameBTN_Click(object sender, EventArgs e)
        {
            Connect4MainForm MainForm = new Connect4MainForm();
            //hides main menu
            this.Hide();
            MainForm.Show();
        }

        // shows messagebox with information about the program

        private void AboutBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Connect 4 by Ryan Burrett.\n \nThis game plays like traditional Connect 4, where 4 of the same colour in a row wins the game", "About", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
