using System.Media;

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
            int computerChoice = computer.Next(1,6);
            lblWin.Visible = false;

            if (btnRock.Enabled)
            {
                switch (computerChoice)
                {
                    //Rock
                    case 1:
                        lblWin.Text = "You both chose Rock, Draw.";
                        lblWin.Visible = true;
                        break;
                    //Paper
                    case 2:
                        lblWin.Text = "Paper Covers Rock, You Lose!";
                        lblWin.Visible = true;
                        break;
                    //Scissor
                    case 3:
                        lblWin.Text = "Rock Crushes Scissors, You Win!";
                           lblWin.Visible = true;
                        break;
                    //Lizard
                    case 4:
                        lblWin.Text = "Rock Crushes Lizard, You Win!";
                        lblWin.Visible = true;
                        break;
                    //Spock
                    case 5:
                        lblWin.Text = "Spock Vaporizes Rock, You Lose!";
                        lblWin.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            int computerChoice = computer.Next(1, 6);
            lblWin.Visible = false;

            if (btnRock.Enabled)
            {
                switch (computerChoice)
                {
                    //Rock
                    case 1:
                        lblWin.Text = "Paper Covers Rock, You Win!";
                        lblWin.Visible = true;
                        break;
                    //Paper
                    case 2:
                        lblWin.Text = "You both Chose Paper, Draw.";
                        lblWin.Visible = true;
                        break;
                    //Scissor
                    case 3:
                        lblWin.Text = "Scissors cut paper, You Lose!";
                        lblWin.Visible = true;
                        break;
                    //Lizard
                    case 4:
                        lblWin.Text = "Lizard eats paper, You Lose!";
                        lblWin.Visible = true;
                        break;
                    //Spock
                    case 5:
                        lblWin.Text = "Paper disproves Spock, You Win!";
                        lblWin.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            int computerChoice = computer.Next(1, 6);
            lblWin.Visible = false;

            if (btnRock.Enabled)
            {
                switch (computerChoice)
                {
                    //Rock
                    case 1:
                        lblWin.Text = "Rock crushes scissors, You Lose!";
                        lblWin.Visible = true;
                        break;
                    //Paper
                    case 2:
                        lblWin.Text = "Scissors cut paper, You Win!";
                        lblWin.Visible = true;
                        break;
                    //Scissor
                    case 3:
                        lblWin.Text = "You both chose scissors, Draw.";
                        lblWin.Visible = true;
                        break;
                    //Lizard
                    case 4:
                        lblWin.Text = "Scissors decapitate lizard, You Win!";
                        lblWin.Visible = true;
                        break;
                    //Spock
                    case 5:
                        lblWin.Text = "Spock smashes Scissors, You Lose!";
                        lblWin.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnLizard_Click(object sender, EventArgs e)
        {
            int computerChoice = computer.Next(1, 6);
            lblWin.Visible = false;

            if (btnRock.Enabled)
            {
                switch (computerChoice)
                {
                    //Rock
                    case 1:
                        lblWin.Text = "Rock smashes lizard, You Lose!";
                        lblWin.Visible = true;
                        break;
                    //Paper
                    case 2:
                        lblWin.Text = "Lizard eats paper, You Win!";
                        lblWin.Visible = true;
                        break;
                    //Scissor
                    case 3:
                        lblWin.Text = "Scissors decapitate lizard, You Lose!";
                        lblWin.Visible = true;
                        break;
                    //Lizard
                    case 4:
                        lblWin.Text = "You both chose lizard, Draw.";
                        lblWin.Visible = true;
                        break;
                    //Spock
                    case 5:
                        lblWin.Text = "Lizard poisons Spock, You Win!";
                        lblWin.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnSpock_Click(object sender, EventArgs e)
        {
            int computerChoice = computer.Next(1, 6);
            lblWin.Visible = false;

            if (btnRock.Enabled)
            {
                switch (computerChoice)
                {
                    //Rock
                    case 1:
                        lblWin.Text = "Spock Vaporizes rock, You Win!";
                        lblWin.Visible = true;
                        break;
                    //Paper
                    case 2:
                        lblWin.Text = "Paper disproves Spock, You Lose!";
                        lblWin.Visible = true;
                        break;
                    //Scissor
                    case 3:
                        lblWin.Text = "Spock smashes scissors, You Win!";
                        lblWin.Visible = true;
                        break;
                    //Lizard
                    case 4:
                        lblWin.Text = "Lizard poisons Spock, You Lose";
                        lblWin.Visible = true;
                        break;
                    //Spock
                    case 5:
                        lblWin.Text = "You both chose Spock, Draw.";
                        lblWin.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblWin.Visible = false ;
        }

        //private void ScoreKeeping()
        //{
        //    var lblComputerScoreCount++;
        //}

    }
}