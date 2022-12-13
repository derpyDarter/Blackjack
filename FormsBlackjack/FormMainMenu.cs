using Blackjack;
namespace FormsBlackjack
{
    public partial class FormMainMenu : Form
    {

        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please enter your name.");
            }
            else
            {
                ShowGameAtTable();
            }
        }

        private void ShowGameAtTable()
        {
            int numPlayers = Convert.ToInt32(numericUpDownPlayers.Value);
            int numDecks = Convert.ToInt32(numericUpDownDecks.Value);
            int minBet = Convert.ToInt32(numericUpDownMinBet.Value);
            int maxBet = Convert.ToInt32(numericUpDownMaxBet.Value);
            decimal playerBankroll = numericUpDownPlayerBankroll.Value;
            decimal dealerBankroll = numericUpDownDealerBankroll.Value;

            var table = new Table(numPlayers, numDecks, minBet, maxBet, textBoxName.Text, playerBankroll, dealerBankroll);

            var gameMenu = new GameMenu(table);
            gameMenu.Show();
        }
    }
}