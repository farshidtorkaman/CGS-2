using System;
using static ArtGallery.Validations.ArtPieceValidation;
using ArtGallery.Validations;
using CGS;

namespace ArtGallery
{
    public class Function
    {
        public static void AddArtist()
        {
            Gallery gallery = new Gallery();
            bool condition;
            string ID;
            do
            {
                Console.Write("Enter Artist ID: ");
                ID = Console.ReadLine();
                condition = Validation.IsIdValid(ID);
                if (!condition)
                    Console.WriteLine("ID is not valid (Enter 5 Unique character)");
            } while (!condition);

            string fname;
            do
            {
                Console.Write("Enter Artist First Name: ");
                fname = Console.ReadLine();
                condition = ArtistValidation.IsNameValid(fname);
                if (!condition)
                    Console.WriteLine("First name should be at most 40 character");
            } while (!condition);

            string lname;
            do
            {
                Console.Write("Enter Artist Last Name: ");
                lname = Console.ReadLine();
                condition = ArtistValidation.IsNameValid(lname);
                if (!condition)
                    Console.WriteLine("Last name should be at most 40 character");
            } while (!condition);

            gallery.AddArtist(fname, lname, ID);

            Console.WriteLine("Artist Added Succesfully");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        //public static void AddCurator()
        //{
        //        bool condition;

        //        string ID;
        //        do
        //        {
        //            Console.Write("Enter Curator ID: ");
        //            ID = Console.ReadLine();
        //            condition = CuratorValidation.IsIdValid(ID);
        //            if (!condition)
        //                Console.WriteLine("ID is not valid (Enter 5 Unique character)");
        //        } while (!condition);

        //        string fname;
        //        do
        //        {
        //            Console.Write("Enter Curator First Name: ");
        //            fname = Console.ReadLine();
        //            condition = CuratorValidation.IsNameValid(fname);
        //            if (!condition)
        //                Console.WriteLine("first name should be at most 40 character");
        //        } while (!condition);

        //        string lname;
        //        do
        //        {
        //            Console.Write("Enter Curator Last Name: ");
        //            lname = Console.ReadLine();
        //            condition = CuratorValidation.IsNameValid(lname);
        //            if (!condition)
        //                Console.WriteLine("Last name should be at most 40 character");
        //        } while (!condition);

        //        Data.MyCurators[CuratorCount].ID = ID;
        //        Data.MyCurators[CuratorCount].fname = fname;
        //        Data.MyCurators[CuratorCount].lname = lname;
        //        Console.WriteLine("Curator Added Succesfully");
        //        Console.WriteLine("");
        //        Console.WriteLine("");
        //        CuratorCount++;

        //}

        public static void AddArtPiece()
        {
            Gallery gallery = new Gallery();
            bool condition;

            string ID;
            do
            {
                Console.Write("Enter ID: ");
                ID = Console.ReadLine();
                condition = Validation.IsIdValid(ID);
                if (!condition)
                    Console.WriteLine("ID is not valid (Enter 5 Unique character)");
            } while (!condition);

            string title;
            do
            {
                Console.Write("Enter the title: ");
                title = Console.ReadLine();
                condition = IsTitleValid(title);
                if (!condition)
                    Console.WriteLine("Title should be at most 40 character");
            } while (!condition);

            string date;
            do
            {
                Console.Write("Enter the date in year: ");
                date = Console.ReadLine();
                condition = IsDateValid(date);
                if (!condition)
                    Console.WriteLine("Date must be 4 digits");
            } while (!condition);

            string IDArtist;
            do
            {
                Console.Write("Enter artist ID: ");
                IDArtist = Console.ReadLine();
                condition = Validation.IsIdValid(IDArtist);
                if (!condition)
                    Console.WriteLine("Artist ID is not valid (Enter 5 Unique character)");
            } while (!condition);

            //string IDCurator;
            //do
            //{
            //    Console.Write("Enter curator ID: ");
            //    IDCurator = Console.ReadLine();
            //    condition = Validation.IsIdValid(IDCurator);
            //    if (!condition)
            //    {
            //        Console.WriteLine("Id Curator does not exist");
            //        string response;
            //        do
            //        {
            //            Console.Write("do you want to add this curator? (y/n): ");
            //            response = Console.ReadLine();
            //            if (response == "y" || response == "Y")
            //            {
            //                AddCurator();
            //            }
            //            else if (response == "n" || response == "N")
            //            {
            //                throw new Exception();
            //            }
            //            else
            //            {
            //                Console.WriteLine("invalid response");
            //            }
            //        } while (!(response == "y" || response == "Y" || response == "n" || response == "N"));
            //    }
            //} while (!condition);

            string estimed;
            do
            {
                Console.Write("Enter Estimated Price: ");
                estimed = Console.ReadLine();
                condition = IsEstimedAndPriceValid(estimed);
                if (!condition)
                    Console.WriteLine("Estimated Price must be digits");
            } while (!condition);

            gallery.AddPiece(ID, title, date, double.Parse(estimed == "" ? "0" : estimed), IDArtist, "");

            Console.WriteLine("Art Piece Added Succesfully\n");

        }

        public static void SellPiece()
        {
            Gallery gallery = new Gallery();
            bool condition;

            string pieceId;
            do
            {
                Console.Write("Enter Piece ID: ");
                pieceId = Console.ReadLine();
                condition = ArtPieceValidation.IsIdExist(pieceId);
                if (!condition)
                    Console.WriteLine("ID is not exist");
            } while (!condition);

            double pricePaid;
            do
            {
                Console.Write("Enter Price Paid: ");
                condition = Double.TryParse(Console.ReadLine(), out pricePaid);
                if (!condition)
                    Console.WriteLine("enter valid price paid");
            } while (!condition);

            gallery.SellPiece(pieceId, pricePaid);

            Console.WriteLine("Art Piece Sold Succesfully\n");
        }
    }
}