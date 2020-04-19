using System;
using System.Windows.Forms;
using CGS;

namespace ArtGalleryWin
{
    public partial class SellPieceForm : Form
    {
        private readonly Gallery _gallery = new Gallery();
        public SellPieceForm()
        {
            InitializeComponent();
        }

        private void SellPieceButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SellPieceId.Text) || string.IsNullOrWhiteSpace(PricePaid.Text))
            {
                MessageBox.Show("Both Fields are Required");
                return;
            }

            var result = double.TryParse(PricePaid.Text, out var pricePaid);
            if (!result)
            {
                MessageBox.Show("Enter Valid Price Paid");
                return;
            }

            var sellResult = _gallery.SellPiece(SellPieceId.Text, pricePaid);
            if (sellResult)
            {
                MessageBox.Show("Piece Sold Successfully");
                Close();
            }
            else
            {
                MessageBox.Show("Piece Not Found!");
            }
        }

        private void CancelSellPiece_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
