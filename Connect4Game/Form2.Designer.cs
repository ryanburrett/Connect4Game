namespace Connect4Game
{
    partial class MainMenuForm
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
            this.StartGameBTN = new System.Windows.Forms.Button();
            this.AboutBTN = new System.Windows.Forms.Button();
            this.ConnectLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // StartGameBTN
            // 
            this.StartGameBTN.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameBTN.Location = new System.Drawing.Point(186, 225);
            this.StartGameBTN.Name = "StartGameBTN";
            this.StartGameBTN.Size = new System.Drawing.Size(403, 114);
            this.StartGameBTN.TabIndex = 0;
            this.StartGameBTN.Text = "Start Game";
            this.StartGameBTN.UseVisualStyleBackColor = true;
            this.StartGameBTN.Click += new System.EventHandler(this.StartGameBTN_Click);
            // 
            // AboutBTN
            // 
            this.AboutBTN.Location = new System.Drawing.Point(316, 403);
            this.AboutBTN.Name = "AboutBTN";
            this.AboutBTN.Size = new System.Drawing.Size(144, 66);
            this.AboutBTN.TabIndex = 2;
            this.AboutBTN.Text = "About";
            this.AboutBTN.UseVisualStyleBackColor = true;
            this.AboutBTN.Click += new System.EventHandler(this.AboutBTN_Click);
            // 
            // ConnectLogo
            // 
            this.ConnectLogo.Image = global::Connect4Game.Properties.Resources.connect_4_logo;
            this.ConnectLogo.Location = new System.Drawing.Point(161, 55);
            this.ConnectLogo.Name = "ConnectLogo";
            this.ConnectLogo.Size = new System.Drawing.Size(458, 164);
            this.ConnectLogo.TabIndex = 1;
            this.ConnectLogo.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 557);
            this.Controls.Add(this.AboutBTN);
            this.Controls.Add(this.ConnectLogo);
            this.Controls.Add(this.StartGameBTN);
            this.Name = "MainMenuForm";
            this.Text = "Connect 4 Menu";
            ((System.ComponentModel.ISupportInitialize)(this.ConnectLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGameBTN;
        private System.Windows.Forms.PictureBox ConnectLogo;
        private System.Windows.Forms.Button AboutBTN;
    }
}