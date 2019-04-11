using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library : ICheckInOutManager, IUserManager
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public Catalog Catalog { get; set; }

        public Library(string Name)
        {
            this.Name = Name;
            Users = new List<User>();

            Console.Title = "Welcome to " + Name + "!";
        }

        public void CheckIn(int UserID, int BookID)
        {
            User uResult = Users.First(x => x.ID == UserID);
            Book bResult = uResult.Books.First(x => x.ID == BookID);
            uResult.Books.Remove(bResult);
            Catalog.Books.First(x => x.ID == BookID).Amount++;
            Console.WriteLine("\"{0}\" was successfully checked in by {1}!\n", bResult.Name, uResult.Name);
        }
        public void CheckOut(int UserID, int BookID)
        {
            Book bResult = Catalog.Books.First(x => x.ID == BookID);
            if (bResult.Amount > 0)
            {
                User uResult = Users.First(x => x.ID == UserID);
                uResult.Books.Add(bResult);
                Catalog.Books.First(x => x.ID == BookID).Amount--;
                Console.WriteLine("\"{0}\" was successfully checked out to {1}!\n", bResult.Name, uResult.Name);
            }
            else
            {
                Console.WriteLine("There are no more copies of \"{0}\" available.\n", bResult.Name);
            }
        }

        public void Register(string Name, int PIN, string Password)
        {
            if (Users.Any(x => x.PIN == PIN))
            {
                Console.WriteLine("The desired PIN already exists.\n");
            }
            else if (Users.Any(x => x.Password == Password))
            {
                Console.WriteLine("The desired Password already exists.\n");
            }
            else if (Users.Any(x => x.PIN == PIN && x.Password == Password))
            {
                Console.WriteLine("The desired PIN & Password already exists.\n");
            }
            else
            {
                User newUser = new User(Name, PIN, Password);
                Users.Add(newUser);
            }
            
        }
        public void Login(int PIN, string Password)
        {
            if (Users.Any(x => x.PIN == PIN && x.Password == Password))
            {
                User current = Users.First(x => x.PIN == PIN && x.Password == Password);
                current.LoggedIn = true;
                Console.WriteLine("You have successfully logged in, {0}!\n", current.Name);
            }
            else
            {
                Console.WriteLine("The PIN and/or Password is incorrect.\n");
            }
        }
        public void Logout(int UserID)
        {
            User log = Users.First(x => x.ID == UserID);
            log.LoggedIn = false;
            Console.WriteLine("You have successfully logged out, {0}!\nThanks for using {1}!\n", log.Name, Name);
        }
    }
}
