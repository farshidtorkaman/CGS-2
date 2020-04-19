namespace ArtGalleryWin
{
    partial class SellPieceForm
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
            this.PricePaid = new System.Windows.Forms.TextBox();
            this.SellPieceId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SellPieceButton = new System.Windows.Forms.Button();
            this.CancelSellPiece = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PricePaid
            // 
            this.PricePaid.Location = new System.Drawing.Point(112, 150);
            this.PricePaid.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PricePaid.Name = "PricePaid";
            this.PricePaid.Size = new System.Drawing.Size(225, 27);
            this.PricePaid.TabIndex = 1;
            // 
            // SellPieceId
            // 
            this.SellPieceId.Location = new System.Drawing.Point(112, 102);
            this.SellPieceId.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SellPieceId.Name = "SellPieceId";
            this.SellPieceId.Size = new System.Drawing.Size(225, 27);
            this.SellPieceId.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Piece ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Price Paid:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sell Piece";
            // 
            // SellPieceButton
            // 
            this.SellPieceButton.Location = new System.Drawing.Point(112, 219);
            this.SellPieceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SellPieceButton.Name = "SellPieceButton";
            this.SellPieceButton.Size = new System.Drawing.Size(116, 31);
            this.SellPieceButton.TabIndex = 2;
            this.SellPieceButton.Text = "Submit";
            this.SellPieceButton.UseVisualStyleBackColor = true;
            this.SellPieceButton.Click += new System.EventHandler(this.SellPieceButton_Click);
            // 
            // CancelSellPiece
            // 
            this.CancelSellPiece.Location = new System.Drawing.Point(254, 219);
            this.CancelSellPiece.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelSellPiece.Name = "CancelSellPiece";
            this.CancelSellPiece.Size = new System.Drawing.Size(116, 31);
            this.CancelSellPiece.TabIndex = 3;
            this.CancelSellPiece.Text = "Cancel";
            this.CancelSellPiece.UseVisualStyleBackColor = true;
            this.CancelSellPiece.Click += new System.EventHandler(this.CancelSellPiece_Click);
            // 
            // SellPieceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 285);
            this.Controls.Add(this.CancelSellPiece);
            this.Controls.Add(this.SellPieceButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PricePaid);
            this.Controls.Add(this.SellPieceId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SellPieceForm";
            this.Text = "SellPieceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PricePaid;
        private System.Windows.Forms.TextBox SellPieceId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SellPieceButton;
        private System.Windows.Forms.Button CancelSellPiece;
    }
}