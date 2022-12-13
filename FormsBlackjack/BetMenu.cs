using Blackjack;

namespace FormsBlackjack
{
    public partial class BetMenu : Form
    {
        private Player _player { get; set; }
        private int _minBet { get; set; }
        private int _maxBet { get; set; }
        public int Bet { get; set; }
        private decimal _lastBet {  get; set; }
        public BetMenu(Player player, int minBet, int maxBet, decimal lastBet)
        {
            InitializeComponent();
            _player = player;
            _minBet = minBet;
            _maxBet = maxBet;
            _lastBet = lastBet;
        }

        private void BetMenu_Load(object sender, EventArgs e)
        {
            labelBankroll.Text += _player.Bankroll.ToString("c").PadLeft(15);
            numericUpDownBet.Minimum = _minBet;
            numericUpDownBet.Maximum = _maxBet;
            numericUpDownBet.Value = _lastBet;

            if (_player.Bankroll < _maxBet)
            {
                numericUpDownBet.Maximum = _player.Bankroll;
            }
            else
            {
                numericUpDownBet.Maximum = _maxBet;
            }
            
        }

        private void buttonDeal_Click(object sender, EventArgs e)
        {
            PassBetValToGameMenu();
            Close();
        }



        private void BetMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            PassBetValToGameMenu();
        }

        private void PassBetValToGameMenu()
        {
            Bet = Convert.ToInt32(numericUpDownBet.Value);
            DialogResult = DialogResult.OK;
        }

    }
}
