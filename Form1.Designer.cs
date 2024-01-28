namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb_pl1 = new GroupBox();
            rb_pl1O = new RadioButton();
            rb_pl1X = new RadioButton();
            txt_pl1Name = new TextBox();
            lbl_pl1Name = new Label();
            gb_player2 = new GroupBox();
            rb_pl2O = new RadioButton();
            rb_pl2X = new RadioButton();
            txt_pl2Name = new TextBox();
            lbl_player2Name = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btn_start = new Button();
            gb_pl1.SuspendLayout();
            gb_player2.SuspendLayout();
            SuspendLayout();
            // 
            // gb_pl1
            // 
            gb_pl1.Controls.Add(rb_pl1O);
            gb_pl1.Controls.Add(rb_pl1X);
            gb_pl1.Controls.Add(txt_pl1Name);
            gb_pl1.Controls.Add(lbl_pl1Name);
            gb_pl1.Location = new Point(71, 76);
            gb_pl1.Name = "gb_pl1";
            gb_pl1.Size = new Size(223, 100);
            gb_pl1.TabIndex = 0;
            gb_pl1.TabStop = false;
            gb_pl1.Text = "Player 1";
            // 
            // rb_pl1O
            // 
            rb_pl1O.AutoSize = true;
            rb_pl1O.Location = new Point(106, 61);
            rb_pl1O.Name = "rb_pl1O";
            rb_pl1O.Size = new Size(34, 19);
            rb_pl1O.TabIndex = 4;
            rb_pl1O.TabStop = true;
            rb_pl1O.Text = "O";
            rb_pl1O.UseVisualStyleBackColor = true;
            rb_pl1O.CheckedChanged += rb_pl1O_CheckedChanged;
            rb_pl1O.Enter += rb_pl1O_CheckedChanged;
            // 
            // rb_pl1X
            // 
            rb_pl1X.AutoSize = true;
            rb_pl1X.Location = new Point(6, 61);
            rb_pl1X.Name = "rb_pl1X";
            rb_pl1X.Size = new Size(32, 19);
            rb_pl1X.TabIndex = 3;
            rb_pl1X.TabStop = true;
            rb_pl1X.Text = "X";
            rb_pl1X.UseVisualStyleBackColor = true;
            rb_pl1X.CheckedChanged += rb_pl1X_CheckedChanged;
            rb_pl1X.Enter += rb_pl1X_CheckedChanged;
            // 
            // txt_pl1Name
            // 
            txt_pl1Name.Location = new Point(75, 23);
            txt_pl1Name.Name = "txt_pl1Name";
            txt_pl1Name.Size = new Size(100, 23);
            txt_pl1Name.TabIndex = 1;
            // 
            // lbl_pl1Name
            // 
            lbl_pl1Name.AutoSize = true;
            lbl_pl1Name.Location = new Point(20, 26);
            lbl_pl1Name.Name = "lbl_pl1Name";
            lbl_pl1Name.Size = new Size(39, 15);
            lbl_pl1Name.TabIndex = 0;
            lbl_pl1Name.Text = "Name";
            // 
            // gb_player2
            // 
            gb_player2.Controls.Add(rb_pl2O);
            gb_player2.Controls.Add(rb_pl2X);
            gb_player2.Controls.Add(txt_pl2Name);
            gb_player2.Controls.Add(lbl_player2Name);
            gb_player2.Location = new Point(517, 76);
            gb_player2.Name = "gb_player2";
            gb_player2.Size = new Size(200, 100);
            gb_player2.TabIndex = 1;
            gb_player2.TabStop = false;
            gb_player2.Text = "Player 2";
            // 
            // rb_pl2O
            // 
            rb_pl2O.AutoSize = true;
            rb_pl2O.Location = new Point(133, 61);
            rb_pl2O.Name = "rb_pl2O";
            rb_pl2O.Size = new Size(34, 19);
            rb_pl2O.TabIndex = 6;
            rb_pl2O.TabStop = true;
            rb_pl2O.Text = "O";
            rb_pl2O.UseVisualStyleBackColor = true;
            rb_pl2O.CheckedChanged += rb_pl2O_CheckedChanged;
            // 
            // rb_pl2X
            // 
            rb_pl2X.AutoSize = true;
            rb_pl2X.Location = new Point(33, 61);
            rb_pl2X.Name = "rb_pl2X";
            rb_pl2X.Size = new Size(32, 19);
            rb_pl2X.TabIndex = 5;
            rb_pl2X.TabStop = true;
            rb_pl2X.Text = "X";
            rb_pl2X.UseVisualStyleBackColor = true;
            rb_pl2X.CheckedChanged += rb_pl2X_CheckedChanged;
            // 
            // txt_pl2Name
            // 
            txt_pl2Name.Location = new Point(78, 23);
            txt_pl2Name.Name = "txt_pl2Name";
            txt_pl2Name.Size = new Size(100, 23);
            txt_pl2Name.TabIndex = 2;
            // 
            // lbl_player2Name
            // 
            lbl_player2Name.AutoSize = true;
            lbl_player2Name.Location = new Point(15, 26);
            lbl_player2Name.Name = "lbl_player2Name";
            lbl_player2Name.Size = new Size(39, 15);
            lbl_player2Name.TabIndex = 1;
            lbl_player2Name.Text = "Name";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(350, 268);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(75, 23);
            btn_start.TabIndex = 2;
            btn_start.Text = "Start Game";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_start);
            Controls.Add(gb_player2);
            Controls.Add(gb_pl1);
            Name = "Form1";
            Text = "Form1";
            gb_pl1.ResumeLayout(false);
            gb_pl1.PerformLayout();
            gb_player2.ResumeLayout(false);
            gb_player2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_pl1;
        private GroupBox gb_player2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private RadioButton rb_pl1O;
        private RadioButton rb_pl1X;
        private TextBox txt_pl1Name;
        private Label lbl_pl1Name;
        private TextBox txt_pl2Name;
        private Label lbl_player2Name;
        private RadioButton rb_pl2O;
        private RadioButton rb_pl2X;
        private Button btn_start;
    }
}
