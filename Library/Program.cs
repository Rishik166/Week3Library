// See https://aka.ms/new-console-template for more information


using Library;

Book book = new Book();
// This information is for one book in our Library
book.Title = "C# for beginners";
book.Author = "BillGates";
book.ISBN = "12345678";

book.DisplayInfo();

// This is for another book in our Library
Book book1 = new Book();
book1.Title = " C# Methods and classes";
book1.Author = "Microsoft";
book1.ISBN = "55667778";

book1.DisplayInfo();