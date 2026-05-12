using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }      
    public string Author { get; set; }     
    public int Year { get; set; }          

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}

class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>();

        books.Add(new Book("Война и мир", "Лев Толстой", 1869));
        books.Add(new Book("Преступление и наказание", "Федор Достоевский", 1866));
        books.Add(new Book("Мастер и Маргарита", "Михаил Булгаков", 1967));

        Console.WriteLine("Список книг:");
        Console.WriteLine("-------------------");

        foreach (Book book in books)
        {
            Console.WriteLine($"{book.Author} - {book.Title} ({book.Year})");
        }
    }
}
