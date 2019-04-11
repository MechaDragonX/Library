using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User
    {
        private static Random rng = new Random(4101);
        public int ID { get; set; }
        public string Name { get; set; }
        public int PIN { get; set; }
        public string Password { get; set; }
        public List<Book> Books { get; set; }
        public bool LoggedIn { get; set; }

        public User(string Name, int PIN, string Password)
        {
            ID = rng.Next(1000);
            this.Name = Name;
            this.PIN = PIN;
            this.Password = Password;
            Books = new List<Book>();
        }
    }
}
