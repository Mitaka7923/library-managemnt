using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    internal class CheckedOutBook
    {
        public int CheckoutID { get; set; }
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime DueDate { get; set; }

        public CheckedOutBook(int checkoutID, int bookID, string title, string author, DateTime checkoutDate, DateTime dueDate)
        {
            this.CheckoutID = checkoutID;
            this.BookID = bookID;
            this.Title = title;
            this.Author = author;
            this.CheckoutDate = checkoutDate;
            this.DueDate = dueDate;
        }
    }
}
