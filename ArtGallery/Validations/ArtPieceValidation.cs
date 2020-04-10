using CGS;
using System;

namespace ArtGallery.Validations
{
    public class ArtPieceValidation
    {
        readonly static Pieces pieces = Pieces.Instance;

        public static bool IsIdExist(string ID)
        {
            bool isExist = false;
            foreach (var item in pieces)
            {
                var artPiece = (ArtPiece)item;
                if (artPiece.PieceId == ID)
                {
                    isExist = true;
                    break;
                }
            }

            bool isValid = isExist && Validation.IsIdValid(ID);

            return isValid;
        }

        public static bool IsTitleValid(string title)
        {
            return Validation.IsAtMost40Char(title);
        }

        public static bool IsDateValid(string date)
        {
            bool condition = false;
            if (date.Length == 4)
                condition = true;

            foreach (var character in date)
            {
                if (!Char.IsNumber(character))
                    condition = false;
            }

            return condition;
        }

        //public static bool IsArtistIdValid(string artistId)
        //{
        //    bool isExist = false;
        //    for (int i = 0; i < Data.MyArtists.Length; i++)
        //    {
        //        var artists = Data.MyArtists[i];
        //        if (artists.ID != null && artists.ID == artistId)
        //            isExist = true;
        //    }

        //    return isExist;
        //}

        //public static bool IsCuratorIdValid(string curatorId)
        //{
        //    bool isExist = false;
        //    for (int i = 0; i < Data.MyCurators.Length; i++)
        //    {
        //        var curators = Data.MyCurators[i];
        //        if (curators.ID != null && curators.ID == curatorId)
        //            isExist = true;
        //    }

        //    return isExist;
        //}

        public static bool IsEstimedAndPriceValid(string esmited)
        {
            bool condition = true;
            foreach (var character in esmited)
            {
                if (!Char.IsNumber(character))
                    condition = false;
            }
            return condition;
        }

        public static bool IsStatusValid(string status)
        {
            bool condition = false;
            if (status.Length == 1 && (status == "D" || status == "S" || status == "O" || status == "d" || status == "s" || status == "o"))
                condition = true;

            return condition;
        }
    }
}
