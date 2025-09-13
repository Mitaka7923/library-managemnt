namespace LibraryManagement.Models
{
    internal class Checkout
    {
        public Checkout(int bookID, int memberID, DateTime checkOutDate, DateTime dueDate)
        {
            this.BookID = bookID;
            this.MemberID = memberID;
            this.CheckOutDate = checkOutDate;
            this.DueDate = dueDate;
        }
        public int CheckOutID { get; set; }
        public int BookID { get; set; }
        public int MemberID { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }

}
