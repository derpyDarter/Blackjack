using Blackjack;

namespace FormsBlackjack
{
    public partial class GameMenu : Form
    {
        private Table _table { get; set; }
        private GameController _controller { get; set; }
        private decimal _lastBet {get;set;}

        public GameMenu(Table table)
        {
            InitializeComponent();
            _table = table;
            _controller = new GameController();
            _lastBet = _table.MinimumBet;
        }

        private void GameMenu_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            if (_table.Players.Any(p => p.PlayerID == 1) && _table.Dealer.Bankroll >(_table.Players.Count() * _table.MaximumBet))
            {
                var userPlayer = _table.Players[0];
                var bettor = new BetController();
                var betMenu = new BetMenu(userPlayer, _table.MinimumBet, _table.MaximumBet, _lastBet);
                DialogResult result = betMenu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    bettor.PlaceBet(userPlayer, betMenu.Bet);
                    _lastBet = userPlayer.Bet; 
                }

                _table = bettor.ExecuteTableAIWagers(_table);
                _table = _controller.InitialDeal(_table);

                var winHdlr = new WinController(_table);
                _table = winHdlr.GetNaturalWinners(_table);

                SetBankBalanceDisplay();
                LoadPlayerGrid();
                ShowDealerCards();

                foreach (Player p in _table.NaturalWinners)
                {
                    p.IsStand = true;
                }
            }
            
        }

        private void SetBankBalanceDisplay()
        {
            labelBankBalance.Text = $"Bank: {_table.Dealer.Bankroll.ToString("c")}";
        }


        private void buttonHit_Click(object sender, EventArgs e)
        {
            _table = _controller.PlayTableRound(_table);
            LoadPlayerGrid();
            var winController = new WinController(_table);
            var player = _table.Players[0];
            player.Score = winController.GetScore(player.Hand, true);
            
            if (player.IsBust || player.Score == 21)
            {
                buttonHit.Enabled = false;
                buttonStand.Enabled = false;
                EndGame();
            }
        }

        private void buttonStand_Click(object sender, EventArgs e)
        {
            _table.Players[0].IsStand = true;
            buttonHit.Enabled = false;
            buttonStand.Enabled = false;
            EndGame();
        }

        private void EndGame()
        {
            _controller.PlayUntilStandOrBust(_table);
            LoadPlayerGrid();
            _controller.PlayDealer(_table);

            var winController = new WinController(_table);
            _table = winController.GetWinners(_table);
            _table = winController.GetLosers(_table);
            _table = winController.GetPushes(_table);

            var bettor = new BetController(); 

            _table = bettor.PayOutWagers(_table);
            _table = bettor.ReturnWagers(_table);
            _table = bettor.CollectWagers(_table);
            



            SetBankBalanceDisplay();
            labelDealer.Text = BuildDealerString();
            LoadPlayerGrid();
            LabelBusts();
            ShowEndMsg();

            var winCtrl = new WinController(_table);
            _table = winCtrl.RemoveBankruptPlayers(_table);

            ClearGameData();
            GameOverMsg();
            WinMsg();
            StartGame();
        }

        private void ShowDealerCards()
        {
            labelDealer.Text += $"    {_table.Dealer.Hand[0].Name}{_table.Dealer.Hand[0].Suit}  XX".PadLeft(6);
        }

        private void ClearGameData()
        {
            _table.NaturalWinners.Clear();
            _table.Winners.Clear();
            _table.Pushers.Clear(); 
            _table.Losers.Clear();

            foreach (Player p in _table.Players)
            {
                p.Hand.Clear();
                p.Score = 0;
                p.IsStand = false;
                p.IsBust = false;
                p.IsNaturalWinner = false;
                p.Bet = 0;
            }


            labelDealer.Text = _table.Dealer.Name;
            labelDealer.BackColor = Color.Transparent;

            _table.Dealer.Hand.Clear();
            _table.Dealer.IsNaturalWinner = false;
            _table.Dealer.IsStand = false;
            _table.Dealer.IsBust = false;
            _table.Dealer.Score = 0;

            dataGridViewPlayers.Rows.Clear();
            buttonHit.Enabled = true;
            buttonStand.Enabled = true;
        }


        private void ShowEndMsg()
        {
            var msg = String.Empty;

            msg += BuildDealerScoreMsg();
            msg += BuildWinMsg();
            msg += BuildLoseMsg();
            msg += BuildPushMsg();
            msg += BuildBankruptPlayersMsg();
            MessageBox.Show(msg);
        }

        private string BuildDealerScoreMsg()
        {
            var msg = String.Empty;
            var winController = new WinController(_table);
            _table.Dealer.Score = winController.GetScore(_table.Dealer.Hand, false);
            msg += $"{_table.Dealer.Name} has a score of {_table.Dealer.Score}\n";
            return msg;
        }

        private string BuildPushMsg()
        {
            var msg = String.Empty;
            if (_table.Pushers.Count > 0)
            {
                foreach (Player w in _table.Pushers)
                {
                    msg += $"{w.Name} pushes with a score of {w.Score}\n";
                }
            }

            return msg;
        }

        private string BuildLoseMsg()
        {
            var msg = String.Empty;
            if (_table.Losers.Count > 0)
            {
                foreach (Player w in _table.Losers)
                {
                    msg += $"{w.Name} loses with a score of {w.Score}\n";
                }
            }

            return msg;
        }

        private string BuildWinMsg()
        {
            var msg = String.Empty;
            if (_table.Winners.Count > 0)
            {
                
                foreach (Player w in _table.Winners)
                {
                    msg += $"{w.Name} wins with a score of {w.Score}\n";
                }
            }

            return msg;
        }

        private void LabelBusts()
        {
            foreach (DataGridViewRow r in dataGridViewPlayers.Rows)
            {
                string playerID = r.Cells[0].Value.ToString();
                var player = _table.Players.FirstOrDefault(c => c.PlayerID.ToString() == playerID);
                if (player != null && player.IsBust)
                {
                    r.Cells[4].Value += "****BUST****".PadLeft(16);
                    r.Cells[4].Style.BackColor = Color.Red;
                }
            }
        }

        private string BuildDealerString()
        {
            var msg = String.Empty;
            msg += _table.Dealer.Name;
            foreach (Card c in _table.Dealer.Hand)
            {
                msg += $"{c.Name.PadLeft(4)}{c.Suit}";
            }

            if (_table.Dealer.IsBust)
            {
                labelDealer.BackColor = Color.Red;
            }

            return msg;
        }

        private void LoadPlayerGrid()
        {
            dataGridViewPlayers.Rows.Clear();
            foreach (Player p in _table.Players)
            {
                string handMsg = GetHandString(p.Hand);
                dataGridViewPlayers.Rows.Add(p.PlayerID, p.Name, p.Bankroll.ToString("c"), p.Bet.ToString("c"), handMsg);
            }
            dataGridViewPlayers.ClearSelection();
        }

        private string GetHandString(List<Card> hand)
        {
            var msg = String.Empty;
            foreach (Card c in hand)
            {
                msg += $"{c.Name}{c.Suit}".PadLeft(4);
            }
            return msg;
        }

        private string BuildBankruptPlayersMsg()
        {
            var bankruptMsg = String.Empty;

            foreach(Player p in _table.Players)
            {
                if (p.Bankroll < _table.MinimumBet)
                {
                    bankruptMsg += $"\n{p.Name} is bankrupt and leaving the table. ";
                }
            }

            return bankruptMsg;

        }

        private void GameOverMsg()
        {
            var gameOverMsg = String.Empty;
            // User player would have been removed by controller already
            // So test must be done by seeing if UserID 1 is still in the collection

            if (!_table.Players.Any(p => p.PlayerID == 1))
            {
                gameOverMsg += "You are bankrupt. \nGAME OVER";
                MessageBox.Show(gameOverMsg);
                Close();
            }

        }

        private void WinMsg()
        {
            
            if (_table.Dealer.Bankroll < (_table.MaximumBet * _table.Players.Count()))
            {
                MessageBox.Show("The dealer does not have enough money to handle the action at this table.\n Congratulations! You win!");
                Close();
            }
        }
    }
}
