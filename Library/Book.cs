
namespace Library
{
    class Book
    {

        private string title; // variable
        private string author; // variable
        private string isbn; // variable

        //Title property to allow access
        // to the title private variable
        public string Title
        {
            get { return title; } // get method
            set { title = value; } // set method

        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
    

        //Example of a constructor that allows us to 'construct' a new
        //Book object

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        
        
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }


    }
}
    

