using Microsoft.VisualBasic.Devices;
using System.Media;

namespace RockPaperScissorsLizardSpock
{
    public partial class RPSLS : Form
    {
        Random computer = new Random();
        int playerScore = 0;
        int computerScore = 0;
       
        public RPSLS()
        {
            InitializeComponent();
        }


        protected void btnRock_Click(object sender, EventArgs e)
        {
            
            WinConditions(HandSign.Rock);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            
            WinConditions(HandSign.Paper);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            
            WinConditions(HandSign.Scissors);
        }

        private void btnLizard_Click(object sender, EventArgs e)
        {
           
            WinConditions(HandSign.Lizard);
        }

        private void btnSpock_Click(object sender, EventArgs e)
        {
            
            WinConditions(HandSign.Spock);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblWin.Visible = false ;
            playerScore = 0;
            computerScore = 0;
            lblPlayerScoreCount.ResetText();
            lblComputerScoreCount.ResetText();
        }

        //private void ScoreKeeping()
        //{
        //    var lblComputerScoreCount++;
        //}
        
        public void WinConditions(HandSign handSign)
        {
            HandSign computerChoice = (HandSign)computer.Next(0, 5);
            lblWin.Visible = false;
            lblPlayerScoreCount.Visible = true;
            lblComputerScoreCount.Visible = true;


            if (handSign == HandSign.Rock)
            {
                switch (computerChoice)
                {
                    //Rock
                    case HandSign.Rock:
                        lblWin.Text = "You both chose Rock, Draw.";
                        lblWin.Visible = true;
                        break;
                    //Paper
                    case HandSign.Paper:
                        lblWin.Text = "Paper Covers Rock, You Lose!";
                        ++computerScore;
                        lblWin.Visible = true;
                        break;
                    //Scissor
                    case HandSign.Scissors:
                        lblWin.Text = "Rock Crushes Scissors, You Win!";
                        ++playerScore;
                        lblWin.Visible = true;
                        break;
                    //Lizard
                    case HandSign.Lizard:
                        lblWin.Text = "Rock Crushes Lizard, You Win!";
                        ++playerScore;
                        lblWin.Visible = true;
                        break;
                    //Spock
                    case HandSign.Spock:
                        lblWin.Text = "Spock Vaporizes Rock, You Lose!";
                        ++computerScore;
                        lblWin.Visible = true;
                        break;
                    default:
                        break;
                }
                lblComputerScoreCount.Text = computerScore.ToString();
                lblPlayerScoreCount.Text = playerScore.ToString();
            }

            if (handSign == HandSign.Paper)
            {
                switch (computerChoice)
                {
                    //Rock
                    case HandSign.Rock:
                        lblWin.Text = "Paper Covers Rock, You Win!";
                        ++playerScore;
                        lblWin.Visible = true;
                        break;
                    //Paper
                    case HandSign.Paper:
                        lblWin.Text = "You both Chose Paper, Draw.";
                        lblWin.Visible = true;
                        break;
                    //Scissor
                    case HandSign.Scissors:
                        lblWin.Text = "Scissors cut paper, You Lose!";
                        ++computerScore;
                        lblWin.Visible = true;
                        break;
                    //Lizard
                    case HandSign.Lizard:
                        lblWin.Text = "Lizard eats paper, You Lose!";
                        ++computerScore;
                        lblWin.Visible = true;
                        break;
                    //Spock
                    case HandSign.Spock:
                        lblWin.Text = "Paper disproves Spock, You Win!";
                        ++playerScore;
                        lblWin.Visible = true;
                        break;
                }
                lblComputerScoreCount.Text = computerScore.ToString();
                lblPlayerScoreCount.Text = playerScore.ToString();
            }

            if (handSign == HandSign.Scissors)
            {
                switch (computerChoice)
                {
                    //Rock
                    case HandSign.Rock:
                        lblWin.Text = "Rock crushes scissors, You Lose!";
                        ++computerScore;
                        lblWin.Visible = true;
                        break;
                    //Paper
                    case HandSign.Paper:
                        lblWin.Text = "Scissors cut paper, You Win!";
                        ++playerScore;
                        lblWin.Visible = true;
                        break;
                    //Scissor
                    case HandSign.Scissors:
                        lblWin.Text = "You both chose scissors, Draw.";
                        lblWin.Visible = true;
                        break;
                    //Lizard
                    case HandSign.Lizard:
                        lblWin.Text = "Scissors decapitate lizard, You Win!";
                        ++playerScore;
                        lblWin.Visible = true;
                        break;
                    //Spock
                    case HandSign.Spock:
                        lblWin.Text = "Spock smashes Scissors, You Lose!";
                        ++computerScore;
                        lblWin.Visible = true;
                        break;
                    default:
                        break;
                }
                lblComputerScoreCount.Text = computerScore.ToString();
                lblPlayerScoreCount.Text = playerScore.ToString();
            }

            if (handSign == HandSign.Lizard)
            {
                switch (computerChoice)
                {
                    //Rock
                    case HandSign.Rock:
                        lblWin.Text = "Rock smashes lizard, You Lose!";
                        ++computerScore;
                        lblWin.Visible = true;
                        break;
                    //Paper
                    case HandSign.Paper:
                        lblWin.Text = "Lizard eats paper, You Win!";
                        ++playerScore;
                        lblWin.Visible = true;
                        break;
                    //Scissor
                    case HandSign.Scissors:
                        lblWin.Text = "Scissors decapitate lizard, You Lose!";
                        ++computerScore;
                        lblWin.Visible = true;
                        break;
                    //Lizard
                    case HandSign.Lizard:
                        lblWin.Text = "You both chose lizard, Draw.";
                        lblWin.Visible = true;
                        break;
                    //Spock
                    case HandSign.Spock:
                        lblWin.Text = "Lizard poisons Spock, You Win!";
                        ++playerScore;
                        lblWin.Visible = true;
                        break;
                }
                lblComputerScoreCount.Text = computerScore.ToString();
                lblPlayerScoreCount.Text = playerScore.ToString();
            }

            if (handSign == HandSign.Spock)
            {
                switch (computerChoice)
                {
                    //Rock
                    case HandSign.Rock:
                        lblWin.Text = "Spock Vaporizes rock, You Win!";
                        ++playerScore;
                        lblWin.Visible = true;
                        break;
                    //Paper
                    case HandSign.Paper:
                        lblWin.Text = "Paper disproves Spock, You Lose!";
                        ++computerScore;
                        lblWin.Visible = true;
                        break;
                    //Scissor
                    case HandSign.Scissors:
                        lblWin.Text = "Spock smashes scissors, You Win!";
                        ++playerScore;
                        lblWin.Visible = true;
                        break;
                    //Lizard
                    case HandSign.Lizard:
                        lblWin.Text = "Lizard poisons Spock, You Lose";
                        ++computerScore;
                        lblWin.Visible = true;
                        break;
                    //Spock
                    case HandSign.Spock:
                        lblWin.Text = "You both chose Spock, Draw.";
                        lblWin.Visible = true;
                        break;
                }
                lblComputerScoreCount.Text = computerScore.ToString();
                lblPlayerScoreCount.Text = playerScore.ToString();
            }
        }
    }
}