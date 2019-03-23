using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Actor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UrlIMDB { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }


   
}
