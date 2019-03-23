using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public bool IsForChildren { get; set; }
        public Category Category { get; set; }
        public DateTime ReleaseYear { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
