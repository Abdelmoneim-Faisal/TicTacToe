namespace TicTacToe
{
    partial class GameScoreForm
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
            dgv_gameScore = new DataGridView();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_gameScore).BeginInit();
            SuspendLayout();
            // 
            // dgv_gameScore
            // 
            dgv_gameScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_gameScore.Location = new Point(12, 12);
            dgv_gameScore.Name = "dgv_gameScore";
            dgv_gameScore.Size = new Size(542, 342);
            dgv_gameScore.TabIndex = 0;
            dgv_gameScore.RowHeaderMouseDoubleClick += dgv_gameScore_RowHeaderMouseDoubleClick;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(713, 39);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 1;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // GameScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(dgv_gameScore);
            Name = "GameScoreForm";
            Text = "GameScoreForm";
            Load += GameScoreForm_Load;
            MouseDown += GameScoreForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dgv_gameScore).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_gameScore;
        private Button btn_delete;
    }
}