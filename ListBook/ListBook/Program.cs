using ListBook.Models;
using System;
using System.Collections.Generic;

namespace ListBook
{
    class Program
    {
        public delegate bool Check(string str);
        static void Main(string[] args)
        {
            List<Book> pages = new List<Book>();

            pages.Add(new Book { Name = "C#", Authoru = "Nizami", Price = 50 });
            pages.Add(new Book { Name = "JavaScript", Authoru = "Vugar",  Price = 130 });
            pages.Add(new Book { Name = "CSS", Authoru = "Nizami",  Price = 45 });
            pages.Add(new Book { Name = "HTML", Authoru = "Nizami", Price = 120 });
            pages.Add(new Book { Name = "C++",Authoru = "Nizami",  Price = 55 });

            var result = pages.FindAll(m => m.Authoru == "Nizami");
            Console.WriteLine(result.Count);
        }
    }
}
