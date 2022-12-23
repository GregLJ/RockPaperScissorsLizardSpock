namespace RockPaperScissorsLizardSpock
{
    public partial class RPSLS
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnLizard = new System.Windows.Forms.Button();
            this.btnSpock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayerScoreCount = new System.Windows.Forms.Label();
            this.lblComputerScoreCount = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RPSLS_Game = new System.Windows.Forms.TabPage();
            this.Game_Options = new System.Windows.Forms.TabPage();
            this.numMaxScore = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.RPSLS_Game.SuspendLayout();
            this.Game_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxScore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.White;
            this.btnRock.Location = new System.Drawing.Point(297, 80);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 23);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(297, 109);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 23);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(297, 138);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(75, 23);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnLizard
            // 
            this.btnLizard.Location = new System.Drawing.Point(297, 167);
            this.btnLizard.Name = "btnLizard";
            this.btnLizard.Size = new System.Drawing.Size(75, 23);
            this.btnLizard.TabIndex = 3;
            this.btnLizard.Text = "Lizard";
            this.btnLizard.UseVisualStyleBackColor = true;
            this.btnLizard.Click += new System.EventHandler(this.btnLizard_Click);
            // 
            // btnSpock
            // 
            this.btnSpock.Location = new System.Drawing.Point(297, 196);
            this.btnSpock.Name = "btnSpock";
            this.btnSpock.Size = new System.Drawing.Size(75, 23);
            this.btnSpock.TabIndex = 4;
            this.btnSpock.Text = "Spock";
            this.btnSpock.UseVisualStyleBackColor = true;
            this.btnSpock.Click += new System.EventHandler(this.btnSpock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(98, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rock, Paper, Scissors, Lizard, Spock";
            // 
            // lblWin
            // 
            this.lblWin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWin.Enabled = false;
            this.lblWin.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWin.Location = new System.Drawing.Point(17, 267);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(644, 45);
            this.lblWin.TabIndex = 6;
            this.lblWin.Text = "Draw";
            this.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWin.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(476, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(444, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Computer  Score:";
            // 
            // lblPlayerScoreCount
            // 
            this.lblPlayerScoreCount.AutoSize = true;
            this.lblPlayerScoreCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerScoreCount.Location = new System.Drawing.Point(590, 109);
            this.lblPlayerScoreCount.Name = "lblPlayerScoreCount";
            this.lblPlayerScoreCount.Size = new System.Drawing.Size(19, 21);
            this.lblPlayerScoreCount.TabIndex = 9;
            this.lblPlayerScoreCount.Text = "0";
            this.lblPlayerScoreCount.Visible = false;
            // 
            // lblComputerScoreCount
            // 
            this.lblComputerScoreCount.AutoSize = true;
            this.lblComputerScoreCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComputerScoreCount.Location = new System.Drawing.Point(590, 142);
            this.lblComputerScoreCount.Name = "lblComputerScoreCount";
            this.lblComputerScoreCount.Size = new System.Drawing.Size(19, 21);
            this.lblComputerScoreCount.TabIndex = 10;
            this.lblComputerScoreCount.Text = "0";
            this.lblComputerScoreCount.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(8, 40);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RPSLS_Game);
            this.tabControl1.Controls.Add(this.Game_Options);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 428);
            this.tabControl1.TabIndex = 12;
            // 
            // RPSLS_Game
            // 
            this.RPSLS_Game.BackColor = System.Drawing.Color.SteelBlue;
            this.RPSLS_Game.Controls.Add(this.label1);
            this.RPSLS_Game.Controls.Add(this.btnReset);
            this.RPSLS_Game.Controls.Add(this.btnRock);
            this.RPSLS_Game.Controls.Add(this.lblComputerScoreCount);
            this.RPSLS_Game.Controls.Add(this.btnPaper);
            this.RPSLS_Game.Controls.Add(this.lblPlayerScoreCount);
            this.RPSLS_Game.Controls.Add(this.btnScissors);
            this.RPSLS_Game.Controls.Add(this.label3);
            this.RPSLS_Game.Controls.Add(this.btnLizard);
            this.RPSLS_Game.Controls.Add(this.label2);
            this.RPSLS_Game.Controls.Add(this.btnSpock);
            this.RPSLS_Game.Controls.Add(this.lblWin);
            this.RPSLS_Game.Location = new System.Drawing.Point(4, 24);
            this.RPSLS_Game.Name = "RPSLS_Game";
            this.RPSLS_Game.Padding = new System.Windows.Forms.Padding(3);
            this.RPSLS_Game.Size = new System.Drawing.Size(738, 400);
            this.RPSLS_Game.TabIndex = 0;
            this.RPSLS_Game.Text = "RPSLS Game";
            // 
            // Game_Options
            // 
            this.Game_Options.BackColor = System.Drawing.Color.SteelBlue;
            this.Game_Options.Controls.Add(this.numMaxScore);
            this.Game_Options.Controls.Add(this.label4);
            this.Game_Options.Location = new System.Drawing.Point(4, 24);
            this.Game_Options.Name = "Game_Options";
            this.Game_Options.Padding = new System.Windows.Forms.Padding(3);
            this.Game_Options.Size = new System.Drawing.Size(738, 400);
            this.Game_Options.TabIndex = 1;
            this.Game_Options.Text = "Options";
            // 
            // numMaxScore
            // 
            this.numMaxScore.Location = new System.Drawing.Point(116, 25);
            this.numMaxScore.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numMaxScore.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numMaxScore.Name = "numMaxScore";
            this.numMaxScore.Size = new System.Drawing.Size(120, 23);
            this.numMaxScore.TabIndex = 1;
            this.numMaxScore.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Max Score";
            // 
            // RPSLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(746, 429);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "RPSLS";
            this.Text = "RPSLS";
            this.tabControl1.ResumeLayout(false);
            this.RPSLS_Game.ResumeLayout(false);
            this.RPSLS_Game.PerformLayout();
            this.Game_Options.ResumeLayout(false);
            this.Game_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Button btnLizard;
        private Button btnSpock;
        private Label label1;
        private Label lblWin;
        private Label label2;
        private Label label3;
        private Label lblPlayerScoreCount;
        private Label lblComputerScoreCount;
        private Button btnReset;
        private TabControl tabControl1;
        private TabPage RPSLS_Game;
        private TabPage Game_Options;
        private NumericUpDown numMaxScore;
        private Label label4;
    }
}