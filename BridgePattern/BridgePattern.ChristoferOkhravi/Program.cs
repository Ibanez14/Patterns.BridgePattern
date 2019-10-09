using BridgePattern.ChristoferOkhravi.Participants.Models;
using BridgePattern.ConceptualExample;
using System;

namespace BridgePattern.ChristoferOkhravi
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating arist resource
            var artist = new Artist()
            {
                Image = "drunkInGreatCanyon.jpeg",
                Name = "Bruce Springsteen"
            };
            var artistResource = new ArtistResoruce(artist);

            // Creating book resource
            var book = new Book()
            {
                Author = "Camus",
                Description = " published in 1947, that tells the story of suffering",
                Genre = "Philosophy",
                Image = "drunkInChurch.jpeg"
            };
            var bookResource = new BookResource(book);


            // Creating some types of views
            var longArtistView = new LongView(artistResource);
            var shortArtistView = new ShortView(artistResource);

            var longBookView = new LongView(bookResource);
            var shortBookView = new ShortView(bookResource);



            var views = new IView[] { longArtistView, shortArtistView, longBookView, shortBookView };

            foreach (var view in views)
            {   // returns string
                view.Show().Print();
            }


            Console.Read(); 

        }
    }


    public static class Ex
    {
        public static void Print(this object obj) => Console.WriteLine(obj);
    }
}
