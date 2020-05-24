namespace Connect4Game
{
    partial class Connect4MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FeedbackRTB = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.Player1CheckBox = new System.Windows.Forms.CheckBox();
            this.Player2CheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.restartGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // restartGameToolStripMenuItem
            // 
            this.restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            this.restartGameToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.restartGameToolStripMenuItem.Text = "Restart Game";
            this.restartGameToolStripMenuItem.Click += new System.EventHandler(this.restartGameToolStripMenuItem_Click);
            // 
            // FeedbackRTB
            // 
            this.FeedbackRTB.Location = new System.Drawing.Point(207, 504);
            this.FeedbackRTB.Name = "FeedbackRTB";
            this.FeedbackRTB.Size = new System.Drawing.Size(198, 109);
            this.FeedbackRTB.TabIndex = 1;
            this.FeedbackRTB.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(94, 499);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox2.Location = new System.Drawing.Point(493, 499);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Location = new System.Drawing.Point(123, 504);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(45, 13);
            this.Player1Label.TabIndex = 5;
            this.Player1Label.Text = "Player 1";
            this.Player1Label.Click += new System.EventHandler(this.Player1Label_Click);
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.Location = new System.Drawing.Point(442, 504);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(45, 13);
            this.Player2Label.TabIndex = 6;
            this.Player2Label.Text = "Player 2";
            this.Player2Label.Click += new System.EventHandler(this.Player2Label_Click);
            // 
            // Player1CheckBox
            // 
            this.Player1CheckBox.AutoCheck = false;
            this.Player1CheckBox.AutoSize = true;
            this.Player1CheckBox.Location = new System.Drawing.Point(175, 504);
            this.Player1CheckBox.Name = "Player1CheckBox";
            this.Player1CheckBox.Size = new System.Drawing.Size(15, 14);
            this.Player1CheckBox.TabIndex = 7;
            this.Player1CheckBox.UseVisualStyleBackColor = true;
            // 
            // Player2CheckBox
            // 
            this.Player2CheckBox.AutoCheck = false;
            this.Player2CheckBox.AutoSize = true;
            this.Player2CheckBox.Location = new System.Drawing.Point(421, 503);
            this.Player2CheckBox.Name = "Player2CheckBox";
            this.Player2CheckBox.Size = new System.Drawing.Size(15, 14);
            this.Player2CheckBox.TabIndex = 8;
            this.Player2CheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 627);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tip: You can change name by clicking on \"Player 1/2\"";
            // 
            // Connect4MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 649);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player2CheckBox);
            this.Controls.Add(this.Player1CheckBox);
            this.Controls.Add(this.Player2Label);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FeedbackRTB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Connect4MainForm";
            this.Text = "Connect 4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox FeedbackRTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label Player2Label;
        private System.Windows.Forms.CheckBox Player1CheckBox;
        private System.Windows.Forms.CheckBox Player2CheckBox;
        private System.Windows.Forms.ToolStripMenuItem restartGameToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

