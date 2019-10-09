using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.ChristoferOkhravi.Participants.Models
{
    public class Artist
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }

    public class Book
    {
        public string Image { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
    }
}
