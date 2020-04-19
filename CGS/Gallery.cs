using System.Text;

namespace CGS
{
    public class Gallery
    {
        private readonly Pieces _pieces = Pieces.Instance;
        private readonly Artists _artists = Artists.Instance;

        public void AddArtist(string firstName, string lastName, string artistId)
        {
            var artist = new Artist(firstName, lastName, artistId);
            _artists.Add(artist);
        }

        public string ListArtists()
        {
            var artists = new StringBuilder();
            foreach (var item in _artists)
            {
                var artist = (Artist)item;
                artists.Append("Artist Id: " + artist.ArtistId + ", First Name: " + artist.FirstName +
                               ", Last Name: " + artist.LastName + "\n");
                //Console.WriteLine("Artist Id: " + artist.ArtistId + ", First Name: " + artist.FirstName + ", Last Name: " + artist.LastName + "\n");
            }

            return artists.ToString();
        }

        public void AddPiece(string pieceId, string title, string year, double estimate, string artistId, string curatorId)
        {
            var piece = new ArtPiece(pieceId, title, year, estimate, artistId, curatorId);
            _pieces.Add(piece);
        }

        public string ListPieces()
        {
            var pieces = new StringBuilder();
            foreach (var item in _pieces)
            {
                var piece = (ArtPiece)item;
                pieces.Append("Piece Id: " + piece.PieceId +
                              ", Title: " + piece.Title +
                              ", Year: " + piece.Year +
                              ", Price: " + piece.Price +
                              ", Estimate: " + piece.Estimate +
                              ", Artist Id: " + piece.ArtistId +
                              ", Curator Id: " + piece.CuratorId +
                              ", Status: " + piece.Status + "\n");
            }

            return pieces.ToString();
        }

        public bool SellPiece(string pieceId, double pricePaid)
        {
            foreach (var piece in _pieces)
            {
                var artPiece = (ArtPiece)piece;
                if (artPiece.PieceId != pieceId) continue;
                
                if (artPiece.Status == 'S')
                    return false;

                artPiece.ChangeStatus('S');
                artPiece.PricePaid(pricePaid);
                artPiece.CalculateComm(pricePaid);
                return true;
            }
            return false;
        }
    }
}