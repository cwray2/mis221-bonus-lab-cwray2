using System;

namespace mis221_bonus_lab_cwray2
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("Jeff Lucas", 'm', "jslucas@cba.ua.edu");
            Console.WriteLine(myAuthor.ToString());

            Book myBook = new Book("12243", "My Book, Your Book", myAuthor);
            Console.WriteLine("\n" + myBook.ToString());

            Console.WriteLine("\n" + myBook.GetAuthor().ToString());

            Book yourBook = new Book("4321", "The Phantom Book", new Author("Jamie", 'f', "jamie@mail.com"));
            Console.WriteLine("\n" + yourBook.ToString());

            yourBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");
            Console.WriteLine(yourBook.ToString());
        }
    }
}
