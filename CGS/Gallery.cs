using System;
using System.Collections.Generic;
using System.Text;

namespace CGS
{
    public class Gallery
    {
        readonly Pieces pieces = Pieces.Instance;
        readonly Artists artists = Artists.Instance;

        public void AddArtist(string firstName, string lastName, string artistId)
        {
            Artist artist = new Artist(firstName, lastName, artistId);
            artists.Add(artist);
        }

        public void ListArtists()
        {
            foreach (var item in artists)
            {
                var artist = (Artist)item;
                Console.WriteLine("AritstId: " + artist.ArtistId + ", First Name: " + artist.FirstName + ", Last Name: " + artist.LastName + "\n");
            }
        }

        public void AddPiece(string pieceId, string title, string year, double estimate, string artistId, string curatorId)
        {
            ArtPiece piece = new ArtPiece(pieceId, title, year, estimate, artistId, curatorId);
            pieces.Add(piece);
        }

        public void ListPieces()
        {
            foreach (var item in pieces)
            {
                var piece = (ArtPiece)item;
                Console.WriteLine("Piece Id: " + piece.PieceId +
                    ", Title: " + piece.Title +
                    ", Year: " + piece.Year +
                    ", Price: " + piece.Price +
                    ", Estimate: " + piece.Estimate +
                    ", Artist Id: " + piece.ArtistId +
                    ", Curator Id: " + piece.CuratorId +
                    ", Status: " + piece.Status + "\n");
            }
        }

        public bool SellPiece(string pieceId, double pricePaid)
        {

            foreach (var piece in pieces)
            {
                var artPiece = (ArtPiece)piece;
                if(artPiece.PieceId == pieceId)
                {
                    if (artPiece.Status == 'S')
                        return false;

                    artPiece.ChangeStatus('S');
                    artPiece.PricePaid(pricePaid);
                    artPiece.CalculateComm(pricePaid);
                    return true;
                }
            }
            return false;
        }
    }
}