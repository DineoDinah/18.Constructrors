using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructrors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("Herry Porter", "JK Rowling", 400);

            Console.WriteLine(book1.title);
            Console.ReadLine();
        }
            class Book
        {
            public string title;
            public string author;
            public int pages;

            public Book(string aTitle, string aAuthor, int aPage)
            {
                title = aTitle;
                author = aAuthor;
                pages = aPage;

            }
        }
    }
            
        
    
}
