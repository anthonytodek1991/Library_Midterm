using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryMidterm
{
    class Book
    {
        //private for security
        private string title;
        private string author;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public Book(string t, string a)
        {
            title = t;
            author = a;
        }

    }
}
