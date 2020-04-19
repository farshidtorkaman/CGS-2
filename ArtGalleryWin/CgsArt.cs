using CGS;
using System;
using System.Windows.Forms;

namespace ArtGalleryWin
{
    public partial class CgsArt : Form
    {
        private readonly Gallery _gallery = new Gallery();
        public CgsArt()
        {
            InitializeComponent();
        }

        private void SubmitArtistButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(IdTextBox.Text) || string.IsNullOrWhiteSpace(FirstNameTextbox.Text) || 
               string.IsNullOrWhiteSpace(LastNameTextbox.Text))
            {
                MessageBox.Show("All Fields are Required");
                return;
            }

            
            _gallery.AddArtist(FirstNameTextbox.Text, LastNameTextbox.Text, IdTextBox.Text);
            MessageBox.Show("Artist Added Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_gallery.ListArtists());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SubmitArtPieceButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PieceId.Text) || string.IsNullOrWhiteSpace(PieceTitle.Text) ||
                string.IsNullOrWhiteSpace(PieceArtistId.Text))
            {
                MessageBox.Show("Id, Title and Artist Id are Required");
                return;
            }

            var result = double.TryParse(PieceValue.Text, out var estimate);
            if (!result)
            {
                MessageBox.Show("Enter Numeric Value for Piece");
                return;
            }
            
            _gallery.AddPiece(PieceId.Text, PieceTitle.Text, PieceYear.Text, estimate, PieceArtistId.Text, "");
            MessageBox.Show("Piece Added Successfully");
        }

        private void ListPieces_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_gallery.ListPieces());
        }

        private void SellArtPiece_Click(object sender, EventArgs e)
        {
            SellPieceForm sellPiece = new SellPieceForm();
            sellPiece.Show();
            sellPiece.Activate();
        }
    }
}
