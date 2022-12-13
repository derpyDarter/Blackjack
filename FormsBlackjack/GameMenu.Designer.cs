namespace FormsBlackjack
{
    partial class GameMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxPlayers = new System.Windows.Forms.GroupBox();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.PlayerNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bankroll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonHit = new System.Windows.Forms.Button();
            this.buttonStand = new System.Windows.Forms.Button();
            this.labelDealer = new System.Windows.Forms.Label();
            this.labelBankBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPlayers
            // 
            this.groupBoxPlayers.Controls.Add(this.dataGridViewPlayers);
            this.groupBoxPlayers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPlayers.Location = new System.Drawing.Point(12, 111);
            this.groupBoxPlayers.Name = "groupBoxPlayers";
            this.groupBoxPlayers.Size = new System.Drawing.Size(1249, 216);
            this.groupBoxPlayers.TabIndex = 1;
            this.groupBoxPlayers.TabStop = false;
            this.groupBoxPlayers.Text = "Players";
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.AllowUserToAddRows = false;
            this.dataGridViewPlayers.AllowUserToDeleteRows = false;
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerNum,
            this.PlayerName,
            this.Bankroll,
            this.Bet,
            this.Hand});
            this.dataGridViewPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewPlayers.MultiSelect = false;
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.ReadOnly = true;
            this.dataGridViewPlayers.RowHeadersWidth = 51;
            this.dataGridViewPlayers.RowTemplate.Height = 29;
            this.dataGridViewPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(1243, 183);
            this.dataGridViewPlayers.TabIndex = 0;
            this.dataGridViewPlayers.TabStop = false;
            // 
            // PlayerNum
            // 
            this.PlayerNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PlayerNum.Frozen = true;
            this.PlayerNum.HeaderText = "Player #";
            this.PlayerNum.MinimumWidth = 6;
            this.PlayerNum.Name = "PlayerNum";
            this.PlayerNum.ReadOnly = true;
            this.PlayerNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PlayerNum.Width = 111;
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PlayerName.Frozen = true;
            this.PlayerName.HeaderText = "Name";
            this.PlayerName.MinimumWidth = 6;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            this.PlayerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PlayerName.Width = 93;
            // 
            // Bankroll
            // 
            this.Bankroll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Bankroll.Frozen = true;
            this.Bankroll.HeaderText = "Bankroll";
            this.Bankroll.MinimumWidth = 6;
            this.Bankroll.Name = "Bankroll";
            this.Bankroll.ReadOnly = true;
            this.Bankroll.Width = 112;
            // 
            // Bet
            // 
            this.Bet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Bet.Frozen = true;
            this.Bet.HeaderText = "Bet";
            this.Bet.MinimumWidth = 6;
            this.Bet.Name = "Bet";
            this.Bet.ReadOnly = true;
            this.Bet.Width = 69;
            // 
            // Hand
            // 
            this.Hand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Hand.HeaderText = "Hand";
            this.Hand.MinimumWidth = 6;
            this.Hand.Name = "Hand";
            this.Hand.ReadOnly = true;
            this.Hand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // buttonHit
            // 
            this.buttonHit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHit.Location = new System.Drawing.Point(503, 333);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(90, 51);
            this.buttonHit.TabIndex = 2;
            this.buttonHit.Text = "Hit";
            this.buttonHit.UseVisualStyleBackColor = true;
            this.buttonHit.Click += new System.EventHandler(this.buttonHit_Click);
            // 
            // buttonStand
            // 
            this.buttonStand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStand.Location = new System.Drawing.Point(599, 333);
            this.buttonStand.Name = "buttonStand";
            this.buttonStand.Size = new System.Drawing.Size(90, 51);
            this.buttonStand.TabIndex = 3;
            this.buttonStand.Text = "Stand";
            this.buttonStand.UseVisualStyleBackColor = true;
            this.buttonStand.Click += new System.EventHandler(this.buttonStand_Click);
            // 
            // labelDealer
            // 
            this.labelDealer.AutoSize = true;
            this.labelDealer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDealer.Location = new System.Drawing.Point(15, 39);
            this.labelDealer.Name = "labelDealer";
            this.labelDealer.Size = new System.Drawing.Size(83, 32);
            this.labelDealer.TabIndex = 4;
            this.labelDealer.Text = "Dealer";
            // 
            // labelBankBalance
            // 
            this.labelBankBalance.AutoSize = true;
            this.labelBankBalance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBankBalance.Location = new System.Drawing.Point(931, 39);
            this.labelBankBalance.Name = "labelBankBalance";
            this.labelBankBalance.Size = new System.Drawing.Size(155, 32);
            this.labelBankBalance.TabIndex = 5;
            this.labelBankBalance.Text = "Bank Balance";
            this.labelBankBalance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dealer and all AI players stand at 17";
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBankBalance);
            this.Controls.Add(this.labelDealer);
            this.Controls.Add(this.buttonStand);
            this.Controls.Add(this.buttonHit);
            this.Controls.Add(this.groupBoxPlayers);
            this.Name = "GameMenu";
            this.Text = "GameMenu";
            this.Load += new System.EventHandler(this.GameMenu_Load);
            this.groupBoxPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxPlayers;
        private DataGridView dataGridViewPlayers;
        private Button buttonHit;
        private Button buttonStand;
        private Label labelDealer;
        private DataGridViewTextBoxColumn PlayerNum;
        private DataGridViewTextBoxColumn PlayerName;
        private DataGridViewTextBoxColumn Bankroll;
        private DataGridViewTextBoxColumn Bet;
        private DataGridViewTextBoxColumn Hand;
        private Label labelBankBalance;
        private Label label1;
    }
}