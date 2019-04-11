using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Catalog
    {
        public List<Book> Books { get; set; }

        public Catalog()
        {
            Books = new List<Book>();
        }

        public int Add(Book book)
        {
            Books.Add(book);
            return book.ID;
        }
        public void Search(Func<Book, bool> predicate) // x => x.<property>
        {
            IEnumerable<Book> results = Books.Where(predicate);
            foreach (var item in results)
            {
                Console.WriteLine(item.ToString());
                /*
                    Writes:
                  
                    ID: <ID>
                    Name: <Name>
                    Author: <Author>
                    Copies Available: <Amount>
                */
            }
        }
    }
}
