using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CGS
{
    public class Pieces : CollectionBase
    {
        private static Pieces instance;
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
                if (instance == null)
                    instance = new Pieces();

                return instance;
            }
        }

        public Pieces this[int PieceIndex]
        {
            get
            {
                return (Pieces)List[PieceIndex];
            }
            set
            {
                List[PieceIndex] = value;
            }
        }
    }
}
