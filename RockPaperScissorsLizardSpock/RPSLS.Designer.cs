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
            this.lblLose = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
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
            this.lblWin.Location = new System.Drawing.Point(234, 305);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(232, 47);
            this.lblWin.TabIndex = 6;
            this.lblWin.Text = "YOU WIN!";
            this.lblWin.Visible = false;
            this.lblWin.Click += new System.EventHandler(this.lblWin_Click);
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Font = new System.Drawing.Font("Elephant", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLose.Location = new System.Drawing.Point(234, 305);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(257, 47);
            this.lblLose.TabIndex = 7;
            this.lblLose.Text = "YOU LOSE!";
            this.lblLose.Visible = false;
            this.lblLose.Click += new System.EventHandler(this.lblLose_Click);
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Font = new System.Drawing.Font("Elephant", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDraw.Location = new System.Drawing.Point(267, 305);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(173, 47);
            this.lblDraw.TabIndex = 8;
            this.lblDraw.Text = "DRAW!";
            this.lblDraw.Visible = false;
            // 
            // RPSLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.lblLose);
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
        private Label lblLose;
        private Label lblDraw;
    }
}