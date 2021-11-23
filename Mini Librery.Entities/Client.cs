using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Librery.Entities
{
    public class Client
    {
        public Client(string firstName, string lastName, string id, string email, string phone, DateTime dOB)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Email = email;
            Phone = phone;
            DOB = dOB;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }

        public List<MiniBook> BorrowedBooksList { get; set; } = new List<MiniBook>();
        
    }
}
