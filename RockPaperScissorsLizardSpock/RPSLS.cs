namespace RockPaperScissorsLizardSpock
{
    public partial class RPSLS : Form
    {
        public RPSLS()
        {
            InitializeComponent();
        }

        Random computer = new Random();
        
        private void btnRock_Click(object sender, EventArgs e)
        {
            var userName = "Greg";

            int computerChoice = computer.Next(1,5);
            lblDraw.Visible = false;
            lblWin.Visible = false;
            lblLose.Visible = false;
            if (btnRock.Enabled)
            {
                // Switch should return a value that can be compared to userInput
                // and determine win/lose condition if this button is pressed.
                switch (computerChoice)
                {
                    //Rock
                    case 1:
                            lblDraw.Visible = true;
                        break;
                    //Paper
                    case 2:
                            lblLose.Visible = true;
                        break;
                    //Scissor
                    case 3:
                            lblWin.Visible = true;
                        break;
                    //Lizard
                    case 4:
                            lblWin.Visible = true;
                        break;
                    //Spock
                    case 5:
                        lblWin.Visible = true;
                        break;
                    default:
                        break;
                }
            }
            
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {

        }

        private void btnScissors_Click(object sender, EventArgs e)
        {

        }

        private void btnLizard_Click(object sender, EventArgs e)
        {

        }

        private void btnSpock_Click(object sender, EventArgs e)
        {

        }

        private void lblWin_Click(object sender, EventArgs e)
        {

        }

        private void lblLose_Click(object sender, EventArgs e)
        {

        }
    }
}