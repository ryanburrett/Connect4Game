namespace Connect4Game
{
    partial class PlayerNameScreen
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
            this.InfoText = new System.Windows.Forms.Label();
            this.PlayerNameEntryTxtBox = new System.Windows.Forms.TextBox();
            this.SubmitBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoText.Location = new System.Drawing.Point(93, 69);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(443, 36);
            this.InfoText.TabIndex = 0;
            this.InfoText.Text = "Please Enter you Name Below";
            // 
            // PlayerNameEntryTxtBox
            // 
            this.PlayerNameEntryTxtBox.Location = new System.Drawing.Point(213, 145);
            this.PlayerNameEntryTxtBox.Name = "PlayerNameEntryTxtBox";
            this.PlayerNameEntryTxtBox.Size = new System.Drawing.Size(198, 20);
            this.PlayerNameEntryTxtBox.TabIndex = 1;
            // 
            // SubmitBTN
            // 
            this.SubmitBTN.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBTN.Location = new System.Drawing.Point(266, 197);
            this.SubmitBTN.Name = "SubmitBTN";
            this.SubmitBTN.Size = new System.Drawing.Size(104, 31);
            this.SubmitBTN.TabIndex = 2;
            this.SubmitBTN.Text = "Submit";
            this.SubmitBTN.UseVisualStyleBackColor = true;
            this.SubmitBTN.Click += new System.EventHandler(this.SubmitBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOTE: Change will become active after a move is taken";
            // 
            // PlayerNameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 272);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitBTN);
            this.Controls.Add(this.PlayerNameEntryTxtBox);
            this.Controls.Add(this.InfoText);
            this.Name = "PlayerNameScreen";
            this.Text = "Player Name Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.TextBox PlayerNameEntryTxtBox;
        private System.Windows.Forms.Button SubmitBTN;
        private System.Windows.Forms.Label label1;
    }
}