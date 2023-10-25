using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class DbStore
    {
        Book book = new Book("sgggs", "shsgsg", 2000);

        List<Book> books=new List<Book>(5);
        public void Add(Book book)
        {
            book.Id= Guid.NewGuid().ToString();

            books.Add(book);
           
        }

        public void AddRange()
        {
            books.AddRange(books);
        }
        public void Remove(Book book)
        {
            books.Remove(book);
        }
        public void Update(string id)
        {
            foreach (Book book in books) 
            {
                if(book.Id == id)
                {
                    book.Name = Console.ReadLine();
                }
               
            }
        }
        public void ShowBook(string id)
        {
            foreach (Book book in books)
            {
                if (book.Id == id)
                {
                    Console.WriteLine($"{book.Id},{book.Name},{book.Author},{book.Year}");
                }
                
            }
        }
        public void  ShowAllBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Id},{book.Name},{book.Author},{book.Year}");
            }
        }

        private List<Book> ReadFromDb()
        {
            return books;   
        }

        private void WriteToDb(List<Book> books)
        {
            
        }
    }
}
