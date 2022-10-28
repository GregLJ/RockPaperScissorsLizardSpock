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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lblWin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayerScoreCount = new System.Windows.Forms.Label();
            this.lblComputerScoreCount = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.White;
            this.btnRock.Location = new System.Drawing.Point(316, 91);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 23);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(316, 120);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 23);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(316, 149);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(75, 23);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnLizard
            // 
            this.btnLizard.Location = new System.Drawing.Point(316, 178);
            this.btnLizard.Name = "btnLizard";
            this.btnLizard.Size = new System.Drawing.Size(75, 23);
            this.btnLizard.TabIndex = 3;
            this.btnLizard.Text = "Lizard";
            this.btnLizard.UseVisualStyleBackColor = true;
            this.btnLizard.Click += new System.EventHandler(this.btnLizard_Click);
            // 
            // btnSpock
            // 
            this.btnSpock.Location = new System.Drawing.Point(316, 207);
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
            this.label1.Location = new System.Drawing.Point(114, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rock, Paper, Scissors, Lizard, Spock";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Elephant", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWin.Location = new System.Drawing.Point(73, 310);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(598, 47);
            this.lblWin.TabIndex = 6;
            this.lblWin.Text = "Rock Crushes Lizard You Win!";
            this.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWin.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player Score:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Computer  Score:";
            this.label3.Visible = false;
            // 
            // lblPlayerScoreCount
            // 
            this.lblPlayerScoreCount.AutoSize = true;
            this.lblPlayerScoreCount.Location = new System.Drawing.Point(585, 88);
            this.lblPlayerScoreCount.Name = "lblPlayerScoreCount";
            this.lblPlayerScoreCount.Size = new System.Drawing.Size(13, 15);
            this.lblPlayerScoreCount.TabIndex = 9;
            this.lblPlayerScoreCount.Text = "0";
            this.lblPlayerScoreCount.Visible = false;
            // 
            // lblComputerScoreCount
            // 
            this.lblComputerScoreCount.AutoSize = true;
            this.lblComputerScoreCount.Location = new System.Drawing.Point(585, 120);
            this.lblComputerScoreCount.Name = "lblComputerScoreCount";
            this.lblComputerScoreCount.Size = new System.Drawing.Size(13, 15);
            this.lblComputerScoreCount.TabIndex = 10;
            this.lblComputerScoreCount.Text = "0";
            this.lblComputerScoreCount.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(21, 43);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // RPSLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblComputerScoreCount);
            this.Controls.Add(this.lblPlayerScoreCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpock);
            this.Controls.Add(this.btnLizard);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.DoubleBuffered = true;
            this.Name = "RPSLS";
            this.Text = "RPSLS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Button btnLizard;
        private Button btnSpock;
        private Label label1;
        private PrintDialog printDialog1;
        private Label lblWin;
        private Label label2;
        private Label label3;
        private Label lblPlayerScoreCount;
        private Label lblComputerScoreCount;
        private Button btnReset;
    }
}