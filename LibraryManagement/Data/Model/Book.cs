using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Model
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public virtual Author author { get; set; }

        public int  authorId { get; set; }

        public virtual Customer Borrower { get; set; }
    }
}
