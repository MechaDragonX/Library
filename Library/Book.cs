using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private static Random rng = new Random(4102);
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Amount { get; set; }

        public Book(string Name, string Author, int Amount)
        {
            ID = rng.Next(1000);
            this.Name = Name;
            this.Author = Author;
            this.Amount = Amount;
        }

        public override string ToString()
        {
            return string.Format
            (

                "{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}\n",
                "ID", ID,
                "Name", Name,
                "Author", Author,
                "Copies Available", Amount
            );
        }
    }
}
