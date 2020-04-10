using CGS;
using System;
using static ArtGallery.Function;

namespace ArtGallery
{
    class Program
    {
        static void Main()
        {
            Gallery gallery = new Gallery();
            Menu();
            Console.Write("Enter your number of task: ");
            string task = Console.ReadLine();
            switch (task)
            {
                case "1":
                    AddArtist();
                    break;
                //case "2":
                //    AddCurator();
                //    break;
                case "2":
                    AddArtPiece();
                    break;
                case "3":
                    gallery.ListArtists();
                    break;
                case "4":
                    gallery.ListPieces();
                    break;
                case "5":
                    SellPiece();
                    break;
                default:
                    return;
            }

            Main();
        }

        static void Menu()
        {
            Console.WriteLine("1. Create an Artist");
            //Console.WriteLine("2. Create a Curator");
            Console.WriteLine("2. Create an Art Piece");
            Console.WriteLine("3. Display all Artists");
            Console.WriteLine("4. Display all Art Pieces");
            Console.WriteLine("5. Sell Art Piece");
            Console.WriteLine("6. Quit the application");
            Console.WriteLine("");
        }
    }
}
