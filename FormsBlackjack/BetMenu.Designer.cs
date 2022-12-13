namespace FormsBlackjack
{
    partial class BetMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelBankroll = new System.Windows.Forms.Label();
            this.labelBet = new System.Windows.Forms.Label();
            this.numericUpDownBet = new System.Windows.Forms.NumericUpDown();
            this.buttonDeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Bet";
            // 
            // labelBankroll
            // 
            this.labelBankroll.AutoSize = true;
            this.labelBankroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBankroll.Location = new System.Drawing.Point(12, 54);
            this.labelBankroll.Name = "labelBankroll";
            this.labelBankroll.Size = new System.Drawing.Size(71, 23);
            this.labelBankroll.TabIndex = 1;
            this.labelBankroll.Text = "Bankroll";
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBet.Location = new System.Drawing.Point(14, 112);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(35, 23);
            this.labelBet.TabIndex = 2;
            this.labelBet.Text = "Bet";
            // 
            // numericUpDownBet
            // 
            this.numericUpDownBet.Location = new System.Drawing.Point(71, 112);
            this.numericUpDownBet.Name = "numericUpDownBet";
            this.numericUpDownBet.Size = new System.Drawing.Size(117, 27);
            this.numericUpDownBet.TabIndex = 3;
            // 
            // buttonDeal
            // 
            this.buttonDeal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeal.Location = new System.Drawing.Point(57, 162);
            this.buttonDeal.Name = "buttonDeal";
            this.buttonDeal.Size = new System.Drawing.Size(111, 50);
            this.buttonDeal.TabIndex = 4;
            this.buttonDeal.Text = "Deal";
            this.buttonDeal.UseVisualStyleBackColor = true;
            this.buttonDeal.Click += new System.EventHandler(this.buttonDeal_Click);
            // 
            // BetMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 224);
            this.Controls.Add(this.buttonDeal);
            this.Controls.Add(this.numericUpDownBet);
            this.Controls.Add(this.labelBet);
            this.Controls.Add(this.labelBankroll);
            this.Controls.Add(this.label1);
            this.Name = "BetMenu";
            this.Text = "BetMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BetMenu_FormClosing);
            this.Load += new System.EventHandler(this.BetMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelBankroll;
        private Label labelBet;
        private NumericUpDown numericUpDownBet;
        private Button buttonDeal;
    }
}