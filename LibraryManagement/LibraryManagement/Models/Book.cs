namespace LibraryManagement.Models
{
    internal class Book
    {
        public Book(int bookID, string title, string author, string genre, string iSBN, int availableCopies, int totalCopies)
        {
            this.BookID = bookID;
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.ISBN = iSBN;
            this.AvailableCopies = availableCopies;
            this.TotalCopies = totalCopies;
        }

        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
        public int AvailableCopies { get; set; }
        public int TotalCopies { get; set; }
    }
}
