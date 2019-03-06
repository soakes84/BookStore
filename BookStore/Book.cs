using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    public class Book
    {
        private string title;
        private string author;

        private DateTime publishDate;

        private decimal price;

        public Book(string title, string author, DateTime publishDate, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.PublishDate = publishDate;
            this.Price = price;
        }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }

        public DateTime PublishDate { get => publishDate; set => publishDate = value; }

        public decimal Price { get => price; set => price = value; }

    }
}
