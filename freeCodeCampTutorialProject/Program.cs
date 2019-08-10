using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freeCodeCampTutorialProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("Harry Potter","Rowling",400);


            Book book2 = new Book("Lord of the rings", "Tolkien", 700);

            book2.title = "Hobbit";

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);

            Console.ReadLine();
        }
        
            

    }
}
