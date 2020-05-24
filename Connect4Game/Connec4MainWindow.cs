using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Connect4Game
{
    public partial class Connect4MainForm : Form
    {
        Button[,] btn = new Button[7, 6];
        bool Player1Turn = true;  // player 1 colour is red 

        bool Player2Turn = false; // player 2 colour is yellow
        bool gameFinished = false; //boolean value to check for an ended game
        public static string player1Name = "Player 1"; // static strings to set player names, so can be set from another form easily
        public static string  player2Name = "Player 2";
        public static bool p1active; // used as an indicator whether to set the new name to player 1 or player 2
        List<Point> ButtonLocInArray = new List<Point>(); // list of clicked board positions
        List<Color> ButtonColor = new List<Color>(); // list of clicked board button colours
        Point point; // point varaible, later used to store converted text of the buttons



        public Connect4MainForm()
        {
            InitializeComponent();
            SetDefaults();

            // DrawButtons();
            UpdateNames();
           
        }

       
        public void UpdateNames()
        {
            // method to update playernames if they are changed by the user during runtime
            {
               
                if (player1Name != null)
                {
                    Player1Label.Text = player1Name;
                }

                if (player2Name != null)
                {
                    Player2Label.Text = player2Name;
                }
            }
        }


        public void SetDefaults()
        {
            Button[,] btn = new Button[7, 6];
            Player1CheckBox.Checked = true;
            Player1Turn = true;
            Player2Turn = false; //used to reset variables
            gameFinished = false;
            ButtonLocInArray.Clear();
            ButtonColor.Clear();


            DrawButtons();

        }

        public void DrawButtons()
        {
           


            for (int x = 0; x < btn.GetLength(0); x++)         // Loop for x
            {
                for (int y = 0; y < btn.GetLength(1); y++)     // Loop for y
                {
                    btn[x, y] = new Button();
                    btn[x, y].SetBounds(75 * x + 50, 75 * y + 35, 75, 75);

                    btn[x, y].BackColor = Color.PowderBlue;
                    btn[x, y].Text = Convert.ToString((x + 1) + "," + (y + 1));
                    btn[x, y].Click += new EventHandler(this.btnEvent_Click);


                    Controls.Add(btn[x, y]);

                }
            }
        }


        void btnEvent_Click(object sender, EventArgs e)
        {
            // Console.WriteLine(((Button)sender).Text);
            Button activeBTN = ((Button)sender);
            UpdateNames();

            //checks if game has finished for not, if it hasn't then it processes the button press
            if (gameFinished != true)

            {

                // stores the button.text as a point, calls a fucntion to convert it
                Point activeButtonPointLocation = ConvertLocationToPointType(activeBTN.Text);

                //checks if the button clicked has already be clicked before, if so displays error msg
                if (activeBTN.BackColor == Color.Red || activeBTN.BackColor == Color.Yellow)
                {
                    FeedbackRTB.Text += ("Invalid Move on button: " + activeBTN.Text + "/n");
                   



                }
                else
                {
                    /// need to store button details here 

                    // if button hasnt been clicked it is passed to move validation function to process it

                    bool validMove = moveValidation(activeButtonPointLocation, activeBTN);


                    // if move if valid and its player 1's turn then it turn the clicked button red for player 1
                    // adds the clicked buttons text(grid coords) and its new colour to corresponding lists so a log can be made
                    if (validMove == true && Player1Turn == true)
                    {
                        activeBTN.BackColor = Color.Red;
                        ButtonLocInArray.Add(activeButtonPointLocation);
                        ButtonColor.Add(activeBTN.BackColor);

                    }
                    // same as above if but for player 2 turn being active
                    if (validMove == true && Player2Turn == true)
                    {
                        activeBTN.BackColor = Color.Yellow;
                        ButtonLocInArray.Add(activeButtonPointLocation);
                        ButtonColor.Add(activeBTN.BackColor);

                    }


                    // changed player 1 turn to player 2, plus some gui changes to indicate this
                    if (Player1Turn == true && validMove == true)
                    {
                        Player1Turn = false;
                        Player2Turn = true;
                        Player2CheckBox.Checked = true;
                        Player1CheckBox.Checked = false;

                    }
                    //same as above
                    /// needs cleaning up, too many if's 
                    else if (Player1Turn == false && validMove == true)
                    {
                        Player1Turn = true;
                        Player2Turn = false;
                        Player2CheckBox.Checked = false;
                        Player1CheckBox.Checked = true;
                    }
                    else
                    {

                    }


                }

                // then checks for any true returns from 3 fucntions which check for a winning combonation

                if (checkWinnerHori() || checkDiaganol() || checkWinnerVertically())
                {
                    // as the player turns are are already changed above, in the code, this may seem wrong if statement but its valid
                    //depending on the current players turn then a message box is shown declearing the winner, The textbox on the gui is also filled with 
                    // this information.
                    //the game is declared finished, stops any more moves after a winner is crowned 
                    // a function to make a log file is called, this writes a log,txt file to the system with all moves the winner of the game
                    if (Player1Turn == false)
                    {
                        MessageBox.Show(player1Name + " has Won the game", "Winner Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        FeedbackRTB.Text += ("\n"+player1Name + " Has Won, Log File saved to disk for most recent game");
                        gameFinished = true;
                        makeLogFile(player1Name);
                        
                        
                    }
                    
                    else
                    {
                        MessageBox.Show(player2Name + " has Won the game", "Winner Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        FeedbackRTB.Text += (player2Name + " has Won, Log File saved to disk for most recent game ");
                        gameFinished = true;
                        makeLogFile(player2Name);
                       
                    }

                }



            }

        }


        // logic for checking for the winning move, loops through rows and columns and trys
        // to match the current counter of btn with the ones 3 steps infront of it for a positive match for all of them
        public bool checkWinnerHori()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine(btn[i,j].BackColor + "    FFFFFFFFFFFFFFFFFFFFFFFFFF");
                    if (btn[i, j].BackColor != Color.PowderBlue &&
                    btn[i, j].BackColor == btn[i + 1, j].BackColor && 
                    btn[i, j].BackColor == btn[i + 2, j].BackColor &&
                    btn[i, j].BackColor == btn[i + 3, j].BackColor)
                        return true;
                    
               
        }

     }
            // returns false if a match isn't found

            return false;
    }

        //similar to above logic but adjusted for verticallity 
        // still checks the 3 spaces infront of itself for 3 matches
        public bool checkWinnerVertically()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //Console.WriteLine(btn[i, j].BackColor + "    FFFFFFFFFFFFFFFFFFFFFFFFFF");
                    if (btn[i, j].BackColor != Color.PowderBlue &&
                    btn[i, j].BackColor == btn[i, j + 1].BackColor &&
                    btn[i, j].BackColor == btn[i, j + 2].BackColor &&
                    btn[i, j].BackColor == btn[i, j + 3].BackColor)
                    {
                        return true;
                    }

                }

            }
            return false;
        }



        public bool checkDiaganol()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (btn[j, i].BackColor != Color.PowderBlue &&
                        btn[j, i].BackColor == btn[j + 1, i + 1].BackColor &&
                        btn[j, i].BackColor == btn[j + 2, i + 2].BackColor &&
                        btn[j, i].BackColor == btn[j + 3, i + 3].BackColor)
                    {
                        return true;
                    }
                }

                for (int k=3; k<7;k++)
                {
                    if (btn[k, i].BackColor != Color.PowderBlue &&
                        btn[k, i].BackColor == btn[k - 1, i + 1].BackColor &&
                        btn[k, i].BackColor == btn[k - 2, i + 2].BackColor &&
                        btn[k, i].BackColor == btn[k - 3, i + 3].BackColor)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
       
        //function to check for validation of a button click
        public bool moveValidation(Point activeButtonPointLocation, Button activeBTN)
        {
            int valueofY = activeButtonPointLocation.Y;
            bool validMove = false;
            // used as a reference to the button one space below the active button, can tell if there is a coloured button below the new clicked one
            Point p = new Point(activeButtonPointLocation.X, activeButtonPointLocation.Y + 1);

            //this is true for the bottom row of buttons
            if (valueofY == 6)
            {
                validMove = true;
                return validMove;
            }
            // if the log list contains the button then it has already been clicked, so exists below and therefore the move is valid
            else if (ButtonLocInArray.Contains(p))
            {
                
                
                    validMove = true;
                    return validMove;
                
                
            }
            //returns false if move is invalid
            else
            {
                return validMove;
            }


        }

        //function used to convert the button text to a point location
        //
        //slightly long winded as im sure i could have used the btn location in the array but i was so confused when first writing this, i went with what
        // i knew would work, i would do this whole section differently second time round
        public Point ConvertLocationToPointType(string buttonLOC)
        {
            point = new Point();

            int i = 0;
            // delimiter is used to split the text of the button this is then put into a new instance of point
            string[] parts = buttonLOC.Split(',');
            foreach (string part in parts)
            {
                if (i == 0)
                {
                   // Console.WriteLine();
                    point.X = Convert.ToInt32(part);
                    i++;
                }
                else
                {
                    point.Y = Convert.ToInt32(part);
                }
               // Console.WriteLine(part);
            }
            Console.WriteLine(point);
            return point;


        }

        // function used to print a log file with infromation about the most recent game played 
        public void makeLogFile(string winningPlayer)
        {

            // open streamwriter, set to overwrite any previous log information
            StreamWriter twriter = new StreamWriter("log.txt");



            // loops both lists and prints the details of each move location and the colour placed on that space
            for (int i=0; i<ButtonLocInArray.Count;i++)
            {
                twriter.WriteLine("Move "+(i+1) + ": " + ButtonLocInArray[i] + "   Colour Placed: " + ButtonColor[i]);

               // FeedbackRTB.Text += ("\n" + ButtonLocInArray[i]); // for testing when made
            }
            //prints  the winner of the game
            twriter.WriteLine("Winner of this game: " + winningPlayer);
            twriter.Close();


        }
    
        
        
        private void Form1_Load(object sender, EventArgs e)  //REQUIRED
        {
            
        }

        
        // messagebox is shown when the about menu is pressed
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Connect 4 by Ryan Burrett.\n \nThis game plays like traditional Connect 4, where 4 of the same colour in a row wins the game", "About", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        // creates a new instance of the form when restart game is clicked
        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect4MainForm newForm = new Connect4MainForm();
          //shows new form
            newForm.Show();
            //hides old form
            this.Hide();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        // used to close all instances of the Connect4MainForm
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /*private void Player1Label_DoubleClick(object sender, EventArgs e)
        {
            p1active = true;
            
            PlayerNameScreen ps = new PlayerNameScreen();
            ps.Show();
            //updateNames();
        }*/ //redundant


            // function to change the player name of a player upon a click
        private void Player2Label_Click(object sender, EventArgs e)
        {
            // launches an instance of form, where the name editing takes place
            p1active = false;
            PlayerNameScreen ps = new PlayerNameScreen();
            ps.Show();
            //updateNames();
        }
        //same as function above but for player 1
        private void Player1Label_Click(object sender, EventArgs e)
        {
            p1active = true;

            PlayerNameScreen ps = new PlayerNameScreen();
            ps.Show();
            //updateNames();
        }
    }
}
