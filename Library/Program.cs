using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library weeb = new Library("Kinokubiya");

            var catalog = new Catalog();

            catalog.Add(new Book("kimi no na wa. / your name.", "Makoto Shinkai", 6)); // Create Your Name manga
            catalog.Add(new Book("We Never Learn", "Tashi Tsutsui", 3)); // Create We Never Learn manga
            catalog.Add(new Book("Nani ga Fakku Kono BL!?", "Nani", 2)); // Create Werid BL Stuff
            catalog.Add(new Book("Fullmetal Alchemist Artbook", "Minoru Arakawa", 1)); // Create Fullmetal Artbook
            weeb.Catalog = catalog;

            weeb.Register("Raghav Vivek", 1234, "Password"); // Create Raghav
            weeb.Register("Ishan Parikh", 5678, "drowssaP"); // Create Ishan
            weeb.Register("Ken Armstrong", 9012, "Pdarsosw"); // Create Ken
            Console.WriteLine();

            weeb.Login(1234, "Password"); // Login Raghav
            weeb.Login(5678, "drowssaP"); // Login Ishan
            weeb.Login(9012, "Pdarsosw"); // Login Ken
            Console.WriteLine();

            weeb.CheckOut // Check out Your Name manga to Raghav
            (
                weeb.Users.First(x => x.Name == "Raghav Vivek").ID,
                weeb.Catalog.Books.First(x => x.Name == "kimi no na wa. / your name.").ID
            );
            weeb.CheckOut // Raghav checks out BL
            (
                weeb.Users.First(x => x.Name == "Raghav Vivek").ID,
                weeb.Catalog.Books.First(x => x.Name == "Nani ga Fakku Kono BL!?").ID
            );
            weeb.CheckOut // Check out Fullmetal artbook to Ishan
            (
                weeb.Users.First(x => x.Name == "Ishan Parikh").ID,
                weeb.Catalog.Books.First(x => x.Name == "Fullmetal Alchemist Artbook").ID
            );
            weeb.CheckOut // Check out We Never Learn to Ken
            (
                weeb.Users.First(x => x.Name == "Ken Armstrong").ID,
                weeb.Catalog.Books.First(x => x.Name == "We Never Learn").ID
            );
            Console.WriteLine();

            weeb.CheckIn // Raghav checks in BL
            (
                weeb.Users.First(x => x.Name == "Raghav Vivek").ID,
                weeb.Catalog.Books.First(x => x.Name == "Nani ga Fakku Kono BL!?").ID
            );
            Console.WriteLine();

            weeb.Catalog.Search(x => x.Name == "We Never Learn"); // Search for that cool manga

            weeb.Logout(weeb.Users.First(x => x.Name == "Raghav Vivek").ID); // Log out Raghav
            weeb.Logout(weeb.Users.First(x => x.Name == "Ishan Parikh").ID); // Log out Ishan
            weeb.Logout(weeb.Users.First(x => x.Name == "Ken Armstrong").ID); // Log out Ken
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
