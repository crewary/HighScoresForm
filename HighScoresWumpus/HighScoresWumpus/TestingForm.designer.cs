namespace WumpusTest2010
{
    partial class TestingForm
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
            this.DisplayHighScoresButton = new System.Windows.Forms.Button();
            this.UpdateHighScoresButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.returnScoreBox = new System.Windows.Forms.TextBox();
            this.CalculateScoreButton = new System.Windows.Forms.Button();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxArrows = new System.Windows.Forms.TextBox();
            this.tboxTurns = new System.Windows.Forms.TextBox();
            this.tboxCoins = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DisplayHighScoresButton
            // 
            this.DisplayHighScoresButton.Location = new System.Drawing.Point(12, 238);
            this.DisplayHighScoresButton.Name = "DisplayHighScoresButton";
            this.DisplayHighScoresButton.Size = new System.Drawing.Size(130, 23);
            this.DisplayHighScoresButton.TabIndex = 34;
            this.DisplayHighScoresButton.Text = "DisplayHighScores";
            this.DisplayHighScoresButton.UseVisualStyleBackColor = true;
            this.DisplayHighScoresButton.Click += new System.EventHandler(this.DisplayHighScoresButton_Click);
            // 
            // UpdateHighScoresButton
            // 
            this.UpdateHighScoresButton.Location = new System.Drawing.Point(12, 209);
            this.UpdateHighScoresButton.Name = "UpdateHighScoresButton";
            this.UpdateHighScoresButton.Size = new System.Drawing.Size(130, 23);
            this.UpdateHighScoresButton.TabIndex = 32;
            this.UpdateHighScoresButton.Text = "UpdateHighScores";
            this.UpdateHighScoresButton.UseVisualStyleBackColor = true;
            this.UpdateHighScoresButton.Click += new System.EventHandler(this.UpdateHighScores_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "returnScoreBox";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "tboxName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "tboxArrows";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "tboxTurns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "tboxCoins";
            // 
            // returnScoreBox
            // 
            this.returnScoreBox.Location = new System.Drawing.Point(115, 141);
            this.returnScoreBox.Name = "returnScoreBox";
            this.returnScoreBox.Size = new System.Drawing.Size(100, 20);
            this.returnScoreBox.TabIndex = 53;
            // 
            // CalculateScoreButton
            // 
            this.CalculateScoreButton.Location = new System.Drawing.Point(12, 12);
            this.CalculateScoreButton.Name = "CalculateScoreButton";
            this.CalculateScoreButton.Size = new System.Drawing.Size(97, 20);
            this.CalculateScoreButton.TabIndex = 25;
            this.CalculateScoreButton.Text = "CalculateScore";
            this.CalculateScoreButton.UseVisualStyleBackColor = true;
            this.CalculateScoreButton.Click += new System.EventHandler(this.CalculateScoreButton_Click);
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(115, 94);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(100, 20);
            this.tboxName.TabIndex = 24;
            // 
            // tboxArrows
            // 
            this.tboxArrows.Location = new System.Drawing.Point(115, 39);
            this.tboxArrows.Name = "tboxArrows";
            this.tboxArrows.Size = new System.Drawing.Size(100, 20);
            this.tboxArrows.TabIndex = 22;
            // 
            // tboxTurns
            // 
            this.tboxTurns.Location = new System.Drawing.Point(115, 65);
            this.tboxTurns.Name = "tboxTurns";
            this.tboxTurns.Size = new System.Drawing.Size(100, 20);
            this.tboxTurns.TabIndex = 23;
            // 
            // tboxCoins
            // 
            this.tboxCoins.Location = new System.Drawing.Point(115, 13);
            this.tboxCoins.Name = "tboxCoins";
            this.tboxCoins.Size = new System.Drawing.Size(100, 20);
            this.tboxCoins.TabIndex = 21;
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 325);
            this.Controls.Add(this.DisplayHighScoresButton);
            this.Controls.Add(this.UpdateHighScoresButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returnScoreBox);
            this.Controls.Add(this.CalculateScoreButton);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.tboxArrows);
            this.Controls.Add(this.tboxTurns);
            this.Controls.Add(this.tboxCoins);
            this.Name = "TestingForm";
            this.Text = "TestingForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DisplayHighScoresButton;
        private System.Windows.Forms.Button UpdateHighScoresButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox returnScoreBox;
        private System.Windows.Forms.Button CalculateScoreButton;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxArrows;
        private System.Windows.Forms.TextBox tboxTurns;
        private System.Windows.Forms.TextBox tboxCoins;
    }
}