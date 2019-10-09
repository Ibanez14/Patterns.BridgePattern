using BridgePattern.ChristoferOkhravi.Participants.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.ChristoferOkhravi
{
    /// - - - - - - 
    public interface IResource
    {
        string Image { get; }
        string Title { get; }
        string Uri { get; }
    }

    public class ArtistResoruce : IResource
    {
        public ArtistResoruce(Artist artist)
        {
            Artist = artist;
        }
        public Artist Artist { get; set; }

        public string Image
            => Artist.Image;
        public string Title
            => $"Today our guest is {Artist.Name}";
        public string Uri
            => $"artist.com";
    }

    public class BookResource : IResource
    {
        public BookResource(Book book)
        {
            Book = book;
        }
        public Book Book { get; set; }

        public string Image
            => Book.Image;
        public string Title
            => $"{Book.Description} of {Book.Genre} genre";
        public string Uri
            => "somebook.com";
    }
}
