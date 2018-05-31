using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Model
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string Name { get; set; }

        public ICollection <Book> Books { get; set; }
    }


    public class Books
    {
        public int BookId { get; set; }
    }
}
