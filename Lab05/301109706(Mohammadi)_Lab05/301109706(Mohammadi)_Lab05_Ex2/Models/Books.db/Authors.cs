using System;
using System.Collections.Generic;
using System.Text;

namespace _301109706_Mohammadi__Lab05_Ex2.Models.Books.db
{
    public class Authors
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string FullInfo
        {
            get { return $"{ FirstName } { LastName } "; }
        }
    }
}
