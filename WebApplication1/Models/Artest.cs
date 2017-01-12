using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Artest
    {
        public int ArtistId { get; set; }

        public string Name { get; set; }

        public List<Album> Albums { get; set; }

    }
}