namespace CharlieQuartet
{
    partial class CardGameForm
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
            this.currentcardlabel = new System.Windows.Forms.Label();
            this.balancelabel = new System.Windows.Forms.Label();
            this.betamountlabel = new System.Windows.Forms.Label();
            this.cardpointslabel = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.betbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.hitbutton = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Label();
            this.betamount = new System.Windows.Forms.Label();
            this.cardpoints = new System.Windows.Forms.Label();
            this.currentcard = new System.Windows.Forms.Label();
            this.card1 = new System.Windows.Forms.Label();
            this.card2 = new System.Windows.Forms.Label();
            this.card3 = new System.Windows.Forms.Label();
            this.card4 = new System.Windows.Forms.Label();
            this.card5 = new System.Windows.Forms.Label();
            this.card6 = new System.Windows.Forms.Label();
            this.card7 = new System.Windows.Forms.Label();
            this.card8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentcardlabel
            // 
            this.currentcardlabel.AutoSize = true;
            this.currentcardlabel.Location = new System.Drawing.Point(45, 80);
            this.currentcardlabel.Name = "currentcardlabel";
            this.currentcardlabel.Size = new System.Drawing.Size(68, 13);
            this.currentcardlabel.TabIndex = 0;
            this.currentcardlabel.Text = "Current card:";
            // 
            // balancelabel
            // 
            this.balancelabel.AutoSize = true;
            this.balancelabel.Location = new System.Drawing.Point(453, 80);
            this.balancelabel.Name = "balancelabel";
            this.balancelabel.Size = new System.Drawing.Size(49, 13);
            this.balancelabel.TabIndex = 1;
            this.balancelabel.Text = "Balance:";
            // 
            // betamountlabel
            // 
            this.betamountlabel.AutoSize = true;
            this.betamountlabel.Location = new System.Drawing.Point(261, 80);
            this.betamountlabel.Name = "betamountlabel";
            this.betamountlabel.Size = new System.Drawing.Size(64, 13);
            this.betamountlabel.TabIndex = 2;
            this.betamountlabel.Text = "Bet amount:";
            // 
            // cardpointslabel
            // 
            this.cardpointslabel.AutoSize = true;
            this.cardpointslabel.Location = new System.Drawing.Point(638, 80);
            this.cardpointslabel.Name = "cardpointslabel";
            this.cardpointslabel.Size = new System.Drawing.Size(63, 13);
            this.cardpointslabel.TabIndex = 3;
            this.cardpointslabel.Text = "Card points:";
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(48, 150);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(125, 100);
            this.startbutton.TabIndex = 4;
            this.startbutton.Text = "START (disable when game is in progress)";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // betbutton
            // 
            this.betbutton.Location = new System.Drawing.Point(264, 150);
            this.betbutton.Name = "betbutton";
            this.betbutton.Size = new System.Drawing.Size(125, 100);
            this.betbutton.TabIndex = 5;
            this.betbutton.Text = "BET";
            this.betbutton.UseVisualStyleBackColor = true;
            // 
            // stopbutton
            // 
            this.stopbutton.Location = new System.Drawing.Point(641, 150);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(125, 100);
            this.stopbutton.TabIndex = 6;
            this.stopbutton.Text = "STOP";
            this.stopbutton.UseVisualStyleBackColor = true;
            // 
            // hitbutton
            // 
            this.hitbutton.Location = new System.Drawing.Point(456, 150);
            this.hitbutton.Name = "hitbutton";
            this.hitbutton.Size = new System.Drawing.Size(125, 100);
            this.hitbutton.TabIndex = 7;
            this.hitbutton.Text = "HIT";
            this.hitbutton.UseVisualStyleBackColor = true;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(508, 80);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(56, 13);
            this.balance.TabIndex = 8;
            this.balance.Text = "BALANCE";
            // 
            // betamount
            // 
            this.betamount.AutoSize = true;
            this.betamount.Location = new System.Drawing.Point(331, 80);
            this.betamount.Name = "betamount";
            this.betamount.Size = new System.Drawing.Size(78, 13);
            this.betamount.TabIndex = 9;
            this.betamount.Text = "BET AMOUNT";
            // 
            // cardpoints
            // 
            this.cardpoints.AutoSize = true;
            this.cardpoints.Location = new System.Drawing.Point(707, 80);
            this.cardpoints.Name = "cardpoints";
            this.cardpoints.Size = new System.Drawing.Size(80, 13);
            this.cardpoints.TabIndex = 10;
            this.cardpoints.Text = "CARD POINTS";
            // 
            // currentcard
            // 
            this.currentcard.AutoSize = true;
            this.currentcard.Location = new System.Drawing.Point(119, 80);
            this.currentcard.Name = "currentcard";
            this.currentcard.Size = new System.Drawing.Size(93, 13);
            this.currentcard.TabIndex = 11;
            this.currentcard.Text = "CURRENT CARD";
            // 
            // card1
            // 
            this.card1.AutoSize = true;
            this.card1.Location = new System.Drawing.Point(45, 349);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(46, 13);
            this.card1.TabIndex = 12;
            this.card1.Text = "CARD 1";
            // 
            // card2
            // 
            this.card2.AutoSize = true;
            this.card2.Location = new System.Drawing.Point(127, 349);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(46, 13);
            this.card2.TabIndex = 13;
            this.card2.Text = "CARD 2";
            // 
            // card3
            // 
            this.card3.AutoSize = true;
            this.card3.Location = new System.Drawing.Point(264, 348);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(46, 13);
            this.card3.TabIndex = 14;
            this.card3.Text = "CARD 3";
            // 
            // card4
            // 
            this.card4.AutoSize = true;
            this.card4.Location = new System.Drawing.Point(347, 347);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(46, 13);
            this.card4.TabIndex = 15;
            this.card4.Text = "CARD 4";
            // 
            // card5
            // 
            this.card5.AutoSize = true;
            this.card5.Location = new System.Drawing.Point(456, 349);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(46, 13);
            this.card5.TabIndex = 16;
            this.card5.Text = "CARD 5";
            // 
            // card6
            // 
            this.card6.AutoSize = true;
            this.card6.Location = new System.Drawing.Point(539, 349);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(46, 13);
            this.card6.TabIndex = 17;
            this.card6.Text = "CARD 6";
            // 
            // card7
            // 
            this.card7.AutoSize = true;
            this.card7.Location = new System.Drawing.Point(641, 349);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(46, 13);
            this.card7.TabIndex = 18;
            this.card7.Text = "CARD 7";
            // 
            // card8
            // 
            this.card8.AutoSize = true;
            this.card8.Location = new System.Drawing.Point(724, 349);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(46, 13);
            this.card8.TabIndex = 19;
            this.card8.Text = "CARD 8";
            // 
            // CardGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 507);
            this.Controls.Add(this.card8);
            this.Controls.Add(this.card7);
            this.Controls.Add(this.card6);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.currentcard);
            this.Controls.Add(this.cardpoints);
            this.Controls.Add(this.betamount);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.hitbutton);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.betbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.cardpointslabel);
            this.Controls.Add(this.betamountlabel);
            this.Controls.Add(this.balancelabel);
            this.Controls.Add(this.currentcardlabel);
            this.Name = "CardGameForm";
            this.Text = "CardGameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentcardlabel;
        private System.Windows.Forms.Label balancelabel;
        private System.Windows.Forms.Label betamountlabel;
        private System.Windows.Forms.Label cardpointslabel;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button betbutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Button hitbutton;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label betamount;
        private System.Windows.Forms.Label cardpoints;
        private System.Windows.Forms.Label currentcard;
        private System.Windows.Forms.Label card1;
        private System.Windows.Forms.Label card2;
        private System.Windows.Forms.Label card3;
        private System.Windows.Forms.Label card4;
        private System.Windows.Forms.Label card5;
        private System.Windows.Forms.Label card6;
        private System.Windows.Forms.Label card7;
        private System.Windows.Forms.Label card8;
    }
}