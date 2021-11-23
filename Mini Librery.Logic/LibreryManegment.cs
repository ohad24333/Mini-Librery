using Mini_Librery.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Mini_Librery.Logic
{
    public static class LibreryManegment
    {

        #region Lists
        public static List<Client> AllClients { get; set; } = JsonSerializer.Deserialize<List<Client>>(File.ReadAllText(@"C:\Users\ohad2\source\repos\Mini Librery\Client As Json\client.json"));
        public static List<Book> AllBooksInLibrery { get; set; } = JsonSerializer.Deserialize<List<Book>>(File.ReadAllText(@"C:\Users\ohad2\source\repos\Mini Librery\Books As Txt File\books.json"));

        public static List<Borrowing> AllBorrowings { get; set; } = JsonSerializer.Deserialize<List<Borrowing>>(File.ReadAllText(@"C:\Users\ohad2\source\repos\Mini Librery\Borrowing As Json\borrowing.json"));

        #endregion

        #region Delegates And Events

        public delegate void MassegeDelegate(string massege);
        public delegate bool BookSearchDelegate(Book book);
        public delegate void BookEditDelegate(Book book);

        public delegate bool ClientSearchDelegate(Client client);

        public static event Action<ColumnsEnum> ClientColumnIsInvalid;
        public static event Action<Client,string> NewClientHasAddedEvent;
      
      

        public static event MassegeDelegate BookIsInvalidEvent;
        public static event MassegeDelegate NewBookHasAddedEvent;
        public static event Action<Borrowing, string> NewBorrowingHasAddedEvent;

        public static event MassegeDelegate BooksListHasBeenReadFromJsonEvent;

        public static event MassegeDelegate ClientIvalidMassegeEvent;



        #endregion

        #region Book Methods

        public static void SaveNewJsonFileOfBooks()
        {
            var json = JsonSerializer.Serialize(AllBooksInLibrery);
            File.WriteAllText(@"C:\Users\ohad2\source\repos\Mini Librery\Books As Txt File\books.json", json);
        }

        public static void ReadBooksFromJsonFile()
        {
            var jsonStr = File.ReadAllText(@"C:\Users\ohad2\source\repos\Mini Librery\Books As Txt File\books.json");
            AllBooksInLibrery = JsonSerializer.Deserialize<List<Book>>(jsonStr);
            BooksListHasBeenReadFromJsonEvent("");
        }

        public static bool ValidateBookProperties(string author, string name, string numberOfCopies, string numberOfPages)
        {
            foreach (var item in AllBooksInLibrery)
            {
                if (item.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && item.Aouthor.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    BookIsInvalidEvent("This Book is Allready In The List");
                    return false;
                }
            }

            if (!isValidNameRegEx.IsMatch(author))
            {
                BookIsInvalidEvent("Aouthor Name Is Invalid");

                return false;
            }
            if (!isValidNameRegEx.IsMatch(name))
            {
                BookIsInvalidEvent("Book Name Is Invalid");

                return false;
            }
            if (!isValidNumberOfCopiesRegEx.IsMatch(numberOfCopies))
            {
                BookIsInvalidEvent("Number Of Copies Is Invalid");

                return false;
            }
            if (!isValidNumberOfPagesRegEx.IsMatch(numberOfPages))
            {
                BookIsInvalidEvent("Number Of Pages Is Invalid");

                return false;
            }

            return true;
        }

        public static void AddABookToList(Book book)
        {
            book.Id = (AllBooksInLibrery.Count + 1).ToString();
            AllBooksInLibrery.Add(book);
            var json = JsonSerializer.Serialize(AllBooksInLibrery);
            File.WriteAllText(@"C:\Users\ohad2\source\repos\Mini Librery\Books As Txt File\books.json", json);
            NewBookHasAddedEvent("Book Has Added Seccessfully!");
        }

        public static Book SearchBook(BookSearchDelegate searchDelegate)
        {
            foreach (var book in AllBooksInLibrery)
            {
                if (searchDelegate(book))
                {
                    return book;
                }
            }
            return null;
        }



        #endregion

        #region Client Methods

        public static void SaveNewJsonFileOfClients()
        {
            var json = JsonSerializer.Serialize(AllClients);
            File.WriteAllText(@"C:\Users\ohad2\source\repos\Mini Librery\Client As Json\client.json", json);
        }
        public static bool ValidateClientProperties(string firstName, string lastName, string id, string email, string phone)
        {
            bool result = true;
            foreach (var item in AllClients)
            {
                if (item.Id == id)
                {
                    ClientIvalidMassegeEvent("This Id Is Already Registered");
                    return false;
                }
            }
            if (!isValidNameRegEx.IsMatch(firstName))
            {
                ClientColumnIsInvalid(ColumnsEnum.FirstName);
                result = false;
            }
            if (!isValidNameRegEx.IsMatch(lastName))
            {
                ClientColumnIsInvalid(ColumnsEnum.LastName);
                result = false;
            }
            if (!IsValidId.IsMatch(id))
            {
                ClientColumnIsInvalid(ColumnsEnum.Id);
                result = false;
            }
            if (!isValidEmail.IsMatch(email))
            {
                ClientColumnIsInvalid(ColumnsEnum.Email);
                result = false;
            }
            if (!IsValidPhone.IsMatch(phone))
            {
                ClientColumnIsInvalid(ColumnsEnum.Phone);
                result = false;
            }
            if (!result)
            {
                ClientIvalidMassegeEvent("Invalid Inserts\nPlease Try Again");
            }

            return result;

        }

        public static void AddClientToList(Client client)
        {
           
            AllClients.Add(client);
            var json = JsonSerializer.Serialize(AllClients);
            File.WriteAllText(@"C:\Users\ohad2\source\repos\Mini Librery\Client As Json\client.json", json);
            NewClientHasAddedEvent(client,"Client Has Added Seccessfully!");
        }


        public static Client SearchClient(ClientSearchDelegate searchDelegate)
        {
            foreach (var client in AllClients)
            {
                if (searchDelegate(client))
                {
                    return client;
                }
            }
            return null;
        }

        #endregion

        #region Borrowing Methods

        public static void AddBorrowToList(Borrowing borrowing)
        {           
            AllBorrowings.Add(borrowing);
            var json = JsonSerializer.Serialize(AllBorrowings);
            File.WriteAllText(@"C:\Users\ohad2\source\repos\Mini Librery\Borrowing As Json\borrowing.json", json);
            SaveNewJsonFileOfClients();


            NewBorrowingHasAddedEvent(borrowing,"The Book Has Borrowed Seccessfully!");
        }




        #endregion

        #region RegEx

        #region Books

        static Regex isValidNameRegEx = new Regex(@"\D{2,18}");
        static Regex isValidNumberOfCopiesRegEx = new Regex(@"\d{0,9}");
        static Regex isValidNumberOfPagesRegEx = new Regex(@"\d{2,4}");

        #endregion

        #region Client

        static Regex isValidEmail = new Regex(@"^[A-z]{3,10}(\@gmail|\@yahoo|@walla)\.(net|com)", RegexOptions.IgnoreCase);
        static Regex IsValidPhone = new Regex(@"0{1}[0-9]{9}");
        static Regex IsValidId = new Regex(@"[1-9]{9}");
        public static bool IsValidIsraeliIdNumber(this string s)
        {
            int stringAssInt;
            if (!int.TryParse(s, out stringAssInt))
            {
                return false;
            }


            int sumNum = 0, checkDigit;
            int[] arr = new int[9];
            string code = "121212121";
            for (int i = 0; i < 9; i++)
            {
                arr[i] = s[i] * code[i];
            }

            foreach (var digit in arr)
            {
                if (digit > 9)
                {
                    int sum = (digit % 10) + (digit / 10);
                    sumNum += sum;
                }
                else
                    sumNum += digit;
            }

            if (sumNum % 10 != 0) return false;

            checkDigit = stringAssInt % 10;

            int idWithOutCheckDigit = sumNum - checkDigit;

            if (!(10 - (idWithOutCheckDigit % 10) == checkDigit))
            {
                return false;
            }

            return true;

            #endregion




        }



        #endregion



    }
}
