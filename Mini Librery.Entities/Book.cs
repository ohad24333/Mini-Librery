using System;

namespace Mini_Librery.Entities
{
    public class Book
    {
        public string Id { get; set; }
        public string ISBN { get; set; }
        public string Aouthor { get; set; }
        public string Name { get; set; }
        public int NumberOfPages { get; set; }
        public int NumberOfCopies { get; set; }
        public int NumberOfBorrowedOut { get; set; }
        public DateTime DatePublished { get; set; }

        public Book(string aouthor, string name, int numberOfPages, int numberOfCopies, int numberOfBorrowedOut, DateTime datePublished)
        {
            
            ISBN = new Guid().ToString() ;
            Aouthor = aouthor;
            Name = name;
            NumberOfPages = numberOfPages;
            NumberOfCopies = numberOfCopies;
            NumberOfBorrowedOut = numberOfBorrowedOut;
            DatePublished = datePublished;
        }
    }
}




 