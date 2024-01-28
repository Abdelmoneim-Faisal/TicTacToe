namespace TicTacToe
{
    partial class Game
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
            lbl_pl1Name = new Label();
            lbl_pl2Name = new Label();
            lbl_pl1Sign = new Label();
            lbl_pl2Sign = new Label();
            btn_reset = new Button();
            btn_saveScore = new Button();
            gamePanel = new Panel();
            panel8 = new Panel();
            pos8 = new Label();
            panel7 = new Panel();
            pos7 = new Label();
            panel6 = new Panel();
            pos6 = new Label();
            panel3 = new Panel();
            pos3 = new Label();
            panel4 = new Panel();
            pos4 = new Label();
            panel5 = new Panel();
            pos5 = new Label();
            panel2 = new Panel();
            pos2 = new Label();
            panel1 = new Panel();
            pos1 = new Label();
            panel0 = new Panel();
            pos0 = new Label();
            pl1Score = new TextBox();
            pl2Score = new TextBox();
            btn_newGame = new Button();
            gamePanel.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel0.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_pl1Name
            // 
            lbl_pl1Name.AutoSize = true;
            lbl_pl1Name.Location = new Point(444, 30);
            lbl_pl1Name.Name = "lbl_pl1Name";
            lbl_pl1Name.Size = new Size(38, 15);
            lbl_pl1Name.TabIndex = 0;
            lbl_pl1Name.Text = "label1";
            // 
            // lbl_pl2Name
            // 
            lbl_pl2Name.AutoSize = true;
            lbl_pl2Name.Location = new Point(444, 86);
            lbl_pl2Name.Name = "lbl_pl2Name";
            lbl_pl2Name.Size = new Size(38, 15);
            lbl_pl2Name.TabIndex = 1;
            lbl_pl2Name.Text = "label2";
            // 
            // lbl_pl1Sign
            // 
            lbl_pl1Sign.AutoSize = true;
            lbl_pl1Sign.Location = new Point(499, 30);
            lbl_pl1Sign.Name = "lbl_pl1Sign";
            lbl_pl1Sign.Size = new Size(38, 15);
            lbl_pl1Sign.TabIndex = 2;
            lbl_pl1Sign.Text = "label1";
            // 
            // lbl_pl2Sign
            // 
            lbl_pl2Sign.AutoSize = true;
            lbl_pl2Sign.Location = new Point(499, 86);
            lbl_pl2Sign.Name = "lbl_pl2Sign";
            lbl_pl2Sign.Size = new Size(38, 15);
            lbl_pl2Sign.TabIndex = 3;
            lbl_pl2Sign.Text = "label2";
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(444, 170);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(75, 23);
            btn_reset.TabIndex = 4;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_saveScore
            // 
            btn_saveScore.Location = new Point(444, 268);
            btn_saveScore.Name = "btn_saveScore";
            btn_saveScore.Size = new Size(75, 23);
            btn_saveScore.TabIndex = 6;
            btn_saveScore.Text = "Save Score";
            btn_saveScore.UseVisualStyleBackColor = true;
            btn_saveScore.Click += btn_saveScore_Click;
            // 
            // gamePanel
            // 
            gamePanel.BackColor = SystemColors.ButtonShadow;
            gamePanel.Controls.Add(panel8);
            gamePanel.Controls.Add(panel7);
            gamePanel.Controls.Add(panel6);
            gamePanel.Controls.Add(panel3);
            gamePanel.Controls.Add(panel4);
            gamePanel.Controls.Add(panel5);
            gamePanel.Controls.Add(panel2);
            gamePanel.Controls.Add(panel1);
            gamePanel.Controls.Add(panel0);
            gamePanel.Location = new Point(25, 12);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(392, 331);
            gamePanel.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(pos8);
            panel8.Location = new Point(286, 248);
            panel8.Name = "panel8";
            panel8.Size = new Size(89, 68);
            panel8.TabIndex = 1;
            panel8.Click += panel8_Click;
            // 
            // pos8
            // 
            pos8.AutoSize = true;
            pos8.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            pos8.Location = new Point(32, 22);
            pos8.Name = "pos8";
            pos8.Size = new Size(69, 24);
            pos8.TabIndex = 1;
            pos8.Text = "label9";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(pos7);
            panel7.Location = new Point(157, 248);
            panel7.Name = "panel7";
            panel7.Size = new Size(89, 68);
            panel7.TabIndex = 1;
            panel7.Click += panel7_Click;
            // 
            // pos7
            // 
            pos7.AutoSize = true;
            pos7.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            pos7.Location = new Point(32, 22);
            pos7.Name = "pos7";
            pos7.Size = new Size(69, 24);
            pos7.TabIndex = 1;
            pos7.Text = "label8";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(pos6);
            panel6.Location = new Point(28, 248);
            panel6.Name = "panel6";
            panel6.Size = new Size(89, 68);
            panel6.TabIndex = 1;
            panel6.Click += panel6_Click;
            // 
            // pos6
            // 
            pos6.AutoSize = true;
            pos6.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            pos6.Location = new Point(32, 22);
            pos6.Name = "pos6";
            pos6.Size = new Size(69, 24);
            pos6.TabIndex = 1;
            pos6.Text = "label7";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pos3);
            panel3.Location = new Point(28, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(89, 68);
            panel3.TabIndex = 1;
            panel3.Click += panel3_Click;
            // 
            // pos3
            // 
            pos3.AutoSize = true;
            pos3.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            pos3.Location = new Point(32, 22);
            pos3.Name = "pos3";
            pos3.Size = new Size(69, 24);
            pos3.TabIndex = 1;
            pos3.Text = "label4";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pos4);
            panel4.Location = new Point(157, 133);
            panel4.Name = "panel4";
            panel4.Size = new Size(89, 68);
            panel4.TabIndex = 1;
            panel4.Click += panel4_Click;
            // 
            // pos4
            // 
            pos4.AutoSize = true;
            pos4.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            pos4.Location = new Point(32, 22);
            pos4.Name = "pos4";
            pos4.Size = new Size(69, 24);
            pos4.TabIndex = 1;
            pos4.Text = "label5";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(pos5);
            panel5.Location = new Point(286, 133);
            panel5.Name = "panel5";
            panel5.Size = new Size(89, 68);
            panel5.TabIndex = 2;
            panel5.Click += panel5_Click;
            // 
            // pos5
            // 
            pos5.AutoSize = true;
            pos5.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            pos5.Location = new Point(32, 22);
            pos5.Name = "pos5";
            pos5.Size = new Size(69, 24);
            pos5.TabIndex = 1;
            pos5.Text = "label6";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pos2);
            panel2.Location = new Point(286, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(89, 68);
            panel2.TabIndex = 1;
            panel2.Click += panel2_Click;
            // 
            // pos2
            // 
            pos2.AutoSize = true;
            pos2.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            pos2.Location = new Point(32, 22);
            pos2.Name = "pos2";
            pos2.Size = new Size(69, 24);
            pos2.TabIndex = 1;
            pos2.Text = "label3";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pos1);
            panel1.Location = new Point(157, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(89, 68);
            panel1.TabIndex = 1;
            panel1.Click += panel1_Click;
            // 
            // pos1
            // 
            pos1.AutoSize = true;
            pos1.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            pos1.Location = new Point(32, 22);
            pos1.Name = "pos1";
            pos1.Size = new Size(69, 24);
            pos1.TabIndex = 1;
            pos1.Text = "label2";
            // 
            // panel0
            // 
            panel0.BackColor = Color.White;
            panel0.Controls.Add(pos0);
            panel0.Location = new Point(28, 18);
            panel0.Name = "panel0";
            panel0.Size = new Size(89, 68);
            panel0.TabIndex = 0;
            panel0.Click += panel0_Click;
            // 
            // pos0
            // 
            pos0.AutoSize = true;
            pos0.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pos0.Location = new Point(32, 22);
            pos0.Name = "pos0";
            pos0.Size = new Size(69, 24);
            pos0.TabIndex = 0;
            pos0.Text = "label1";
            pos0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pl1Score
            // 
            pl1Score.Location = new Point(557, 27);
            pl1Score.Name = "pl1Score";
            pl1Score.ReadOnly = true;
            pl1Score.Size = new Size(100, 23);
            pl1Score.TabIndex = 8;
            pl1Score.Text = "0";
            pl1Score.TextAlign = HorizontalAlignment.Center;
            // 
            // pl2Score
            // 
            pl2Score.Location = new Point(557, 83);
            pl2Score.Name = "pl2Score";
            pl2Score.ReadOnly = true;
            pl2Score.Size = new Size(100, 23);
            pl2Score.TabIndex = 10;
            pl2Score.Text = "0";
            pl2Score.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_newGame
            // 
            btn_newGame.Location = new Point(444, 218);
            btn_newGame.Name = "btn_newGame";
            btn_newGame.Size = new Size(75, 23);
            btn_newGame.TabIndex = 11;
            btn_newGame.Text = "New Game";
            btn_newGame.UseVisualStyleBackColor = true;
            btn_newGame.Click += btn_newGame_Click;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_newGame);
            Controls.Add(pl2Score);
            Controls.Add(pl1Score);
            Controls.Add(gamePanel);
            Controls.Add(btn_saveScore);
            Controls.Add(btn_reset);
            Controls.Add(lbl_pl2Sign);
            Controls.Add(lbl_pl1Sign);
            Controls.Add(lbl_pl2Name);
            Controls.Add(lbl_pl1Name);
            Name = "Game";
            Text = "Game";
            Load += Game_Load;
            gamePanel.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel0.ResumeLayout(false);
            panel0.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_pl1Name;
        private Label lbl_pl2Name;
        private Label lbl_pl1Sign;
        private Label lbl_pl2Sign;
        private Button btn_reset;
        private Button btn_saveScore;
        private Panel gamePanel;
        private TextBox pl1Score;
        private TextBox pl2Score;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel2;
        private Panel panel1;
        private Panel panel0;
        private Label pos8;
        private Label pos7;
        private Label pos6;
        private Label pos3;
        private Label pos4;
        private Label pos5;
        private Label pos2;
        private Label pos1;
        private Label pos0;
        private Button btn_newGame;
    }
}