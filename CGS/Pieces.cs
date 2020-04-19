using System.Collections;

namespace CGS
{
    public class Pieces : CollectionBase
    {
        private static Pieces _instance;
        public void Add(ArtPiece piece)
        {
            List.Add(piece);
        }

        private Pieces()
        {

        }

        public static Pieces Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Pieces();
                return _instance;
            }
        }

        public Pieces this[int pieceIndex]
        {
            get => (Pieces)List[pieceIndex];
            set => List[pieceIndex] = value;
        }
    }
}
