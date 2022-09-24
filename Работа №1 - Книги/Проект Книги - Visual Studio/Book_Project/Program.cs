using System;
using System.Collections.Generic;
namespace Book_Project;
class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>();
        Book book1 = new Book(1, "Book_Name_1");
        books.Add(book1);
        Book book2 = new Book(2, "Book_Name_2");
        books.Add(book2);
        foreach (Book b in books)
        {
            Console.WriteLine(b);
        }
        List<Annotation> annotations = new List<Annotation>();
        Annotation annotation1 = new Annotation(1, "Annotation_Text", 2);
        annotations.Add(annotation1);
        Annotation annotation2 = new Annotation(2, "Annotation_Text", 1);
        annotations.Add(annotation2);
        foreach (Annotation a in annotations)
        {
            Console.WriteLine(a);
        }
        Console.WriteLine("******");
        foreach (Book b in books)
        {
            Console.WriteLine(b);
            foreach (Annotation a in annotations)
            {
                if (b.ID == a.Book_ID)
                {
                    Console.WriteLine(a);
                }
            }
        }
        Console.ReadLine();
    }
}