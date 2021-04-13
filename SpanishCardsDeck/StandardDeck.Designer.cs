namespace SpanishCardsDeck
{
    partial class StandardDeck
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
            this.lblCardscount = new System.Windows.Forms.Label();
            this.pnlCardsCount = new System.Windows.Forms.Panel();
            this.lblSticksCount = new System.Windows.Forms.Label();
            this.lblCupsCount = new System.Windows.Forms.Label();
            this.lblSwordsCount = new System.Windows.Forms.Label();
            this.lblCoinscount = new System.Windows.Forms.Label();
            this.lstcardsontable = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnTakeCards = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstRemovedcards = new System.Windows.Forms.ListBox();
            this.lblcardsontablecount = new System.Windows.Forms.Label();
            this.lblRemovedcount = new System.Windows.Forms.Label();
            this.btnReturnallcards = new System.Windows.Forms.Button();
            this.pnlCardsCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCardscount
            // 
            this.lblCardscount.AutoSize = true;
            this.lblCardscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardscount.Location = new System.Drawing.Point(21, 46);
            this.lblCardscount.Name = "lblCardscount";
            this.lblCardscount.Size = new System.Drawing.Size(0, 25);
            this.lblCardscount.TabIndex = 0;
            // 
            // pnlCardsCount
            // 
            this.pnlCardsCount.Controls.Add(this.lblSticksCount);
            this.pnlCardsCount.Controls.Add(this.lblCupsCount);
            this.pnlCardsCount.Controls.Add(this.lblSwordsCount);
            this.pnlCardsCount.Controls.Add(this.lblCoinscount);
            this.pnlCardsCount.Controls.Add(this.lblCardscount);
            this.pnlCardsCount.Location = new System.Drawing.Point(81, 13);
            this.pnlCardsCount.Name = "pnlCardsCount";
            this.pnlCardsCount.Size = new System.Drawing.Size(1179, 111);
            this.pnlCardsCount.TabIndex = 1;
            // 
            // lblSticksCount
            // 
            this.lblSticksCount.AutoSize = true;
            this.lblSticksCount.Location = new System.Drawing.Point(737, 65);
            this.lblSticksCount.Name = "lblSticksCount";
            this.lblSticksCount.Size = new System.Drawing.Size(0, 20);
            this.lblSticksCount.TabIndex = 4;
            // 
            // lblCupsCount
            // 
            this.lblCupsCount.AutoSize = true;
            this.lblCupsCount.Location = new System.Drawing.Point(429, 65);
            this.lblCupsCount.Name = "lblCupsCount";
            this.lblCupsCount.Size = new System.Drawing.Size(0, 20);
            this.lblCupsCount.TabIndex = 3;
            // 
            // lblSwordsCount
            // 
            this.lblSwordsCount.AutoSize = true;
            this.lblSwordsCount.Location = new System.Drawing.Point(737, 19);
            this.lblSwordsCount.Name = "lblSwordsCount";
            this.lblSwordsCount.Size = new System.Drawing.Size(0, 20);
            this.lblSwordsCount.TabIndex = 2;
            // 
            // lblCoinscount
            // 
            this.lblCoinscount.AutoSize = true;
            this.lblCoinscount.Location = new System.Drawing.Point(429, 19);
            this.lblCoinscount.Name = "lblCoinscount";
            this.lblCoinscount.Size = new System.Drawing.Size(0, 20);
            this.lblCoinscount.TabIndex = 1;
            // 
            // lstcardsontable
            // 
            this.lstcardsontable.FormattingEnabled = true;
            this.lstcardsontable.ItemHeight = 20;
            this.lstcardsontable.Location = new System.Drawing.Point(27, 207);
            this.lstcardsontable.Name = "lstcardsontable";
            this.lstcardsontable.Size = new System.Drawing.Size(443, 744);
            this.lstcardsontable.TabIndex = 2;
            this.lstcardsontable.SelectedIndexChanged += new System.EventHandler(this.lstcardsontable_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(588, 209);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 45);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Cards";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(588, 300);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(127, 45);
            this.btnShuffle.TabIndex = 4;
            this.btnShuffle.Text = "Shuffle Cards";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnTakeCards
            // 
            this.btnTakeCards.Location = new System.Drawing.Point(588, 389);
            this.btnTakeCards.Name = "btnTakeCards";
            this.btnTakeCards.Size = new System.Drawing.Size(127, 45);
            this.btnTakeCards.TabIndex = 5;
            this.btnTakeCards.Text = "Take Cards";
            this.btnTakeCards.UseVisualStyleBackColor = true;
            this.btnTakeCards.Click += new System.EventHandler(this.btnTakeCards_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(90, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cards on Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(884, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cards Removed from Table";
            // 
            // lstRemovedcards
            // 
            this.lstRemovedcards.FormattingEnabled = true;
            this.lstRemovedcards.ItemHeight = 20;
            this.lstRemovedcards.Location = new System.Drawing.Point(864, 207);
            this.lstRemovedcards.Name = "lstRemovedcards";
            this.lstRemovedcards.Size = new System.Drawing.Size(408, 224);
            this.lstRemovedcards.TabIndex = 8;
            this.lstRemovedcards.SelectedIndexChanged += new System.EventHandler(this.lstRemovedcards_SelectedIndexChanged);
            // 
            // lblcardsontablecount
            // 
            this.lblcardsontablecount.AutoSize = true;
            this.lblcardsontablecount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcardsontablecount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblcardsontablecount.Location = new System.Drawing.Point(334, 168);
            this.lblcardsontablecount.Name = "lblcardsontablecount";
            this.lblcardsontablecount.Size = new System.Drawing.Size(0, 36);
            this.lblcardsontablecount.TabIndex = 10;
            // 
            // lblRemovedcount
            // 
            this.lblRemovedcount.AutoSize = true;
            this.lblRemovedcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemovedcount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRemovedcount.Location = new System.Drawing.Point(1264, 168);
            this.lblRemovedcount.Name = "lblRemovedcount";
            this.lblRemovedcount.Size = new System.Drawing.Size(0, 36);
            this.lblRemovedcount.TabIndex = 11;
            // 
            // btnReturnallcards
            // 
            this.btnReturnallcards.Location = new System.Drawing.Point(985, 471);
            this.btnReturnallcards.Name = "btnReturnallcards";
            this.btnReturnallcards.Size = new System.Drawing.Size(170, 56);
            this.btnReturnallcards.TabIndex = 12;
            this.btnReturnallcards.Text = "Return cards to table original position";
            this.btnReturnallcards.UseVisualStyleBackColor = true;
            this.btnReturnallcards.Click += new System.EventHandler(this.btnReturnallcards_Click);
            // 
            // StandardDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 1050);
            this.Controls.Add(this.btnReturnallcards);
            this.Controls.Add(this.lblRemovedcount);
            this.Controls.Add(this.lblcardsontablecount);
            this.Controls.Add(this.lstRemovedcards);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTakeCards);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lstcardsontable);
            this.Controls.Add(this.pnlCardsCount);
            this.Name = "StandardDeck";
            this.Text = "Spanish playing cards";
            this.Load += new System.EventHandler(this.StandardDeck_Load);
            this.pnlCardsCount.ResumeLayout(false);
            this.pnlCardsCount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardscount;
        private System.Windows.Forms.Panel pnlCardsCount;
        private System.Windows.Forms.Label lblSticksCount;
        private System.Windows.Forms.Label lblCupsCount;
        private System.Windows.Forms.Label lblSwordsCount;
        private System.Windows.Forms.Label lblCoinscount;
        private System.Windows.Forms.ListBox lstcardsontable;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnTakeCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstRemovedcards;
        private System.Windows.Forms.Label lblcardsontablecount;
        private System.Windows.Forms.Label lblRemovedcount;
        private System.Windows.Forms.Button btnReturnallcards;
    }
}

