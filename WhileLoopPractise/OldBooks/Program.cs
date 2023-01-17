using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            string book = Console.ReadLine();
            int searchedBooks = 1;
            while(book != "No More Books")
            {
                if (book == favBook)
                {
                    Console.WriteLine($"You checked {searchedBooks - 1} books and found it.");
                    break;
                }
                book = Console.ReadLine();
                searchedBooks++;
            }
            if(book == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!\nYou checked {searchedBooks-1} books.");
            }
        }
    }
}
