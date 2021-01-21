using System;

namespace Abstract_Classes
{
    class Program
    {
        static void Main()
        {
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            int price = int.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
    abstract class Book
    {

        protected string title;
        protected string author;

        public Book(string t, string a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }

    //Write MyBook class
    class MyBook : Book
    {
        private int price;
        public MyBook(string title, string author, int price) : base(title, author)
        {
            this.price = price;
        }

        public override void display()
        {
            Console.WriteLine("Title: " + this.title + "\n"
                + "Author: " + this.author + "\n"
                + "Price: " + this.price);
        }
    }
}

