namespace FormsBlackjack
{
    partial class FormMainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.numericUpDownPlayers = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownDecks = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMinBet = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownMaxBet = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownPlayerBankroll = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownDealerBankroll = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDecks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayerBankroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDealerBankroll)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(401, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blackjack";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(33, 121);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(190, 27);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(34, 99);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(93, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Player Name";
            // 
            // numericUpDownPlayers
            // 
            this.numericUpDownPlayers.Location = new System.Drawing.Point(247, 122);
            this.numericUpDownPlayers.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPlayers.Name = "numericUpDownPlayers";
            this.numericUpDownPlayers.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownPlayers.TabIndex = 3;
            this.numericUpDownPlayers.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number Of Players";
            // 
            // numericUpDownDecks
            // 
            this.numericUpDownDecks.Location = new System.Drawing.Point(424, 121);
            this.numericUpDownDecks.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownDecks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDecks.Name = "numericUpDownDecks";
            this.numericUpDownDecks.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownDecks.TabIndex = 5;
            this.numericUpDownDecks.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of Decks";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Lime;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(589, 165);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(314, 57);
            this.buttonStart.TabIndex = 15;
            this.buttonStart.Text = "Start Game";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minimum Bet";
            // 
            // numericUpDownMinBet
            // 
            this.numericUpDownMinBet.Location = new System.Drawing.Point(589, 121);
            this.numericUpDownMinBet.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownMinBet.Name = "numericUpDownMinBet";
            this.numericUpDownMinBet.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownMinBet.TabIndex = 7;
            this.numericUpDownMinBet.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(752, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Maximum Bet";
            // 
            // numericUpDownMaxBet
            // 
            this.numericUpDownMaxBet.Location = new System.Drawing.Point(753, 123);
            this.numericUpDownMaxBet.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownMaxBet.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMaxBet.Name = "numericUpDownMaxBet";
            this.numericUpDownMaxBet.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownMaxBet.TabIndex = 8;
            this.numericUpDownMaxBet.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Player Bankroll";
            // 
            // numericUpDownPlayerBankroll
            // 
            this.numericUpDownPlayerBankroll.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPlayerBankroll.Location = new System.Drawing.Point(247, 190);
            this.numericUpDownPlayerBankroll.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownPlayerBankroll.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPlayerBankroll.Name = "numericUpDownPlayerBankroll";
            this.numericUpDownPlayerBankroll.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownPlayerBankroll.TabIndex = 12;
            this.numericUpDownPlayerBankroll.ThousandsSeparator = true;
            this.numericUpDownPlayerBankroll.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Dealer Bankroll";
            // 
            // numericUpDownDealerBankroll
            // 
            this.numericUpDownDealerBankroll.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDealerBankroll.Location = new System.Drawing.Point(423, 190);
            this.numericUpDownDealerBankroll.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDownDealerBankroll.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownDealerBankroll.Name = "numericUpDownDealerBankroll";
            this.numericUpDownDealerBankroll.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownDealerBankroll.TabIndex = 14;
            this.numericUpDownDealerBankroll.ThousandsSeparator = true;
            this.numericUpDownDealerBankroll.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 261);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownDealerBankroll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownPlayerBankroll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownMaxBet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownMinBet);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownDecks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownPlayers);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "FormMainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDecks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayerBankroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDealerBankroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private Label labelName;
        private NumericUpDown numericUpDownPlayers;
        private Label label2;
        private NumericUpDown numericUpDownDecks;
        private Label label3;
        private Button buttonStart;
        private Label label4;
        private NumericUpDown numericUpDownMinBet;
        private Label label5;
        private NumericUpDown numericUpDownMaxBet;
        private Label label6;
        private NumericUpDown numericUpDownPlayerBankroll;
        private Label label7;
        private NumericUpDown numericUpDownDealerBankroll;
    }
}