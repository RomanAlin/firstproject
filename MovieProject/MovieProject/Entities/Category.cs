using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieProject.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}