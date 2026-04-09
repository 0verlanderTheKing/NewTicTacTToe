namespace tictactoe
{
    partial class Form1
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
            this.topLeftLabel = new System.Windows.Forms.Label();
            this.topMiddleLabel = new System.Windows.Forms.Label();
            this.topRightLabel = new System.Windows.Forms.Label();
            this.middleLeftLabel = new System.Windows.Forms.Label();
            this.centerLabel = new System.Windows.Forms.Label();
            this.middleRightLabel = new System.Windows.Forms.Label();
            this.bottomLeftLabel = new System.Windows.Forms.Label();
            this.bottomCenterLabel = new System.Windows.Forms.Label();
            this.bottomRightLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.randomFirstTurnButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.winsLabel = new System.Windows.Forms.Label();
            this.lossesLabel = new System.Windows.Forms.Label();
            this.tiesLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.scoreReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLeftLabel
            // 
            this.topLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topLeftLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topLeftLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLeftLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.topLeftLabel.Location = new System.Drawing.Point(30, 20);
            this.topLeftLabel.Name = "topLeftLabel";
            this.topLeftLabel.Size = new System.Drawing.Size(75, 75);
            this.topLeftLabel.TabIndex = 0;
            this.topLeftLabel.Tag = "0,0";
            this.topLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topLeftLabel.Click += new System.EventHandler(this.squareLabel_Click);
            // 
            // topMiddleLabel
            // 
            this.topMiddleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topMiddleLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topMiddleLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topMiddleLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.topMiddleLabel.Location = new System.Drawing.Point(110, 20);
            this.topMiddleLabel.Name = "topMiddleLabel";
            this.topMiddleLabel.Size = new System.Drawing.Size(75, 75);
            this.topMiddleLabel.TabIndex = 1;
            this.topMiddleLabel.Tag = "0,1";
            this.topMiddleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topMiddleLabel.Click += new System.EventHandler(this.squareLabel_Click);
            // 
            // topRightLabel
            // 
            this.topRightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topRightLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topRightLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topRightLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.topRightLabel.Location = new System.Drawing.Point(190, 20);
            this.topRightLabel.Name = "topRightLabel";
            this.topRightLabel.Size = new System.Drawing.Size(75, 75);
            this.topRightLabel.TabIndex = 2;
            this.topRightLabel.Tag = "0,2";
            this.topRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topRightLabel.Click += new System.EventHandler(this.squareLabel_Click);
            // 
            // middleLeftLabel
            // 
            this.middleLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middleLeftLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.middleLeftLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleLeftLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.middleLeftLabel.Location = new System.Drawing.Point(30, 100);
            this.middleLeftLabel.Name = "middleLeftLabel";
            this.middleLeftLabel.Size = new System.Drawing.Size(75, 75);
            this.middleLeftLabel.TabIndex = 3;
            this.middleLeftLabel.Tag = "1,0";
            this.middleLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.middleLeftLabel.Click += new System.EventHandler(this.squareLabel_Click);
            // 
            // centerLabel
            // 
            this.centerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.centerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.centerLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.centerLabel.Location = new System.Drawing.Point(110, 100);
            this.centerLabel.Name = "centerLabel";
            this.centerLabel.Size = new System.Drawing.Size(75, 75);
            this.centerLabel.TabIndex = 4;
            this.centerLabel.Tag = "1,1";
            this.centerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.centerLabel.Click += new System.EventHandler(this.squareLabel_Click);
            // 
            // middleRightLabel
            // 
            this.middleRightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middleRightLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.middleRightLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleRightLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.middleRightLabel.Location = new System.Drawing.Point(190, 100);
            this.middleRightLabel.Name = "middleRightLabel";
            this.middleRightLabel.Size = new System.Drawing.Size(75, 75);
            this.middleRightLabel.TabIndex = 5;
            this.middleRightLabel.Tag = "1,2";
            this.middleRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.middleRightLabel.Click += new System.EventHandler(this.squareLabel_Click);
            // 
            // bottomLeftLabel
            // 
            this.bottomLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomLeftLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bottomLeftLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLeftLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bottomLeftLabel.Location = new System.Drawing.Point(30, 180);
            this.bottomLeftLabel.Name = "bottomLeftLabel";
            this.bottomLeftLabel.Size = new System.Drawing.Size(75, 75);
            this.bottomLeftLabel.TabIndex = 6;
            this.bottomLeftLabel.Tag = "2,0";
            this.bottomLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bottomLeftLabel.Click += new System.EventHandler(this.squareLabel_Click);
            // 
            // bottomCenterLabel
            // 
            this.bottomCenterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomCenterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bottomCenterLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomCenterLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bottomCenterLabel.Location = new System.Drawing.Point(110, 180);
            this.bottomCenterLabel.Name = "bottomCenterLabel";
            this.bottomCenterLabel.Size = new System.Drawing.Size(75, 75);
            this.bottomCenterLabel.TabIndex = 7;
            this.bottomCenterLabel.Tag = "2,1";
            this.bottomCenterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bottomCenterLabel.Click += new System.EventHandler(this.squareLabel_Click);
            // 
            // bottomRightLabel
            // 
            this.bottomRightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomRightLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bottomRightLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomRightLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bottomRightLabel.Location = new System.Drawing.Point(190, 180);
            this.bottomRightLabel.Name = "bottomRightLabel";
            this.bottomRightLabel.Size = new System.Drawing.Size(75, 75);
            this.bottomRightLabel.TabIndex = 8;
            this.bottomRightLabel.Tag = "2,2";
            this.bottomRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bottomRightLabel.Click += new System.EventHandler(this.squareLabel_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(30, 288);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(235, 30);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(290, 270);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(109, 23);
            this.newGameButton.TabIndex = 10;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // randomFirstTurnButton
            // 
            this.randomFirstTurnButton.Location = new System.Drawing.Point(290, 228);
            this.randomFirstTurnButton.Name = "randomFirstTurnButton";
            this.randomFirstTurnButton.Size = new System.Drawing.Size(222, 33);
            this.randomFirstTurnButton.TabIndex = 11;
            this.randomFirstTurnButton.Text = "Randomize First Turn";
            this.randomFirstTurnButton.UseVisualStyleBackColor = true;
            this.randomFirstTurnButton.Visible = false;
            this.randomFirstTurnButton.Click += new System.EventHandler(this.randomFirstTurnButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(403, 270);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(109, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // winsLabel
            // 
            this.winsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winsLabel.Location = new System.Drawing.Point(348, 9);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(100, 23);
            this.winsLabel.TabIndex = 12;
            // 
            // lossesLabel
            // 
            this.lossesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lossesLabel.Location = new System.Drawing.Point(348, 48);
            this.lossesLabel.Name = "lossesLabel";
            this.lossesLabel.Size = new System.Drawing.Size(100, 23);
            this.lossesLabel.TabIndex = 13;
            this.lossesLabel.Click += new System.EventHandler(this.lossesLabel_Click);
            // 
            // tiesLabel
            // 
            this.tiesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tiesLabel.Location = new System.Drawing.Point(348, 80);
            this.tiesLabel.Name = "tiesLabel";
            this.tiesLabel.Size = new System.Drawing.Size(100, 23);
            this.tiesLabel.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(290, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 15);
            this.textBox1.TabIndex = 15;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Wins:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(290, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 15);
            this.textBox2.TabIndex = 16;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Losses:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(290, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(37, 15);
            this.textBox3.TabIndex = 17;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Ties:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(110, 258);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 15);
            this.textBox4.TabIndex = 18;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "You are \"X\"";
            // 
            // scoreReset
            // 
            this.scoreReset.Location = new System.Drawing.Point(290, 189);
            this.scoreReset.Name = "scoreReset";
            this.scoreReset.Size = new System.Drawing.Size(222, 33);
            this.scoreReset.TabIndex = 19;
            this.scoreReset.Text = "Reset Score";
            this.scoreReset.UseVisualStyleBackColor = true;
            this.scoreReset.Click += new System.EventHandler(this.scoreReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 340);
            this.Controls.Add(this.scoreReset);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tiesLabel);
            this.Controls.Add(this.lossesLabel);
            this.Controls.Add(this.winsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.randomFirstTurnButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.bottomRightLabel);
            this.Controls.Add(this.bottomCenterLabel);
            this.Controls.Add(this.bottomLeftLabel);
            this.Controls.Add(this.middleRightLabel);
            this.Controls.Add(this.centerLabel);
            this.Controls.Add(this.middleLeftLabel);
            this.Controls.Add(this.topRightLabel);
            this.Controls.Add(this.topMiddleLabel);
            this.Controls.Add(this.topLeftLabel);
            this.Name = "Form1";
            this.Text = "tictactoe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLeftLabel;
        private System.Windows.Forms.Label topMiddleLabel;
        private System.Windows.Forms.Label topRightLabel;
        private System.Windows.Forms.Label middleLeftLabel;
        private System.Windows.Forms.Label centerLabel;
        private System.Windows.Forms.Label middleRightLabel;
        private System.Windows.Forms.Label bottomLeftLabel;
        private System.Windows.Forms.Label bottomCenterLabel;
        private System.Windows.Forms.Label bottomRightLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button randomFirstTurnButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Label lossesLabel;
        private System.Windows.Forms.Label tiesLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button scoreReset;
    }
}

