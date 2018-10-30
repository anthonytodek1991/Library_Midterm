using System;
using System.Collections.Generic;

namespace LibraryMidterm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookClassList = new List<Book>();
            bookClassList.Add(new Book("The Name of the Wind", "Patrick Rothfuss"));
            bookClassList.Add(new Book("Call of the Wild", "Jack London"));
            bookClassList.Add(new Book("House of Leaves", "Mark Z. Danielewski"));
            bookClassList.Add(new Book("Of Mice and Men", "John Steinbeck"));
            bookClassList.Add(new Book("To Kill a Mockingbird", "Harper Lee"));
            bookClassList.Add(new Book("Oh, The Places You'll Go", "Dr. Seuss"));
            bookClassList.Add(new Book("The Adventures of Winnie the Pooh", "Ralph Wright"));
            bookClassList.Add(new Book("The Giving Tree", "Shel Silverstein"));
            bookClassList.Add(new Book("The Child Called It", "Dave Pelzer"));
            bookClassList.Add(new Book("Green Eggs and Ham", "Dr. Seuss"));

            //choose a task

            Console.WriteLine("Welcome to the Grand Circus Library");

            while (true)
            {
                string userTask = UserInput("What task would you like to complete? \n 1. Search by title \n 2. Search by author \n 3. Quit");
                while(userTask != "1" && userTask != "2" && userTask != "3")
                {
                    userTask = UserInput("That is not valid. Please enter a valid selection. \n 1. Search by title \n 2. Search by author \n 3. Quit");
                }
                if (userTask == "1")
                {

                    //input
                    string bookSearch = UserInput("What book do you want to check out?").ToLower();
                    //processing
                    List<Book> bookMatches = new List<Book>();
                    
                    foreach (Book book in bookClassList)
                    {
                        if (book.Title.ToLower().Contains(bookSearch))
                        {
                            bookMatches.Add(book);
                        }
                    }

                    if (bookMatches.Count == 0)
                    {
                        Console.WriteLine("I'm sorry! that selection is not available! Try again...");
                    }

                    foreach (Book book in bookMatches)
                    {
                        Console.WriteLine($"Title: {book.Title} by Author: {book.Author}.");
                    }
                }
                
                else if (userTask == "2")
                {

                    //input
                    string authorSearch = UserInput("What author do you want to look up?").ToLower();
                    //processing
                    List<Book> authorMatches = new List<Book>();
                                    
                    foreach (Book author in bookClassList)
                    {
                    if (author.Author.ToLower().Contains(authorSearch))
                    {
                         authorMatches.Add(author);
                    }                                        
                }

                    if (authorMatches.Count == 0)
                    {
                        Console.WriteLine("I'm sorry! that selection is not available! Try again...");
                    }

                    foreach (Book author in authorMatches)
                    {
                         Console.WriteLine($"Title: {author.Title} by Author: {author.Author}.");
                    }
                }
                else if (userTask == "3")
                {
                    //quit
                    break;
                }
            }
        }

        public static string UserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }
    }
}
