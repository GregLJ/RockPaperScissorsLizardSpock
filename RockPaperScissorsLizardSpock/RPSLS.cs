using Microsoft.VisualBasic.Devices;
using System.Media;
using System.Windows.Forms;

namespace RockPaperScissorsLizardSpock
{
    public partial class RPSLS : Form
    {
        private readonly Dictionary<HandSign, Dictionary<HandSign, string>> results = new Dictionary<HandSign, Dictionary<HandSign, string>>
        {
            {
                HandSign.Rock, new Dictionary<HandSign, string>
                {
                    { HandSign.Paper, "Paper covers Rock, You Lose!" },
                    { HandSign.Scissors, "Rock crushes Scissors, You Win!" },
                    { HandSign.Lizard, "Rock crushes Lizard, You Win!" },
                    { HandSign.Spock, "Spock vaporizes Rock, You Lose!" }
                }
            },
            {
                HandSign.Paper, new Dictionary<HandSign, string>
                {
                    { HandSign.Rock, "Paper covers Rock, You Win!" },
                    { HandSign.Scissors, "Scissors cuts Paper, You Lose!" },
                    { HandSign.Lizard, "Lizard eats Paper, You Lose!" },
                    { HandSign.Spock, "Paper disproves Spock, You Win!" }
                }
            },
            {
                HandSign.Scissors, new Dictionary<HandSign, string>
                {
                    { HandSign.Paper, "Scissors cuts Paper, You Win!" },
                    { HandSign.Rock, "Rock crushes Scissors, You Lose!" },
                    { HandSign.Lizard, "Scissors decapitates Lizard, You Win!" },
                    { HandSign.Spock, "Spock smashes Scissors, You Lose!" }
                }
            },
            {
                HandSign.Lizard, new Dictionary<HandSign, string>
                {
                    { HandSign.Spock, "Lizard poisons Spock, You Win!" },
                    { HandSign.Paper, "Lizard eats Paper, You Win!" },
                    { HandSign.Scissors, "Scissors decapitates Lizard, You Lose!" },
                    { HandSign.Rock, "Rock crushes Lizard, You Lose!" }
                }
            },
            {
                HandSign.Spock, new Dictionary<HandSign, string>
                {
                    { HandSign.Scissors, "Spock smashes Scissors, You Win!"},
                    { HandSign.Rock, "Spock vaporizes Rock, You Win!"},
                    { HandSign.Lizard, "Lizard poisons Spock, You Lose!"},
                    { HandSign.Paper, "Paper disproves Spock, You Lose!"}
                }
            }
        };

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
            GameReset();
        }

        private void GameReset()
        {
            lblWin.Visible = false;
            playerScore = 0;
            computerScore = 0;
            lblPlayerScoreCount.ResetText();
            lblComputerScoreCount.ResetText();
        }


        int playerScore = 0;
        int computerScore = 0;

        private void DisplayWinLoseMessage()
        {
            if (computerScore == Convert.ToInt32(numMaxScore.Value))
            {
                lblWin.Text = $"Computer Wins! Better luck next time! Your Score: {playerScore} Computer Score: {computerScore}";
                lblWin.Visible = true;
                MessageBox.Show(lblWin.Text);
                GameReset();
            }
            else if (playerScore == Convert.ToInt32(numMaxScore.Value))
            {
                lblWin.Text = $"You Win! Your Score: {playerScore} Computer Score: {computerScore}";
                lblWin.Visible = true;
                MessageBox.Show(lblWin.Text);
                GameReset();
            }
        }
        public void WinConditions(HandSign handSign)
        {
            Random computer = new Random();
            HandSign computerChoice = (HandSign)computer.Next(0, 5);
            lblWin.Visible = false;
            lblPlayerScoreCount.Visible = true;
            lblComputerScoreCount.Visible = true;

            HandSign playerSign = handSign;
            HandSign computerSign = computerChoice;
            string message = "";

            if (playerSign == computerSign)
            {
                message = "Draw";
            }
            else
            {
                message = results[playerSign][computerSign];
            }

            lblWin.Text = message;
            lblWin.Visible = true;

            if (message == "Draw")
            {
                // Do nothing
            }
            else if (message.Contains("Win"))
            {
                playerScore++;
                lblPlayerScoreCount.Text = playerScore.ToString();
            }
            else if (message.Contains("Lose"))
            {
                computerScore++;
                lblComputerScoreCount.Text = computerScore.ToString();
            }

            DisplayWinLoseMessage();
        }
    }
}